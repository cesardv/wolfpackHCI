<?php

class AdditionalInfoObject extends DBObject {
	$id;
	$description;
	
	function __construct($link) {
		$this->link = $link;
	}
	
	function select ( $id ) {
		$selectAdditionalInfoStmt = $this->link->conn->prepare(
		"select id, description from AdditionalInfo where id=?"
		);
		$selectAdditionalInfoStmt->bind_param("i", $id);
		$selectAdditionalInfoStmt->execute();
		$selectAdditionalInfoStmt->bind_result($info_id, $description);
		$this->id = $info_id;
		$this->description = $description;
		$success = $selectAdditionalInfoStmt->errno? false : true;
		$selectAdditionalInfoStmt->close();
		return $success;
	}
	
	function insert ($hash) {
		$insertInfoStmt = $this->link->conn->prepare(
		"insert into AdditionalInfo (b_id, description) values (?,?)"
		);
		$insertInfoStmt->bind_param("is", $hash['b_id'], $hash['description']);
		$insertInfoStmt->execute();
		$success = $insertInfoStmt->errno? false : true;
		$insertInfoStmt->close();
		return $success;
	}
	
	
}

?>