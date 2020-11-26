 <?php
ini_set('error_reporting', E_ALL & ~E_DEPRECATED & ~E_STRICT & ~E_NOTICE); // Show all errors minus STRICT, DEPRECATED and NOTICES
ini_set('display_errors', 0); // disable error display
ini_set('log_errors', 0); // disable error logging
session_start(); 
  $conn = mysqli_connect('studmysql01.fhict.local','dbi435115','group3');

  mysqli_select_db($conn,'dbi435115');
  $usr = $_SESSION['userName'];
  
$result = mysqli_query($conn,"SELECT * FROM employees WHERE UserName = '$usr'");
 while($rowval = mysqli_fetch_array($result))
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

  if(isset($_POST['update']))
  {
    $username = $_POST['username'];
    
    $sql = "UPDATE `employees` SET UserName = '$_POST[uname]', FirstName = '$_POST[fname]', LastName = '$_POST[lname]', Email = '$_POST[email]', DateOfBirth = '$_POST[dob]', PhoneNumber = '$_POST[phone]', Nationality = '$_POST[nationality]',City = '$_POST[city]', ZipCode = '$_POST[zipcode]', Adress = '$_POST[address]' WHERE UserID= '$_POST[Id]'";
    
    $sql_run = mysqli_query($conn, $sql);
    $username = $_POST[uname];

    if($sql_run)
    {
     header("refresh:1; url=PersonalDetails.php");
     echo '<script type="text/javascript"> alert("Your details have been updated")</script>';

     if($_SESSION['userName'] != $username)
     {
      session_destroy(); 
       header("refresh:1; url=LoginPage.php");
       echo '<script type="text/javascript"> alert("You have been logged out because you changed your username,please re-login with your new username.")</script>';
     }
    }
    else
    {
      header("refresh:1; url=PersonalDetails.php");
     echo '<script type="text/javascript"> alert("Something went wrong, details could not be updated")</script>';
    }
  }

?>