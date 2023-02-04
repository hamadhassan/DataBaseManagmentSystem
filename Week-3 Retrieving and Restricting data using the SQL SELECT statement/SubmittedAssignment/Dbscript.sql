----------------------------------------------------------------------
-------------------LAB TASK
----------------------------------------------------------------------
CREATE DATABASE northwind

CREATE TABLE Student(
RegNo varchar(30),
Firstname varchar(50),
Lastname varchar(50),
GPA float,
Contact bigint,
);

DROP TABLE student 

INSERT INTO Student(RegNo,Firstname,Lastname,GPA,Contact) 
VALUES('2021-CS-5','Umar','Ahmed',null,03030299368)

SELECT * FROM student 

SELECT regNo FROM student 

SELECT GPA FROM student WHERE gpa>3.5

SELECT GPA FROM student WHERE gpa<=3.5

SELECT CONCAT(firstname ,' ',lastname) AS FullName FROM student 

SELECT * FROM Employees

SELECT * FROM Employees WHERE TitleOfCourtesy ='Dr.' 

SELECT * FROM Employees WHERE TitleOfCourtesy like 'm%' 

SELECT * FROM Employees WHERE Region is null

SELECT * FROM Employees WHERE Region is not null

SELECT * FROM orders  WHERE ShipVia=3 and EmployeeID=5 

SELECT * FROM orders  WHERE ShipVia=3 or EmployeeID=5 

SELECT * FROM orders  WHERE ShipVia<>4 

SELECT ShipVia, EmployeeID FROM orders  WHERE (ShipVia=1*2 +1)

SELECT * FROM student WHERE gpa>3.5

SELECT  distinct ShipVia FROM orders   WHERE ShipVia=1

SELECT gpa FROM student ORDER BY gpa 

SELECT gpa FROM student ORDER BY gpa desc

SELECT * FROM region ORDER BY regiondescription desc

SELECT top 10 productname, unitprice FROM Products  ORDER BY unitprice
 
SELECT productname, unitprice FROM Products WHERE UnitPrice=UnitPrice%2 ORDER BY unitprice

SELECT productname FROM Products
----------------------------------------------------------------------
-------------------HOME TASK
----------------------------------------------------------------------
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
