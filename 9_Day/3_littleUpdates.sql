SELECT * FROM northwind.products

UPDATE northwind.products 
SET product_name = REPLACE(product_name, 'Northwind', "")
WHERE product_name LIKE '%Northwind%'

UPDATE northwind.products 
SET description = 'Delicious'
WHERE id % 2 = 0

UPDATE northwind.products 
SET description = 'Not Delicious'
WHERE id % 2 = 1

SELECT * FROM northwind.products
WHERE id % 2 = 0