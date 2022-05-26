-- FUNÇÃO DE GRUPOS
 
-- SUM(SOMA)

SELECT CustomerID, SUM(Freight) FROM Orders GROUP BY CustomerID;

SELECT CustomerID, SUM(Freight) FROM Orders GROUP BY CustomerID HAVING SUM(Freight) > 1000;

SELECT CustomerID, SUM(Freight) FROM Orders WHERE CustomerID NOT LIKE 'W%' GROUP BY CustomerID HAVING SUM(Freight) > 40 ORDER BY CustomerID DESC;
 
SELECT * FROM [Order Details];

SELECT * FROM Employees;

SELECT * FROM Orders;

--EXERCICIOS
SELECT CategoryID,SUM(UnitsInStock) FROM Products GROUP BY CategoryID;
--
SELECT ProductID,SUM(UnitPrice) FROM [Order Details] GROUP BY ProductID HAVING SUM(UnitPrice) > 500;
--
SELECT EmployeeID,COUNT(OrderID) FROM Orders GROUP BY EmployeeID ORDER BY COUNT(OrderID) DESC;
--
SELECT OrderID,SUM(UnitPrice) FROM [Order Details] GROUP BY OrderID HAVING SUM(UnitPrice) > 200;
--
SELECT ShipVia,SUM(Freight) FROM Orders GROUP BY ShipVia;

SELECT  FROM Products;


