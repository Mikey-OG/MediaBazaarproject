<?php

include ('Config.php');

class Connection {

	private $username = DBUSER;
	private $password = DBPWD;
	private $host = DBHOST;
	private $name = DBNAME;

	public function connect() {

		$dsn = 'mysql:host=' . $this->host . ';dbname=' . $this->name;
		$pdo = new PDO($dsn, $this->username, $this->password);
        $pdo-> setAttribute(PDO::ATTR_DEFAULT_FETCH_MODE, PDO::FETCH_ASSOC);
        $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    	$pdo->setAttribute(PDO::ATTR_EMULATE_PREPARES, false);

        return $pdo;
    }
}