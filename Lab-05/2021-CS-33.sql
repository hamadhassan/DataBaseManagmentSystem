--1 Return customers and their orders, including customers 
-- who placed no orders (CustomerID, OrderID, OrderDate)
SELECT C.CustomerID,O.OrderID,O.OrderDate
FROM Customers C FULL OUTER JOIN Orders O
ON C.CustomerID=O.CustomerID
--2 Report only those customer IDs who never
--placed any order. (CustomerID, OrderID, OrderDate)
SELECT C.CustomerID,O.OrderID,O.OrderDate
FROM Customers C LEFT OUTER JOIN Orders O
ON C.CustomerID=O.CustomerID
WHERE O.OrderID IS NULL 
--3 Report those customers who placed orders 
--on July,1997. (CustomerID, OrderID, OrderDate)
SELECT C.CustomerID,O.OrderID,O.OrderDate
FROM Customers C  LEFT OUTER JOIN Orders O
ON C.CustomerID=O.CustomerID
WHERE YEAR(O.OrderDate)='1997' AND  MONTH(O.OrderDate)='7'
--4 Report the total orders of each customer. (customerID, totalorders)
SELECT C.CustomerID,COUNT(C.CustomerID)AS TotalOrders
FROM Customers C  LEFT OUTER JOIN Orders O
ON C.CustomerID=O.CustomerID
GROUP BY C.CustomerID
--5 Write a query to generate a five copies of each employee. (EmployeeID, FirstName, LastName)
SELECT E.EmployeeID,E.FirstName,E.LastName
FROM Employees E CROSS JOIN Employees E2 CROSS JOIN Employees E3 CROSS JOIN 
Employees E4 CROSS JOIN Employees E5

--6. Write a query that returns a row for each employee 
--and day in the range 04-07-1996 through 04-08-1997. (EmployeeID, Date)
SELECT E.EmployeeID,E.BirthDate
FROM Employees E
WHERE E.BirthDate BETWEEN  '1996-07-04 00:00:00.000' AND '1997-08-04 00:00:00.000'
--7. Return US customers, and for each customer return the total number of 
--orders and total quantities. (CustomerID, Totalorders, totalquantity)
SELECT C.CustomerID,COUNT(C.CustomerID)AS [Totalorders],SUM(OD.Quantity) AS [Total Quantity]
FROM Customers C 
JOIN Orders O
ON C.CustomerID=O.CustomerID
JOIN [Order Details] OD
ON OD.OrderID=O.OrderID
WHERE C.Country='USA'
GROUP BY C.CustomerID
--8. Write a query that returns all customers in the output,
--but matches them with their respective orders only if they were placed on 
--July 04,1997. (CustomerID, CompanyName, OrderID, Orderdate)
SELECT  C.CustomerID,O.OrderID,O.OrderDate
FROM Customers C JOIN Orders O
ON C.CustomerID=O.CustomerID
where O.OrderDate='1997-07-04 00:00:00.000'
--9 Are there any employees who are older than their managers?
DECLARE @MangerAge as DateTime=(SELECT E.BirthDate FROM Employees E WHERE E.Title LIKE'%Manager%')
SELECT CONCAT(E.FirstName,' ',E.LastName) AS FullName
FROM Employees E
WHERE E.BirthDate < @MangerAge
--10 List that names of those employees and their ages. (EmployeeName, Age, Manager Age)
SELECT CONCAT(E.FirstName,' ',E.LastName) AS FullName, YEAR(GETDATE())-YEAR(E.BirthDate) AS AGE , YEAR(GETDATE())-YEAR(@MangerAge) AS ManagerAge
FROM Employees E
WHERE E.BirthDate < @MangerAge
--11 List the names of products which 
--were ordered on 8th August 1997. (ProductName, OrderDate)
SELECT P.ProductName,O.OrderDate
FROM Products P JOIN [Order Details] OD
ON P.ProductID=OD.ProductID
JOIN Orders O
ON O.OrderID=OD.OrderID
WHERE O.OrderDate='1997-08-08 00:00:00.000'
--12 List the addresses, cities, countries of all orders which were serviced
--by Anne and were shipped late. (Address, City, Country)
SELECT O.ShipAddress,O.ShipCity,O.ShipCountry
FROM Orders O JOIN Employees E
ON O.EmployeeID=E.EmployeeID
WHERE E.FirstName='Anne'AND o.ShippedDate>o.RequiredDate
--List all countries to which beverages have been shipped. (Country)
SELECT O.ShipCountry
FROM Orders O
WHERE O.ShipName like '%beverages%'



