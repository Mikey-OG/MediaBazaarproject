<?php 

	require_once ('Connection.php');

    class UserInfo {

        public function getUserInlog(string $userName, int $i): string {

            $result = array();

            $Connection = new Connection();

            $sql = "SELECT UserName, Password, FormAccess FROM employees WHERE UserName = ?";
            $stmt = $Connection->connect()->prepare($sql);

            $stmt->execute([$userName]);
            $pdoResult = $stmt->fetchAll();
            
        foreach($pdoResult as $record) {
            $result[0] = $record['UserName'];
            $result[1] = $record['Password'];
            $result[2] = $record['FormAccess'];
        }

        if($result == null) {
            $result[0] = "null";
            $result[1] = "null";
            $result[2] = "null";
        }

        return $result[$i];

        }

    }
?>