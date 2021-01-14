<!DOCTYPE html>
<html>
<head>
	<link href="https://www.cssscript.com/wp-includes/css/sticky.css" rel="stylesheet" type="text/css">
	<link rel="stylesheet" href="../Css/Availibilty.css">
	<title>Availibility</title>
</head>
<body>
	<?php include ('NavigationBar.php');?>
	<div class="container">
		<div class="title">
			Availability
		</div>
		<div class="content-right">
			<form action="../Logic/Availability.php" method="post">
				<div class="inner-title">
					<input type="date" name="date" class="input">
					<input type="submit" id="variable" value="Submit Availibilty" class="button2">
				</div>
				<div class="item">
					Morning
					<select class="category" name="morning">
						<option value="Available">Available</option>
						<option value="Unavailable">Unavailable</option>
					</select>
				</div>
				<div class="item">
					Afternoon
					<select class="category" name="afternoon">
						<option value="Available">Available</option>
						<option value="Unavailable">Unavailable</option>
					</select>
				</div>
				<div class="item">
				Evening
				<select class="category" name="evening">
					<option value="Available">Available</option>
					<option value="Unavailable">Unavailable</option>
				</select>
				</div>
			</form>
		</div>
		<div class='card'>
			<form action="../Logic/AvailabilityWeek.php" method="post">
				<div class='card-date'>
					Weekly set 
				</div>
				<div class="actionBar">
					<div class='text'>From Week:</div>
					<select class="category" name="date2">
						<option value="18-01-2021">3</option>
						<option value="25-01-2021">4</option>
						<option value="01-02-2021">5</option>
					</select>
					<div class='text'>Until Week:</div>
					<select class="category" name="until">
						<option value="18-01-2021">3</option>
						<option value="25-01-2021">4</option>
						<option value="01-02-2021">5</option>
						<option value="08-02-2021">6</option>
					</select>
					<input type="submit" value="Submit weekly set" class="button">
				</div>
				<div class='card-schedule'>
					<div class='card-schedule-column'>
						<div class='card-schedule-column-title'>
							Monday
						</div>
						<div class='card-schedule-column-content'>
							<select class="category" name="monday">
								<option value="Available">Available</option>
								<option value="Unavailable">Unavailable</option>
							</select>
						</div>
					</div>
					<div class='card-schedule-column'>
						<div class='card-schedule-column-title'>
							Tuesday
						</div>
						<div class='card-schedule-column-content'>
							<select class="category" name="tuesday">
								<option value="Available">Available</option>
								<option value="Unavailable">Unavailable</option>
							</select>
						</div>
					</div>
					<div class='card-schedule-column'>
						<div class='card-schedule-column-title'>
							Wednesday
						</div>
						<div class='card-schedule-column-content'>
							<select class="category" name="wednesday">
								<option value="Available">Available</option>
								<option value="Unavailable">Unavailable</option>
							</select>
						</div>
					</div>
					<div class='card-schedule-column'>
						<div class='card-schedule-column-title'>
							Thursday
						</div>
						<div class='card-schedule-column-content'>
							<select class="category" name="thursday">
								<option value="Available">Available</option>
								<option value="Unavailable">Unavailable</option>
							</select>
						</div>
					</div>	
					<div class='card-schedule-column'>
						<div class='card-schedule-column-title'>
							Friday
						</div>
						<div class='card-schedule-column-content'>
							<select class="category" name="friday">
								<option value="Available">Available</option>
								<option value="Unavailable">Unavailable</option>
							</select>
						</div>
					</div>	
					<div class='card-schedule-column'>
						<div class='card-schedule-column-title'>
							Saturday
						</div>
						<div class='card-schedule-column-content'>
							<select class="category" name="saturday">
								<option value="Available">Available</option>
								<option value="Unavailable">Unavailable</option>
							</select>
						</div>
					</div>	
					<div class='card-schedule-column'>
						<div class='card-schedule-column-title'>
							Sunday
						</div>
						<div class='card-schedule-column-content'>
							<select class="category" name="sunday">
								<option value="Available">Available</option>
								<option value="Unavailable">Unavailable</option>
							</select>
						</div>
					</div>		
				</div>
			</form>
		</div>
	</div>

	<script src="../JS/date-picker.js"></script>
</body>
</html>