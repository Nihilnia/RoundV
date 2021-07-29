-- ASC (Default)
-- SELECT * FROM gloria_db.products order by Name ASC

-- DESC (Reverse)
-- SELECT * FROM gloria_db.products order by Price DESC

-- Multiple criteria
-- SELECT * FROM gloria_db.products order by ID DESC, Price ASC

SELECT ID, Name, Price FROM gloria_db.products WHERE ID BETWEEN 1 AND 4 
order by ID DESC

