<?php
require_once ('NavigationBar.php');
?>
<main>
	<link rel="stylesheet" href="../Css/personaldetailstyle.css">
	<div class = "personaldetails">
	<h1>Personal Information </h1>
<?php
		require_once('../classes/userview.class.php');
		$usr = $_SESSION['userName'];
		$usv = new Userview();
		$usv->ShowUsersByUsingPreparedStatements($usr);
	?>
</div>
<div class = "message">
<h3>Important Message</h3>
<p>if you notice errors in your personal details<br>
	click on the link to<a href="#"> update your persnal details</a>
</p>
</div>
</main>