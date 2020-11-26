<?php
require_once('usermodel.class.php');
class Userview
{
	private UserModel $usermodel;

	public function __construct()
	{
		$this->usermodel = new UserModel();	
	}

	public function ShowUsersByUsingPreparedStatements($username): void
	{
		$this->usermodel->ShowUserInformationUsingPreparedStatements($username);
	}

	public function ShowAllEmployeesInfoToAdmin(): void
	{
		$this->usermodel->ShowAllEmployees();
	}

	public function ShowEmployeesInfoToAdminBySearch($Search,$String): void
	{
		$this->usermodel->ShowUserSelectedUserInfo($Search,$String);
	}

	public function ShowUserEmployeesPerRole(): void
	{
		$this->usermodel->ShowEmployeesPerRole();
	}

	public function ShowUserEmployeesPerDepartment(): void
	{
		$this->usermodel->ShowEmployeesPerDepartment();
	}

	public function ShowUserProductsPerCategory(): void
	{
		$this->usermodel->ShowProductsPerCategory();
	}

	public function ShowUserEmployeesPerCity(): void
	{
		$this->usermodel->ShowEmployeesPerCity();
	}
}