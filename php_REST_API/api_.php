<?php
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "webapp";

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);

// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}


header("Content-Type: application/json; charset=UTF-8");
header("Access-Control-Allow-Methods: GET, POST, PUT, DELETE");

$method = $_SERVER['REQUEST_METHOD'];
$id = isset($_GET['id']) ? $_GET['id'] : null;

$input = json_decode(file_get_contents("php://input"), true);

function GetAllUsers($id){
    global $conn;
    $data = [];
    if(!$id){
        $sql = "SELECT * FROM users";
        $result = $conn->query($sql);
        $data = $result->fetch_all(MYSQLI_ASSOC);

        if(!$result->num_rows > 0){
            echo json_encode(["Message" => "Nincsenek adatok."]);
            http_response_code(404);
        }
    } else {
        $sql = "SELECT * FROM users WHERE id=$id";
        $result = $conn->query($sql);
        $data = $result->fetch_assoc();

        if(!$result->num_rows > 0){
            echo json_encode(["Message" => "Nincsenek adatok."]);
            http_response_code(404);
        }
    }
    echo json_encode($data);
}

function InsertUsers($input){
    global $conn;

    $insert = "INSERT INTO users(username, email, pwd) VALUES (?,?,?)";
    $stmt = $conn->prepare($insert);
    $stmt->bind_param("sss",$input['username'],$input['email'],$input['pwd']);

    if($stmt->execute()){
        echo json_encode(["Message" => "Sikeres mentés"]);
    }
}

function UpdateUsers($id,$input){
    global $conn;

    $update = "UPDATE users SET username = ?, email = ?, pwd = ? WHERE id = ?";
    $stmt = $conn->prepare($update);
    $stmt->bind_param("sssi", $input['username'], $input['email'],$input['pwd'], $id);

    if($stmt->execute() && $stmt->affected_rows > 0){
        echo json_encode(["Message" => "Sikeres frissités"]);
    } else {
        echo json_encode(["Message" => "Elem nem található"]);
        http_response_code(404);
    }
}

function DeleteUser($id){
    global $conn;

    $delete = "DELETE FROM users WHERE id = ?";
    $stmt = $conn->prepare($delete);
    $stmt->bind_param("i", $id);

    if($stmt->execute() && $stmt->affected_rows > 0){
        echo json_encode(["Message" => "Sikeres törlés"]);
    }
}

switch($method){
    case "GET":
        GetAllUsers($id);
        break;
    case "POST":
        InsertUsers($input);
        break;
    case "PUT":
        UpdateUsers($id,$input);
        break;
    case "DELETE":
        DeleteUser($id);
        break;
    default:
        http_response_code(405);
        json_encode(["Message" => "Method nem támogatott"]);
        break;
}
?>