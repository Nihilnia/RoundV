SELECT * FROM northwind.customers

SELECT cst.id, CONCAT(first_name, ' ', last_name) AS 'Customer', cst.company,
ord.customer_id, ord.id AS 'Order ID',
ordDtl.product_id AS 'Product ID',
prd.product_name
FROM northwind.customers AS cst
INNER JOIN northwind.orders AS ord
ON cst.id = ord.customer_id
INNER JOIN northwind.order_details AS ordDtl
ON ord.id = ordDtl.order_id
INNER JOIN northwind.products as prd
ON ordDtl.product_id = prd.id