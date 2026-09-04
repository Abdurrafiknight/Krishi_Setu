-- ============================================
-- Krishi Setu PRO - Database Schema
-- Separate database from the original KrishiSetuDB.
-- Run this entire script in SSMS (New Query window).
-- Safe to re-run: drops existing objects first.
-- ============================================

IF EXISTS (SELECT name FROM sys.databases WHERE name = 'KrishiSetuProDB')
BEGIN
    ALTER DATABASE KrishiSetuProDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE KrishiSetuProDB;
END
GO

CREATE DATABASE KrishiSetuProDB;
GO

USE KrishiSetuProDB;
GO

-- Users table (Farmers, Buyers, Admin)
CREATE TABLE Users (
    UserId INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(100) NOT NULL,
    UserType NVARCHAR(20) NOT NULL CHECK (UserType IN ('Farmer','Buyer','Admin')),
    FullName NVARCHAR(100) NULL,
    Phone NVARCHAR(20) NULL,
    CreatedDate DATETIME DEFAULT GETDATE()
);
GO

-- Products table
CREATE TABLE Products (
    ProductId INT IDENTITY(1,1) PRIMARY KEY,
    ProductName NVARCHAR(100) NOT NULL,
    Quantity DECIMAL(10,2) NOT NULL CHECK (Quantity >= 0),
    Price DECIMAL(10,2) NOT NULL CHECK (Price >= 0),
    FarmerId INT NOT NULL,
    CreatedDate DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_Products_Farmer FOREIGN KEY (FarmerId) REFERENCES Users(UserId)
);
GO

-- PromoCodes table
CREATE TABLE PromoCodes (
    PromoId INT IDENTITY(1,1) PRIMARY KEY,
    Code NVARCHAR(20) NOT NULL UNIQUE,
    DiscountPercent DECIMAL(5,2) NOT NULL CHECK (DiscountPercent BETWEEN 0 AND 100),
    IsActive BIT DEFAULT 1,
    ExpiryDate DATETIME NULL,
    CreatedDate DATETIME DEFAULT GETDATE()
);
GO

-- Transactions table
CREATE TABLE Transactions (
    TransactionId INT IDENTITY(1,1) PRIMARY KEY,
    ProductId INT NOT NULL,
    BuyerId INT NOT NULL,
    FarmerId INT NOT NULL,
    Quantity DECIMAL(10,2) NOT NULL,
    GrossAmount DECIMAL(10,2) NOT NULL,
    Discount DECIMAL(10,2) DEFAULT 0,
    FinalAmount DECIMAL(10,2) NOT NULL,
    AdminCommission DECIMAL(10,2) NOT NULL,
    PromoCode NVARCHAR(20) NULL,
    TransactionDate DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_Trans_Product FOREIGN KEY (ProductId) REFERENCES Products(ProductId),
    CONSTRAINT FK_Trans_Buyer FOREIGN KEY (BuyerId) REFERENCES Users(UserId),
    CONSTRAINT FK_Trans_Farmer FOREIGN KEY (FarmerId) REFERENCES Users(UserId)
);
GO

-- Reviews table (buyers rate farmers they've purchased from)
CREATE TABLE Reviews (
    ReviewId INT IDENTITY(1,1) PRIMARY KEY,
    FarmerId INT NOT NULL,
    BuyerId INT NOT NULL,
    Rating INT NOT NULL CHECK (Rating BETWEEN 1 AND 5),
    Comment NVARCHAR(300) NULL,
    ReviewDate DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_Reviews_Farmer FOREIGN KEY (FarmerId) REFERENCES Users(UserId),
    CONSTRAINT FK_Reviews_Buyer FOREIGN KEY (BuyerId) REFERENCES Users(UserId)
);
GO

-- Seed one Admin account
INSERT INTO Users (Username, Password, UserType, FullName)
VALUES ('admin', 'admin123', 'Admin', 'Super Admin');
GO

-- Seed a sample promo code
INSERT INTO PromoCodes (Code, DiscountPercent, IsActive, ExpiryDate)
VALUES ('KRISHI10', 10.00, 1, DATEADD(YEAR, 1, GETDATE()));
GO
