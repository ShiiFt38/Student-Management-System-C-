USE [StudentsManager]

CREATE TABLE Students
(
 FirstName VARCHAR (20),
 Surname VARCHAR(20),
 DOB VARCHAR(20),
 Phone INT,
 CourseID VARCHAR(20),
 Gender VARCHAR(10),
 StudentAddress VARCHAR(30),
 StudentNumber VARCHAR (13)
)

USE [StudentsManager]

SELECT * FROM [dbo].[Students]

UPDATE Students SET [FirstName] = '', [Surname] = '', [DOB] = '', [Phone] = '', [CourseID] = '', [Gender] = '', [StudentAddress] = '', [StudentNumber] = ''

