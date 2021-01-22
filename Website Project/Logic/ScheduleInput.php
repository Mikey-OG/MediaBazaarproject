<?php
	require ("../DataBase/GetSchedules.php");

	class ScheduleInput {

		public function Date (int $countDay, string $date) : string {
			$neededDay = date("d-m-Y", strtotime($date . $countDay . "days"));
			return $neededDay;
		}

		public function SetCurrentDate() {
			$date = date("d-m-Y", strtotime("monday this week"));
			$_SESSION['Date'] = $date;
		}

		public function ShiftEmployees (int $countDay, string $TimeShift) : string {
			$GetSchedules = new ScheduleInfo();
			return $GetSchedules->getSchedule($this->Date($countDay, $_SESSION['Date']), $TimeShift);
		}

		public function ShiftEmployee (int $countDay, string $TimeShift, int $UserID) : string {
			$GetSchedules = new ScheduleInfo();
			return $GetSchedules->getScheduleSpecific($this->Date($countDay, $_SESSION['Date']), $TimeShift, $UserID);
		}
	}

?>