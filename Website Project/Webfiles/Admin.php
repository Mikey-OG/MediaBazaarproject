<?php
require_once ('NavigationBar.php');
?>
<main>
	<link rel="stylesheet" href="../Css/adminpagestylesheet.css">
	<div class = "adminpage">
	<h1>Welcome Admin</h1>
    <form class = "search_bar" method="post" action="Admin.php">
    <input type="text" placeholder="Employee name.." name="search_firstname">
    <button type="submit" name="search">Search For Employee</button>
	</form>
<?php
		require_once('../classes/userview.class.php');
		$usv = new Userview();
		if(isset($_POST['search']))
		{
			$firstname = $_POST['search_firstname'];
			$usv->ShowEmployeesInfoToAdminBySearch($firstname);
		}
		else
		{
			$usv->ShowAllEmployeesInfoToAdmin();
		}
		
?>
</div>
</main>