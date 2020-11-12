<?php
require_once('../DataBase/Connection.php');
class StockModel
{
	private Connection  $conn;

	public function __construct()
	{
		$this->conn = new Connection();
	}

	public function ShowStock()
	{
		$sql = "SELECT ProductID,Name,Price,Quantity,MinimumQuantity,Category FROM stockinventory";
		$stmt = $this->conn->connect()->query($sql);
		if($stmt)
		{
			echo'
					<table cellpadding = "5" cellspacing = "5" align= "center"
					<tr>
						<td>ID</td>
						<td>Item Name</td>
						<td>Price</td>
						<td>Quantity</td>
						<td>Minimum Quantity</td>
						<td>Category</td>
					</tr>
				'
			;

			while ($row = $stmt->fetch(PDO::FETCH_OBJ)) 
			{
				echo'
						<tr>
							<th>'.$row->ProductID.'</th>
							<th>'.$row->Name.'</th>
							<th>'.$row->Price.'</th>
							<th>'.$row->Quantity.'</th>
							<th>'.$row->MinimumQuantity.'</th>
							<th>'.$row->Category.'</th>
						</tr>
					'
				;
			}
			echo '</table>';	
        }
    }
    public function SearchStock($Search,$String)
	{
		$sql = "SELECT ProductID,Name,Price,Quantity,MinimumQuantity,Category FROM stockinventory WHERE $String LIKE '%$Search%'";
		$stmt = $this->conn->connect()->query($sql);
		if($stmt)
		{
			echo'
					<table cellpadding = "5" cellspacing = "5" align= "center"
					<tr>
						<td>ID</td>
						<td>Item Name</td>
						<td>Price</td>
						<td>Quantity</td>
						<td>Minimum Quantity</td>
						<td>Category</td>
					</tr>
				'
			;

			while ($row = $stmt->fetch(PDO::FETCH_OBJ)) 
			{
				echo'
						<tr>
							<th>'.$row->ProductID.'</th>
							<th>'.$row->Name.'</th>
							<th>'.$row->Price.'</th>
							<th>'.$row->Quantity.'</th>
							<th>'.$row->MinimumQuantity.'</th>
							<th>'.$row->Category.'</th>
						</tr>
					'
				;
			}
			echo '</table>';	
		}
	}
	public function ShowLowStock()
	{
		$sql = "SELECT ProductID,Name,Price,Quantity,MinimumQuantity,Category FROM stockinventory WHERE Quantity <= MinimumQuantity OR Quantity IS NULL";
		$stmt = $this->conn->connect()->query($sql);
		if($stmt)
		{
			echo'
					<table cellpadding = "5" cellspacing = "5" align= "center"
					<tr>
						<td>ID</td>
						<td>Item Name</td>
						<td>Price</td>
						<td>Quantity</td>
						<td>Minimum Quantity</td>
						<td>Category</td>
					</tr>
				'
			;

			while ($row = $stmt->fetch(PDO::FETCH_OBJ)) 
			{
				echo'
						<tr>
							<th>'.$row->ProductID.'</th>
							<th>'.$row->Name.'</th>
							<th>'.$row->Price.'</th>
							<th>'.$row->Quantity.'</th>
							<th>'.$row->MinimumQuantity.'</th>
							<th>'.$row->Category.'</th>
						</tr>
					'
				;
			}
			echo '</table>';	
		}
	}
	public function SearchForCategory()
	{
		$sql = "SELECT DISTINCT Category FROM stockinventory";
		$stmt = $this->conn->connect()->query($sql);
		$all = $stmt->fetchAll();
		?>
		<select  data-rel="chosen"  name="categories">
				<?php foreach($all as $nt) { echo "<option value =$nt[Category]>$nt[Category]</option>";}?>
		</select>
		<?php
	}
}
?>