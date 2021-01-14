<?php
	require_once ("../DataBase/SetAvailability.php");

	session_start();
	$Availability = new Availability();
	$count = 0;
	$mondayDate = $_POST['date2'];
	$tuesdayDate = date("d-m-Y", strtotime($_POST['date2'] . ' + 1 days'));
	$wednesdayDate = date("d-m-Y", strtotime($_POST['date2'] . ' + 2 days'));
	$thursdayDate = date("d-m-Y", strtotime($_POST['date2'] . ' + 3 days'));
	$fridayDate = date("d-m-Y", strtotime($_POST['date2'] . ' + 4 days'));
	$saturdayDate = date("d-m-Y", strtotime($_POST['date2'] . ' + 5 days'));
	$sundayDate = date("d-m-Y", strtotime($_POST['date2'] . ' + 6 days'));

	while ($count < $Availability->CalculateFromUntill()) {
		$Availability->SetAvailabilityMonday($mondayDate);
		$Availability->SetAvailabilityTuesday($tuesdayDate);
		$Availability->SetAvailabilityWednesday($wednesdayDate);
		$Availability->SetAvailabilityThursday($thursdayDate);
		$Availability->SetAvailabilityFriday($fridayDate);
		$Availability->SetAvailabilitySaturday($saturdayDate);
		$Availability->SetAvailabilitySunday($sundayDate);
		$mondayDate = date("d-m-Y", strtotime($mondayDate . ' + 7 days'));
		$tuesdayDate = date("d-m-Y", strtotime($tuesdayDate . ' + 7 days'));
		$wednesdayDate = date("d-m-Y", strtotime($wednesdayDate . ' + 7 days'));
		$thursdayDate = date("d-m-Y", strtotime($thursdayDate . ' + 7 days'));
		$fridayDate = date("d-m-Y", strtotime($fridayDate . ' + 7 days'));;
		$saturdayDate = date("d-m-Y", strtotime($saturdayDate . ' + 7 days'));
		$sundayDate = date("d-m-Y", strtotime($sundayDate . ' + 7 days'));
		$count += 1;
	}

	echo "<script> location.href='../Webfiles/AvailabilityPage.php'</script>";

	
 	class Availability {
 		public function CalculateFromUntill() : int {
 			$fromDate = $_POST['date2'];
 			$untilDate = $_POST['until'];
 			$daysBetween = strtotime($untilDate) - strtotime($fromDate);
 			$result = abs(round($daysBetween / 86400));
 			$result = $result / 7;
 			if ($result > 0) {
 				$result = $result + 1;
 				return $result;
 			}
 			else {
 				return 1;
 			}
 		}

 		public function SetAvailabilityMonday(string $date) {
			$SetAvailability = new SetAvailability();
			if ($_POST['monday'] == "Available") {
				$SetAvailability->SetAvailabilityMorningAvailable($date, $_SESSION['UserID']);
				$SetAvailability->SetAvailabilityAfternoonAvailable($date, $_SESSION['UserID']);
				$SetAvailability->SetAvailabilityEveningAvailable($date, $_SESSION['UserID']);
			}
			elseif ($_POST['monday'] == "Unavailable") {
				$SetAvailability->SetAvailabilityMorning($date, $_SESSION['UserID']);
				$SetAvailability->SetAvailabilityAfternoon($date, $_SESSION['UserID']);
				$SetAvailability->SetAvailabilityEvening($date, $_SESSION['UserID']);
			}
		}

		public function SetAvailabilityTuesday(string $date) {
			$SetAvailability = new SetAvailability();
			if ($_POST['tuesday'] == "Available") {
				$SetAvailability->SetAvailabilityMorningAvailable($date, $_SESSION['UserID']);
				$SetAvailability->SetAvailabilityAfternoonAvailable($date, $_SESSION['UserID']);
				$SetAvailability->SetAvailabilityEveningAvailable($date, $_SESSION['UserID']);
			}
			elseif ($_POST['tuesday'] == "Unavailable") {
				$SetAvailability->SetAvailabilityMorning($date, $_SESSION['UserID']);
				$SetAvailability->SetAvailabilityAfternoon($date, $_SESSION['UserID']);
				$SetAvailability->SetAvailabilityEvening($date, $_SESSION['UserID']);
			}
		}

		public function SetAvailabilityWednesday(string $date) {
			$SetAvailability = new SetAvailability();
			if ($_POST['wednesday'] == "Available") {
				$SetAvailability->SetAvailabilityMorningAvailable($date, $_SESSION['UserID']);
				$SetAvailability->SetAvailabilityAfternoonAvailable($date, $_SESSION['UserID']);
				$SetAvailability->SetAvailabilityEveningAvailable($date, $_SESSION['UserID']);
			}
			elseif ($_POST['wednesday'] == "Unavailable") {
				$SetAvailability->SetAvailabilityMorning($date, $_SESSION['UserID']);
				$SetAvailability->SetAvailabilityAfternoon($date, $_SESSION['UserID']);
				$SetAvailability->SetAvailabilityEvening($date, $_SESSION['UserID']);
			}
		}

		public function SetAvailabilityThursday(string $date) {
			$SetAvailability = new SetAvailability();
			if ($_POST['thursday'] == "Available") {
				$SetAvailability->SetAvailabilityMorningAvailable($date, $_SESSION['UserID']);
				$SetAvailability->SetAvailabilityAfternoonAvailable($date, $_SESSION['UserID']);
				$SetAvailability->SetAvailabilityEveningAvailable($date, $_SESSION['UserID']);
			}
			elseif ($_POST['thursday'] == "Unavailable") {
				$SetAvailability->SetAvailabilityMorning($date, $_SESSION['UserID']);
				$SetAvailability->SetAvailabilityAfternoon($date, $_SESSION['UserID']);
				$SetAvailability->SetAvailabilityEvening($date, $_SESSION['UserID']);
			}
		}

		public function SetAvailabilityFriday(string $date) {
			$SetAvailability = new SetAvailability();
			if ($_POST['friday'] == "Available") {
				$SetAvailability->SetAvailabilityMorningAvailable($date, $_SESSION['UserID']);
				$SetAvailability->SetAvailabilityAfternoonAvailable($date, $_SESSION['UserID']);
				$SetAvailability->SetAvailabilityEveningAvailable($date, $_SESSION['UserID']);
			}
			elseif ($_POST['friday'] == "Unavailable") {
				$SetAvailability->SetAvailabilityMorning($date, $_SESSION['UserID']);
				$SetAvailability->SetAvailabilityAfternoon($date, $_SESSION['UserID']);
				$SetAvailability->SetAvailabilityEvening($date, $_SESSION['UserID']);
			}
		}

		public function SetAvailabilitySaturday(string $date) {
			$SetAvailability = new SetAvailability();
			if ($_POST['saturday'] == "Available") {
				$SetAvailability->SetAvailabilityMorningAvailable($date, $_SESSION['UserID']);
				$SetAvailability->SetAvailabilityAfternoonAvailable($date, $_SESSION['UserID']);
				$SetAvailability->SetAvailabilityEveningAvailable($date, $_SESSION['UserID']);
			}
			elseif ($_POST['saturday'] == "Unavailable") {
				$SetAvailability->SetAvailabilityMorning($date, $_SESSION['UserID']);
				$SetAvailability->SetAvailabilityAfternoon($date, $_SESSION['UserID']);
				$SetAvailability->SetAvailabilityEvening($date, $_SESSION['UserID']);
			}
		}

		public function SetAvailabilitySunday(string $date) {
			$SetAvailability = new SetAvailability();
			if ($_POST['sunday'] == "Available") {
				$SetAvailability->SetAvailabilityMorningAvailable($date, $_SESSION['UserID']);
				$SetAvailability->SetAvailabilityAfternoonAvailable($date, $_SESSION['UserID']);
				$SetAvailability->SetAvailabilityEveningAvailable($date, $_SESSION['UserID']);
			}
			elseif ($_POST['sunday'] == "Unavailable") {
				$SetAvailability->SetAvailabilityMorning($date, $_SESSION['UserID']);
				$SetAvailability->SetAvailabilityAfternoon($date, $_SESSION['UserID']);
				$SetAvailability->SetAvailabilityEvening($date, $_SESSION['UserID']);
			}
		}
	}

?>