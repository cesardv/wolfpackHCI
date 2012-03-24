<?php

class Photo extends DBObject{
	$filename;
	
	public function __construct( $link ) {
		$this->link = $link;
	}
	
	public function select ( $breed_id ) {
		$selectBreedPhotoStmt = $this->link->conn->prepare(
		"select filename"
		);
	}
}

?>