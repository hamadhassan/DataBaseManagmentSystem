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







