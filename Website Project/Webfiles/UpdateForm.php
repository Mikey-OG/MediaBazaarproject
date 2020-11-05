<!DOCTYPE html>
<html>
<head>
  <title></title>
  <link rel="stylesheet" href="../Css/updatestyle.css" type="text/css">
</head>
<body>
  <?php include "NavigationBar.php"?>

    <form action="Update.php" method="POST">
      <div class="topdiv">
        <img src="../Media/update.jpg" width="40px" height="40px">
        <h2>Update personal details</h2>
      </div><br>
       <label for="username">Username</label>
       <input type="text" name="uname" class="inputbox" placeholder="Please enter username"><br>
        
       <label for="firstname">Firstname</label>
       <input type="text" name="fname" class="inputbox" placeholder="Please enter firstname"><br>
      
       <label for="lastname">Lastname</label>
       <input type="text"  name="lname" class="inputbox" placeholder="Please enter lastname"><br>
       
       <label for="email">Email</label>&nbsp; &nbsp; &nbsp; 
       <input type="email"  name="email" class="inputbox" placeholder="Please enter your email"><br>
      
       <label for="phonenumber">Phone</label>&nbsp; &nbsp; &nbsp; 
       <input type="number" name="phone" class="inputbox" placeholder="Please enter phone number"><br>
        
       <label for="nationality">Nationality</label>
       <input type="text" name="nationality" class="inputbox" placeholder="Please enter nationality"><br>

       <label for="address">Address</label>&nbsp; &nbsp;
       <input type="text" name="address" class="inputbox" placeholder="Please enter address"><br>
        
       <label for="city">City</label>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
       <input type="text" name="city" class="inputbox" placeholder="Please enter city"><br>
        
       <label for="zipcode">Zipcode</label>&nbsp; &nbsp;
       <input type="text" name="zipcode" class="inputbox" placeholder="Please enter zipcode"><br>
        
       <input type="submit"  name="update" class="updateBtn" value="Click to Update Personal Information"/>  
    </form>
</body>
</html>


