<?php
if (file_exists("../objects/AppObject.php")) require_once "../objects/AppObject.php";
else require_once "./objects/AppObject.php";

class LoggedInstance extends AppObject {
	
	public $id;
	public $password;
	public $account_id;
	public $contact_id;
	public $username;
	public $role;
	public $type;
	public $updated;
	public $status = false;
	public $conn;
			
	function __construct() {
		parent::__construct();
		$this->id = NULL;
		$this->role = "Guest";
	}
	
	function connect() {
		require_once parent::__get("rel_path") . '/info/mysql_info.php';
		if (mysqli_connect_errno()) die("MySQL Connection Failure: ".mysqli_connect_error() );
	}
			
	function insert($username, $password, $role) {
		$salt = hash("sha256", $password.$role, false);
		$id = md5($salt.$username);
		$password = md5($salt.$password);
		$insertUserStmt = $this->conn->prepare(
		"insert into User (id, username, password, role) values (?,?,?,?)"
		);
		$insertUserStmt->bind_param("ssss",$id, $username, $password, $role);
		$insertUserStmt->execute();
		if ($insertUserStmt->errno) $this->status="Unable to create account.";
		else {
			$this->id = $id;
			$this->username = $username;
			$this->role = $role;
			$this->status = "success";
		}
		$insertUserStmt->close();
	}
	
	function login($username, $password, $role) {
		$salt = hash("sha256", $password.$role, false);
		$password = md5($salt.$password);
		if ($role=="Editor") {
			$selectUserStmt = $this->conn->prepare(
			"SELECT id, username, role
			FROM User
			WHERE username=? AND password=?");
		}
		//echo "pass: ".$password;

		/*echo "SELECT id, username, role, business_id, contact_id, type, updated
			FROM User
			WHERE username='${username}' AND password='${password}'";*/

		$selectUserStmt->bind_param("ss", $username, $password); //double encryption
		$selectUserStmt->execute();
		$selectUserStmt->bind_result($this->id, $this->username, $this->role);
		
		if ($selectUserStmt->fetch()) $this->status = "success"; 
		else $this->status = "The username or password supplied was not valid. If you are an employer, please make sure you \"check\" the \"I am an employer\" checkbox";	
		
		$selectUserStmt->close();		
	}
	
	function usernameExists( $username ) {
		$selectUsernameStmt = $this->conn->prepare(
		"select username from User where username=?"
		);	
		$selectUsernameStmt->bind_param("s", $username);
		$selectUsernameStmt->execute();
		if ($selectUsernameStmt->fetch()):
			$exists = true;
		else:
			$exists = false;
		endif;
		$selectUsernameStmt->close();
		return $exists;
	}
				
	function changePassword( $newPassword, $id, $role ) {
		if (! $role):
			$selectRoleStmt = $this->conn->prepare(
			"select role from User where id=?"
			);
			$selectRoleStmt->bind_param("s", $id);
			$selectRoleStmt->execute();
			$selectRoleStmt->bind_result($role);
			$selectRoleStmt->fetch();
			$selectRoleStmt->close();
		endif;
		//echo $role;
		$changePasswordStmt = $this->conn->prepare(
		"update User set password=? where id=?"
		);
		$salt = hash("sha256", $newPassword.$role, false);
		$newPassword = md5($salt.$newPassword);
		
		$changePasswordStmt->bind_param("ss", $newPassword, $id);
		$changePasswordStmt->execute();
		
		if (! $changePasswordStmt->errno):
			$this->status = "success";
		else:
			$this->status = "Unable to change password.";
		endif;
		
		$changePasswordStmt->close();
	}
		
	function disconnect() {
		$this->conn->close();
	}
	
}


?>