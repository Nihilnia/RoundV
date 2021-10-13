SELECT * FROM northwind.order_details;

-- ORDER Products
SELECT ordDtl.id, ordDtl.order_id, ordDtl.product_id, COUNT(*) AS 'Piece', SUM(ordDtl.quantity) AS 'Total Order',
prd.product_name as 'Product', prd.product_code
FROM northwind.order_details AS ordDtl
INNER JOIN northwind.products AS prd
ON ordDtl.product_id = prd.id
GROUP BY ordDtl.product_id
ORDER BY SUM(ordDtl.quantity)

-- TOP 3 Earning
SELECT prd.id, prd.product_name,
SUM(ordDtl.quantity * ordDtl.unit_price) AS 'Earning'
FROM northwind.products AS prd
INNER JOIN northwind.order_details AS ordDtl
ON prd.id = ordDtl.product_id
GROUP BY prd.id
ORDER BY Earning DESC
LIMIT 3

-- SHIPPER PAYS
SELECT ord.id AS 'Order ID', ord.shipper_id, ord.ship_city, SUM(ord.shipping_fee) AS 'Total Shipping Fee', 
shp.id, shp.company
FROM northwind.orders AS ord
INNER JOIN northwind.shippers AS shp
ON ord.shipper_id = shp.id
GROUP BY ord.shipper_id
ORDER BY SUM(ord.shipping_fee) DESC

-- CHEAPER SHIPPER
SELECT ord.id AS 'Order ID', ord.shipper_id, ord.ship_city, COUNT(ord.shipper_id) AS 'Total Ship', AVG(ord.shipping_fee) AS 'Average', 
shp.id, shp.company
FROM northwind.orders AS ord
INNER JOIN northwind.shippers AS shp
ON ord.shipper_id = shp.id
WHERE ord.shipping_fee > 0
GROUP BY ord.shipper_id
HAVING COUNT(ord.shipper_id) > 10



SELECT emp.id, CONCAT(emp.first_name, ' ', emp.last_name) AS 'Employee',
ord.id AS 'Order ID', ord.employee_id as 'Employee ID', ord.ship_name
FROM northwind.orders AS ord
RIGHT JOIN northwind.employees as emp
ON ord.employee_id = emp.id