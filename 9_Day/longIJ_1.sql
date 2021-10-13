SELECT CONCAT(first_name, " ", last_name) as 'Customer', customer_id, CONCAT(company, " ", job_title) as Company_Title, ship_city, COUNT(orderZ.customer_id) as 'Total Orderz', product_id as 'Product', prd.id FROM northwind.orders as orderZ
INNER JOIN northwind.customers as customerZ
ON orderZ.customer_id = customerZ.id
INNER JOIN northwind.order_details as oD ON oD.id = orderZ.id
INNER JOIN northwind.products as prd ON oD.id = prd.id
GROUP BY orderZ.customer_id ORDER BY COUNT(orderZ.customer_id) DESC -- example: prd id = 43 is 'Traders Coffee'

SELECT * FROM northwind.orders WHERE customer_id = 4

SELECT * FROM northwind.orders as orderZ
INNER JOIN northwind.customers as customerZ
ON orderZ.customer_id = customerZ.id