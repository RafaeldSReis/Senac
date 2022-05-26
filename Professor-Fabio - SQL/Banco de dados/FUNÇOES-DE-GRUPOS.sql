SELECT avg(unitprice) "média dos preços",
MAX (unitprice) "maior preço",
MIN (unitprice) "menor preço"
from Products;

SELECT * FROM Products;
SELECT * FROM Orders;
SELECT * FROM [Order Details];

SELECT MAX (hiredate),
MIN (hiredate)
FROM Employees;

SELECT COUNT (*)
FROM Employees;

--EXERCICIOS
SELECT MAX (Freight) FROM Orders;

SELECT SUM (Quantity) FROM [Order Details];

SELECT COUNT (OrderID) FROM Orders;

SELECT avg(unitprice) "média dos preços",
MAX (unitprice) "maior preço",
MIN (unitprice) "menor preço"
from Products;

SELECT MIN (HireDate) FROM Employees;




