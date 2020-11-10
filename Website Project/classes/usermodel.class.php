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

	public function ShowAllEmployees()
	{
		$sql = "SELECT UserName, Email, FirstName, LastName, Nationality, Salary, DepartmentName, RoleName FROM employees";
		$stmt = $this->conn->connect()->query($sql);
		if($stmt)
		{
			echo'
					<table cellpadding = "5" cellspacing = "5" align= "center"
					<tr>
						<td>Username</td>
						<td>Email</td>
						<td>Firstname</td>
						<td>Lastname</td>
						<td>Nationality</td>
						<td>Salary</td>
						<td>Department</td>
						<td>Role</td>
					</tr>
				'
			;

			while ($row = $stmt->fetch(PDO::FETCH_OBJ)) 
			{
				echo'
						<tr>
							<th>'.$row->UserName.'</th>
							<th>'.$row->Email.'</th>
							<th>'.$row->FirstName.'</th>
							<th>'.$row->LastName.'</th>
							<th>'.$row->Nationality.'</th>
							<th>'.$row->Salary.'</th>
							<th>'.$row->DepartmentName.'</th>
							<th>'.$row->RoleName.'</th>
						</tr>
					'
				;
			}
			echo '</table>';	
		}
	}

	public function ShowUserSelectedUserInfo($firstname)
	{
		$sql = "SELECT UserName, Email, FirstName, LastName, Nationality, Salary, DepartmentName, RoleName FROM employees WHERE FirstName LIKE :firstname";
		$stmt = $this->conn->connect()->prepare($sql);
		$stmt->bindParam('firstname', $firstname);
		$stmt->execute();
		if($stmt)
		{
			echo'
					<table cellpadding = "7" cellspacing = "10" align= "center"
					<tr>
						<td>Username</td>
						<td>Email</td>
						<td>Firstname</td>
						<td>Lastname</td>
						<td>Nationality</td>
						<td>Salary</td>
						<td>Department</td>
						<td>Role</td>
					</tr>
				'
			;

			while ($row = $stmt->fetch(PDO::FETCH_OBJ)) 
			{
				echo'
						<tr>
							<th>'.$row->UserName.'</th>
							<th>'.$row->Email.'</th>
							<th>'.$row->FirstName.'</th>
							<th>'.$row->LastName.'</th>
							<th>'.$row->Nationality.'</th>
							<th>'.$row->Salary.'</th>
							<th>'.$row->DepartmentName.'</th>
							<th>'.$row->RoleName.'</th>
						</tr>
					'
				;
			}
			echo '</table>';	
		}

	}
}