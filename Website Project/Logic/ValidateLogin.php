<?php 

	require_once ("../DataBase/GetUserInfo.php");
	require('ScheduleInput.php');

	session_start();

	$Validate = new Validate();

	$Validate->validateLogin($_POST['userName'], $_POST['password']);

	class Validate {

		public function validateLogin(string $userName, string $password) {
			require_once('../classes/encryption.php');
			$cry = new Encryption();
			$UserInfo = new UserInfo();
			$ScheduleInput = new ScheduleInput();


			if ($userName == $UserInfo->getUserInlog($userName, 0) && $cry->Encrypt($password) == $UserInfo->getUserInlog($userName, 1)) {

				$_SESSION['userName'] = $userName; 
				$_SESSION['FormAccess'] = $UserInfo->getUserInlog($userName, 2);
				$_SESSION['UserID'] = $UserInfo->getUserInlog($userName, 3);
				$ScheduleInput->SetCurrentDate();

				echo "<script> location.href='../Webfiles/ScheduleViewPage.php'</script>"; 

			}

			else {

				echo "<script> location.href='../Webfiles/LoginPage.php?Validate=false'</script>"; 

			}

		}

	}
?>