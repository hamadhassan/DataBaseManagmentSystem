-- Task-01
SELECT ProductName
FROM Products
WHERE UnitPrice> 
	(SELECT AVG(UnitPrice)
	FROM Products)

-- Task-02
SELECT O.ShippedDate
FROM  Products as P JOIN [Order Details] as OD
ON P.ProductID=OD.ProductID
JOIN Orders as O
ON O.OrderID= OD.OrderID
GROUP BY O.ShippedDate
-- Task-03
SELECT Country
FROM Suppliers
GROUP BY Country
HAVING COUNT(Country)>=2
-- Task-04
SELECT COUNT(ORDERID),Count(Month(ShippedDate))
FROM Orders
Where ShippedDate>RequiredDate
GROUP BY ORDERID



