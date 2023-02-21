SELECT C.CustomerID,O.OrderID,O.OrderDate
FROM Customers C FULL OUTER JOIN Orders O
ON C.CustomerID=O.CustomerID


DECLARE @ID AS INT=(SELECT O.CustomerID FROM Customers O)

SELECT *
FROM Customers C 
WHERE C.CustomerID =@ID

SELECT *
FROM Customers C 
WHERE C.CustomerID
