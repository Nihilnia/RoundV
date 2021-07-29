-- min()
-- SELECT Name as 'Product Name', min(price) as 'Minimum Price' FROM gloria_db.products

-- max()
-- SELECT Name as 'Product Name', max(price) as 'Minimum Price' FROM gloria_db.products WHERE ID BETWEEN 2 and 4

-- limit
-- SELECT Name, Price FROM gloria_db.products ORDER BY Price DESC limit 2

-- count()
-- SELECT count(*) as 'All Products' FROM gloria_db.products

-- avg()
-- SELECT avg(Price) from gloria_db.products

-- sum()
-- SELECT sum(Price) from gloria_db.products

-- SELECT count(ID) from gloria_db.products
-- SELECT sum(stock) as 'Total Products in Stock' from gloria_db.products

-- SELECT sum(price * stock) as 'Total revenue' FROM gloria_db.products


SELECT min(price) as 'Minimum Price' FROM gloria_db.products

