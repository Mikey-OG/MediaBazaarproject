<!DOCTYPE html>
<html>
<head>
	<link rel="stylesheet" href="../Css/ScheduleViewPageStylesheet.css">
	<title>Schedule View</title>
</head>
<body>
	<?php include ('NavigationBar.php'); ?>
	<div class="cards">
		<?php
		require ('../Logic/ScheduleInput.php');
		$ScheduleInput = new ScheduleInput();
		if ($_SESSION['FormAccess'] == "StockManagerForm" || $_SESSION['FormAccess'] == "EmployeeForm" || $_SESSION['FormAccess'] == "AdminForm") {
		$countDay = 0;
		while ($countDay < 7) {
			echo "
			<div class='card'>
				<div class='card-date'>
					". $ScheduleInput->Date($countDay) ."
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
					". $ScheduleInput->Date($countDay) ."
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