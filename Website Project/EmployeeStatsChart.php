<?php
require_once ("class/LGC_EmployeeManagement.class.php");
require_once ('NavigationBar.php');
?>
<main>
  <link rel="stylesheet" href="Css/companystatsstyle.css">
  <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
  <h1>WELCOME TO MEDIA BAAZAR STATS OVERVIEW</h1>
<script type="text/javascript">
      google.charts.load('current', {'packages':['corechart']});
      google.charts.setOnLoadCallback(drawChart);
      function drawChart() 
      {
        var data = google.visualization.arrayToDataTable([
        ['Task', 'Hours per Day'], 
        <?php      
        
         $lem = new LGC_EmployeeManagement();
         $lem->ShowUserEmployeesPerRole();
        ?>
        ]);
        var chart = new google.visualization.PieChart(document.getElementById('EmployeeRole_div'));
        chart.draw(data, {width: 700, height: 400, title: 'Number Of Employees Per Role'});
      }
</script>

<script type="text/javascript">
      google.charts.load('current', {'packages':['corechart']});
      google.charts.setOnLoadCallback(drawChart);
      function drawChart() 
      {
        var data = google.visualization.arrayToDataTable([
        ['Task', 'Hours per Day'], 
        <?php      
      $lem = new LGC_EmployeeManagement();
      $lem->ShowUserEmployeesPerDepartment();
        ?>
        ]);
        var chart = new google.visualization.PieChart(document.getElementById('EmployeeDepartment_div'));
        chart.draw(data, {width: 700, height: 400, title: 'Number Of Employees Per Department'});
      }
</script>

<script type="text/javascript">
      google.charts.load('current', {'packages':['corechart']});
      google.charts.setOnLoadCallback(drawChart);
      function drawChart() 
      {
        var data = google.visualization.arrayToDataTable([
        ['Task', 'Hours per Day'], 
        <?php      
      $lem = new LGC_EmployeeManagement();
      $lem->ShowUserProductsPerCategory();
        ?>
        ]);
        var chart = new google.visualization.PieChart(document.getElementById('ProductsCategory_div'));
        chart.draw(data, {width: 700, height: 400, title: 'Number of Products Per Category'});
      }
</script>

<script type="text/javascript">
      google.charts.load('current', {'packages':['corechart']});
      google.charts.setOnLoadCallback(drawChart);
      function drawChart() 
      {
        var data = google.visualization.arrayToDataTable([
        ['Task', 'Hours per Day'], 
        <?php      
      $lem = new LGC_EmployeeManagement();
      $lem->ShowUserEmployeesPerCity();
        ?>
        ]);
        var chart = new google.visualization.PieChart(document.getElementById('EmployeeCity_div'));
        chart.draw(data, {width: 700, height: 400, title: 'Number of Employees Per City'});
      }
</script>

<div class = "charts">
<div class = "EmployeeRole" id="EmployeeRole_div" style="width: 500px; height: 600px;"></div>
<div class = "EmployeeDepartment" id="EmployeeDepartment_div" style="width: 400px; height: 240px;"></div>
<div class = "ProductsCategory" id="ProductsCategory_div" style="width: 400px; height: 240px;"></div>
<div class = "EmployeeCity" id="EmployeeCity_div" style="width: 600px; height: 600px;"></div>
</div>
</main>