<?php 
session_start();
?>
<!DOCTYPE html>
<html>
<head>
	<link rel="stylesheet" href="Css/LoginStylesheet.css">
	<title>Login</title>
</head>
<body>
		<?php 

			if(isset($_SESSION['userName'] )){
				header("Location: ScheduleViewPage.php");
			}
		?>	
	<form action="Logic/ValidateLogin.inc.php" method="post">
		<h2>Login</h2>
		<label>User Name</label>
		<input type="text" name="userName" id="userName" autocomplete="off">
		<label>Password</label>
		<input type="password" name="password" id="password" autocomplete="off">
		<?php 
			if(isset($_GET['Validate']) == "false") {
				echo '<div class="loginFailed">Login failed! Check your credentials.</div>';
			}
		?>	
		<button type="submit">Login</button>
	</form>
</body>
</html>
