<?php

header("Content-type: application/json");
header("Access-Control-Allow-Methods: GET, POST, PUT, DELETE");

$servername = "localhost";
$username = "root";
$password = "";
$dbname = "netrunner";

$conn = new mysqli($servername, $username, $password, $dbname);

if ($conn->connect_error) {
  die("Connection failed: " . $conn->connect_error);
}

$method = $_SERVER['REQUEST_METHOD'];
$id = isset($_GET['id']) ? $_GET['id'] : null;

$input = json_decode(file_get_contents("php://input"), true);

switch($method){
    case "GET":
        if(!$id){
            $QueryAll = "SELECT * FROM 'implants'";
            $result = $conn->query($QueryAll);
            $data = $result->fetch_all(MYSQLI_ASSOC);
        } else {
            $QueryById = "SELECT * FROM 'implants' WHERE id = $id";
            $result = $conn->query($QueryById);

            if ($result->num_rows > 0) 
            {
                $data = $result->fetch_assoc();
            } else {
                http_response_code(404);
                break;
            }
        }
        echo json_encode($data);
        http_response_code(200);
        break;

    case "POST":
        $insert = "INSERT INTO implants (name, slot, ram_usage ,danger_level) 
        VALUES (?,?,?,?)";
        $stmt = $conn->prepare($insert);
        $stmt->bind_param("ssii",$input['name'],$input['slot'],$input['ram_usage'],$input['danger_level']);
        
        if($stmt->execute()){
            echo json_encode(["Message" => "Sikeres beszúrás"]);
            http_response_code(201);
        }

        break;
    case "PUT":
        if($id){
            $update = "UPDATE implants SET name=? , slot=? , ram_usage=?, danger_level = ? WHERE id=?";
            $stmt = $conn->prepare($update);
            $stmt->bind_param("ssiii",$input['name'],$input['slot'],$input['ram_usage'],$input['danger_level'], $id);
            
            if($stmt->execute() && $stmt->affected_rows > 0){
                echo json_encode(["Message" => "Sikeres mentés"]);
                http_response_code(200);
            }
        }
        else {
            echo json_encode(["Message" => "ID nem található!"]);
            http_response_code(404);
        }
    case "DELETE":
        if($id){
            $delete = "DELETE FROM `cars` where id=?";
            $stmt = $conn-> prepare($delete);
            $stmt->bind_param("i", $id);

            if ($stmt->execute() && $stmt -> affected_rows > 0 ) {
                echo json_encode(["message" => "Autó törölve."]);
            } else {
                echo json_encode(["message" => "Ezzel az ID-val nincs törölhető sor."]);
            }
        }
        break;
    default:
           http_response_code(405);
           echo json_encode(["message" => "Nem támogatott művelet."]);
    break;
        break;
}

?>