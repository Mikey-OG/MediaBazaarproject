<?php
require_once ('NavigationBar.php');
?>
<main>
	<link rel="stylesheet" href="../Css/adminpagestyling.css">
	<div class="actionBar">
		<form method="post" action="Admin.php">
			<input type="text" placeholder="Employee name..." name="search_firstname" class="textbox">
			<input type="submit" name="search" class="button" value="Search">
		</form>
	</div>
	<div class = "adminpage">
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