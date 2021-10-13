SELECT * FROM northwind.customers

SELECT * FROM northwind.customers AS customerZ
INNER JOIN northwind.orders AS orderZ
ON customerZ.id = orderZ.customer_id

SELECT cst.id, CONCAT(cst.first_name, ' ', cst.last_name) 'Customer', cst.company,
ord.ship_city, ord.shipped_date FROM northwind.customers AS cst
INNER JOIN northwind.orders AS ord
ON cst.id = ord.customer_id
WHERE ord.ship_city = 'Las Vegas'