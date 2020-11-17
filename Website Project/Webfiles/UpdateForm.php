<!DOCTYPE html>
<html>
<head>
  <title></title>
  <link rel="stylesheet" href="../Css/updatestyle.css" type="text/css">
</head>
<body>
  <?php include "NavigationBar.php";
       
       require_once('Update.php');
      
  ?>
    <h2>Update personal details</h2>
    <form action="Update.php" method="POST">
      <!--<div class="topdiv">
        <img src="../Media/update.jpg" width="40px" height="40px">
        <h2>Update personal details</h2>
      </div><br>-->
       <label for="username"><b>Username</b></label><br>
       <input type="text" name="uname" class="inputbox" placeholder="Please enter username" value="<?php echo $username;?>"><br><br>
       <p></p>
        
       <label for="firstname"><b>Firstname</b></label><br>
       <input type="text" name="fname" class="inputbox" placeholder="Please enter firstname" value="<?php echo $fname;?>"><br><br>
       <p></p>

       <label for="lastname"><b>Lastname</b></label><br>
       <input type="text"  name="lname" class="inputbox" placeholder="Please enter lastname" value="<?php echo $lname;?>"><br><br>
       <p></p>

       <label for="dob"><b>D.O.B</b></label><br>
       <input type="date"  name="dob" class="inputbox" placeholder="Please enter your date of birth" value="<?php echo $dob;?>"><br><br>
       <p></p>
       
       <label for="email"><b>Email</b></label><br>
       <input type="email"  name="email" class="inputbox" placeholder="Please enter your email" value="<?php echo $email;?>"><br><br>
       <p></p>
      
       <label for="phonenumber"><b>Phone</b></label><br>
       <input type="text" name="phone" class="inputbox" placeholder="Please enter phone number" value="<?php echo $phone;?>"><br><br>
       <p></p>
        
       <label for="nationality"><b>Nationality</b></label><br>
       <input type="text" name="nationality" class="inputbox" placeholder="Please enter nationality" value="<?php echo $nationality;?>"><br><br>
       <p></p>

       <label for="address"><b>Address</b></label><br>
       <input type="text" name="address" class="inputbox" placeholder="Please enter address" value="<?php echo $address;?>"><br><br>
       <p></p>
        
       <label for="city"><b>City</b></label><br>
       <input type="text" name="city" class="inputbox" placeholder="Please enter city" value="<?php echo $city;?>"><br><br>
       <p></p>
        
       <label for="zipcode"><b>Zipcode</b></label><br>
       <input type="text" name="zipcode" class="inputbox" placeholder="Please enter zipcode" value="<?php echo $zipcode;?>"><br><br>
       
        
       <input type="submit"  name="update" class="updateBtn" value="Click to Update Personal Information"/>  
    </form>
</body>
</html>


