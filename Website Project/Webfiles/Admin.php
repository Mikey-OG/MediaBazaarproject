<?php
require_once ('NavigationBar.php');
?>
<main>
	<link rel="stylesheet" href="../Css/adminpagestylesheet.css">
	<div class = "adminpage">
	<h1>Welcome Admin</h1>
    <form class = "search_bar" method="post" action="">
    <input type="text" placeholder="Employee name.." name="search">
    <button type="submit" name="submit">Search For Employee</button>
	</form>
<?php
		require_once('../classes/userview.class.php');
		$usv = new Userview();
		$usv->ShowAllEmployeesInfoToAdmin();
?>
</div>
</main>