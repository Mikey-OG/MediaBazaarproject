<?php 

	require_once ("../DataBase/GetUserInfo.php");

	session_start();

	$userName = $_POST['userName'];
	$password = $_POST['password'];
	$Validate = new Validate();

	$Validate->validateLogin($userName, $password);

	class Validate {

		public function validateLogin(string $userName, string $password) {
			require_once('../classes/encryption.php');
			$cry = new Encryption();

			$UserInfo = new UserInfo();


			if ($userName == $UserInfo->getUserInlog($userName, 0) && $cry->Encrypt($password) == $UserInfo->getUserInlog($userName, 1)) {

				$_SESSION['userName'] = $userName; 
				$_SESSION['FormAccess'] = $UserInfo->getUserInlog($userName, 2);
				echo "<script> location.href='../Webfiles/NavigationBar.php'</script>"; 

			}

			else {

				echo "<script> location.href='../Webfiles/LoginPage.php?Validate=false'</script>"; 

			}

		}

	}
?>