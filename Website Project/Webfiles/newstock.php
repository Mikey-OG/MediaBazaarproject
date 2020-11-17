<?php
require_once ('NavigationBar.php');
require_once('../classes/stockmodel.class.php');
$stm = new StockModel();
?>
<main>
<div class ="stockpage">
<link rel="stylesheet" href="../Css/stockstyle.css">
    <div class="topnav">
        <form method="post" action="newstock.php">
            <div class="search-container">
            <select  data-rel="chosen"  name="categories">
                <option>ProductID</option>
                <option>Name</option>
                <option>Price</option>
                <option>Quantity</option>
                <option>MinimumQuantity</option>
                <option>Category</option>
		    </select>
                <input type="text" placeholder="Search For.." name="search">
                <button type="submit" value="click" name="submit">Search</button> 
            </div>
            <div class="search-container">
                <button type="submit" value="click" name="lowstock">Check Low Stock</button>
            </div>
            <div class="search-container">
                <button type="submit" value="click" name="reset">Reset</button>
                <input type="number" placeholder="Set Limit.." name="limitset">
                <button type="submit" value="click" name="limit">Set Limit</button>
             </div>
            </form>
    </div>
<?php
		if(isset($_POST['submit']))
		{
            $String = $_POST["categories"];
			$Search = $_POST["search"];
			$stm->SearchStock($Search,$String);
        }
        else{
            if(isset($_POST['lowstock']))
            {
                $stm->ShowLowStock();
            }	
            else{
                if(isset($_POST['limit']))
                {
                    $increase = $_POST["limitset"];
                    $stm->LimitSearch($increase);
                }
                else{
                    if(isset($_POST['reset']))
                    {
                        $String = $_POST["categories"];
                        $Search = "";
                        $stm->SearchStock($Search,$String);
                    }
                    else{
                        $stm->ShowStock();
                    }
                }
            }
        }
?>
</div>
</main>