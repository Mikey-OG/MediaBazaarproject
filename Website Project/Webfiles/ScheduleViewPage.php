	<!DOCTYPE html>
<html>
<head>
	<link rel="stylesheet" href="../Css/ScheduleViewPageStylesheet.css">
	<title>Schedule View</title>
</head>
<body>
	<?php include ('NavigationBar.php');?>
	<form class="actionBar" method="post">
		<input type="submit" class= "button" name="dateDecrease" value="<">
		<div class="actionBar-date">
			<?php
				require ('../Logic/ScheduleInput.php');
				$ScheduleInput = new ScheduleInput();
			 	if(isset($_POST['dateDecrease'])) { $_SESSION['Date'] = date("d-m-Y", strtotime($_SESSION['Date'] . ' - 7 days'));}
				if(isset($_POST['dateIncrease'])) { $_SESSION['Date'] = date("d-m-Y", strtotime($_SESSION['Date'] . ' + 7 days'));}
				$date = new DateTime($_SESSION['Date']);
				$week = $date->format("W");
				echo "Week ". $week;
			?>
		</div>
		<input type="submit" class= "button" name="dateIncrease" value=">">
	</form>
	<div class="cards">
		<?php
		if ($_SESSION['FormAccess'] == "StockManagerForm" || $_SESSION['FormAccess'] == "EmployeeForm" || $_SESSION['FormAccess'] == "AdminForm") {
		$countDay = 0;
		while ($countDay < 7) {
			echo "
			<div class='card'>
				<div class='card-date'>
					". $ScheduleInput->Date($countDay, $_SESSION['Date']) ."
				</div>
				<div class='card-schedule'>
					<div class='card-schedule-column'>
						<div class='card-schedule-column-title'>
							Morning
						</div>
						<div class='card-schedule-column-content'>
							". $ScheduleInput->ShiftEmployees($countDay, "Morning", $_SESSION['UserID']) ."
						</div>
					</div>
					<div class='card-schedule-column'>
						<div class='card-schedule-column-title'>
							Afternoon
						</div>
						<div class='card-schedule-column-content'>
							". $ScheduleInput->ShiftEmployees($countDay, "Afternoon", $_SESSION['UserID']) ."
						</div>
					</div>
					<div class='card-schedule-column'>
						<div class='card-schedule-column-title'>
							Evening
						</div>
						<div class='card-schedule-column-content'>
							". $ScheduleInput->ShiftEmployees($countDay, "Evening", $_SESSION['UserID']) ."
						</div>
					</div>	
				</div>
			</div>";
		$countDay = $countDay + 1; 
		} }
		else {
		$countDay = 0;
		while ($countDay < 7) {
			echo "
			<div class='card'>
				<div class='card-date'>
					". $ScheduleInput->Date($countDay, $_SESSION['Date']) ."
				</div>
				<div class='card-schedule'>
					<div class='card-schedule-column'>
						<div class='card-schedule-column-title'>
							Morning
						</div>
						<div class='card-schedule-column-content'>
							". $ScheduleInput->ShiftEmployee($countDay, "Morning", $_SESSION['UserID']) ."
						</div>
					</div>
					<div class='card-schedule-column'>
						<div class='card-schedule-column-title'>
							Afternoon
						</div>
						<div class='card-schedule-column-content'>
							". $ScheduleInput->ShiftEmployee($countDay, "Afternoon", $_SESSION['UserID']) ."
						</div>
					</div>
					<div class='card-schedule-column'>
						<div class='card-schedule-column-title'>
							Evening
						</div>
						<div class='card-schedule-column-content'>
							". $ScheduleInput->ShiftEmployee($countDay, "Evening", $_SESSION['UserID']) ."
						</div>
					</div>	
				</div>
			</div>";
		$countDay = $countDay + 1; 
		}
		}
		?>
	</div>
</body>
</html>