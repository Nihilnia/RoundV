SELECT order_id, product_id, unit_price, product_name, product_code, count(product_name) FROM northwind.order_details as detailZ
INNER JOIN northwind.products as productZ
ON detailZ.product_id = productZ.id GROUP BY product_name ORDER BY count(product_name) DESC