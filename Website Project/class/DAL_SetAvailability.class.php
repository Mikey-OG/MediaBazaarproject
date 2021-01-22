<?php
	require_once("../DataBase/Connection.php");

	class DAL_SetAvailability {

		public function SetAvailabilityMorning(string $date, int $userID) {

			$Connection = new Connection();

            $sql = "INSERT INTO availability (UserID, Date, Shift, Available) VALUES (?, ?, 'Morning', 'Unavailable')";
            $stmt = $Connection->connect()->prepare($sql);
            $stmt->execute([$userID, $date]);
		}

		public function SetAvailabilityAfternoon(string $date, int $userID) {

			$Connection = new Connection();

            $sql = "INSERT INTO availability (UserID, Date, Shift, Available) VALUES (?, ?, 'Afternoon', 'Unavailable')";
            $stmt = $Connection->connect()->prepare($sql);
            $stmt->execute([$userID, $date]);
		}

		public function SetAvailabilityEvening(string $date, int $userID) {

			$Connection = new Connection();

            $sql = "INSERT INTO availability (UserID, Date, Shift, Available) VALUES (?, ?, 'Evening', 'Unavailable')";
            $stmt = $Connection->connect()->prepare($sql);
            $stmt->execute([$userID, $date]);
		}

		public function SetAvailabilityMorningAvailable(string $date, int $userID) {

			$Connection = new Connection();

            $sql = "DELETE FROM availability WHERE UserID = ? AND Date = ? AND Shift = ?";
            $stmt = $Connection->connect()->prepare($sql);
            $stmt->execute([$userID, $date, "Morning"]);
		}

		public function SetAvailabilityAfternoonAvailable(string $date, int $userID) {

			$Connection = new Connection();

            $sql = "DELETE FROM availability WHERE UserID = ? AND Date = ? AND Shift = ?";
            $stmt = $Connection->connect()->prepare($sql);
            $stmt->execute([$userID, $date, "Afternoon"]);
		}

		public function SetAvailabilityEveningAvailable(string $date, int $userID) {

			$Connection = new Connection();

            $sql = "DELETE FROM availability WHERE UserID = ? AND Date = ? AND Shift = ?";
            $stmt = $Connection->connect()->prepare($sql);
            $stmt->execute([$userID, $date, "Evening"]);
		}
	}

?>