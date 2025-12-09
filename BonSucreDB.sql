DROP DATABASE IF EXISTS BonSucre
GO

CREATE DATABASE BonSucre
GO

USE BonSucre
GO

-- Create Customers table
CREATE TABLE Customers (
    CustomerId INT PRIMARY KEY IDENTITY(1,1),
    Name varchar(100) NOT NULL,
    Email varchar(100) NOT NULL,
    DateOfBirth DATE NOT NULL
);

-- Create Desserts table
CREATE TABLE Desserts (
    DessertId INT PRIMARY KEY IDENTITY(1,1),
    Name varchar(100) NOT NULL,
    Price smallmoney NOT NULL,
    Category varchar(50) NOT NULL
);

-- Create Reviews table
CREATE TABLE Reviews (
    ReviewId INT PRIMARY KEY IDENTITY(1,1),
    CustomerId INT FOREIGN KEY REFERENCES Customers(CustomerId),
    DessertId INT FOREIGN KEY REFERENCES Desserts(DessertId),
    Score INT CHECK (Score >= 1 AND Score <= 5),
    Date DATE NOT NULL
);

-- Insert sample Customers
INSERT INTO Customers (Name, Email, DateOfBirth) VALUES
('Alice Johnson', 'alice.j@example.com', '2000-05-12'),
('Bob Smith', 'bob.smith@example.com', '1999-03-22'),
('Cathy Nguyen', 'cathy.nguyen@example.com', '2001-07-18'),
('David Chen', 'david.chen@example.com', '2002-09-10'),
('Emily Rivera', 'emily.r@example.com', '2000-01-30'),
('Frank O''Brien', 'frank.ob@example.com', '1998-12-15'),
('Grace Lee', 'grace.lee@example.com', '2001-06-01'),
('Henry Patel', 'henry.p@example.com', '1997-11-05'),
('Ivy Gonzalez', 'ivy.g@example.com', '2003-02-20'),
('Jake Thompson', 'jake.t@example.com', '1999-08-09');

-- Insert sample Desserts
INSERT INTO Desserts (Name, Price, Category) VALUES
('Chocolate Lava Cake', 4.99, 'Pastry'),
('Strawberry Shortcake', 5.50, 'Pastry'),
('Vanilla Ice Cream', 2.99, 'Ice Cream'),
('Mango Sorbet', 3.50, 'Ice Cream'),
('Peanut Butter Fudge', 3.25, 'Candy'),
('Lemon Tart', 4.25, 'Pastry'),
('Rocky Road Bar', 3.99, 'Candy'),
('Coconut Macaron', 2.75, 'Pastry'),
('Mint Chip Ice Cream', 3.10, 'Ice Cream'),
('Caramel Apple Pop', 2.50, 'Candy');

-- Insert sample Reviews
INSERT INTO Reviews (CustomerId, DessertId, Score, Date) VALUES
(1, 1, 5, '2025-04-01'),
(2, 3, 4, '2025-04-02'),
(3, 2, 3, '2025-04-03'),
(4, 5, 5, '2025-04-04'),
(5, 6, 4, '2025-04-05'),
(6, 7, 2, '2025-04-06'),
(7, 4, 5, '2025-04-07'),
(8, 8, 3, '2025-04-08'),
(9, 9, 4, '2025-04-09'),
(10, 10, 5, '2025-04-10');
