<?php
/* 	AUTHOR:			Eric Hunter
*	DATE:			2 March 2012
*/


class Breed extends DBObject {
	
	//Atomic Attributes
	public $name;
	public $origin;
	public $group;
	public $weight;
	public $height;
	public $temperament;
	public $lifespan;

	//Object Attributes -- All Multi-valued
	public $additionalInformation;
	public $photos;
	public $trainingTips;
	public $healthProblems;
		
	public __construct( DBLink &$link ) {
		//import other classes
		require_once $this->rel_path . "AdditionalInformation.php";
		require_once $this->rel_path . "Photos.php";
		require_once $this->rel_path . "TrainingTips.php";
		require_once $this->rel_path . "HealthProblems.php";
		
		$this->link = $link;
		$this->additionalInformation = new AdditionalInformation($this->link);
		$this->photos = new Photos($this->link);
		$this->trainingTips = new TrainingTips($this->link);
		$this->healthProblems = new HealthProblems($this->link);
	} 
	
	public select ( int $id ) {
		$selectBreedStmt = $this->link->conn->prepare(
			"select id, name, origin, dogGroup, weight, height, temperament, lifespan ".
			"from Breed B ".
			"where B.id=?"
		);
		$selectBreedStmt->bind_param("i", $id);
		$selectBreedStmt->execute();
		$selectBreedStmt->bind_result($this->id, $this->name, $this->origin, $this->group, $this->weight, $this->height, $this->temperament, $this->lifespan);
		if (! $selectBreedStmt->fetch()):
			$this->errorMessages->append("Could not find a record of this breed.");
		endif;
		$selectBreedStmt->close();
		return $this->errorMessages->count()? false : true; // if count returns more than 0, return false.
	}
	
	public insert ( array $hash ) {
		$insertBreedStmt = $this->link->conn->prepare(
			"insert into Breed (name, origin, dogGroup, weight, height, temperament, lifespan) ".
			"values (?,?,?,?,?,?,?)"
		);
		
		$insertBreedStmt->bind_param("sssssss", $hash['name'], $hash['origin'], $hash['dogGroup'], $hash['weight'], $hash['height'], $hash['temperament'], $hash['lifespan']);
		$insertBreedStmt->execute();
		
		if (! $insertBreedStmt->errno): //if no error
			$this->select($insertBreedStmt->insert_id);
		else:
			$this->errorMessages->append("There was an error creating this breed.");
		endif;
		$insertBreedStmt->close();
		return $this->errorMessages->count()? false : true;
	}
	
}
?>