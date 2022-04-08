/* Lista todos os campos da tabela empregado */
SELECT * FROM Employees;

/* Lista todos os campos da tabela Clientes */
SELECT * FROM Customers;

/* Lista name e srobrename da tabela empregados */
SELECT firstname,lastname FROM Employees;

/* Lista cidade e região da tabela clientes */
SELECT city,Region FROM Customers;

/* 1 - Mostre o nome e o preço de cada produto */
SELECT ProductName,UnitPrice FROM Products;

/* 2 - Mostre todas as categorias */
SELECT * FROM Categories;

/* 3 - Mostre a descrição e o nome da categoria */
SELECT Description,CategoryName FROM Categories;

/* 4 - Mostre tudo da tabela orders */
SELECT * FROM Orders;

/* 5 - Mostre o id a data da ordem e a data do requirimento  */
SELECT  OrderID,OrderDate,RequiredDate FROM Orders;



