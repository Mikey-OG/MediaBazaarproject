 <?php

  $conn = mysqli_connect('studmysql01.fhict.local','dbi435115','group3');

  //$db = mysqli_select_db($conn,"dbi447707");
  mysqli_select_db($conn,'dbi435115');
  $usr = $_SESSION['userName'];
  
$result = mysqli_query($conn,"SELECT * FROM employees WHERE UserName = '$usr'");
 while($rowval = mysqli_fetch_array($result))
 {

$username= $rowval['UserName'];

$fname= $rowval['FirstName'];

$lname= $rowval['LastName'];

$dob= date('Y-m-d', strtotime($rowval['DateOfBirth']));

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
    
    $sql = "UPDATE `employees` SET FirstName = '$_POST[fname]', LastName = '$_POST[lname]', Email = '$_POST[email]', DateOfBirth = '$_POST[dob]', PhoneNumber = '$_POST[phone]', Nationality = '$_POST[nationality]',City = '$_POST[city]', ZipCode = '$_POST[zipcode]', Adress = '$_POST[address]' WHERE UserName = '$_POST[uname]'";
    
    $sql_run = mysqli_query($conn, $sql);


    if($sql_run)
    {
     header("refresh:1; url=PersonalDetails.php");
     echo '<script type="text/javascript"> alert("Your details have been updated")</script>';
    }
    else
    {
     echo '<script type="text/javascript"> alert("Something went wrong, details could not be updated")</script>';
    }
  }

?>