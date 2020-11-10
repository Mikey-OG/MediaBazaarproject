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

}