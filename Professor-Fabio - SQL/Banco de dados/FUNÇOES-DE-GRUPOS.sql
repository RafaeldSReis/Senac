SELECT avg(unitprice) "m�dia dos pre�os",
MAX (unitprice) "maior pre�o",
MIN (unitprice) "menor pre�o"
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

SELECT avg(unitprice) "m�dia dos pre�os",
MAX (unitprice) "maior pre�o",
MIN (unitprice) "menor pre�o"
from Products;

SELECT MIN (HireDate) FROM Employees;




