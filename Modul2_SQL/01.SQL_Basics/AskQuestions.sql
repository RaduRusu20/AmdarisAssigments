USE DatabaseAssigment;

SELECT FirstName, LastName
FROM dbo.Customers;

SELECT *
FROM dbo.Customers;

SELECT FirstName, LastName
FROM dbo.Customers
WHERE FirstName LIKE 'A%';

SELECT FirstName, LastName
FROM dbo.Customers
WHERE FirstName LIKE 'R___';

SELECT *
FROM dbo.Customers
ORDER BY LastName;

SELECT *
FROM dbo.Customers
ORDER BY FirstName DESC;

SELECT *
FROM dbo.Products;

SELECT TOP 7 _Name, Price
FROM dbo.Products;

SELECT _Name, Price
FROM dbo.Products
WHERE _Name LIKE '[mgj]%';

SELECT _Name, Price
FROM dbo.Products
WHERE _Name LIKE '[^mgj]%';

SELECT TOP 3 _Name, Price
FROM dbo.Products
WHERE Price > 200;

SELECT _Name as 'Product Name', Price as 'Product Price'
FROM dbo.Products;


SELECT COUNT(Id) as 'Number of customers', Adress
FROM dbo.Customers
WHERE Email LIKE '%@amdaris%'
GROUP BY Adress
HAVING Adress LIKE '[A-Z]%'
ORDER BY COUNT(Id) DESC;

SELECT c.FirstName, c.LastName, p._Name, p.Price
FROM dbo.Customers AS c
INNER JOIN dbo.ShoppingCartsProducts as scp
ON scp.ShoppingCartId = c.ShoppingCartId
INNER JOIN dbo.Products as p
ON scp.ProductId = p.Id;

SELECT c.FirstName, c.LastName, p._Name, p.Price
FROM dbo.Customers AS c
FULL JOIN dbo.ShoppingCartsProducts as scp
ON scp.ShoppingCartId = c.ShoppingCartId
FULL JOIN dbo.Products as p
ON scp.ProductId = p.Id;

SELECT c.FirstName, c.LastName, p._Name, p.Price
FROM dbo.Customers AS c
LEFT JOIN dbo.ShoppingCartsProducts as scp
ON scp.ShoppingCartId = c.ShoppingCartId
LEFT JOIN dbo.Products as p
ON scp.ProductId = p.Id;

SELECT c.FirstName, c.LastName, p._Name, p.Price
FROM dbo.Customers AS c
RIGHT JOIN dbo.ShoppingCartsProducts as scp
ON scp.ShoppingCartId = c.ShoppingCartId
RIGHT JOIN dbo.Products as p
ON scp.ProductId = p.Id
ORDER BY p.Price;


