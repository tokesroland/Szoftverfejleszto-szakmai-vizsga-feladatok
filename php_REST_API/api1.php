<?php

$servername = "localhost";
$username = "root";
$password = "";
$dbname = "webapp";

$conn = new mysqli($servername, $username, $password, $dbname);

if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

include "UserController.php";

header("Content-Type: application/json; charset=UTF-8");

$method = $_SERVER['REQUEST_METHOD'];
$id = isset($_GET['id']) ? $_GET['id'] : null;
$input = json_decode(file_get_contents("php://input"), true);

switch($method){
    case "GET":
        GetUsers($id);
        break;
    case "POST":
        InsertData($input);
        break;
    case "PUT":
        UpdateData($id, $input);
        break;
    case "DELETE":
        DeleteData($id);
        break;
    default:
        json_encode(["Message" => "Method nem megfelelő"] );
        http_response_code(405);
        break;
}
?>