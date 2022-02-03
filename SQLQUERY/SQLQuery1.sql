
CREATE TABLE Products(
	Id INT IDENTITY PRIMARY KEY,
	ProductName NVARCHAR(30) NOT NULL,
);

CREATE TABLE Categories (
	Id INT IDENTITY PRIMARY KEY NOT NULL,
	CategoryName NVARCHAR(30) NOT NULL,
);

CREATE TABLE Products_Categories(
	Id INT NOT NULL PRIMARY KEY,
	ProdictId INT NOT NULL FOREIGN KEY REFERENCES Products(Id) ON DELETE CASCADE,
	CategoryId INT NOT NULL FOREIGN KEY REFERENCES Categories(Id) ON DELETE CASCADE,
);

ALTER TABLE Products_Categories
ADD Id INT NOT NULL PRIMARY KEY;

INSERT INTO Products (ProductName)
VALUES ('Milk'), ('Water'), ('Phone');

INSERT INTO Categories(CategoryName)
VALUES ('Kitchen'), ('Bathroom'), ('Car');

INSERT INTO Products_Categories(Id, ProdictId, CategoryId)
VALUES (1, 1, 1), (2, 2, 1), (3, 2, 2); 

SELECT Products.Id, Products.ProductName, Categories.CategoryName as Category
FROM Products 
LEFT JOIN Products_Categories
ON Products.Id = Products_Categories.ProdictId
LEFT JOIN Categories
ON Categories.Id = Products_Categories.CategoryId;
