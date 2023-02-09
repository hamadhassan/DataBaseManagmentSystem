-- Company
CREATE TABLE Company(
name varchar(30),
city varchar(30)
);
INSERT INTO Company VALUES ('Nestle','Lahore')
INSERT INTO Company VALUES ('Mair','Lahore')
INSERT INTO Company VALUES ('National','Multan')
INSERT INTO Company VALUES ('Omore','Karachi')
INSERT INTO Company VALUES ('Unilever','Islambad')
INSERT INTO Company VALUES ('Kanas','Karachi')
SELECT * FROM Company
-- Product
DROP TABLE Product
CREATE TABLE Product(
name varchar(30),
maker varchar(30),
cost int,
Years DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
);
INSERT INTO Product(name,maker,cost) VALUES('Abuelita','Nestle',200)
INSERT INTO Product(name,maker,cost) VALUES('All Stars','Nestle',500)
INSERT INTO Product(name,maker,cost) VALUES('Alpia ','Nestle',600)
INSERT INTO Product(name,maker,cost) VALUES('Animal Bar ','Unilever',800)
INSERT INTO Product(name,maker,cost) VALUES('Fruit Gums','Unilever',1000)
INSERT INTO Product(name,maker,cost) VALUES('Maverick','Unilever',900)
INSERT INTO Product(name,maker,cost) VALUES('kababs','National',1500)
INSERT INTO Product(name,maker,cost) VALUES('biryani','National',21000)
INSERT INTO Product(name,maker,cost) VALUES('BBQ','National',10000)
INSERT INTO Product(name,maker,cost) VALUES('Acqua Panna (Italy)','Unilever',10)
INSERT INTO Product(name,maker,cost) VALUES('Acqua Panna (Pakistan)','Unilever',20)
INSERT INTO Product(name,maker,cost) VALUES('Cerelac (Pakistan)','Unilever',0)
INSERT INTO Product(name,maker,cost) VALUES('Cerelac (India)','Unilever',10)
INSERT INTO Product(name,maker,cost) VALUES('Acqua Panna (Italy)','Nestle',10)
INSERT INTO Product(name,maker,cost) VALUES('Acqua Panna (Pakistan)','Nestle',20)
INSERT INTO Product(name,maker,cost) VALUES('Cerelac (Pakistan)','Nestle',0)
INSERT INTO Product(name,maker,cost) VALUES('Cerelac (India)','Nestle',10)
INSERT INTO Product(name,maker,cost) VALUES('Cerelac (India)','Unilever',10)
INSERT INTO Product(name,maker,cost) VALUES('Acqua Panna (Italy)','Unilever',10)



SELECT * FROM Product
-- Product
DROP TABLE Purchase
CREATE TABLE Purchase(
id int IDENTITY,
product varchar(30),
buyer varchar(30),
price int
);
INSERT INTO Purchase(product,buyer,price) VALUES('Abuelita','Aslam',300)
INSERT INTO Purchase(product,buyer,price) VALUES('Abuelita','Ali',350)
INSERT INTO Purchase(product,buyer,price) VALUES('Abuelita','Hassan',220)
INSERT INTO Purchase(product,buyer,price) VALUES('Alpia','Ahmed',600)
INSERT INTO Purchase(product,buyer,price) VALUES('Alpia','Umar',650)
INSERT INTO Purchase(product,buyer,price) VALUES('Alpia','Bilal',700)
INSERT INTO Purchase(product,buyer,price) VALUES('BBQ','Bilal',10000)
INSERT INTO Purchase(product,buyer,price) VALUES('biryani','Bilal Ahmed',22000)
INSERT INTO Purchase(product,buyer,price) VALUES('Abuelita','Aslam Ali',305)
INSERT INTO Purchase(product,buyer,price) VALUES('Abuelita','Ali Ali',355)
INSERT INTO Purchase(product,buyer,price) VALUES('Abuelita','Hassan Ali',225)
INSERT INTO Purchase(product,buyer,price) VALUES('Alpia','Ahmed Ali',605)
INSERT INTO Purchase(product,buyer,price) VALUES('Alpia','Umar Ali',655)


-------------------------------------------------------------------
--------------------Question Start---------------------------------
-------------------------------------------------------------------
----Question-01-01 (BY Sub Query)
SELECT name
FROM Product
WHERE cost>
(SELECT AVG(cost)
FROM Product)
----Question-01-02 (BY Cartesian Product- CROSS SELF JOIN)
SELECT pr.name
FROM Product Pr CROSS JOIN Product Pr1
GROUP BY pr.name,Pr.cost
HAVING Pr.cost > AVG(Pr1.cost)
----Question-01-03 (BY Cartesian Product- CROSS SELF JOIN with Where caluse)
SELECT pr.name
FROM Product Pr CROSS JOIN Product Pr1
WHERE PR.maker=PR1.maker
GROUP BY pr.name,Pr.cost
HAVING Pr.cost > AVG(Pr1.cost)
----Question-01-04 (BY JOIN)
SELECT pr.name
FROM Product Pr JOIN Product Pr1
ON PR.maker=PR1.maker
GROUP BY pr.name,Pr.cost
HAVING Pr.cost > AVG(Pr1.cost)
----Question-01-05 (BY JOIN Changing On condition)
SELECT pr.name
FROM Product Pr JOIN Product Pr1
ON PR.maker>PR1.maker
GROUP BY pr.name,Pr.cost
HAVING Pr.cost > AVG(Pr1.cost)
----Question-01-06 (By LEFT OUTER Join)
SELECT pr.name
FROM Product Pr LEFT OUTER JOIN Product Pr1
ON PR.maker=PR1.maker
GROUP BY pr.name,Pr.cost
HAVING Pr.cost > AVG(Pr1.cost)
----Question-01-07 (By Right OUTER Join)
SELECT pr.name
FROM Product Pr Right OUTER JOIN Product Pr1
ON PR.maker=PR1.maker
GROUP BY pr.name,Pr.cost
HAVING Pr.cost > AVG(Pr1.cost)
----Question-01-08 (By FULL OUTER Join)
SELECT pr.name
FROM Product Pr FULL OUTER JOIN Product Pr1
ON PR.maker=PR1.maker
GROUP BY pr.name,Pr.cost
HAVING Pr.cost > AVG(Pr1.cost)
------------------------------------------------------------------------
------------------------------------------------------------------------
----Question-02-01 (Simple Method)
SELECT C.name
FROM Company C,Product Pr, Purchase Pu
WHERE  C.name=Pr.maker AND Pr.name=Pu.product AND pu.buyer ='Aslam'
----Question-02-02 (BY Sub Query)
SELECT C.name
FROM Company C
WHERE C.name IN (SELECT Pr.maker
	FROM Product Pr, Purchase Pu
	WHERE pu.buyer ='Aslam' AND Pr.name=Pu.product)
----Question-02-03 (BY Sub Query)
SELECT C.name
FROM Company C
WHERE C.name IN (SELECT Pr.maker
	FROM Product Pr
	WHERE Pr.name IN (SELECT Pu.product
		FROM Purchase Pu
		WHERE pu.buyer='Aslam'))
----Question-02-04 (BY Sub Query)
SELECT Pr.maker
FROM Product Pr
WHERE Pr.name IN (SELECT Pu.product 
	FROM Purchase Pu
	WHERE Pu.buyer='Aslam')
----Question-02-05 (Cartesian Product)
SELECT C.name
FROM Company C CROSS JOIN Product Pr CROSS JOIN Purchase Pu
WHERE C.name=Pr.maker AND Pr.name=Pu.product AND pu.buyer ='Aslam'
----Question-02-06 (FULL Outer Join)
SELECT C.name
FROM Company C FULL OUTER JOIN Product Pr 
ON C.name=Pr.maker
FULL OUTER JOIN Purchase Pu
ON Pr.name=Pu.product
WHERE pu.buyer ='Aslam'
----Question-02-07 (LEFT Outer Join)
SELECT C.name
FROM Company C LEFT OUTER JOIN Product Pr 
ON C.name=Pr.maker
LEFT OUTER JOIN Purchase Pu
ON Pr.name=Pu.product
WHERE pu.buyer ='Aslam'
----Question-02-08 (RIGHT Outer Join)
SELECT C.name
FROM Company C RIGHT OUTER JOIN Product Pr 
ON C.name=Pr.maker
RIGHT OUTER JOIN Purchase Pu
ON Pr.name=Pu.product
WHERE pu.buyer ='Aslam'
----Question-02-09 (RIGHT AND LEFT Outer Join)
SELECT C.name
FROM Company C LEFT OUTER JOIN Product Pr 
ON C.name=Pr.maker
RIGHT OUTER JOIN Purchase Pu
ON Pr.name=Pu.product
WHERE pu.buyer ='Aslam'
----Question-02-10 (LEFT JOIN AND SubQuery)
SELECT C.name
FROM Company C LEFT OUTER JOIN Product Pr 
ON C.name=Pr.maker
WHERE PR.name IN (SELECT Pu.product
	FROM Purchase Pu
	WHERE pu.buyer ='Aslam')
----Question-02-11 (Theta Join)
SELECT C.name
FROM Company C JOIN Product Pr 
ON C.name=Pr.maker
JOIN Purchase Pu
ON Pr.name=Pu.product
WHERE pu.buyer ='Aslam'
------------------------------------------------------------------------
------------------------------------------------------------------------
----Question-03-01 (self-contained scalar subquery)
DECLARE @SUM as int =(Select SUM(Pr.cost)
FROM Product Pr
WHERE Pr.maker='Unilever')
(SELECT Pr.name
FROM Product Pr
WHERE NOT Pr.maker='Unilever' AND Pr.cost>@SUM)
----Question-03-02 (Sub-Query Method)
SELECT Pr.name
FROM Product Pr
WHERE NOT Pr.maker='Unilever' AND Pr.cost>(Select SUM(Pr.cost)
FROM Product Pr
WHERE Pr.maker='Unilever')
----Question-03-03 (Product)
SELECT DISTINCT Pr.name
FROM Product Pr CROSS JOIN Product Pr1
WHERE NOT Pr.maker='Unilever' AND Pr.cost>(Select SUM(Pr.cost)
FROM Product Pr
WHERE Pr.maker='Unilever')
----Question-03-04 (Join)
SELECT  Pr.name
FROM Product Pr FULL OUTER JOIN Product Pr1
ON Pr.name=Pr1.name
WHERE NOT Pr.maker='Unilever' AND Pr.cost>(Select SUM(Pr.cost)
FROM Product Pr
WHERE Pr.maker='Unilever')
----Question-03-05 (Left Join)
SELECT  Pr.name
FROM Product Pr Left OUTER JOIN Product Pr1
ON Pr.name=Pr1.name
WHERE NOT Pr.maker='Unilever' AND Pr.cost>(Select SUM(Pr.cost)
FROM Product Pr
WHERE Pr.maker='Unilever')
----Question-03-06 (Right Join)
SELECT  Pr.name
FROM Product Pr Right OUTER JOIN Product Pr1
ON Pr.name=Pr1.name
WHERE NOT Pr.maker='Unilever' AND Pr.cost>(Select SUM(Pr.cost)
FROM Product Pr
WHERE Pr.maker='Unilever')
------------------------------------------------------------------------
------------------------------------------------------------------------
----Question-04-01 ()
SELECT Pr.maker
FROM Product Pr 
Where Pr.name = (SELECT Pr1.name
	FROM Product Pr1
	Where Pr.name=Pr1.name)
----
SELECT Pr.name,Pr.maker
FROM Product Pr JOIN Product Pr1
On Pr.name=Pr1.name
WHERE Pr.name=Pr1.name

------------------------------------------------------------------------
------------------------------------------------------------------------
----Question-05-01 (Simple)
SELECT Pr.name
FROM Company C,Product Pr
WHERE Pr.maker=C.name AND C.city='Lahore' 
----Question-05-02 (Sub Query)
SELECT Pr.name
FROM Product Pr
WHERE Pr.maker IN (SELECT C.name
	FROM Company C
	WHERE C.city='Lahore')
----Question-05-03 (CROSS JOIN)
SELECT Pr.name
FROM Product Pr CROSS JOIN Company C
WHERE Pr.maker=C.name AND C.city='Lahore'
----Question-05-04 (JOIN)
SELECT Pr.name
FROM Product Pr JOIN Company C
ON Pr.maker=C.name
WHERE C.city='Lahore'
----Question-05-05 (FULL OUTER JOIN)
SELECT Pr.name
FROM Product Pr FULL OUTER JOIN Company C
ON Pr.maker=C.name
WHERE C.city='Lahore' AND Pr.name IS NOT NULL
----Question-05-05 (LEFT OUTER JOIN)
SELECT Pr.name
FROM Product Pr LEFT OUTER JOIN Company C
ON Pr.maker=C.name
WHERE C.city='Lahore' AND Pr.name IS NOT NULL
----Question-05-06 (Right OUTER JOIN)
SELECT Pr.name
FROM Product Pr RIGHT OUTER JOIN Company C
ON Pr.maker=C.name
WHERE C.city='Lahore' AND Pr.name IS NOT NULL
------------------------------------------------------------------------
------------------------------------------------------------------------
----Question-06-01 (BY SUB QUERY)
SELECT Pu.buyer
FROM Purchase Pu
WHERE Pu.product IN(SELECT Pr.name
	FROM Product Pr
	WHERE Pr.maker IN (SELECT C.name
		FROM Company C
		WHERE C.city='Lahore'))
----Question-06-02 (SIMPLE)
SELECT Pu.buyer
FROM Purchase Pu,Product Pr,Company C
WHERE Pu.product=Pr.name AND Pr.maker =C.name AND C.city='Lahore'
----Question-06-03 (CROSS)
SELECT Pu.buyer
FROM Purchase Pu CROSS JOIN Product Pr CROSS JOIN Company C
WHERE Pu.product=Pr.name AND Pr.maker =C.name AND C.city='Lahore'
----Question-06-04 (JOIN)
SELECT Pu.buyer
FROM Purchase Pu JOIN Product Pr
ON Pu.product=Pr.name
JOIN Company C
ON Pr.maker =C.name
WHERE C.city='Lahore'
----Question-06-04 (JOIN)
SELECT Pu.buyer
FROM Purchase Pu FULL OUTER JOIN Product Pr
ON Pu.product=Pr.name
FULL OUTER JOIN Company C
ON Pr.maker =C.name
WHERE C.city='Lahore'AND  Pu.id IS NOT NULL
----Question-06-05 (LEFT JOIN)
SELECT Pu.buyer
FROM Purchase Pu LEFT OUTER JOIN Product Pr
ON Pu.product=Pr.name
LEFT OUTER JOIN Company C
ON Pr.maker =C.name
WHERE C.city='Lahore'AND  Pu.id IS NOT NULL
----Question-06-06 (RIGHT JOIN)
SELECT Pu.buyer
FROM Purchase Pu RIGHT OUTER JOIN Product Pr
ON Pu.product=Pr.name
RIGHT OUTER JOIN Company C
ON Pr.maker =C.name
WHERE C.city='Lahore'AND  Pu.id IS NOT NULL
------------------------------------------------------------------------
------------------------------------------------------------------------
----Question-07-01 (SIMPLE)
SELECT Pu.product as Name,AVG(Pu.price) as Price
FROM Purchase Pu
GROUP BY Pu.product
HAVING COUNT(Pu.product)>=5
----Question-07-02 (CROSS JOIN)
SELECT Pu.product as Name,AVG(Pu.price) as Price
FROM Purchase Pu CROSS JOIN Purchase Pu1
WHERE Pu.id=Pu1.id
GROUP BY Pu.product
HAVING COUNT(Pu1.product)>=5
----Question-07-03 (JOIN)
SELECT Pu.product as Name,AVG(Pu.price) as Price
FROM Purchase Pu JOIN Purchase Pu1
ON Pu.id=Pu1.id
GROUP BY Pu.product
HAVING COUNT(Pu1.product)>=5
----Question-07-04 (FULL OUTER JOIN JOIN)
SELECT Pu.product as Name,AVG(Pu.price) as Price
FROM Purchase Pu FULL OUTER JOIN Purchase Pu1
ON Pu.id=Pu1.id
GROUP BY Pu.product
HAVING COUNT(Pu1.product)>=5
----Question-07-05 (LEFT OUTER JOIN JOIN)
SELECT Pu.product as Name,AVG(Pu.price) as Price
FROM Purchase Pu LEFT OUTER JOIN Purchase Pu1
ON Pu.id=Pu1.id
GROUP BY Pu.product
HAVING COUNT(Pu1.product)>=5
----Question-07-06 (RIGHT OUTER JOIN JOIN)
SELECT Pu.product as Name,AVG(Pu.price) as Price
FROM Purchase Pu RIGHT OUTER JOIN Purchase Pu1
ON Pu.id=Pu1.id
GROUP BY Pu.product
HAVING COUNT(Pu1.product)>=5
------------------------------------------------------------------------
------------------------------------------------------------------------
----Question-08-01 (By Subquery : Change 2024->2015)
SELECT Pr.name
FROM Product Pr
WHERE Pr.cost>
	(SELECT  AVG(Pr1.cost)
	FROM Product Pr1
	WHERE Pr1.maker=Pr.maker AND YEAR(Pr1.years)<'2024')
----Question-08-02 (CROSS : Change 2024->2015)
SELECT DISTINCT Pr.name
FROM Product Pr CROSS JOIN Product Pr1
WHERE Pr1.maker=Pr.maker OR  Pr.cost>
	(SELECT  AVG(Pr2.cost)
	FROM Product Pr2
	WHERE YEAR(Pr2.years)<'2024')
----Question-08-03 (JOIN : Change 2024->2015)
SELECT  Pr.name
FROM Product Pr JOIN Product Pr1
ON Pr1.maker=Pr.maker
WHERE Pr.cost>
	(SELECT  AVG(Pr.cost)
	FROM Product Pr
	WHERE YEAR(Pr.years)<'2024')
----Question-08-04 (FULL OUTER JOIN : Change 2024->2015)
SELECT  Pr.name
FROM Product Pr FULL OUTER JOIN Product Pr1
ON Pr1.maker=Pr.maker
WHERE Pr.cost>
	(SELECT  AVG(Pr.cost)
	FROM Product Pr
	WHERE YEAR(Pr.years)<'2024')
----Question-08-05 (LEFT OUTER JOIN : Change 2024->2015)
SELECT  Pr.name
FROM Product Pr LEFT OUTER JOIN Product Pr1
ON Pr1.maker=Pr.maker
WHERE Pr.cost>
	(SELECT  AVG(Pr.cost)
	FROM Product Pr
	WHERE YEAR(Pr.years)<'2024')

----Question-08-06 (RIGHT OUTER JOIN : Change 2024->2015)
SELECT  Pr.name
FROM Product Pr RIGHT OUTER JOIN Product Pr1
ON Pr1.maker=Pr.maker
WHERE Pr.cost>
	(SELECT  AVG(Pr.cost)
	FROM Product Pr
	WHERE YEAR(Pr.years)<'2024')
------------------------------------------------------------------------
------------------------------------------------------------------------
----Question-09-01 (BY SUB QUERY)
SELECT C.name
FROM Company C
WHERE C.name IN (SELECT Pr.maker
	FROM Product Pr
	WHERE Pr.name IN(SELECT Pu.product
		FROM Purchase Pu
		WHERE Pr.cost<Pu.price))
----Question-09-02 (BY SIMPLE)
SELECT DISTINCT C.name
FROM Company C,Product Pr,Purchase Pu
WHERE C.name=Pr.maker AND Pr.name = Pu.product AND  Pr.cost< Pu.price
----Question-09-03 (BY CROSS JOIN)
SELECT DISTINCT C.name
FROM Company C CROSS JOIN Product Pr CROSS JOIN Purchase Pu
WHERE C.name=Pr.maker AND Pr.name = Pu.product AND  Pr.cost< Pu.price
----Question-09-04 (BY JOIN)
SELECT DISTINCT C.name
FROM Company C JOIN Product Pr
ON C.name=Pr.maker 
JOIN Purchase Pu
ON Pr.name = Pu.product
WHERE Pr.cost< Pu.price
----Question-09-05 (BY FULL OUTER JOIN)
SELECT DISTINCT C.name
FROM Company C FULL OUTER JOIN Product Pr
ON C.name=Pr.maker 
FULL OUTER JOIN Purchase Pu
ON Pr.name = Pu.product
WHERE Pr.cost< Pu.price
----Question-09-06 (BY LEFT OUTER JOIN)
SELECT DISTINCT C.name
FROM Company C LEFT OUTER JOIN Product Pr
ON C.name=Pr.maker 
LEFT OUTER JOIN Purchase Pu
ON Pr.name = Pu.product
WHERE Pr.cost< Pu.price
----Question-09-07 (BY RIGHT OUTER JOIN)
SELECT DISTINCT C.name
FROM Company C RIGHT OUTER JOIN Product Pr
ON C.name=Pr.maker 
RIGHT OUTER JOIN Purchase Pu
ON Pr.name = Pu.product
WHERE Pr.cost< Pu.price
------------------------------------------------------------------------
------------------------------------------------------------------------
----Question-10-01 ( BY Join CHange 2023->2015 and 2023->2016)
(SELECT DISTINCT Pr.name
FROM Product Pr JOIN Purchase Pu
ON Pr.name=Pu.product
WHERE (Pr.cost-Pu.price)>
	(SELECT AVG(Pr1.cost- Pu1.price)
	FROM Product Pr1,Purchase Pu1
	WHERE YEAR(Pr1.years)='2023') AND (Pr.cost-Pu.price)>
		(SELECT AVG(Pr.cost-Pu.price)
		FROM Product Pr JOIN Purchase Pu
		ON Pr.name=Pu.product
		WHERE YEAR(Pr.Years)='2023'))



















