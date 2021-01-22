<?php 

	require_once ('Connection.php');

    class ScheduleInfo {

        public function getSchedule(string $date, string $TimeShift): string {

            $Connection = new Connection();
            $result = "";

            $sql2 = "SELECT e.FirstName, e.LastName, e.DepartmentName FROM schedules s INNER JOIN employees e ON s.UserID = e.UserID WHERE s.WorkDate = ? AND s.TimeShift = ? AND e.RoleName = 'ShopPersonnel'";

            $sql = "SELECT employee.FirstName, employee.LastName, departments.DepartmentName FROM schedules INNER JOIN employee ON schedules.UserID = employee.UserID INNER JOIN departments ON employee.DepartmentID = departments.DepartmentID INNER JOIN roles ON employee.RoleID = roles.RoleID WHERE schedules.WorkDate = ? AND schedules.TimeShift = ? AND roles.RoleName = 'ShopPersonnel'";
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
            
            $sql2 = "SELECT e.FirstName, e.LastName, e.DepartmentName FROM schedules s INNER JOIN employees e ON s.UserID = e.UserID WHERE s.WorkDate = ? AND s.TimeShift = ? AND s.UserID = ?";

            $sql = "SELECT employee.FirstName, employee.LastName, departments.DepartmentName FROM schedules INNER JOIN employee ON schedules.UserID = employee.UserID INNER JOIN departments ON employee.DepartmentID = departments.DepartmentID WHERE schedules.WorkDate = ? AND schedules.TimeShift = ? AND schedules.UserID = ?";

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