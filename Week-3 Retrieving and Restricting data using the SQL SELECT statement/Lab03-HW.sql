-- Task-01
SELECT OrderID
FROM Orders
WHERE RequiredDate<ShippedDate 
-- Task-02
SELECT Country
FROM Employees
-- Task-03
SELECT CONCAT(FirstName,' ',LastName) as FullName
FROM Employees
WHERE ReportsTo is Null
-- Task-04
SELECT ProductName
FROM Products
WHERE Discontinued=0
-- Task-05
SELECT *
FROM [Order Details]
WHERE Discount=0
-- Task-06
SELECT ContactName
FROM Customers
WHERE Region is NULL
-- Task-07
SELECT ContactName,Phone
FROM Customers
WHERE Country='UK' OR Country='USA'
-- Task-08
SELECT CompanyName
FROM Suppliers
WHERE HomePage is Null
-- Task-09
SELECT ShipCountry
FROM Orders
WHERE OrderDate like '%1997%'
-- Task-10
SELECT CustomerID
FROM Orders
WHERE ShippedDate is NULL
-- Task-11
SELECT SupplierID,CompanyName,City
FROM Suppliers
-- Task-12
SELECT COUNT(DISTINCT Country) as TotalCount
FROM Employees

SELECT CONCAT(FirstName,' ',LastName) as FullName 
FROM Employees
WHERE City = 'London'
-- Task-13
SELECT ProductName
FROM Products
WHERE Discontinued=1
-- Task-14
SELECT OrderID
FROM [Order Details]
WHERE Discount<=0.1
--  Task-15
SELECT EmployeeID,FirstName,LastName,HomePhone
FROM Employees
WHERE Region is Null
