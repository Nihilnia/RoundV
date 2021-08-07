SELECT  first_name, last_name, ship_city, ship_address, order_date,
COUNT(customer_id) as 'TOTAL Fucking ORDERS'
FROM northwind.orders AS orderZ
INNER JOIN northwind.customers AS customerZ
ON orderZ.customer_id = customerZ.id
GROUP BY customer_id ORDER BY COUNT(customer_id) ASC