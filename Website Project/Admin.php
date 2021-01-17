<?php
require_once ('NavigationBar.php');
?>
<main>
	<link rel="stylesheet" href="Css/adminpagestyling.css">
	<div class="actionBar">
		<form method="post" action="Admin.php">
			    <select  data-rel="chosen"  name="categories" class="category">
                <option>UserName</option>
                <option>FirstName</option>
                <option>LastName</option>
                <option>Salary</option>
                <option>DepartmentName</option>
                <option>RoleName</option>
            </select>
			<input type="text" placeholder="Search For..." name="search" class="textbox">
			<input type="submit" name="employeesearch" class="button" value="Search">
		</form>
	</div>
	<div class = "adminpage">
<?php
require_once ("class/LGC_EmployeeManagement.class.php");
$lem = new LGC_EmployeeManagement();
if(isset($_POST['employeesearch']))
{
	$String = $_POST["categories"];
	$Search = $_POST['search'];
	$lem->ShowEmployeesInfoToAdminBySearch($Search,$String);
}
else
{
	$lem->ShowAllEmployeesInfoToAdmin();
}
?>

</div>
</main>