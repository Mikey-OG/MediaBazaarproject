  <?php
  session_start();
  require_once ('../DataBase/Connection.php'); 
  if(isset($_POST['update']))
  {
     $Connection = new Connection(); 
    $usr = $_SESSION['userName'];
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
    
    $sql = "UPDATE `employee` SET UserName=:username, FirstName=:fname, LastName=:lname, DateOfBirth=:dob, Email=:email, PhoneNumber=:phone, Nationality=:nationality, Adress=:address, City=:city, ZipCode=:zipcode WHERE UserID= :Id ";
    
    $stmt = $Connection->connect()->prepare($sql);
    $stmt->execute(array(":username" =>$username,":fname" =>$fname, ":lname" =>$lname, ":dob" =>$dob, ":email" =>$email, ":phone" =>$phone, ":nationality" =>$nationality, ":address" =>$address,":city" =>$city, ":zipcode" =>$zipcode, ":Id" =>$Id));


    if($stmt)
    {
     header("refresh:1; url=../PersonalDetails.php");
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