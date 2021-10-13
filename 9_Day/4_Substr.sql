UPDATE northwind.customers
SET first_name = SUBSTRING(first_name, 1, 4)
WHERE first_name = 'Ming-Yang'

-- Ming