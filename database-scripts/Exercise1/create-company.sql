--CREATE DATABASE mytestdb

USE mytestdb
CREATE TABLE Company (
	ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(255),
	IsActive BIT,
	CreateDate DATE,
	NumberOfEmployees INT
)

