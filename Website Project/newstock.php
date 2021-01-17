<?php
require_once ('NavigationBar.php');
require_once ("class/LGC_StockManagement.class.php");
$lsm = new LGC_StockManagement();
?>
<main>
<div class ="stockpage">
<link rel="stylesheet" href="Css/stockstyle.css">
    <div class="actionBar">
        <form method="post" action="newstock.php">
            <select  data-rel="chosen"  name="categories" class="category">
                <option>ProductID</option>
                <option>Name</option>
                <option>Price</option>
                <option>Quantity</option>
                <option>MinimumQuantity</option>
                <option>Category</option>
            </select>
            <input type="text" placeholder="Search For..." name="search" class="textbox">
            <input type="submit" value="Search" name="submit" class="button">
            <input type="submit" value="Check Low Stock" name="lowstock" class="button">
            <input type="submit" value="Reset" name="reset" class="button">
            <input type="number" placeholder="Set Limit..." name="limitset" class="textboxRight">
            <input type="submit" value="Set Limit" name="limit" class="button">
        </form>
    </div>
<?php
        if(isset($_POST['submit']))
        {
            $String = $_POST["categories"];
            $Search = $_POST["search"];
            $lsm->ShowStockInfoToUserBySearch($Search,$String);
        }
        else{
            if(isset($_POST['lowstock']))
            {
                $lsm->ShowLowStockToUser();
            }   
            else{
                if(isset($_POST['limit']))
                {
                    $increase = $_POST["limitset"];
                    $lsm->UserinputSearchRange($increase);
                }
                else{
                    if(isset($_POST['reset']))
                    {
                        $String = $_POST["categories"];
                        $Search = "";
                        $lsm->ShowStockInfoToUserBySearch($Search,$String);
                    }
                    else{
                        $lsm->ShowUsersStock();
                    }
                }
            }
        }
?>
</div>
</main>