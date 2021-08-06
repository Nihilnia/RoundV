-- SELECT --
SELECT * FROM gloria_db2.products

-- WHERE
SELECT * FROM gloria_db2.products WHERE ID % 2 = 0

-- Where (Operands)
SELECT * FROM gloria_db2.products WHERE Price Between 1000 and 3000
SELECT * FROM gloria_db2.products WHERE Name like '%_x'

-- ORDER --
SELECT * FROM gloria_db2.products ORDER BY Name DESC

SELECT Name as 'Fucking products', Price, Category FROM gloria_db2.products GROUP BY Name

SELECT sum(Price) as 'Sum total', count(*) as 'All of em,' FROM gloria_db2.products

SELECT Name as 'Prd', max(Price) as 'Maximum one' FROM gloria_db2.products

SELECT * FROM gloria_db2.products WHERE Price>=5000

SELECT *, count(Price) FROM gloria_db2.products

-- GROUP BY --

SELECT Name as 'Fcking Products', Price FROM gloria_db2.products GROUP BY Price
SELECT Description, Count(*) as Products FROM gloria_db2.products GROUP by Description

SELECT Price, Count(*) as Products FROM gloria_db2.products GROUP by Description
SELECT Name FROM gloria_db2.products WHERE Price is Max(Price)

SELECT Name, Max(Price) as maxPrc FROM gloria_db2.products WHERE Price = maxPrc

-- GROUP BY --
SELECT Description, Count(Description), Sum(Price) FROM gloria_db2.products GROUP BY Description Order By Price ASC

-------------------------

SELECT * FROM gloria_db2.products

-- INSERT -- 
INSERT INTO gloria_db2.products (Name, Price, ImageUrl, Category)
VALUES ('Song_09', 666, '99.jpg', 'Smoke')

-- UPDATE--
UPDATE gloria_db2.products
SET Name = 'Smoke_09'
WHERE Category Like '%Smoke%'

-- DELETE --
DELETE FROM gloria_db2.products
WHERE Name = 'Smoke_09'
