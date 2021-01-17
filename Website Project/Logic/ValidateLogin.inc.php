<?php 

	include 'autoloader.inc.php';
	session_start();

	$Validate = new Validate();

	$Validate->validateLogin($_POST['userName'], $_POST['password']);

	class Validate {

		public function validateLogin(string $userName, string $password) {
			$cry = new LGC_Encryption();
			$UserInfo = new DAL_UserInfo();
			$ldc = new LGC_DateConfig();


			if ($userName == $UserInfo->getUserInlog($userName, 0) && $cry->Encrypt($password) == $UserInfo->getUserInlog($userName, 1)) {

				$_SESSION['userName'] = $userName; 
				$_SESSION['FormAccess'] = $UserInfo->getUserInlog($userName, 2);
				$_SESSION['UserID'] = $UserInfo->getUserInlog($userName, 3);
				$ldc->SetCurrentDate();

				echo "<script> location.href='../ScheduleViewPage.php'</script>"; 

			}

			else {

				echo "<script> location.href='../index.php?Validate=false'</script>"; 

			}

		}

	}
?>