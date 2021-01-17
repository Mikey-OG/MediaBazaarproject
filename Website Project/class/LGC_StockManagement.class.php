<?php
require_once("DAL_StockManagement.class.php");
class LGC_StockManagement
{
	public function ShowUsersStock(): void
	{
		$dsm = new DAL_StockManagement();
		$dsm->ShowStock();
	}

	public function ShowStockInfoToUserBySearch($Search,$String): void
	{
		$dsm = new DAL_StockManagement();
		$dsm->SearchStock($Search,$String);
	}

	public function ShowLowStockToUser(): void
	{
		$dsm = new DAL_StockManagement();
		$dsm->ShowLowStock();
	}

	public function UserinputSearchRange($increase): void
	{
		$dsm = new DAL_StockManagement();
		$dsm->LimitSearch($increase);
	}

	public function UserSetCategory(): void
	{
		$dsm = new DAL_StockManagement();
		$dsm->SetCategory();
	}
}