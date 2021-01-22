 <?php
ini_set('error_reporting', E_ALL & ~E_DEPRECATED & ~E_STRICT & ~E_NOTICE); // Show all errors minus STRICT, DEPRECATED and NOTICES
ini_set('display_errors', 0); // disable error display
ini_set('log_errors', 0); // disable error logging
session_start();
require_once ('DataBase/Connection.php'); 
 try 
 {
   $Connection = new Connection(); 
  $usr = $_SESSION['userName'];
  
 $result = "SELECT * FROM employee WHERE UserName = :usr";
 $sth = $Connection->connect()->prepare($result);
  $sth->execute(array(":usr" =>$usr));

  while($rowval = $sth->fetch())
 {
   $Id = $rowval['UserID'];

$username= $rowval['UserName'];

$fname= $rowval['FirstName'];

$lname= $rowval['LastName'];

$dob= date('d-m-Y', strtotime($rowval['DateOfBirth']));

$email= $rowval['Email'];

$phone= $rowval['PhoneNumber'];

$nationality= $rowval['Nationality'];

$address= $rowval['Adress'];

$city= $rowval['City'];

$zipcode= $rowval['ZipCode']; 

}
}

catch (Exception $e) 
 {
   echo '<script type="text/javascript"> alert("Something went wrong, please try again. If this problem persists, you can contact the manager or update your details through the app.")</script>';
  echo "<script> location.href='PersonalDetails.php'</script>";
 }

?>