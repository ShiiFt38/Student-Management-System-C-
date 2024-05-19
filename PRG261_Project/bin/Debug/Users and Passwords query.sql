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

SELECT * FROM [dbo].[Users]
