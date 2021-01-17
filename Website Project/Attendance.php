<?php
require_once ('NavigationBar.php');
?>
<main>
    <link rel="stylesheet" href="Css/adminpagestyling.css">
</main>
<?php
if(empty($_GET["Key"]))
{
    header('Location: ScheduleViewPage.php');
}
else{
    require_once('classes/encryption.php');
    $cry = new Encryption();
    $OnlineKey = ($_GET["Key"]);
    $Date = date("d-m-Y");
    $Key = $cry->Encrypt($Date.$_SESSION['userName']);
    $Key = str_replace( array( '+'), ' ', $Key);
    if ($OnlineKey == $Key)
    {
        $conn = mysqli_connect('studmysql01.fhict.local','dbi435115','group3');
        mysqli_select_db($conn,'dbi435115');
        $ID = $_SESSION['UserID'];
        $Attended = true;
        $CurrentDate = date("d-m-Y");
        $sql_run = mysqli_query($conn,"UPDATE `schedules` SET `Attended`='$Attended' WHERE UserID='$ID' AND WorkDate='$CurrentDate'");
        if($sql_run)
        {
            echo '<script>alert("You have been marked present")</script>';
        }
        else
        {
            echo '<script type="text/javascript"> alert("Something went wrong, details could not be updated")</script>';
        }
    }
    else
    {
        echo "The QR Code is incorrect";
    }
}
?>