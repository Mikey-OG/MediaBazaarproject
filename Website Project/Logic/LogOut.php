<?php
	session_start();
	session_destroy();
	echo "<script> location.href='../Webfiles/LoginPage.php'</script>"; 
?>