/*
* AUTHOR: 		Eric Hunter
* DATE: 		2 March 2012
* DESCRIPTION:	Creates the woofpack database in MySQL and all of its tables.
* CONVENTIONS:	Table Names			-> UpperCamelCase
*				Column Names		-> camelCase
*				Non-type Keywords	-> UPPERCASE
*				foreign key 		-> tableabbrev_id
* EXECUTING:	mysql -u root -p < woofpack.sql (UNIX) -- should work in Win
*/

/* CREATE DATABASE -- database name is case-sensitive*/

CREATE DATABASE IF NOT EXISTS woofpack;

/*SELECTING DATABASE woofpack */

USE woofpack;

/*CREATING TABLES*/

CREATE TABLE IF NOT EXISTS Breed (
	id			int				NOT NULL	AUTO_INCREMENT,
	name		varchar(40)		NOT NULL	UNIQUE,
	origin		varchar(60),
	dogGroup	varchar(30),
	weight		varchar(40),
	height		varchar(40),
	temperament	varchar(40),
	lifespan	varchar(40),
	PRIMARY KEY ( id )
);

CREATE TABLE IF NOT EXISTS AdditionalInfo (
	id			int				NOT NULL	AUTO_INCREMENT,
	b_id		int				NOT NULL,
	description	varchar(100)	NOT NULL,
	PRIMARY KEY ( id ),
	FOREIGN KEY ( b_id ) REFERENCES Breed ( id )
);

CREATE TABLE IF NOT EXISTS Photos (
	id			int 			NOT NULL	AUTO_INCREMENT,
	b_id		int				NOT NULL,
	fileName	varchar(100)	NOT NULL,
	PRIMARY KEY ( id ),
	FOREIGN KEY ( b_id ) REFERENCES Breed ( id )
);

CREATE TABLE IF NOT EXISTS HealthProblem (
	id			int				NOT NULL	AUTO_INCREMENT,
	name		varchar(50)		NOT NULL,
	description	varchar(150),
	PRIMARY KEY ( id )
);

CREATE TABLE IF NOT EXISTS BreedHasHealthProblems (
	b_id		int				NOT NULL,
	hp_id		int				NOT NULL,
	FOREIGN KEY ( b_id ) 	REFERENCES Breed ( id ),
	FOREIGN KEY ( hp_id ) 	REFERENCES HealthProblem ( id )
);

CREATE TABLE IF NOT EXISTS TrainingTip (
	id			int				NOT NULL	AUTO_INCREMENT,
	description	varchar(100)	NOT NULL,
	PRIMARY KEY ( id )
);

CREATE TABLE IF NOT EXISTS BreedHasTrainingTips (
	b_id		int				NOT NULL,
	tt_id		int				NOT NULL,
	FOREIGN KEY ( b_id ) 	REFERENCES Breed ( id ),
	FOREIGN KEY ( tt_id ) 	REFERENCES TrainingTip ( id )
);

CREATE TABLE IF NOT EXISTS Food (
	id			int 			NOT NULL	AUTO_INCREMENT,
	isHealthy	boolean			NOT NULL,
	name		varchar(30)		NOT NULL,
	description	varchar(150),
	PRIMARY KEY ( id )
);