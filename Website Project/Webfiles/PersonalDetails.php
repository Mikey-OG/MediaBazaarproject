<?php
require_once ('NavigationBar.php');
?>
<main>
	<link rel="stylesheet" href="../Css/personalDetailsStyle.css">
	<div class = "personaldetails">
	<h1>Personal Information </h1>
	<div class = "details">
<?php
		require_once('../classes/userview.class.php');
		$usr = $_SESSION['userName'];
		$usv = new Userview();
		$usv->ShowUsersByUsingPreparedStatements($usr);
	?>
</div>
</div>
<div class = "message">
<h3>Important Message</h3>
<p>if you notice errors in your personal details<br>
	click on the button to
	<form action="UpdateForm.php" method="post">
	<button type="submit">Update Details</button>
	</form>
</p>
</div>
</main>