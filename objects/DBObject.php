<?php
/* 	AUTHOR:			Eric Hunter
*	DATE:			2 March 2012
*/

class DBObject {
	
	protected $rel_path;
	
	public $errorMessages;
	private $dirStructure = array(
		"do",
		"objects",
		"views"
	);
	
	public function __construct() {
		//rel path resolves directory conflict when importing other classes in object files.
		$this->setRelPath();
		$this->errorMessages = new ArrayObject();
	}
	
	public function __get( $name ) {
		if (method_exists( $this, "get_${name}")):
			if ($name==="rel_path") $this->setRelPath();
			return $this->{"get_$name"}();
		endif;
	}
	
	/*HELPER FUNCTIONS*/
	
	private function setRelPath () {
		$cd = $_SERVER['PHP_SELF'];
		foreach ($this->dirStructure as $dir):
			if ( preg_match("/".$dir."/", $cd)):
				$this->rel_path = "..";
				return;
			endif;
		endforeach;
		$this->rel_path = ".";
	}

	
}

?>