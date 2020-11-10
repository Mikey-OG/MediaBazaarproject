<?php
//this class takes care of the connection to the databse 
//and user input
require_once('../DataBase/Connection.php');
class UserModel
{
	private Connection  $conn;

	//intialize database connection 
	public function __construct()
	{
		$this->conn = new Connection();
	}

	public function ShowUserInformationUsingPreparedStatements($username)
	{
		$sql = "SELECT * FROM employees WHERE UserName = :username";
		$stmt = $this->conn->connect()->prepare($sql);
		$stmt->execute(array(':username' => $username));
		while ($row = $stmt->fetch())
		{
			echo "ID: " . htmlentities($row['UserID']) . "<br><br>" . "UserName: " . htmlentities($row['UserName']) . "<br><br>" . "Email: " .  htmlentities($row['Email']) . "<br><br>" . "FirstName: " . htmlentities($row['FirstName']) . "<br><br>" . "LastName: " . htmlentities($row['LastName']) . "<br><br>" . "DOB: " . htmlentities($row['DateOfBirth']) . "<br><br>" . "PhoneNumber: " . htmlentities($row['PhoneNumber']) . "<br><br>" . "Nationality: " . htmlentities($row['Nationality']) . "<br><br>" 
			. "City: " . htmlentities($row['City']) . "<br><br>" . "ZipCode: " . htmlentities($row['ZipCode']) . "<br><br>" . "Address: " . htmlentities($row['Adress']) . "<br>";
		}
	}
}