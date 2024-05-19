CREATE DATABASE StudentsManager;

USE [StudentsManager];

CREATE TABLE Users
(
Username VARCHAR (20),
PasswordID VARCHAR (20)
)

USE [StudentsManager]

INSERT INTO  [dbo].[Users]
VALUES
('Tshepo', '577893'),
('Reabetswe', '576993'),
('Tebogo', '578663')

USE [StudentsManager]

CREATE TABLE Students
(
 FirstName VARCHAR (20),
 Surname VARCHAR(20),
 DOB VARCHAR(20),
 Phone INT,
 CourseID VARCHAR(20),
 CourseName VARCHAR(20),
 Gender VARCHAR(10),
 StudentAddress VARCHAR(30),
 StudentNumber VARCHAR (13),
 StudentImage IMAGE
)