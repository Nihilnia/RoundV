SELECT * FROM northwind.customers

UPDATE northwind.customers
SET home_phone = 'fuckingHomePhone'
WHERE home_phone is NULL


SELECT * FROM northwind.customers WHERE mobile_phone LIKE 'fuckin\'%'

SELECT * FROM northwind.customers WHERE job_title LIKE 'fucking%'

SELECT * FROM northwind.customers WHERE notes is not NULL

SELECT * FROM northwind.customers WHERE mobile_phone is NULL

SELECT * FROM northwind.customers WHERE web_page LIKE '%github%'


-- SELECT WITH FILTERS --
SELECT *, count(*) FROM northwind.customers
WHERE job_title LIKE '%Manager%' GROUP BY job_title

SELECT first_name, count(first_name) as countTheName FROM northwind.customers GROUP BY first_name
SELECT * FROM northwind.customers WHERE first_name = 'John'

SELECT * FROM northwind.customers ORDER BY first_name ASC

-- INSERT --
INSERT INTO northwind.customers (first_name)
VALUES ('Gloria')

INSERT INTO northwind.customers (mobile_phone)
VALUES (234)


-- UPDATE --
UPDATE northwind.customers
SET Company = 'G_Zero', email_address = 'G@protonmail.com'
WHERE first_name LIKE '%Glo%'

UPDATE northwind.customers
SET home_phone = 'fuckingHomePhone'
WHERE home_phone is NULL

UPDATE northwind.customers
SET mobile_phone = 'fuckin\'Phone'
WHERE mobile_phone is NULL and web_page LIKE '%github%'

UPDATE northwind.customers 
SET email_address = 'Gloria@protonmail.com'
WHERE email_address is NULL

UPDATE northwind.customers
SET web_page = 'https://github.com/Nihilnia'
WHERE job_title LIKE '%fucking%'

UPDATE northwind.customers
SET job_title = replace(job_title, 'fuckingAasdasdas', 'fuckingManager')
WHERE job_title LIKE '%fuckingAasdasdas%'

SELECT *, count(*) as 'Total' FROM northwind.customers
WHERE web_page LIKE '%github%'

UPDATE northwind.customers
SET notes = '01100100 01100101 01100110 01100001 01110101 01101100 01110100'
WHERE notes is NULL and web_page LIKE '%github%'


-- DELETE --
DELETE FROM northwind.customers
WHERE company LIKE '%Zero%'