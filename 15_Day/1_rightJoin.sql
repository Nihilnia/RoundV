SELECT * FROM northwind.employees

SELECT * FROM northwind.orders

SELECT emp.id, CONCAT(emp.first_name, ' ', emp.last_name) AS 'Employee',
ord.id AS 'Order ID', ord.employee_id as 'Employee ID', ord.ship_name
FROM northwind.orders AS ord
RIGHT JOIN northwind.employees as emp
ON ord.employee_id = emp.id
