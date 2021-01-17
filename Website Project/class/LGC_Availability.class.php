<?php
	require_once("DAL_SetAvailability.class.php");

	session_start();
	$la = new LGC_Availability();

	$la->SetAvailabilityMorning();
	$la->SetAvailabilityAfternoon();
	$la->SetAvailabilityEvening();
	echo "<script> location.href='../AvailabilityPage.php'</script>";

 	class LGC_Availability {

 		public function ChangeToDateFormat(string $date) : string {
 			$year = substr($date, 0, 4);
 			$day = substr($date, 8, 2);
 			$month = substr($date, 5, 2);

 			return $day."-".$month."-".$year;
 		}

		public function SetAvailabilityMorning() {
			$dsa = new DAL_SetAvailability();
			if ($_POST['morning'] == "Available") {
				$dsa->SetAvailabilityMorningAvailable(ChangeToDateFormat($_POST['date']), $_SESSION['UserID']);
			}
			elseif ($_POST['morning'] == "Unavailable") {
				$dsa->SetAvailabilityMorning(ChangeToDateFormat($_POST['date']), $_SESSION['UserID']);
			}
		}

		public function SetAvailabilityAfternoon() {
			$dsa = new DAL_SetAvailability();
			if ($_POST['afternoon'] == "Available") {
				$dsa->SetAvailabilityAfternoonAvailable(ChangeToDateFormat($_POST['date']), $_SESSION['UserID']);
			}
			elseif ($_POST['afternoon'] == "Unavailable") {
				$dsa->SetAvailabilityAfternoon(ChangeToDateFormat($_POST['date']), $_SESSION['UserID']);
			}
		}

		public function SetAvailabilityEvening() {
			$dsa = new DAL_SetAvailability();
			if ($_POST['evening'] == "Available") {
				$dsa->SetAvailabilityEveningAvailable(ChangeToDateFormat($_POST['date']), $_SESSION['UserID']);
			}
			elseif ($_POST['evening'] == "Unavailable") {
				$dsa->SetAvailabilityEvening(ChangeToDateFormat($_POST['date']), $_SESSION['UserID']);
			}
		}
	}

?>
