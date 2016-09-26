<?php 
// connect to the mysql database
$link = mysqli_connect('localhost', 'u754486136_admin', 'BM3990hhLT', 'u754486136_users');
mysqli_set_charset($link,'utf8');

$sql = "select * from `$table`".($key?" WHERE id=$key":'');

// excecute SQL statement
$result = mysqli_query($link,$sql);
 
// die if SQL statement failed
if (!$result) {
  http_response_code(404);
  die(mysqli_error());

?>