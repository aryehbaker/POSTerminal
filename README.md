# POSTerminal

This project is a POS for entering orders with customers and products.

Her eis the SQL setup:

CREATE DATABASE POSdb;
GO
USE POSdb;
GO

CREATE TABLE Statuses (
 Id INT IDENTITY(1,1) PRIMARY KEY,
 Status VARCHAR(20)
);
GO
INSERT INTO Statuses (Status)
VALUES
('New'),
('Paid'),
('Ready'),
('Out for Delivery'),
('Delivered'),
('Canceled');
GO

CREATE TABLE Customers(
 Id INT IDENTITY(1,1) PRIMARY KEY,
 FirstName VARCHAR(50),
 LastName VARCHAR(50),
 Address VARCHAR(50),
 Phone VARCHAR(15) 
);
GO

CREATE TABLE Products (
 Id INT IDENTITY (1,1) PRIMARY KEY,
 Products VARCHAR(50),
 Quantity INT,
 Price DECIMAL(10,2)
);
GO




CREATE TABLE Orders(
 Id INT IDENTITY(1,1) PRIMARY KEY,
 CustomerId INT,
 Status INT,
 FOREIGN KEY (CustomerId) REFERENCES Customers (Id),
);
GO

CREATE TABLE Payments(
 Id INT IDENTITY(1,1) PRIMARY KEY,
 OrderId INT,
 Amount DECIMAL (10, 2),
 DateOfPayment DATE,
 FOREIGN KEY (OrderId) REFERENCES Orders(Id) ON DELETE CASCADE
);
GO

CREATE TABLE OrdersProducts(
 Id INT IDENTITY(1,1) PRIMARY KEY,
 OrderId INT,
 ProductId INT,
 FOREIGN KEY (OrderId) REFERENCES Orders(Id) ON DELETE CASCADE,
 FOREIGN KEY (ProductId) REFERENCES Products(Id)
);
GO
