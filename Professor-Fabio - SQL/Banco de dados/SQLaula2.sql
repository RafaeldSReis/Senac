SELECT CONCAT(firstname,' ',lastname) as "Nome e Sobrenome"
FROM Employees;

SELECT CONCAT(firstname,' mora em ',city) as "Nome e Cidade"
FROM Employees;

/* Exercico 1 - Mostrar o nome do produtos e seu preco*/
SELECT CONCAT(ProductName,' preço ', UnitPrice) as "Nome e Preco"
FROM Products;

/* Exercico 2 - Mostrar regiao e a cidade */
SELECT CONCAT(Region,' e ',city) as "Regiao e Cidade"
FROM Suppliers;

/* Exercicio 3 - mostrar o id e a descricao de categorias */
SELECT CONCAT(CategoryID,' tem ',Description) as "Id e Descricao"
FROM Categories;

/* Exercicio 4 - mostrar descricao do territorio e id da regiao */
SELECT CONCAT(TerritoryDescription,' ', RegionID) as "descricao e Cidade"
FROM Territories;

/*-------------------------------------------------------------------*/

SELECT TitleOfCourtesy
FROM Employees;

SELECT distinct(TitleOfCourtesy) FROM Employees;

/* Exercicio 1 - mostrar a cidade sem repetir*/
SELECT distinct(City) FROM Employees;

/* Exercicio 2 - mostrar o preço sem repetir*/
SELECT distinct(UnitPrice) FROM [Order Details];

/* Exercicio 3 - mostrar o pais sem repetir*/
SELECT distinct(Country) FROM Suppliers;

/*--------------------------------------------------------*/

SELECT TerritoryDescription
FROM Territories
WHERE TerritoryID = 01730;

SELECT LastName,FirstName
FROM Employees
WHERE FirstName = 'Robert';

SELECT OrderID,CustomerID
FROM Orders
WHERE ShipAddress = '1996-16-07 00:00:00.000';

 /* Exercicio 1 - mostrar nome do produto onde ID e = "x" */
SELECT ProductName
FROM Products
WHERE ProductID = 1;


 /* Exercicio 2 - mostrar nome da empresa onde ID e = "x" */
SELECT CompanyName
FROM Suppliers
WHERE SupplierID = 1;


 /* Exercicio 3 - mostrar a cidade onde o id = "ALFKI" */
SELECT City
FROM Customers
WHERE CustomerID = 'ALFKI';


 /* Exercicio 4 - mostrar a data onde o id = 10248 */
SELECT OrderDate
FROM Orders
WHERE OrderID = 10248;

 /* Exercicio 5 -  mostrar o frete do id 'vinet' */
SELECT Freight
FROM Orders
WHERE CustomerID = 'VINET';

/*----------------------------------------------------------*/

SELECT ProductName
FROM Products
where UnitPrice >= 30.99;

SELECT CategoryName,Description
FROM Categories
where CategoryID < 5;

SELECT TerritoryDescription
FROM Territories
where TerritoryID between 90000 and 1000000;


SELECT City,Region
FROM Suppliers
where SupplierID in (3,7);

SELECT ProductName
FROM Products
where ProductName like 'cha%';

SELECT City
FROM Employees
where Region is null;
