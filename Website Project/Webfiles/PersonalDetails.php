<?php
require_once ('NavigationBar.php');
require_once('../classes/userview.class.php');
?>
<main>
	<link rel="stylesheet" href="../Css/personalDetailsStyle.css">
	<div class="container">
		<div class="title">
			<a href="UpdateForm.php" class="button">Update</a>
			Personal Details
		</div>
		<div class="content">
			<?php
				$usr = $_SESSION['userName'];
				$usv = new Userview();
				$usv->ShowUsersByUsingPreparedStatements($usr);
			?>
		</div>
	</div>
</main>