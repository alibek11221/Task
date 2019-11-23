CREATE TABLE [dbo].[Products]
(
	Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	Product_Name NVARCHAR(128) NOT NULL
);

CREATE TABLE [dbo].[Categories]
(
	Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	Category_Name NVARCHAR(128) NOT NULL
)

CREATE TABLE [dbo].[Product_Categories]
(
	Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	Proudct_Id INT NOT NULL,
	Categry_Id INT NOT NULL,
	FOREIGN KEY([Proudct_Id]) REFERENCES [dbo].[Products]([Id]),
	FOREIGN KEY([Categry_Id]) REFERENCES [dbo].[Categories]([Id])
)


SELECT p.Product_Name, c.Category_Name
FROM Products AS p
LEFT OUTER JOIN Product_Categories AS pc ON p.Id = pc.Proudct_Id
LEFT OUTER JOIN Categories AS c ON c.Id = pc.Categry_Id