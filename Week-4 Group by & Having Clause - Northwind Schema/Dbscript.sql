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
SELECT Month(ShippedDate) as [Month Number],COUNT(OrderDate) as [Order Delayed]
FROM Orders
Where ShippedDate<RequiredDate
GROUP BY MONTH(ShippedDate)
ORDER BY MONTH(ShippedDate) ASC
-- Task-05
SELECT OrderID,SUM(Discount) as Discount
FROM [Order Details]
WHERE Discount>0
GROUP BY OrderID
-- Task-06
SELECT ShipCity, COUNT(ShipCity) AS [Orders]
FROM Orders
WHERE ShipCountry ='USA' AND YEAR(ShippedDate)='1997'
GROUP BY ShipCity
-- Task-07
SELECT ShipCountry, COUNT(OrderDate) as [Order Delayed]
FROM Orders
Where ShippedDate<RequiredDate
GROUP BY ShipCountry
-- Task-08
SELECT OrderID,SUM(Discount) as Discount,SUM(UnitPrice) as [Total Price]
FROM [Order Details]
WHERE Discount>0
GROUP BY OrderID
-- Task-09
SELECT ShipRegion,ShipCity, COUNT(OrderID) AS [Orders]
FROM Orders
WHERE YEAR(ShippedDate)='1997' AND ShipRegion is not NULL
GROUP BY ShipRegion,ShipCity
ORDER BY ShipRegion

