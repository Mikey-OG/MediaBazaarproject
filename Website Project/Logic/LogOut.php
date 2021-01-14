<?php
	session_start();
	session_destroy();
	echo "<script> location.href='../Webfiles/index.php'</script>"; 
?>