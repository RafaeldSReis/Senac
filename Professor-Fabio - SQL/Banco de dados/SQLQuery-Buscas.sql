SELECT lastname FROM Employees WHERE lastName LIKE 'SU%' AND HireDate LIKE '%1993%'; 

SELECT categoryname,description  FROM Categories WHERE CategoryID = '1' OR CategoryID = '3'; 

SELECT CompanyName,Phone FROM Shippers WHERE NOT ShipperID = 2; 

/* Exercicio 1*/
SELECT ProductName FROM Products WHERE UnitsInStock = 15;

/* Exercicio 2*/
SELECT CompanyName,city FROM Suppliers WHERE city = 'London';

/* Exercicio 3*/
SELECT ProductName,UnitsInStock FROM Products WHERE UnitsInStock < 10;

/* Exercicio 4 Entre "valores BETWEEN"*/
SELECT * FROM [Order Details] WHERE Quantity BETWEEN 80 AND 100;

/* Execicio 5*/
SELECT LastName,EmployeeID FROM Employees WHERE EmployeeID = 3 OR EmployeeID = 6 OR EmployeeID = 9;

/* Exercicio 6*/
SELECT * FROM Suppliers WHERE CompanyName LIKE 'h%';

/* Exercicio 7 */
SELECT * FROM Products WHERE QuantityPerUnit LIKE '%boxe%';

/* Exercicio 8*/
SELECT ContactName FROM Customers WHERE ContactName LIKE '__l%';

/* Exercicio 9*/
SELECT CompanyName,Region FROM Suppliers WHERE Region IS NULL;

/* Exercicio 10*/
SELECT TerritoryDescription,TerritoryID FROM Territories WHERE TerritoryID > 2 AND TerritoryDescription LIKE 'a%';
 
/* Exercicio 11 */
SELECT CompanyName,ShipperID FROM Shippers WHERE ShipperID = 1 OR ShipperID = 3;

/* Exercicio 12*/
SELECT RegionDescription,RegionID FROM Region WHERE RegionID <> 3;
SELECT RegionDescription,RegionID FROM Region WHERE NOT RegionID = 3;


