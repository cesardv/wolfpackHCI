<?php
/* 	AUTHOR:			Eric Hunter
*	DATE:			2 March 2012
*/

class DBObject {
	
	protected $rel_path;
	
	public $errorMessages;
	
	protected $link; // link to MySQL
	
	__construct() {
		//rel path resolves directory conflict when importing other classes in object files.
		
		if (file_exists('./objects/DBObject.php')): //if current executing file in site level directory.
			$this->rel_path = './objects/';
		elseif (file_exists('../objects/DBObject.php')): //if current executing file in other subdirectory.
			$this->rel_path = '../objects/';
		elseif (file_exists('./DBObject.php')): //if current executing file in objects directory.
			$this->rel_path = './';
		endif;
		
		$this->errorMessages = new ArrayObject();
	}
	
}

?>