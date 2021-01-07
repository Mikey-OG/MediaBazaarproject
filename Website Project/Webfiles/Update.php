 <?php
ini_set('error_reporting', E_ALL & ~E_DEPRECATED & ~E_STRICT & ~E_NOTICE); // Show all errors minus STRICT, DEPRECATED and NOTICES
ini_set('display_errors', 0); // disable error display
ini_set('log_errors', 0); // disable error logging
session_start();
require_once ('../DataBase/Connection.php'); 
 try 
 {
   $Connection = new Connection(); 
  $usr = $_SESSION['userName'];
  
 $result = "SELECT * FROM employees WHERE UserName = :usr";
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


  if(isset($_POST['update']))
  {
    $Id = $_POST['Id'];
    $username = $_POST['uname'];
    $fname= $_POST['fname'];
    $lname= $_POST['lname'];
    $dob = $_POST['dob'];
    $email= $_POST['email'];
    $phone= $_POST['phone'];
    $nationality= $_POST['nationality'];
    $address= $_POST['address'];
    $city= $_POST['city'];
    $zipcode= $_POST['zipcode']; 
    
    $sql = "UPDATE `employees` SET UserName=:username, FirstName=:fname, LastName=:lname, DateOfBirth=:dob, Email=:email, PhoneNumber=:phone, Nationality=:nationality, Adress=:address, City=:city, ZipCode=:zipcode WHERE UserID= :Id ";
    
    $stmt = $Connection->connect()->prepare($sql);
    $stmt->execute(array(":username" =>$username,":fname" =>$fname, ":lname" =>$lname, ":dob" =>$dob, ":email" =>$email, ":phone" =>$phone, ":nationality" =>$nationality, ":address" =>$address,":city" =>$city, ":zipcode" =>$zipcode, ":Id" =>$Id));

    $username = $_POST[uname];

    if($stmt)
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
}

catch (Exception $e) 
 {
   echo '<script type="text/javascript"> alert("Something went wrong, please try again. If this problem persists, you can contact the manager or update your details through the app.")</script>';
  echo "<script> location.href='../Webfiles/PersonalDetails.php'</script>";
 }

?>