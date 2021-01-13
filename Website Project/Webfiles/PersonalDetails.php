<?php
require_once ('NavigationBar.php');
require_once('../classes/userview.class.php');
//require_once('../classes/usermodel.class.php');
//$usm = new UserModel();
require_once ('Update.php');
?>
<main>
  <link rel="stylesheet" href="../Css/personalDetailsStyle.css">
  <div class="container">
    <div class="title">
      <!--<a href="PersonalDetails.php?update=true" name="update" class="button">Update</a>-->
      <input type="submit" name ="update" class="updateBtn" value="Update" form="uform" />
      Personal Details
    </div>

  <form action="Update.php" method="POST" id="uform">
    <div class="content" >
      <div class='name'>ID</div><div class='item'><input type="text" name='Id' readonly value="<?php echo $Id;?>"/></div>
      <div class='name'>Username</div><div class='item'><input type="text" name='uname' size="103"  value="<?php echo $username;?>"/></div>
      <div class='name'>Email</div><div class='item' ><input type="email" name='email' size="103" value="<?php echo $email;?>"/></div>
      <div class='name'>First name</div><div class='item' ><input type="text"  name='fname' size="103" value="<?php echo $fname;?>"/></div>
      <div class='name'>Last name</div><div class='item' ><input type="text" name='lname' size="103" value="<?php echo $lname;?>"/></div>
      <div class='name'>Date of birth</div><div class='item' ><input type="text" name='dob' size="103" value="<?php echo $dob;?>" /></div>
      <div class='name'>Phonenumber</div><div class='item' ><input type="text"  name='phone' size="103" value="<?php echo $phone;?>"/></div>
      <div class='name'>Nationality</div><div class='item'  ><input type="text" name='nationality' size="103" value="<?php echo $nationality;?>"/></div>
      <div class='name'>Address</div><div class='item' ><input type="text" name='address' size="103" value="<?php echo $address;?>"/></div>
      <div class='name'>City</div><div class='item' ><input type="text" name='city' size="103" value="<?php echo $city;?>"/></div>
      <div class='name'>Zip code</div><div class='item'><input type="text" name='zipcode' size="103" value="<?php echo $zipcode;?>"/></div>
    </div>  
  </form>
  </div>
</main>