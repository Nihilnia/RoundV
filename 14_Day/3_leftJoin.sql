SELECT prd.id AS 'Product ID', prd.product_name,
ordDtl.order_id 'Order ID', ordDtl.product_id
FROM northwind.products AS prd
LEFT JOIN northwind.order_details as ordDtl
ON prd.id = ordDtl.product_id
WHERE ordDtl.order_id IS NULL