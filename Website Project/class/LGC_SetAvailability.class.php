<?php
	require ("DAL_SetAvailability.class.php");

    class LGC_SetAvailability 
    {
        public function UserSetAvailabilityMorning(string $date, int $userID) 
        {
            $dsa = new DAL_SetAvailability();
            $dsa->SetAvailabilityMorning($date,  $userID);
		}

        public function UserSetAvailabilityAfternoon(string $date, int $userID) 
        {
            $dsa = new DAL_SetAvailability();
            $dsa->SetAvailabilityAfternoon($date,  $userID);
		}

        public function UserSetAvailabilityEvening(string $date, int $userID) 
        {
            $dsa = new DAL_SetAvailability();
            $dsa->SetAvailabilityEvening($date,  $userID);
		}

        public function UserSetAvailabilityMorningAvailable(string $date, int $userID) 
        {
            $dsa = new DAL_SetAvailability();
            $dsa->SetAvailabilityMorningAvailable($date,  $userID);
		}

        public function UserSetAvailabilityAfternoonAvailable(string $date, int $userID) 
        {
            $dsa = new DAL_SetAvailability();
            $dsa->SetAvailabilityAfternoonAvailable($date,  $userID);
		}

        public function UserSetAvailabilityEveningAvailable(string $date, int $userID) 
        {
            $dsa = new DAL_SetAvailability();
            $dsa->SetAvailabilityEveningAvailable($date,  $userID);
		}
	}

?>