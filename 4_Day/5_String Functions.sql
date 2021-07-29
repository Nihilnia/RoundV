-- Length
-- SELECT length(Name) as Length, Name FROM gloria_db.products

-- Right and Left
-- SELECT Left(Description, 5) FROM gloria_db.products
-- SELECT concat(Right(Description, 5), '..') as Gloria FROM gloria_db.products

-- Lower and Upper
-- SELECT lower(Name) as 'Product Name' FROM gloria_db.products
-- SELECT upper(Name) as 'Product Name' FROM gloria_db.products

-- Replace
-- SELECT replace(Name, '_', '----') as Productsss FROM gloria_db.products

-- Trim, ltrim- rtrim
SELECT upper(concat(trim(Name), '..')) FROM gloria_db.products

