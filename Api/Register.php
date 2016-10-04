<?php
// connect to the mysql database
$link = mysqli_connect('mysql.hostinger.nl', 'u754486136_admin', 'ANiJ5qzMZ7', 'u754486136_users');
mysqli_set_charset($link,'utf8');

$sql = "INSERT INTO Users (Name, Username, Password, Email, Confirm) VALUES ('".mysqli_real_escape_string($link, $_POST['name'])."', '".mysqli_real_escape_string($link, $_POST['username'])."', '".mysqli_real_escape_string($link, $_POST['password'])."', '".mysqli_real_escape_string($link, $_POST['email'])."', 0) ";

// excecute SQL statement
$result = mysqli_query($link,$sql);
 
// die if SQL statement failed
if (!$result) {
  die(mysqli_error($link));
}
?> 