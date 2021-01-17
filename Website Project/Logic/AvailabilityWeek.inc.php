<?php
	include 'autoloader.inc.php';

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
		$Availability->SetAvailabilityMonday($Availability->ChangeToDateFormat($mondayDate));
		$Availability->SetAvailabilityTuesday($Availability->ChangeToDateFormat($tuesdayDate));
		$Availability->SetAvailabilityWednesday($Availability->ChangeToDateFormat($wednesdayDate));
		$Availability->SetAvailabilityThursday($Availability->ChangeToDateFormat($thursdayDate));
		$Availability->SetAvailabilityFriday($Availability->ChangeToDateFormat($fridayDate));
		$Availability->SetAvailabilitySaturday($Availability->ChangeToDateFormat($saturdayDate));
		$Availability->SetAvailabilitySunday($Availability->ChangeToDateFormat($sundayDate));
		$mondayDate = date("d-m-Y", strtotime($mondayDate . ' + 7 days'));
		$tuesdayDate = date("d-m-Y", strtotime($tuesdayDate . ' + 7 days'));
		$wednesdayDate = date("d-m-Y", strtotime($wednesdayDate . ' + 7 days'));
		$thursdayDate = date("d-m-Y", strtotime($thursdayDate . ' + 7 days'));
		$fridayDate = date("d-m-Y", strtotime($fridayDate . ' + 7 days'));;
		$saturdayDate = date("d-m-Y", strtotime($saturdayDate . ' + 7 days'));
		$sundayDate = date("d-m-Y", strtotime($sundayDate . ' + 7 days'));
		$count += 1;
	}

	echo "<script> location.href='../AvailabilityPage.php'</script>";

	
 	class Availability {

 		public function ChangeToDateFormat(string $date) : string {
 			$year = substr($date, 0, 4);
 			$day = substr($date, 8, 2);
 			$month = substr($date, 5, 2);

 			return $day."-".$month."-".$year;
 		}


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
			$lsa = new LGC_SetAvailability();
			if ($_POST['monday'] == "Available") {
				$lsa->UserSetAvailabilityMorningAvailable($date, $_SESSION['UserID']);
				$lsa->UserSetAvailabilityAfternoonAvailable($date, $_SESSION['UserID']);
				$lsa->UserSetAvailabilityEveningAvailable($date, $_SESSION['UserID']);
			}
			elseif ($_POST['monday'] == "Unavailable") {
				$lsa->UserSetAvailabilityMorning($date, $_SESSION['UserID']);
				$lsa->UserSetAvailabilityAfternoon($date, $_SESSION['UserID']);
				$lsa->UserSetAvailabilityEvening($date, $_SESSION['UserID']);
			}
		}

		public function SetAvailabilityTuesday(string $date) {
			$lsa = new LGC_SetAvailability();
			if ($_POST['tuesday'] == "Available") {
				$lsa->UserSetAvailabilityMorningAvailable($date, $_SESSION['UserID']);
				$lsa->UserSetAvailabilityAfternoonAvailable($date, $_SESSION['UserID']);
				$lsa->UserSetAvailabilityEveningAvailable($date, $_SESSION['UserID']);
			}
			elseif ($_POST['tuesday'] == "Unavailable") {
				$lsa->UserSetAvailabilityMorning($date, $_SESSION['UserID']);
				$lsa->UserSetAvailabilityAfternoon($date, $_SESSION['UserID']);
				$lsa->UserSetAvailabilityEvening($date, $_SESSION['UserID']);
			}
		}

		public function SetAvailabilityWednesday(string $date) {
			$lsa = new LGC_SetAvailability();
			if ($_POST['wednesday'] == "Available") {
				$lsa->UserSetAvailabilityMorningAvailable($date, $_SESSION['UserID']);
				$lsa->UserSetAvailabilityAfternoonAvailable($date, $_SESSION['UserID']);
				$lsa->UserSetAvailabilityEveningAvailable($date, $_SESSION['UserID']);
			}
			elseif ($_POST['wednesday'] == "Unavailable") {
				$lsa->UserSetAvailabilityMorning($date, $_SESSION['UserID']);
				$lsa->UserSetAvailabilityAfternoon($date, $_SESSION['UserID']);
				$lsa->UserSetAvailabilityEvening($date, $_SESSION['UserID']);
			}
		}

		public function SetAvailabilityThursday(string $date) {
			$lsa = new LGC_SetAvailability();
			if ($_POST['thursday'] == "Available") {
				$lsa->UserSetAvailabilityMorningAvailable($date, $_SESSION['UserID']);
				$lsa->UserSetAvailabilityAfternoonAvailable($date, $_SESSION['UserID']);
				$lsa->UserSetAvailabilityEveningAvailable($date, $_SESSION['UserID']);
			}
			elseif ($_POST['thursday'] == "Unavailable") {
				$lsa->UserSetAvailabilityMorning($date, $_SESSION['UserID']);
				$lsa->UserSetAvailabilityAfternoon($date, $_SESSION['UserID']);
				$lsa->UserSetAvailabilityEvening($date, $_SESSION['UserID']);
			}
		}

		public function SetAvailabilityFriday(string $date) {
			$lsa = new LGC_SetAvailability();
			if ($_POST['friday'] == "Available") {
				$lsa->UserSetAvailabilityMorningAvailable($date, $_SESSION['UserID']);
				$lsa->UserSetAvailabilityAfternoonAvailable($date, $_SESSION['UserID']);
				$lsa->UserSetAvailabilityEveningAvailable($date, $_SESSION['UserID']);
			}
			elseif ($_POST['friday'] == "Unavailable") {
				$lsa->UserSetAvailabilityMorning($date, $_SESSION['UserID']);
				$lsa->UserSetAvailabilityAfternoon($date, $_SESSION['UserID']);
				$lsa->UserSetAvailabilityEvening($date, $_SESSION['UserID']);
			}
		}

		public function SetAvailabilitySaturday(string $date) {
			$lsa = new LGC_SetAvailability();
			if ($_POST['saturday'] == "Available") {
				$lsa->UserSetAvailabilityMorningAvailable($date, $_SESSION['UserID']);
				$lsa->UserSetAvailabilityAfternoonAvailable($date, $_SESSION['UserID']);
				$lsa->UserSetAvailabilityEveningAvailable($date, $_SESSION['UserID']);
			}
			elseif ($_POST['saturday'] == "Unavailable") {
				$lsa->UserSetAvailabilityMorning($date, $_SESSION['UserID']);
				$lsa->UserSetAvailabilityAfternoon($date, $_SESSION['UserID']);
				$lsa->UserSetAvailabilityEvening($date, $_SESSION['UserID']);
			}
		}

		public function SetAvailabilitySunday(string $date) {
			$lsa = new LGC_SetAvailability();
			if ($_POST['sunday'] == "Available") {
				$lsa->UserSetAvailabilityMorningAvailable($date, $_SESSION['UserID']);
				$lsa->UserSetAvailabilityAfternoonAvailable($date, $_SESSION['UserID']);
				$lsa->UserSetAvailabilityEveningAvailable($date, $_SESSION['UserID']);
			}
			elseif ($_POST['sunday'] == "Unavailable") {
				$lsa->UserSetAvailabilityMorning($date, $_SESSION['UserID']);
				$lsa->UserSetAvailabilityAfternoon($date, $_SESSION['UserID']);
				$lsa->UserSetAvailabilityEvening($date, $_SESSION['UserID']);
			}
		}
	}

?>