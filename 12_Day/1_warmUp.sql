-- SELECT
SELECT * FROM northwind.customers

-- WHERE
SELECT * FROM northwind.customers
WHERE job_title LIKE '%fucking%'

-- ORDER
SELECT * FROM northwind.customers
WHERE job_title LIKE '%fucking%'
ORDER BY company DESC

-- Calc Functions
SELECT id, last_name, first_name, company, SUM(zip_postal_code) AS 'ASDAS' FROM northwind.customers
WHERE job_title LIKE '%fucking%'
ORDER BY company DESC

-- String Functions
SELECT id, CONCAT(first_name, ' ', last_name) AS 'FckingCust' FROM northwind.customers
WHERE job_title LIKE '%fucking%'
ORDER BY company DESC

-- GROUP BY
SELECT company, COUNT(company) as 'People' FROM northwind.customers
GROUP BY job_title

-- INSERT
INSERT INTO northwind.customers (id, first_name, last_name, job_title, company)
VALUES (9999, 'Nia', 'Gloria', 'Unknown', 'Company G')

-- UPDATE
UPDATE northwind.customers
SET company = 'Unknown Company'
WHERE company = 'Company G' and last_name LIKE '%oria'

-- DELETE
DELETE FROM northwind.customers
WHERE company IS NULL