<?php 
	session_start(); 
	if (!isset($_SESSION['userName'])) { echo "<script> location.href='../Webfiles/LoginPage.php'</script>"; }
 ?>

<link rel="stylesheet" href="../Css/NavigationBarStylesheet.css">

<nav>
	<a href="#">Schedule</a>
	<a href="PersonalDetails.php">Personal Details</a>
	<a href="stock.php">Stock</a>
	<?php 
		if ($_SESSION['FormAccess'] == "StockManagerForm" || $_SESSION['FormAccess'] == "AdminForm") { echo "<a href='#'>Stock Management</a>"; } 
	?>
	<?php 
		if ($_SESSION['FormAccess'] == "EmployeeForm" || $_SESSION['FormAccess'] == "AdminForm") { echo "<a href='#'>Employee Management</a>"; } 
	?>
	<?php 
		if ($_SESSION['FormAccess'] == "AdminForm") { echo "<a href='#'>Admin</a>"; } 
	?>
	<?php echo "<div class = 'navusername'> " . $_SESSION['userName'] . "</div>" ?>
	<a href="../Logic/Logout.php" class="navigationBarRight">Log out</a>
</nav>	
