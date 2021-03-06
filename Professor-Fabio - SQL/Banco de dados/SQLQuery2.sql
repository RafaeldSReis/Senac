/* Lista todos os campos da tabela empregado */
SELECT * FROM Employees;

/* Lista todos os campos da tabela Clientes */
SELECT * FROM Customers;

/* Lista name e srobrename da tabela empregados */
SELECT firstname,lastname FROM Employees;

/* Lista cidade e regi?o da tabela clientes */
SELECT city,Region FROM Customers;

/* 1 - Mostre o nome e o pre?o de cada produto */
SELECT ProductName,UnitPrice FROM Products;

/* 2 - Mostre todas as categorias */
SELECT * FROM Categories;

/* 3 - Mostre a descri??o e o nome da categoria */
SELECT Description,CategoryName FROM Categories;

/* 4 - Mostre tudo da tabela orders */
SELECT * FROM Orders;

/* 5 - Mostre o id a data da ordem e a data do requirimento  */
SELECT  OrderID,OrderDate,RequiredDate FROM Orders;

/* Calculando os pre?os de 12 produtos */
SELECT  ProductName,UnitPrice,UnitPrice * 12 FROM Products;
SELECT  ProductName,UnitPrice,UnitPrice / 12 FROM Products;

/* Calculando os pre?os de 12 produtos */
SELECT  UnitPrice,UnitPrice + 12 FROM [Order Details];
SELECT  UnitPrice,UnitPrice - 12 FROM [Order Details];

/* Usando ALIASES "APELIDOS" */
SELECT  ProductName,UnitPrice,UnitPrice * 12 AS Total FROM Products;
SELECT Productname Descri??o FROM products;
SELECT  ProductName AS "Nome do Produto" FROM Products;
SELECT City as "Cidade" FROM Customers;
SELECT address as "Endere?o" FROM Customers;
SELECT Country as "Pais" FROM Customers;
SELECT Phone as "Telefone" FROM Customers;

