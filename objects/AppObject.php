<?php
/* 	AUTHOR:			Eric Hunter
*	DATE:			2 March 2012
*/

class AppObject {
	
	public $rel_path;
	
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
		$value = "";
		if ($name=="rel_path"):
			$value = $this->getRelPath();
		endif;
		return $value;
	}
	
	public function import ( array $objects ) {
		foreach ($objects as $classname):
			require_once $this->rel_path . "/objects/" . $classname . ".php";
		endforeach;
	}
	
	/*HELPER FUNCTIONS*/
	
	private function getRelPath () {
		$rel_path = ".";
		$cd = $_SERVER['PHP_SELF'];
		foreach ($this->dirStructure as $dir):
			if ( preg_match("/".$dir."/", $cd)):
				$rel_path = "..";
				return;
			endif;
		endforeach;
		return $rel_path;
	}

	
}

?>