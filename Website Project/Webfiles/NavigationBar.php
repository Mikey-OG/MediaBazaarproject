<?php 
	session_start(); 
	if (!isset($_SESSION['userName'])) { echo "<script> location.href='../Webfiles/LoginPage.php'</script>"; }
 ?>

<link rel="stylesheet" href="../Css/NavigationBarStylesheet.css">

<nav>
	<a href="#">Schedule</a>
<<<<<<< HEAD
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> Smirnov-Kirill
	<a href="#">Personal Details</a>
=======
	<a href="PersonalDetails.php">Personal Details</a>
>>>>>>> Osuntuyi-Michael
	<a href="#">Stock</a>
<<<<<<< HEAD
=======
=======
	<a href="PersonalDetails.php">Personal Details</a>
	<a href="stock.php">Stock</a>
>>>>>>> Smirnov-Kirill
>>>>>>> Smirnov-Kirill
	<?php 
		if ($_SESSION['FormAccess'] == "StockManagerForm" || $_SESSION['FormAccess'] == "AdminForm") { echo "<a href='#'>Stock Management</a>"; } 
	?>
	<?php 
		if ($_SESSION['FormAccess'] == "EmployeeForm" || $_SESSION['FormAccess'] == "AdminForm") { echo "<a href='#'>Employee Management</a>"; } 
	?>
	<?php 
		if ($_SESSION['FormAccess'] == "AdminForm") { echo "<a href='#'>Admin</a>"; } 
	?>
<<<<<<< HEAD
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> Smirnov-Kirill
	<?php echo "<div> " . $_SESSION['userName'] . "</div>" ?>
=======
	<?php echo "<div class = 'navusername'> " . $_SESSION['userName'] . "</div>" ?>
>>>>>>> Osuntuyi-Michael
<<<<<<< HEAD
=======
=======
	<?php echo "<div class = 'navusername'> " . $_SESSION['userName'] . "</div>" ?>
>>>>>>> Smirnov-Kirill
>>>>>>> Smirnov-Kirill
	<a href="../Logic/Logout.php" class="navigationBarRight">Log out</a>
</nav>	
