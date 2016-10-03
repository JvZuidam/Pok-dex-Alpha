<?php 
var_dump($_POST);
exit;
// connect to the mysql database
$link = mysqli_connect('mysql.hostinger.nl', 'u754486136_admin', 'BM3990hhLT', 'u754486136_users');
mysqli_set_charset($link,'utf8');

$sql = "INSERT INTO Users set $set";

// excecute SQL statement
$result = mysqli_query($link,$sql);
 
// die if SQL statement failed
if (!$result) {
  http_response_code(404);
  die(mysqli_error());
}
?> 