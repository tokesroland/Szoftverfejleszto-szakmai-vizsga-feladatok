<?php
function GetUsers($id){
    global $conn;
    $data = [];

    if(!$id){
        $getUsers = "SELECT * FROM users";
        $result = $conn->query($getUsers);
        $data = $result->fetch_all(MYSQLI_ASSOC);

        if(!$result->num_rows > 0){
            echo json_encode(["Message" => "Nincsenek adatok."]);
            http_response_code(404);
        }

    } else {
        $getUsers = "SELECT * FROM users WHERE id = $id";
        $result = $conn->query($getUsers);
        $data = $result->fetch_assoc();

        if(!$result->num_rows > 0){
            echo json_encode(["Message" => "Nincs ilyen ID."]);
            http_response_code(404);
        }
    }
    echo json_encode($data ?: []);
}

function InsertData($input){
    global $conn;

    $insert = "INSERT INTO users(username, email, pwd) VALUES (?,?,?)";
    $stmt = $conn->prepare($insert);
    $stmt->bind_param("sss", $input['username'],$input['email'],$input['pwd']);

    if($stmt->execute()){
        echo json_encode(["Message" => "Sikeres beszúrás"]);
        http_response_code(201);
    }
    else {
        http_response_code(500);
        echo json_encode(["Message" => "KATASZTROFALIS HIBA BAZDMEG"]);
    }

}

function UpdateData($id, $input){
    global $conn;

    if($id){
        $update = "UPDATE users SET username = ?, email = ?, pwd = ? WHERE id = ?";
        $stmt = $conn->prepare($update);
        $stmt->bind_param("sssi", $input['username'],$input['email'],$input['pwd'], $id);

        if($stmt->execute() && $stmt-> affected_rows > 0){
            echo json_encode(["Message" => "Sikeres mentés"]);
            http_response_code(200);

        }
    } else {
        http_response_code(404);
        echo json_encode(["Message" => "ID beállítása kell xdd"]);
    }
}

function DeleteData($id){
    global $conn;

    if($id){
        $delete = "DELETE FROM users WHERE id = ?";
        $stmt = $conn->prepare($delete);
        $stmt->bind_param("i", $id);

        if($stmt->execute() && $stmt->affected_rows > 0){
            http_response_code(200);
            echo json_encode(["Message" => "Törölve gec"]);
        } else {
            http_response_code(404);
            echo json_encode(["Message" => "Nem található az id"]);

        }

    } else {
        echo json_encode(["Message" => "Kötelező megadni az id-t te autista"]);
    }
}

?>