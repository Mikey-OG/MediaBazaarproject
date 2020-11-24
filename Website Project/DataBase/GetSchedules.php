<?php 

	require_once ('Connection.php');

    class ScheduleInfo {

        public function getSchedule(string $date, string $TimeShift): string {

            $Connection = new Connection();
            $result = "";

            $sql = "SELECT e.FirstName, e.LastName, e.DepartmentName FROM schedules s INNER JOIN employees e ON s.UserID = e.UserID WHERE s.WorkDate = ? AND s.TimeShift = ? AND e.RoleName = 'ShopPersonnel'";
            $stmt = $Connection->connect()->prepare($sql);
            $stmt->execute([$date, $TimeShift]);
            while ($row = $stmt->fetch()) {
                $result = $result . $row['FirstName'] . " " . $row['LastName'] . "<b> (" . $row['DepartmentName'] . ")</b><br>";
            }
            if (!empty($result)){
                return $result;
            }
            else{
                return "-";
            }
        }

        public function getScheduleSpecific(string $date, string $TimeShift, int $UserID): string {

            $Connection = new Connection();
            $result = "";

            $sql = "SELECT e.FirstName, e.LastName, e.DepartmentName FROM schedules s INNER JOIN employees e ON s.UserID = e.UserID WHERE s.WorkDate = ? AND s.TimeShift = ? AND s.UserID = ?";
            $stmt = $Connection->connect()->prepare($sql);
            $stmt->execute([$date, $TimeShift, $UserID]);
            while ($row = $stmt->fetch()) {
                $result = $result . $row['FirstName'] . " " . $row['LastName'];
            }
            if (!empty($result)){
                return $result;
            }
            else{
                return "-";
            }
        }
    }

?>