<?php
/* 	AUTHOR:			Eric Hunter
*	DATE:			2 March 2012
*/

class DBLink {
	
	public $id;
	public $status = false;
	public $conn;
	
	private $rel_path;
		
	function __construct() {
		$this->id = NULL;
		
		if (file_exists('./objects/DBLink.php')): //if current executing file in site level directory.
			$this->rel_path = './info/';
		elseif (file_exists('../objects/DBLink.php')): //if current executing file in other subdirectory.
			$this->rel_path = '../info/';
		endif;
	}
	
	public function connect() {
		include $this->rel_path . 'mysql_info.php';
		
		$this->conn = new mysqli($server, $user, $pass, $db);
		if (mysqli_connect_errno()) die("MySQL Connection Failure: ".mysqli_connect_error() );
	}
			
	public function disconnect() {
		$this->conn->close();
	}
}


?>