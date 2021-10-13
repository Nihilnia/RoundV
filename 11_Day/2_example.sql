SELECT cst.id, CONCAT(cst.first_name, " ", cst.last_name) as 'Customer',
ord.customer_id, ord.id AS 'Order ID', ord.ship_city, ord.shipped_date,
ordDtl.order_id, ordDtl.product_id,
prd.id, prd.product_name, SUM(prd.standard_cost) AS 'Cost'
FROM northwind.orders AS ord
INNER JOIN northwind.customers AS cst
ON ord.customer_id = cst.id
INNER JOIN northwind.order_details AS ordDtl
ON ord.id = ordDtl.order_id
INNER JOIN northwind.products as prd
ON ordDtl.product_id = prd.id
GROUP BY ord.id 

SELECT ord.id, CONCAT(cst.first_name, " ", cst.last_name) Customer, ord.order_date, ordDtl.product_id, prd.product_name, sum(ordDtl.quantity * ordDtl.unit_price) as 'Bill' FROM northwind.orders AS ord
INNER JOIN northwind.customers as cst
ON ord.customer_id = cst.id
INNER JOIN northwind.order_details AS ordDtl
ON ordDtl.order_id = ord.id
INNER JOIN northwind.products as prd
ON ordDtl.product_id = prd.id
GROUP BY ord.id

UPDATE northwind.customers
SET first_name = "Anna"
WHERE last_name = "Bedecs"