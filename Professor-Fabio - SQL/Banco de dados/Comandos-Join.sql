create database joins;



use joins;



create table tabelaA(
nome varchar (50) null
);



create table tabelaB(
nome varchar (50) null
);




INSERT INTO TABELAA VALUES ('FERNANDA');
INSERT INTO TABELAA VALUES ('JOSEFA');
INSERT INTO TABELAA VALUES ('LUIZ');
INSERT INTO TABELAA VALUES ('FERNANDO');

DROP TABLE tabelaB;

INSERT INTO tabelaB VALUES ('CARLOS');
INSERT INTO tabelaB VALUES ('MANOEL');
INSERT INTO tabelaB VALUES ('LUIZ');
INSERT INTO tabelaB VALUES ('FERNANDO');






SELECT * FROM tabelaA;



SELECT * FROM tabelaB;

--Join
SELECT a.Nome, b.Nome
FROM tabelaA as A 
LEFT JOIN tabelaB AS B
ON a.Nome = b.Nome;

--Full Outer Join ou --Full Join
SELECT a.Nome, b.Nome
FROM tabelaA as A 
FULL OUTER JOIN tabelaB AS B
ON a.Nome = b.Nome;

--Left Excluding Join
SELECT a.Nome, b.Nome
FROM tabelaA as A 
LEFT JOIN tabelaB AS B
ON a.Nome = b.Nome WHERE b.Nome IS NULL;

--Rigth Excluding Join
SELECT a.Nome, b.Nome
FROM tabelaA as A 
RIGHT JOIN tabelaB AS B
ON a.Nome = b.Nome WHERE a.Nome IS NULL;

--Outer Excluding Join
SELECT a.Nome, b.Nome
FROM tabelaA as A 
FULL OUTER JOIN tabelaB AS B
ON a.Nome = b.Nome WHERE a.Nome IS NULL OR b.Nome IS NULL;

-- FA?A UMA PESQUISA QUE MOSTRE O NOME DO PRODUTO E O NOME DO FORNECEDOR

use Northwind;

SELECT * FROM Products;
SELECT * FROM Suppliers;

-- QUAIS TABELAS EU VOU USAR
-- QUAIS CAMPOS EU VOU USAR
-- QUAIS CAMPOS EST?O NAS TABELAS ENVOLVIDAS

SELECT p.ProductName, s.CompanyName  FROM Products AS p JOIN Suppliers as s on p.SupplierID = s.SupplierID;

-- Exercicio 1
SELECT p.ProductName, c.CategoryName FROM Products p JOIN Categories c ON  p.CategoryID = c.CategoryID;

-- Exercicio 2
SELECT * FROM Territories;
SELECT * FROM Region;

SELECT t.TerritoryDescription, r.RegionDescription FROM Territories t JOIN Region r on t.RegionID = r.RegionID;

-- Exercicio 3
SELECT o.OrderID, c.CompanyName FROM Orders o JOIN Customers c ON  o.CustomerID = c.CustomerID;



-- Exercicio 5 
SELECT p.ProductName, s.CompanyName FROM Products as p JOIN Suppliers as s ON p.SupplierID = s.SupplierID 
                                                       JOIN Categories C ON c.CategoryID = p.CategoryID;