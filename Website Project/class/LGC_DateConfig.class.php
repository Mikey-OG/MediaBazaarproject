<?php

	class LGC_DateConfig {

		public function Date (int $countDay, string $date) : string {
			$neededDay = date("d-m-Y", strtotime($date . $countDay . "days"));
			return $neededDay;
		}

		public function SetCurrentDate() {
			$date = date("d-m-Y", strtotime("monday this week"));
			$_SESSION['Date'] = $date;
		}
	}

?>