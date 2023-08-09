DROP DATABASE QuanLyQuanNet;
-- Create database QuanLyQuanNet
CREATE DATABASE QuanLyQuanNet;
GO

-- Use database QuanLyQuanNet
USE QuanLyQuanNet;
GO

-- Create table account
CREATE TABLE account (
  id INT PRIMARY KEY IDENTITY(1, 1),
  username VARCHAR(50) NOT NULL,
  password VARCHAR(100) NOT NULL,
  role INT NOT NULL DEFAULT 0 -- 0: staff, 1: admin  
);

-- Create table computer
CREATE TABLE computer (
  id INT PRIMARY KEY IDENTITY(1, 1),
  computer_name VARCHAR(50) NOT NULL,
  status VARCHAR(50) NOT NULL DEFAULT 'inactive'
);

-- Create table food_service
CREATE TABLE food_service (
  id INT PRIMARY KEY IDENTITY(1, 1),
  service_name VARCHAR(100) NOT NULL,
  price Int NOT NULL,
  image VARCHAR(250)
);

-- Create table payment_history
CREATE TABLE payment_history (
  id INT PRIMARY KEY IDENTITY(1, 1),
  payment_date DATETIME NOT NULL,
  account_id INT NOT NULL,
  computer_id INT NOT NULL,
  service_id INT NOT NULL,
  quantity INT NOT NULL,
  total_amount DECIMAL(10, 2) NOT NULL,
  FOREIGN KEY (account_id) REFERENCES account(id),
  FOREIGN KEY (computer_id) REFERENCES computer(id),
  FOREIGN KEY (service_id) REFERENCES food_service(id)
);

-- Create table Order
CREATE TABLE [Order] (
  id INT PRIMARY KEY IDENTITY(1, 1),
  computer_id INT NOT NULL,
  service_id INT NOT NULL,
  order_date DATETIME NOT NULL,
  quantity INT NOT NULL,
  total_amount DECIMAL(10, 2) NOT NULL,
  FOREIGN KEY (computer_id) REFERENCES computer(id),
  FOREIGN KEY (service_id) REFERENCES food_service(id)
);
