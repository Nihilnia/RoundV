SELECT CONCAT(cst.first_name, " ", cst.last_name) AS 'Customer', cst.email_address as 'E-Mail', ord.id AS 'Order_ID'
FROM northwind.customers AS cst
LEFT JOIN northwind.orders AS ord
ON cst.id = ord.customer_id
WHERE ord.id is NULL AND cst.email_address is NOT NULL
ORDER BY Customer 


SELECT ship_name FROM northwind.orders
WHERE ship_name LIKE '%Alex%'

SELECT * FROM northwind.order_details as ordDtl
WHERE ordDtl.quantity > 1

SELECT ord.id as 'Order ID', ordDtl.id 'Order Detail ID'
FROM northwind.orders as ord
LEFT JOIN northwind.order_details as ordDtl
on ord.id = ordDtl.id

SELECT ordDtl.product_id, prd.id, prd.product_name
FROM northwind.order_details as ordDtl
LEFT JOIN northwind.products as prd
ON ordDtl.product_id = prd.id
WHERE ordDtl.quantity = 0

SELECT prd.id as 'Product ID', prd.product_name, ordDtl.id as 'Order Detail ID' FROM northwind.products as prd
LEFT JOIN northwind.order_details as ordDtl
ON prd.id = ordDtl.product_id
WHERE ordDtl.id is NULL