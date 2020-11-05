 <?php

  $conn = mysqli_connect('studmysql01.fhict.local','dbi435115','group3');

  //$db = mysqli_select_db($conn,"dbi447707");
  mysqli_select_db($conn,'dbi435115');

  if(isset($_POST['update']))
  {
    $username = $_POST['username'];
    
    $sql = "UPDATE `employees` SET FirstName = '$_POST[fname]', LastName = '$_POST[lname]', Email = '$_POST[email]', DateOfBirth = '$_POST[dob]', PhoneNumber = '$_POST[phone]', Nationality = '$_POST[nationality]',City = '$_POST[city]', ZipCode = '$_POST[zipcode]', Adress = '$_POST[address]' WHERE UserName = '$_POST[uname]'";

    $sql_run = mysqli_query($conn, $sql);

    if($sql_run)
    {
     header("refresh:1; url=UpdateForm.php");
     echo '<script type="text/javascript"> alert("Your details have been updated")</script>';
    }
    else
    {
     echo '<script type="text/javascript"> alert("Something went wrong, details could not be updated")</script>';
    }
  }

?>