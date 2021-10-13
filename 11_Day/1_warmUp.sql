SELECT * FROM northwind.orders as orderZ
INNER JOIN northwind.customers as customerZ
ON orderZ.customer_id = customerZ.id


SELECT cst.id, CONCAT(cst.first_name, " ", cst.last_name) as 'Customer', ord.id as 'Order ID', ord.ship_city, ord.shipped_date FROM northwind.orders as ord
INNER JOIN northwind.customers as cst
ON ord.customer_id = cst.id
WHERE ord.ship_city = 'Las Vegas'
