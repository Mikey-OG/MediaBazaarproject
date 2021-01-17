<?php
	require ("DAL_ScheduleManagement.class.php");

	class LGC_ScheduleManagement {

		public function Date (int $countDay, string $date) : string {
			$neededDay = date("d-m-Y", strtotime($date . $countDay . "days"));
			return $neededDay;
		}

		public function SetCurrentDate() {
			$date = date("d-m-Y", strtotime("monday this week"));
			$_SESSION['Date'] = $date;
		}

		public function ShiftEmployees (int $countDay, string $TimeShift) : string {
			$dsm = new DAL_ScheduleManagement();
			return $dsm->getSchedule($this->Date($countDay, $_SESSION['Date']), $TimeShift);
		}

		public function ShiftEmployee (int $countDay, string $TimeShift, int $UserID) : string {
			$dsm = new DAL_ScheduleManagement();
			return $dsm->getScheduleSpecific($this->Date($countDay, $_SESSION['Date']), $TimeShift, $UserID);
		}
	}

?>