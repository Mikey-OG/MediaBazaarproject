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

	public function ShowEmployeesInfoToAdminBySearch($firstname): void
	{
		$this->usermodel->ShowUserSelectedUserInfo($firstname);
	}
}