<?php
require_once('../classes/userview.class.php');
require_once ('NavigationBar.php');
?>
<main>
	<link rel="stylesheet" href="../Css/chartspagestyle.css">
	<script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
	<h1>WELCOME TO MEDIA BAAZAR STATS OVERVIEW</h1>
<script type="text/javascript">
      google.charts.load("current", {packages:["imagepiechart"]});
      google.charts.setOnLoadCallback(drawChart);
      function drawChart() 
      {
        var data = google.visualization.arrayToDataTable([
        ['Task', 'Hours per Day'], 
        <?php      
        
			$usv = new Userview();
			$usv->ShowUserEmployeesPerRole();
        ?>
        ]);
        var chart = new google.visualization.ImagePieChart(document.getElementById('EmployeeRole_div'));
        chart.draw(data, {width: 430, height: 240, title: 'Amount Of Employees Per Role'});
      }
</script>

<script type="text/javascript">
      google.charts.load("current", {packages:["imagepiechart"]});
      google.charts.setOnLoadCallback(drawChart);
      function drawChart() 
      {
        var data = google.visualization.arrayToDataTable([
        ['Task', 'Hours per Day'], 
        <?php      
			$usv = new Userview();
			$usv->ShowUserEmployeesPerDepartment();
        ?>
        ]);
        var chart = new google.visualization.ImagePieChart(document.getElementById('EmployeeDepartment_div'));
        chart.draw(data, {width: 430, height: 240, title: 'Amount Of Employees Per Department'});
      }
</script>

<script type="text/javascript">
      google.charts.load("current", {packages:["imagepiechart"]});
      google.charts.setOnLoadCallback(drawChart);
      function drawChart() 
      {
        var data = google.visualization.arrayToDataTable([
        ['Task', 'Hours per Day'], 
        <?php      
			$usv = new Userview();
			$usv->ShowUserProductsPerCategory();
        ?>
        ]);
        var chart = new google.visualization.ImagePieChart(document.getElementById('ProductsCategory_div'));
        chart.draw(data, {width: 430, height: 240, title: 'Amount Of Products Per Category'});
      }
</script>

<script type="text/javascript">
      google.charts.load("current", {packages:["imagepiechart"]});
      google.charts.setOnLoadCallback(drawChart);
      function drawChart() 
      {
        var data = google.visualization.arrayToDataTable([
        ['Task', 'Hours per Day'], 
        <?php      
			$usv = new Userview();
			$usv->ShowUserEmployeesPerCity();
        ?>
        ]);
        var chart = new google.visualization.ImagePieChart(document.getElementById('EmployeeCity_div'));
        chart.draw(data, {width: 430, height: 240, title: 'Number of Employees Per City'});
      }
</script>

<div class = "charts">
<div class = "EmployeeRole" id="EmployeeRole_div" style="width: 400px; height: 240px;"></div>
<div class = "EmployeeDepartment" id="EmployeeDepartment_div" style="width: 400px; height: 240px;"></div>
<div class = "ProductsCategory" id="ProductsCategory_div" style="width: 400px; height: 240px;"></div>
<div class = "EmployeeCity" id="EmployeeCity_div" style="width: 400px; height: 240px;"></div>
</div>
</main>