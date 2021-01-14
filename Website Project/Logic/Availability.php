<?php
	require_once ("../DataBase/SetAvailability.php");

	session_start();
	$Availability = new Availability();

	$Availability->SetAvailabilityMorning();
	$Availability->SetAvailabilityAfternoon();
	$Availability->SetAvailabilityEvening();
	echo "<script> location.href='../Webfiles/AvailabilityPage.php'</script>";

 	class Availability {

 		public function ChangeToDateFormat(string $date) : string {
 			$year = substr($date, 0, 4);
 			$day = substr($date, 8, 2);
 			$month = substr($date, 5, 2);

 			return $day."-".$month."-".$year;
 		}

		public function SetAvailabilityMorning() {
			$SetAvailability = new SetAvailability();
			if ($_POST['morning'] == "Available") {
				$SetAvailability->SetAvailabilityMorningAvailable($this->ChangeToDateFormat($_POST['date']), $_SESSION['UserID']);
			}
			elseif ($_POST['morning'] == "Unavailable") {
				$SetAvailability->SetAvailabilityMorning($this->ChangeToDateFormat($_POST['date']), $_SESSION['UserID']);
			}
		}

		public function SetAvailabilityAfternoon() {
			$SetAvailability = new SetAvailability();
			if ($_POST['afternoon'] == "Available") {
				$SetAvailability->SetAvailabilityAfternoonAvailable($this->ChangeToDateFormat($_POST['date']), $_SESSION['UserID']);
			}
			elseif ($_POST['afternoon'] == "Unavailable") {
				$SetAvailability->SetAvailabilityAfternoon($this->ChangeToDateFormat($_POST['date']), $_SESSION['UserID']);
			}
		}

		public function SetAvailabilityEvening() {
			$SetAvailability = new SetAvailability();
			if ($_POST['evening'] == "Available") {
				$SetAvailability->SetAvailabilityEveningAvailable($this->ChangeToDateFormat($_POST['date']), $_SESSION['UserID']);
			}
			elseif ($_POST['evening'] == "Unavailable") {
				$SetAvailability->SetAvailabilityEvening($this->ChangeToDateFormat($_POST['date']), $_SESSION['UserID']);
			}
		}
	}

?>
