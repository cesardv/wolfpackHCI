<?php
/* 	AUTHOR:			Eric Hunter
*	DATE:			8 March 2012
*/

class AdditionalInfo extends DBObject {
	
	$array;
	
	__construct($link) {
		require_once $this->rel_path . "AdditionalInfoObject.php";
		$this->link = $link;
		$this->array = new ArrayObject();
	}
		
	public function selectMany ( $breed_id ) {
		$selectAdditionalInfoStmt = $this->link->conn->prepare(
		"select id, description from AdditionalInfo where b_id=?"
		);
		$selectAdditionalInfoStmt->bind_param("i", $breed_id);
		$selectAdditionalInfoStmt->execute();
		$selectAdditionalInfoStmt->bind_result($info_id, $description);
		while ($selectAdditionalInfoStmt->fetch()):
			
			$infoObject = new AdditionalInfoObject();
			$infoObject->id = $info_id;
			$infoObject->description = $description;
			$this->array->append($infoObject);
			
		endwhile;
		$selectAdditionalInfoStmt->close();
	}

}

?>