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

-- FAÇA UMA PESQUISA QUE MOSTRE O NOME DO PRODUTO E O NOME DO FORNECEDOR

use Northwind;

SELECT * FROM Products;
SELECT * FROM Suppliers;

-- QUAIS TABELAS EU VOU USAR
-- QUAIS CAMPOS EU VOU USAR
-- QUAIS CAMPOS ESTÃO NAS TABELAS ENVOLVIDAS

SELECT p.ProductName, s.CompanyName  FROM Products AS p JOIN Suppliers as s on p.SupplierID = s.SupplierID; 
