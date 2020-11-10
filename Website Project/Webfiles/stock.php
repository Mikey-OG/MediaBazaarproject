<?php
    require_once ('NavigationBar.php');
?>
<head>
    <meta name ="viewport" content="width=device-width, initial-scale=1.0">
    <link href="../Css/stockstyle.css" type="text/css" rel="stylesheet">
</head>

<body>

    <div class="topnav">
        <div class="search-container">
            <form method="post" action="stock.php">
            <input type="text" placeholder="Search Name.." name="search">
            <button type="submit" value="click" name="submit">Search</button>
            <div>
              <button type="submit" value="clk" name="sblowstock">Show low stock</button>
           </div>
            </form>
        </div>
       
    </div>
    <?php
              function Search()
              {
                  echo "<table style='border: solid 1px black;'>";
                  echo "<tr><th>ProductID</th><th>Name</th><th>Price</th><th>Quantity</th><th>StockDate</th><th>Category</th></tr>";
                  $Search = $_POST["search"];
                  $Connection = new Connection();
                  $Connection->Connect("SELECT ProductID,Name,Price,Quantity,StockDate,Category FROM stockinventory WHERE Name LIKE '%$Search%'");
              }
              if(isset($_POST['submit']))
              {
                  Search();
              }

  ?>
   
</body>

<?php
class TableRows extends RecursiveIteratorIterator {
  function __construct($it) {
    parent::__construct($it, self::LEAVES_ONLY);
  }

  function current() {
    return "<td style='width:150px;border:1px solid black;'>" . parent::current(). "</td>";
  }

  function beginChildren() {
    echo "<tr>";
  }

  function endChildren() {
    echo "</tr>" . "\n";
  }
}
class Connection{
    public function Connect($string){
        $servername = "studmysql01.fhict.local";
        $username = "dbi435115";
        $password = "group3";
        $dbname = "dbi435115";
        try {
            $conn = new PDO("mysql:host=$servername;dbname=$dbname", $username, $password);
            $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
            $stmt = $conn->prepare($string);
            $stmt->execute();
  
            $result = $stmt->setFetchMode(PDO::FETCH_ASSOC);
            foreach(new TableRows(new RecursiveArrayIterator($stmt->fetchAll())) as $k=>$v) {
                echo $v;
            }
            } catch(PDOException $e) {
            echo "Error: " . $e->getMessage();
            }
            $conn = null;
            echo "</table>";
    }
}
?>