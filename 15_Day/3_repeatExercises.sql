-- Hangi ürün kaç sipariş aldı.

SELECT ordDtl.product_id, SUM(ordDtl.quantity) AS 'Total Order',
prd.product_name, prd.id, prd.product_code
FROM northwind.order_details AS ordDtl
INNER JOIN northwind.products AS prd
ON ordDtl.product_id = prd.id
GROUP BY ordDtl.product_id
ORDER BY SUM(ordDtl.quantity)


-- En cok kazandıran ilk üc ürün

SELECT ordDtl.product_id, SUM(ordDtl.quantity * ordDtl.unit_price) AS 'Total Fee',
prd.product_name, prd.id, prd.product_code
FROM northwind.order_details AS ordDtl
INNER JOIN northwind.products AS prd
ON ordDtl.product_id = prd.id
GROUP BY prd.product_name
ORDER BY SUM(ordDtl.quantity * ordDtl.unit_price) DESC
LIMIT 3

-- Hangi kargo şirketine ne kadar ödeme yapıldı?

SELECT ord.shipper_id, SUM(ord.shipping_fee),
shp.company
FROM northwind.orders AS ord
INNER JOIN northwind.shippers AS shp
ON ord.shipper_id = shp.id
GROUP BY ord.shipper_id


-- En uygun fiyatlı kargo şirketi?

SELECT ord.shipper_id, shp.company, SUM(ord.shipping_fee) / COUNT(ord.shipper_id) AS 'Average'
FROM northwind.shippers AS shp
INNER JOIN northwind.orders AS ord
ON ord.shipper_id = shp.id
WHERE ord.shipping_fee > 0
GROUP BY shp.id
HAVING COUNT(ord.shipper_id) > 10

