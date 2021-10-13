SELECT * FROM northwind.customers

SELECT cst.id AS 'Customer ID', CONCAT(first_name, ' ', last_name) AS 'Customer', cst.company,
ord.customer_id AS 'OrderList_CustomerID', ord.id AS 'Order ID'
FROM northwind.orders AS ord
RIGHT JOIN northwind.customers AS cst
ON cst.id = ord.customer_id
WHERE ord.customer_id IS NULL