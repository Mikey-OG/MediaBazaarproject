<?php 
	session_start(); 
	if (!isset($_SESSION['userName'])) { echo "<script> location.href='../Webfiles/LoginPage.php'</script>"; }
 ?>

<link rel="stylesheet" href="../Css/NavigationBarStylesheet.css">

<nav>
	<a href="ScheduleViewPage.php">Schedule</a>
	<a href="PersonalDetails.php">Personal Details</a>
	<a href="newstock.php">Stock</a>
	<?php 
		if ($_SESSION['FormAccess'] == "EmployeeForm" || $_SESSION['FormAccess'] == "AdminForm") { echo "<a href='Admin.php'>Employee Management</a>"; } 
	?>
	<?php 
		if ($_SESSION['FormAccess'] == "AdminForm") { echo "<a href='EmployeeStatsChart.php'>Statistics</a>"; } 
	?>
	<?php echo "<div class = 'navusername'> " . $_SESSION['userName'] . "</div>" ?>

	<a href="../Logic/Logout.php" class="navigationBarRight">Log out</a>
</nav>	
