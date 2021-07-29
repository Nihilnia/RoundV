-- SELECT * FROM gloria_db.products
-- SELECT ID, Name, Price FROM gloria_db.products

-- You can give custom names for the columns
-- SELECT ID, Name as PrdName, Price as PrdPrice, ImageUrl FROM gloria_db.products

-- SELECT * FROM gloria_db.products WHERE Price <= 3000 and Price >= 2000
-- SELECT * FROM gloria_db.products WHERE Price >= 2000
-- SELECT * FROM gloria_db.products WHERE NOT Price > 2000
-- SELECT * FROM gloria_db.products

-- SELECT * FROM gloria_db.products WHERE Name = 'Prd_01' AND PRICE <= 3000 
SELECT * FROM gloria_db.products WHERE Name = 'Prd_01' AND (PRICE = 1000 OR PRICE = 3000) 