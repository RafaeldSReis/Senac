SELECT ProductName FROM Products WHERE UnitPrice > 30 ORDER BY ProductName;

SELECT EmployeeID,TerritoryID FROM EmployeeTerritories WHERE TerritoryID > 40000 ORDER BY EmployeeID desc;

SELECT City, Title FROM Employees ORDER BY city,Title;

SELECT Title,HireDate FROM Employees ORDER BY Title,HireDate desc;

SELECT City,Region FROM Customers ORDER BY 2;

/* Exercicio 1*/
SELECT LastName FROM Employees ORDER BY LastName;

/* Exercicio 2*/
SELECT OrderID,OrderDate FROM Orders ORDER BY OrderDate desc;

/* Exercicio 3*/
SELECT ProductName,CategoryID FROM Products ORDER BY CategoryID,ProductName;

/* Exercicio 4*/
SELECT ProductName,CategoryID FROM Products ORDER BY ProductName desc, CategoryID desc;

/* Exercicio 5*/
SELECT SupplierID,CompanyName,City FROM Suppliers ORDER BY 2;

