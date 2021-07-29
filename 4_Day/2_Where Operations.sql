-- Operands- Where


-- Price Between
-- SELECT * FROM gloria_db.products WHERE Price between 2000 and 3000

-- ID Between
-- SELECT * FROM gloria_db.products WHERE ID between 1 and 3

-- ID NOT Between
-- SELECT * FROM gloria_db.products WHERE ID not between 1 and 3

-- IN 
-- SELECT * FROM gloria_db.products WHERE Category in ('Computer')

-- IN (More than one criteria)
-- SELECT * FROM gloria_db.products WHERE Category in ('Computer', 'Cellphone')

-- NOT IN
-- SELECT * FROM gloria_db.products WHERE Category NOT in ('Cellphone')

-- NOT IN (ID)
-- SELECT * FROM gloria_db.products WHERE ID NOT in (1, 2, 3)

-- LIKE
-- SELECT * FROM gloria_db.products WHERE Category like ('%put%')

-- (String%), (%String)
-- SELECT * FROM gloria_db.products WHERE Category like 'Comp%'

-- _String%
-- SELECT * FROM gloria_db.products WHERE Name like '%_1'

-- NOT LIKE
-- SELECT * FROM gloria_db.products WHERE Category NOT like '%Computer%' 

-- More and more
-- SELECT * FROM gloria_db.products WHERE Category in ('Cellphone', 'Computer') and Price between 1000 and 3000

-- SELECT * FROM gloria_db.products WHERE Category like '%Phone%' and Description not like '%not%' and Price between 1000 and 4000
SELECT * FROM gloria_db.products WHERE ID %2 = 0 AND PRICE BETWEEN 2000 AND 3000
