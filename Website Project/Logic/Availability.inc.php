<?php
	include 'autoloader.inc.php';

	session_start();
	$Availability = new Availability();

	$Availability->SetAvailabilityMorning();
	$Availability->SetAvailabilityAfternoon();
	$Availability->SetAvailabilityEvening();
	echo "<script> location.href='../AvailabilityPage.php'</script>";

 	class Availability {

 		public function ChangeToDateFormat(string $date) : string {
 			$year = substr($date, 0, 4);
 			$day = substr($date, 8, 2);
 			$month = substr($date, 5, 2);

 			return $day."-".$month."-".$year;
 		}

		public function SetAvailabilityMorning() {
			$lsa = new LGC_SetAvailability();
			if ($_POST['morning'] == "Available") {
				$lsa->UserSetAvailabilityMorningAvailable($this->ChangeToDateFormat($_POST['date']), $_SESSION['UserID']);
			}
			elseif ($_POST['morning'] == "Unavailable") {
				$lsa->UserSetAvailabilityMorning($this->ChangeToDateFormat($_POST['date']), $_SESSION['UserID']);
			}
		}

		public function SetAvailabilityAfternoon() {
			$lsa = new LGC_SetAvailability();
			if ($_POST['afternoon'] == "Available") {
				$lsa->UserSetAvailabilityAfternoonAvailable($this->ChangeToDateFormat($_POST['date']), $_SESSION['UserID']);
			}
			elseif ($_POST['afternoon'] == "Unavailable") {
				$lsa->UserSetAvailabilityAfternoon($this->ChangeToDateFormat($_POST['date']), $_SESSION['UserID']);
			}
		}

		public function SetAvailabilityEvening() {
			$lsa = new LGC_SetAvailability();
			if ($_POST['evening'] == "Available") {
				$lsa->UserSetAvailabilityEveningAvailable($this->ChangeToDateFormat($_POST['date']), $_SESSION['UserID']);
			}
			elseif ($_POST['evening'] == "Unavailable") {
				$lsa->UserSetAvailabilityEvening($this->ChangeToDateFormat($_POST['date']), $_SESSION['UserID']);
			}
		}
	}

?>
