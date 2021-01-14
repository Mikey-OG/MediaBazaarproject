<?php
	require_once ("../DataBase/SetAvailability.php");

	session_start();
	$Availability = new Availability();

	$Availability->SetAvailabilityMorning();
	$Availability->SetAvailabilityAfternoon();
	$Availability->SetAvailabilityEvening();
	echo "<script> location.href='../Webfiles/AvailabilityPage.php'</script>";

 	class Availability {

		public function SetAvailabilityMorning() {
			$SetAvailability = new SetAvailability();
			if ($_POST['morning'] == "Available") {
				$SetAvailability->SetAvailabilityMorningAvailable($_POST['date'], $_SESSION['UserID']);
			}
			elseif ($_POST['morning'] == "Unavailable") {
				$SetAvailability->SetAvailabilityMorning($_POST['date'], $_SESSION['UserID']);
			}
		}

		public function SetAvailabilityAfternoon() {
			$SetAvailability = new SetAvailability();
			if ($_POST['afternoon'] == "Available") {
				$SetAvailability->SetAvailabilityAfternoonAvailable($_POST['date'], $_SESSION['UserID']);
			}
			elseif ($_POST['afternoon'] == "Unavailable") {
				$SetAvailability->SetAvailabilityAfternoon($_POST['date'], $_SESSION['UserID']);
			}
		}

		public function SetAvailabilityEvening() {
			$SetAvailability = new SetAvailability();
			if ($_POST['evening'] == "Available") {
				$SetAvailability->SetAvailabilityEveningAvailable($_POST['date'], $_SESSION['UserID']);
			}
			elseif ($_POST['evening'] == "Unavailable") {
				$SetAvailability->SetAvailabilityEvening($_POST['date'], $_SESSION['UserID']);
			}
		}
	}

?>
