# POSTerminal

This project is a POS for entering orders with customers and products.

Here is the SQL setup - https://github.com/aryehbaker/POSTerminal/blob/master/POSTerminal/POS.sql

The main form allows entring products, customers and orders. The past orders entered are displayed on screen with customer name, status, amount order is worth, amount paid, order Id and can be selected for editing.

The order entry allows creation / editing of an order. When creating an order a customer is selected. Order status initially is set to  'new'. When paid up, the status can be set 'paid', then to 'ready', 'out for delivery', 'delivered' or 'canceled'

Products can be added and removed. Paid amounts can be entered with a date. Order can be deleted.
