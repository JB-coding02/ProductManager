-- Drop the ProductManagerDb database if it exists.
DROP DATABASE IF EXISTS ProductManagerDb;
GO

-- Create a new ProductManagerDb database.
CREATE DATABASE ProductManagerDb;
GO

-- Switch to the newly created ProductManagerDb database.
USE ProductManagerDb;
GO

CREATE TABLE dbo.Products
(
    Id         INT              NOT NULL IDENTITY(1,1) PRIMARY KEY,
    SalesPrice DECIMAL(10,2)    NOT NULL CHECK (SalesPrice >= 0),
    Name       VARCHAR(200)     NOT NULL
);