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
			echo "<div class='name'>ID</div><div class='item'> " . htmlentities($row['UserID']) . "</div><div class='name'>Username</div><div class='item'>" . htmlentities($row['UserName']) . "</div><div class='name'>Email</div><div class='item'>" .  htmlentities($row['Email']) .  "</div><div class='name'>First name</div><div class='item'>" . htmlentities($row['FirstName']) . "</div><div class='name'>Last name</div><div class='item'>" . htmlentities($row['LastName']) . "</div><div class='name'>Date of birth</div><div class='item'>" . htmlentities($row['DateOfBirth']) . "</div><div class='name'>Phonenumber</div><div class='item'>" . htmlentities($row['PhoneNumber']) . "</div><div class='name'>Nationality</div><div class='item'>" . htmlentities($row['Nationality']) . "</div><div class='name'>City</div><div class='item'>" . htmlentities($row['City']) . "</div><div class='name'>Zip code</div><div class='item'>" . htmlentities($row['ZipCode']) . "</div><div class='name'>Address</div><div class='item'>" . htmlentities($row['Adress']) . "</div>";
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

	public function ShowEmployeesPerRole()
	{
		$sql = "SELECT COUNT(UserName) AS EmployeePerRole, RoleName FROM employees GROUP BY RoleName";
		$stmt = $this->conn->connect()->query($sql);
        while ($row = $stmt->fetch(PDO::FETCH_ASSOC)) 
        {
            echo "['".$row['RoleName']."',".$row['EmployeePerRole']."],";
        }
	}

	public function ShowEmployeesPerDepartment()
	{
		$sql = "SELECT COUNT(UserName) AS EmployeePerDepartment, DepartmentName FROM employees GROUP BY DepartmentName";
		$stmt = $this->conn->connect()->query($sql);
        while ($row = $stmt->fetch(PDO::FETCH_ASSOC)) 
        {
           	echo "['".$row['DepartmentName']."',".$row['EmployeePerDepartment']."],";
        }
	}

	public function ShowProductsPerCategory()
	{
		$sql = "SELECT COUNT(Name) AS ProductsPerCategory, Category FROM stockinventory GROUP BY Category";
		$stmt = $this->conn->connect()->query($sql);
        while ($row = $stmt->fetch(PDO::FETCH_ASSOC)) 
        {
           	echo "['".$row['Category']."',".$row['ProductsPerCategory']."],";
        }
	}

	public function ShowEmployeesPerCity()
	{
		$sql = "SELECT COUNT(UserName) AS EmployeePerCity, City FROM employees GROUP BY City";
		$stmt = $this->conn->connect()->query($sql);
        while ($row = $stmt->fetch(PDO::FETCH_ASSOC)) 
        {
           	echo "['".$row['City']."',".$row['EmployeePerCity']."],";
        }
	}
}