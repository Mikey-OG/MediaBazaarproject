<?php
	require ("../DataBase/GetSchedules.php");

	class ScheduleInput {

		public function Date (int $countDay) : string {
			$firstDay = date("d-m-Y", strtotime("monday this week"));
			$neededDay = date("d-m-Y", strtotime($firstDay . $countDay . "days"));
			return $neededDay;
		}

		public function ShiftEmployees (int $countDay, string $TimeShift) : string {
			$GetSchedules = new ScheduleInfo();
			return $GetSchedules->getSchedule($this->Date($countDay), $TimeShift);
		}

		public function ShiftEmployee (int $countDay, string $TimeShift, int $UserID) : string {
			$GetSchedules = new ScheduleInfo();
			return $GetSchedules->getScheduleSpecific($this->Date($countDay), $TimeShift, $UserID);
		}
	}

?> 