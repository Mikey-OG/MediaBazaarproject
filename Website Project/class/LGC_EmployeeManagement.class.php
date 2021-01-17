<?php
require_once("DAL_EmployeeManagement.class.php");
class LGC_EmployeeManagement
{
	public function ShowUsersByUsingPreparedStatements($username): void
	{
		$dem = new DAL_EmployeeManagement();
		$dem->ShowUserInformationUsingPreparedStatements($username);
	}

	public function ShowAllEmployeesInfoToAdmin(): void
	{
		$dem = new DAL_EmployeeManagement();	
		$dem->ShowAllEmployees();
	}

	public function ShowEmployeesInfoToAdminBySearch($Search,$String): void
	{
		$dem = new DAL_EmployeeManagement();
		$dem->ShowUserSelectedUserInfo($Search,$String);
	}

	public function ShowUserEmployeesPerRole(): void
	{
		$dem = new DAL_EmployeeManagement();
		$dem->ShowEmployeesPerRole();
	}

	public function ShowUserEmployeesPerDepartment(): void
	{
		$dem = new DAL_EmployeeManagement();
		$dem->ShowEmployeesPerDepartment();
	}

	public function ShowUserProductsPerCategory(): void
	{
		$dem = new DAL_EmployeeManagement();
		$dem->ShowProductsPerCategory();
	}

	public function ShowUserEmployeesPerCity(): void
	{
		$dem = new DAL_EmployeeManagement();
		$dem ->ShowEmployeesPerCity();
	}
}