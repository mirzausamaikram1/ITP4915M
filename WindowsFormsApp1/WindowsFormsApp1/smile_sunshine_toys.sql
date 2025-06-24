-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 11, 2025 at 11:22 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `smile_sunshine_toys`
--

-- --------------------------------------------------------

--
-- Table structure for table `categories`
--

CREATE TABLE `categories` (
  `CategoryID` int(11) NOT NULL,
  `CategoryName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `categories`
--

INSERT INTO `categories` (`CategoryID`, `CategoryName`) VALUES
(1, 'Action Figures'),
(2, 'Dolls'),
(5, 'Plush Toys'),
(4, 'Puzzles'),
(3, 'Vehicles');

-- --------------------------------------------------------

--
-- Table structure for table `deliverynotes`
--

CREATE TABLE `deliverynotes` (
  `DeliveryNoteID` int(11) NOT NULL,
  `ShipmentID` int(11) NOT NULL,
  `UserID` varchar(10) NOT NULL,
  `SalesOrderNo` varchar(50) NOT NULL,
  `EstimatedDeliveryDate` date NOT NULL,
  `Status` enum('Pending','Confirmed') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `deliverynotes`
--

INSERT INTO `deliverynotes` (`DeliveryNoteID`, `ShipmentID`, `UserID`, `SalesOrderNo`, `EstimatedDeliveryDate`, `Status`) VALUES
(1, 1, 'EMP014', 'SO001', '2025-06-06', 'Confirmed'),
(2, 2, 'EMP039', 'SO002', '2025-06-07', 'Pending'),
(3, 3, 'EMP014', 'SO003', '2025-06-08', 'Confirmed'),
(4, 4, 'EMP040', 'SO004', '2025-06-09', 'Pending'),
(5, 5, 'EMP039', 'SO005', '2025-06-10', 'Confirmed'),
(6, 6, 'EMP014', 'SO006', '2025-06-11', 'Pending'),
(7, 7, 'EMP041', 'SO007', '2025-06-12', 'Confirmed'),
(8, 8, 'EMP039', 'SO008', '2025-06-13', 'Pending'),
(9, 9, 'EMP040', 'SO009', '2025-06-14', 'Confirmed'),
(10, 10, 'EMP014', 'SO010', '2025-06-15', 'Pending'),
(11, 11, 'EMP039', 'SO011', '2025-06-16', 'Pending'),
(12, 12, 'EMP014', 'SO012', '2025-06-17', 'Confirmed'),
(13, 13, 'EMP040', 'SO013', '2025-06-18', 'Pending'),
(14, 14, 'EMP041', 'SO014', '2025-06-19', 'Confirmed'),
(15, 15, 'EMP039', 'SO015', '2025-06-20', 'Pending');

-- --------------------------------------------------------

--
-- Table structure for table `departments`
--

CREATE TABLE `departments` (
  `DepartmentID` int(11) NOT NULL,
  `DepartmentName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `departments`
--

INSERT INTO `departments` (`DepartmentID`, `DepartmentName`) VALUES
(7, 'Customer Service'),
(9, 'Dispatch'),
(4, 'Finance'),
(8, 'Inventory'),
(1, 'IT'),
(6, 'Logistics'),
(10, 'Procurement'),
(3, 'Production'),
(2, 'R&D'),
(5, 'Sales');

-- --------------------------------------------------------

--
-- Table structure for table `feedback`
--

CREATE TABLE `feedback` (
  `FeedbackID` int(11) NOT NULL,
  `UserID` varchar(10) NOT NULL,
  `Comments` text NOT NULL,
  `SubmittedDate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `feedback`
--

INSERT INTO `feedback` (`FeedbackID`, `UserID`, `Comments`, `SubmittedDate`) VALUES
(1, 'CUST001', 'Great service but product was damaged.', '2025-06-04 15:00:00'),
(2, 'CUST002', 'Fast delivery, happy with the toy!', '2025-06-05 10:00:00'),
(3, 'CUST003', 'Customer support was helpful.', '2025-06-06 05:49:00'),
(4, 'CUST004', 'Product arrived late.', '2025-06-06 05:50:00'),
(5, 'CUST005', 'Excellent quality, will order again.', '2025-06-06 05:51:00'),
(6, 'CUST006', 'Very satisfied with the purchase.', '2025-06-06 05:52:00'),
(7, 'CUST007', 'Toy broke after one day.', '2025-06-06 05:53:00'),
(8, 'CUST008', 'Delivery was on time, great experience.', '2025-06-06 05:54:00'),
(9, 'CUST009', 'Support team resolved my issue quickly.', '2025-06-06 05:55:00'),
(10, 'CUST010', 'Packaging could be better.', '2025-06-06 05:56:00'),
(11, 'CUST001', 'Quick response from support team.', '2025-06-06 06:07:00'),
(12, 'CUST002', 'Product quality is amazing!', '2025-06-06 06:08:00'),
(13, 'CUST003', 'Delivery took longer than expected.', '2025-06-06 06:09:00'),
(14, 'CUST004', 'Very happy with my purchase.', '2025-06-06 06:10:00'),
(15, 'CUST005', 'Toy arrived in perfect condition.', '2025-06-06 06:11:00');

-- --------------------------------------------------------

--
-- Table structure for table `inventory`
--

CREATE TABLE `inventory` (
  `InventoryID` int(11) NOT NULL,
  `ProductID` int(11) NOT NULL,
  `SupplierID` int(11) NOT NULL,
  `WarehouseLocation` varchar(50) NOT NULL,
  `QuantityReceived` int(11) NOT NULL,
  `DamagedItems` int(11) NOT NULL,
  `DateReceived` date NOT NULL,
  `Remarks` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `inventory`
--

INSERT INTO `inventory` (`InventoryID`, `ProductID`, `SupplierID`, `WarehouseLocation`, `QuantityReceived`, `DamagedItems`, `DateReceived`, `Remarks`) VALUES
(1, 1, 1, 'WH1', 100, 5, '2025-06-01', 'Batch received with minor damage'),
(2, 2, 2, 'WH2', 50, 0, '2025-06-02', 'All items in good condition'),
(3, 3, 1, 'WH1', 80, 2, '2025-06-03', 'Some scratches noted'),
(4, 4, 2, 'WH3', 60, 1, '2025-06-04', 'One item defective'),
(5, 5, 1, 'WH2', 70, 0, '2025-06-05', 'Perfect condition'),
(6, 6, 1, 'WH1', 90, 3, '2025-06-06', 'Minor packaging damage'),
(7, 7, 2, 'WH3', 40, 0, '2025-06-06', 'Good condition'),
(8, 8, 1, 'WH2', 75, 1, '2025-06-06', 'Slight defect noted'),
(9, 9, 2, 'WH1', 55, 0, '2025-06-06', 'All items intact'),
(10, 10, 3, 'WH3', 65, 2, '2025-06-06', 'Minor damage reported'),
(11, 11, 1, 'WH1', 85, 1, '2025-06-06', 'One item scratched'),
(12, 12, 2, 'WH2', 45, 0, '2025-06-06', 'All items in good condition'),
(13, 13, 1, 'WH3', 70, 2, '2025-06-06', 'Minor damage reported'),
(14, 14, 2, 'WH1', 50, 0, '2025-06-06', 'Perfect condition'),
(15, 15, 3, 'WH2', 60, 1, '2025-06-06', 'Slight defect noted');

-- --------------------------------------------------------

--
-- Table structure for table `orderdetails`
--

CREATE TABLE `orderdetails` (
  `OrderDetailID` int(11) NOT NULL,
  `OrderID` int(11) NOT NULL,
  `ProductID` int(11) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `UnitPrice` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `orderdetails`
--

INSERT INTO `orderdetails` (`OrderDetailID`, `OrderID`, `ProductID`, `Quantity`, `UnitPrice`) VALUES
(1, 1, 1, 2, 15.99),
(2, 2, 3, 1, 19.99),
(3, 3, 2, 3, 12.99),
(4, 4, 5, 2, 10.99),
(5, 5, 4, 1, 9.99),
(6, 6, 6, 2, 16.99),
(7, 7, 8, 1, 20.99),
(8, 8, 7, 3, 13.99),
(9, 9, 10, 2, 11.99),
(10, 10, 9, 1, 8.99),
(11, 11, 11, 2, 15.99),
(12, 12, 13, 1, 21.99),
(13, 13, 12, 3, 14.99),
(14, 14, 15, 2, 12.99),
(15, 15, 14, 1, 7.99);

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `OrderID` int(11) NOT NULL,
  `CustomerID` varchar(10) DEFAULT NULL,
  `OrderDate` datetime NOT NULL,
  `Status` enum('Pending','Confirmed','Dispatched','Delivered') NOT NULL,
  `TotalAmount` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`OrderID`, `CustomerID`, `OrderDate`, `Status`, `TotalAmount`) VALUES
(1, NULL, '2025-06-01 10:00:00', 'Pending', 31.98),
(2, 'CUST001', '2025-06-02 12:00:00', 'Confirmed', 19.99),
(3, 'CUST002', '2025-06-03 14:00:00', 'Dispatched', 45.97),
(4, 'CUST003', '2025-06-04 09:00:00', 'Delivered', 29.98),
(5, 'CUST004', '2025-06-05 11:00:00', 'Pending', 15.99),
(6, 'CUST005', '2025-06-06 05:49:00', 'Pending', 38.98),
(7, 'CUST006', '2025-06-06 05:50:00', 'Confirmed', 21.99),
(8, 'CUST007', '2025-06-06 05:51:00', 'Dispatched', 54.97),
(9, 'CUST008', '2025-06-06 05:52:00', 'Delivered', 27.98),
(10, 'CUST009', '2025-06-06 05:53:00', 'Pending', 17.99),
(11, 'CUST010', '2025-06-06 06:07:00', 'Pending', 33.98),
(12, NULL, '2025-06-06 06:08:00', 'Confirmed', 25.99),
(13, 'CUST001', '2025-06-06 06:09:00', 'Dispatched', 49.97),
(14, 'CUST002', '2025-06-06 06:10:00', 'Delivered', 31.98),
(15, 'CUST003', '2025-06-06 06:11:00', 'Pending', 19.99);

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `ProductID` int(11) NOT NULL,
  `ProductName` varchar(100) NOT NULL,
  `SupplierID` int(11) NOT NULL,
  `CategoryID` int(11) NOT NULL,
  `QuantityPerUnit` int(11) NOT NULL,
  `UnitPrice` decimal(10,2) NOT NULL,
  `UnitsInStock` int(11) NOT NULL,
  `UnitsOnOrder` int(11) NOT NULL,
  `ReorderLevel` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`ProductID`, `ProductName`, `SupplierID`, `CategoryID`, `QuantityPerUnit`, `UnitPrice`, `UnitsInStock`, `UnitsOnOrder`, `ReorderLevel`) VALUES
(1, 'Super Hero Figure', 1, 1, 10, 15.99, 100, 0, 20),
(2, 'Princess Doll', 2, 2, 5, 12.99, 50, 0, 10),
(3, 'Race Car', 1, 3, 8, 19.99, 80, 0, 15),
(4, 'Puzzle 100 Pieces', 2, 4, 1, 9.99, 60, 0, 10),
(5, 'Teddy Bear', 1, 5, 5, 10.99, 70, 0, 15),
(6, 'Robot Toy', 1, 1, 10, 16.99, 90, 0, 20),
(7, 'Baby Doll', 2, 2, 5, 13.99, 40, 0, 10),
(8, 'Toy Truck', 1, 3, 8, 20.99, 75, 0, 15),
(9, 'Jigsaw Puzzle', 2, 4, 1, 8.99, 55, 0, 10),
(10, 'Plush Elephant', 1, 5, 5, 11.99, 65, 0, 15),
(11, 'Space Ranger Figure', 1, 1, 10, 17.99, 85, 0, 20),
(12, 'Barbie Doll', 2, 2, 5, 14.99, 45, 0, 10),
(13, 'Fire Engine', 1, 3, 8, 21.99, 70, 0, 15),
(14, 'Brain Teaser Puzzle', 2, 4, 1, 7.99, 50, 0, 10),
(15, 'Stuffed Lion', 1, 5, 5, 12.99, 60, 0, 15),
(16, 'Super Villain Figure', 1, 1, 10, 16.49, 95, 0, 20),
(17, 'Fashion Doll', 2, 2, 5, 13.49, 35, 0, 10),
(18, 'Police Car', 1, 3, 8, 20.49, 65, 0, 15),
(19, '3D Puzzle', 2, 4, 1, 9.49, 45, 0, 10),
(20, 'Plush Tiger', 1, 5, 5, 11.49, 55, 0, 15),
(21, 'Hero Action Figure', 1, 1, 10, 15.49, 90, 0, 20),
(22, 'Doll House Set', 2, 2, 5, 12.49, 40, 0, 10),
(23, 'Dump Truck', 1, 3, 8, 19.49, 60, 0, 15),
(24, 'Wooden Puzzle', 2, 4, 1, 8.49, 50, 0, 10),
(25, 'Plush Panda', 1, 5, 5, 10.49, 70, 0, 15),
(26, 'Ninja Figure', 1, 1, 10, 17.49, 85, 0, 20),
(27, 'Bridal Doll', 2, 2, 5, 14.49, 45, 0, 10),
(28, 'Ambulance Toy', 1, 3, 8, 21.49, 75, 0, 15),
(29, 'Maze Puzzle', 2, 4, 1, 7.49, 55, 0, 10),
(30, 'Plush Monkey', 1, 5, 5, 11.99, 65, 0, 15),
(31, 'Warrior Figure', 1, 1, 10, 16.99, 80, 0, 20),
(32, 'Sports Doll', 2, 2, 5, 13.99, 50, 0, 10),
(33, 'Construction Vehicle', 1, 3, 8, 20.99, 70, 0, 15),
(34, 'Logic Puzzle', 2, 4, 1, 8.99, 60, 0, 10),
(35, 'Plush Giraffe', 1, 5, 5, 12.99, 55, 0, 15),
(36, 'Knight Figure', 3, 1, 10, 15.99, 90, 0, 20),
(37, 'Mermaid Doll', 4, 2, 5, 12.99, 40, 0, 10),
(38, 'Helicopter Toy', 3, 3, 8, 19.99, 70, 0, 15),
(39, 'Animal Puzzle', 4, 4, 1, 9.99, 50, 0, 10),
(40, 'Plush Zebra', 3, 5, 5, 10.99, 60, 0, 15);

-- --------------------------------------------------------

--
-- Table structure for table `servicerequests`
--

CREATE TABLE `servicerequests` (
  `RequestID` int(11) NOT NULL,
  `UserID` varchar(10) NOT NULL,
  `DepartmentID` int(11) NOT NULL,
  `Item` varchar(100) NOT NULL,
  `Status` enum('Pending','Completed') NOT NULL,
  `RequestDate` date NOT NULL,
  `Description` text NOT NULL,
  `DocsPath` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `servicerequests`
--

INSERT INTO `servicerequests` (`RequestID`, `UserID`, `DepartmentID`, `Item`, `Status`, `RequestDate`, `Description`, `DocsPath`) VALUES
(1, 'CUST001', 7, 'Teddy Bear', 'Pending', '2025-06-03', 'Defective stitching', '/docs/teddybear_issue.pdf'),
(2, 'CUST002', 8, 'Puzzle 100 Pieces', 'Pending', '2025-06-04', 'Missing pieces', '/docs/puzzle_issue.pdf'),
(3, 'CUST003', 7, 'Race Car', 'Completed', '2025-06-05', 'Broken wheel', '/docs/racecar_issue.pdf'),
(4, 'CUST004', 9, 'Princess Doll', 'Pending', '2025-06-05', 'Damaged packaging', '/docs/doll_issue.pdf'),
(5, 'CUST005', 8, 'Super Hero Figure', 'Completed', '2025-06-06', 'Color fade', '/docs/figure_issue.pdf'),
(6, 'CUST006', 7, 'Robot Toy', 'Pending', '2025-06-06', 'Not working', '/docs/robot_issue.pdf'),
(7, 'CUST007', 8, 'Barbie Doll', 'Completed', '2025-06-06', 'Missing accessory', '/docs/barbie_issue.pdf'),
(8, 'CUST008', 9, 'Fire Engine', 'Pending', '2025-06-06', 'Damaged box', '/docs/fireengine_issue.pdf'),
(9, 'CUST009', 7, 'Brain Teaser Puzzle', 'Pending', '2025-06-06', 'Incomplete set', '/docs/puzzle2_issue.pdf'),
(10, 'CUST010', 8, 'Stuffed Lion', 'Completed', '2025-06-06', 'Torn seam', '/docs/lion_issue.pdf'),
(11, 'CUST001', 7, 'Space Ranger Figure', 'Pending', '2025-06-06', 'Broken arm', '/docs/spaceranger_issue.pdf'),
(12, 'CUST002', 8, 'Fashion Doll', 'Completed', '2025-06-06', 'Missing dress', '/docs/fashiondoll_issue.pdf'),
(13, 'CUST003', 9, 'Police Car', 'Pending', '2025-06-06', 'Damaged packaging', '/docs/policecar_issue.pdf'),
(14, 'CUST004', 7, '3D Puzzle', 'Completed', '2025-06-06', 'Missing pieces', '/docs/3dpuzzle_issue.pdf'),
(15, 'CUST005', 8, 'Plush Tiger', 'Pending', '2025-06-06', 'Torn seam', '/docs/tiger_issue.pdf');

-- --------------------------------------------------------

--
-- Table structure for table `shipments`
--

CREATE TABLE `shipments` (
  `ShipmentID` int(11) NOT NULL,
  `OrderID` int(11) NOT NULL,
  `Carrier` varchar(50) NOT NULL,
  `DeliverySchedule` date NOT NULL,
  `WarehouseLocation` varchar(50) NOT NULL,
  `Status` varchar(50) NOT NULL,
  `CustomerNotes` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `shipments`
--

INSERT INTO `shipments` (`ShipmentID`, `OrderID`, `Carrier`, `DeliverySchedule`, `WarehouseLocation`, `Status`, `CustomerNotes`) VALUES
(1, 1, 'FedEx', '2025-06-06', 'WH1', 'Dispatched', 'Fragile items'),
(2, 2, 'DHL', '2025-06-07', 'WH2', 'On Track', 'Handle with care'),
(3, 3, 'UPS', '2025-06-08', 'WH1', 'Delivered', 'Delivered at 5 PM'),
(4, 4, 'FedEx', '2025-06-09', 'WH3', 'Received', 'Priority shipment'),
(5, 5, 'DHL', '2025-06-10', 'WH2', 'Dispatched', 'Check for damage'),
(6, 6, 'UPS', '2025-06-11', 'WH1', 'Pending', 'Awaiting dispatch'),
(7, 7, 'FedEx', '2025-06-12', 'WH3', 'On Track', 'Express delivery'),
(8, 8, 'DHL', '2025-06-13', 'WH2', 'Delivered', 'Signed by customer'),
(9, 9, 'UPS', '2025-06-14', 'WH1', 'Received', 'Standard shipment'),
(10, 10, 'FedEx', '2025-06-15', 'WH3', 'Dispatched', 'Handle with care'),
(11, 11, 'DHL', '2025-06-16', 'WH2', 'Pending', 'Fragile items'),
(12, 12, 'UPS', '2025-06-17', 'WH1', 'On Track', 'Express delivery'),
(13, 13, 'FedEx', '2025-06-18', 'WH3', 'Dispatched', 'Handle with care'),
(14, 14, 'DHL', '2025-06-19', 'WH2', 'Delivered', 'Signed by customer'),
(15, 15, 'UPS', '2025-06-20', 'WH1', 'Received', 'Standard shipment');

-- --------------------------------------------------------

--
-- Table structure for table `suppliers`
--

CREATE TABLE `suppliers` (
  `SupplierID` int(11) NOT NULL,
  `SupplierName` varchar(100) NOT NULL,
  `Contact` varchar(100) DEFAULT NULL,
  `Reliability` decimal(5,2) DEFAULT NULL,
  `CreatedDate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `suppliers`
--

INSERT INTO `suppliers` (`SupplierID`, `SupplierName`, `Contact`, `Reliability`, `CreatedDate`) VALUES
(1, 'ToyWorld Ltd.', 'John Doe', 85.50, '2025-01-01 09:00:00'),
(2, 'Playtime Inc.', 'Jane Smith', 90.00, '2025-01-02 09:00:00'),
(3, 'FunToys Co.', 'Mike Johnson', 88.00, '2025-01-03 09:00:00'),
(4, 'KidPlay Ltd.', 'Sarah Brown', 92.50, '2025-01-04 09:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `UserID` varchar(10) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `Role` enum('Admin','Manager','Staff','Customer') NOT NULL,
  `FirstName` varchar(50) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Phone` varchar(15) DEFAULT NULL,
  `DepartmentID` int(11) DEFAULT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `City` varchar(50) DEFAULT NULL,
  `State` varchar(50) DEFAULT NULL,
  `ZipCode` varchar(10) DEFAULT NULL,
  `CreatedDate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`UserID`, `Username`, `Password`, `Role`, `FirstName`, `LastName`, `Email`, `Phone`, `DepartmentID`, `Address`, `City`, `State`, `ZipCode`, `CreatedDate`) VALUES
('CUST001', 'cust001', 'Cust123', 'Customer', 'John', 'Doe', 'john.d@customer.com', '123-456-7950', NULL, '101 Cust St', 'Hong Kong', 'HK', '999137', '2025-03-02 09:00:00'),
('CUST002', 'cust002', 'Cust234', 'Customer', 'Jane', 'Smith', 'jane.s@customer.com', '123-456-7951', NULL, '202 Cust Ave', 'Hong Kong', 'HK', '999138', '2025-03-03 09:00:00'),
('CUST003', 'cust003', 'Cust345', 'Customer', 'Mike', 'Brown', 'mike.b@customer.com', '123-456-7952', NULL, '303 Cust Rd', 'Hong Kong', 'HK', '999139', '2025-03-04 09:00:00'),
('CUST004', 'cust004', 'Cust456', 'Customer', 'Sarah', 'Lee', 'sarah.l@customer.com', '123-456-7953', NULL, '404 Cust Ln', 'Hong Kong', 'HK', '999140', '2025-03-05 09:00:00'),
('CUST005', 'cust005', 'Cust567', 'Customer', 'Tom', 'Davis', 'tom.d@customer.com', '123-456-7954', NULL, '505 Cust Blvd', 'Hong Kong', 'HK', '999141', '2025-03-06 09:00:00'),
('CUST006', 'cust006', 'Cust678', 'Customer', 'Emma', 'Wilson', 'emma.w@customer.com', '123-456-7955', NULL, '606 Cust St', 'Hong Kong', 'HK', '999142', '2025-03-07 09:00:00'),
('CUST007', 'cust007', 'Cust789', 'Customer', 'Liam', 'Taylor', 'liam.t@customer.com', '123-456-7956', NULL, '707 Cust Ave', 'Hong Kong', 'HK', '999143', '2025-03-08 09:00:00'),
('CUST008', 'cust008', 'Cust890', 'Customer', 'Olivia', 'Moore', 'olivia.m@customer.com', '123-456-7957', NULL, '808 Cust Rd', 'Hong Kong', 'HK', '999144', '2025-03-09 09:00:00'),
('CUST009', 'cust009', 'Cust012', 'Customer', 'Noah', 'Harris', 'noah.h@customer.com', '123-456-7958', NULL, '909 Cust Ln', 'Hong Kong', 'HK', '999145', '2025-03-10 09:00:00'),
('CUST010', 'cust010', 'Cust123', 'Customer', 'Sophia', 'Clark', 'sophia.c@customer.com', '123-456-7959', NULL, '1010 Cust Blvd', 'Hong Kong', 'HK', '999146', '2025-03-11 09:00:00'),
('EMP001', 'EMP001', 'Admin123', 'Admin', 'Alice', 'Johnson', 'alice.j@smiletoys.com', '123-456-7890', 1, '123 Tech St', 'Hong Kong', 'HK', '999077', '2025-01-01 09:00:00'),
('EMP002', 'EMP002', 'Admin234', 'Admin', 'Bob', 'Smith', 'bob.s@smiletoys.com', '123-456-7891', 1, '456 Tech Ave', 'Hong Kong', 'HK', '999078', '2025-01-02 09:00:00'),
('EMP003', 'EMP003', 'Admin345', 'Admin', 'Charlie', 'Brown', 'charlie.b@smiletoys.com', '123-456-7892', 1, '789 IT Rd', 'Hong Kong', 'HK', '999079', '2025-01-03 09:00:00'),
('EMP004', 'EMP004', 'Admin456', 'Admin', 'David', 'Lee', 'david.l@smiletoys.com', '123-456-7893', 1, '101 IT Ln', 'Hong Kong', 'HK', '999080', '2025-01-04 09:00:00'),
('EMP005', 'EMP005', 'Admin567', 'Admin', 'Eve', 'Davis', 'eve.d@smiletoys.com', '123-456-7894', 1, '202 IT Blvd', 'Hong Kong', 'HK', '999081', '2025-01-05 09:00:00'),
('EMP006', 'EMP006', 'Manager123', 'Manager', 'Frank', 'Wilson', 'frank.w@smiletoys.com', '123-456-7895', 1, '303 IT St', 'Hong Kong', 'HK', '999082', '2025-01-06 09:00:00'),
('EMP007', 'EMP007', 'Manager234', 'Manager', 'Grace', 'Taylor', 'grace.t@smiletoys.com', '123-456-7896', 2, '404 R&D Ave', 'Hong Kong', 'HK', '999083', '2025-01-07 09:00:00'),
('EMP008', 'EMP008', 'Manager345', 'Manager', 'Hank', 'Moore', 'hank.m@smiletoys.com', '123-456-7897', 3, '505 Prod Rd', 'Hong Kong', 'HK', '999084', '2025-01-08 09:00:00'),
('EMP009', 'EMP009', 'Manager456', 'Manager', 'Ivy', 'Anderson', 'ivy.a@smiletoys.com', '123-456-7898', 4, '606 Fin Ln', 'Hong Kong', 'HK', '999085', '2025-01-09 09:00:00'),
('EMP010', 'EMP010', 'Manager567', 'Manager', 'Jack', 'Thomas', 'jack.t@smiletoys.com', '123-456-7899', 5, '707 Sales Blvd', 'Hong Kong', 'HK', '999086', '2025-01-10 09:00:00'),
('EMP011', 'EMP011', 'Manager678', 'Manager', 'Kelly', 'Jackson', 'kelly.j@smiletoys.com', '123-456-7900', 6, '808 Log St', 'Hong Kong', 'HK', '999087', '2025-01-11 09:00:00'),
('EMP012', 'EMP012', 'Manager789', 'Manager', 'Liam', 'White', 'liam.w@smiletoys.com', '123-456-7901', 7, '909 CS Ave', 'Hong Kong', 'HK', '999088', '2025-01-12 09:00:00'),
('EMP013', 'EMP013', 'Manager890', 'Manager', 'Mia', 'Harris', 'mia.h@smiletoys.com', '123-456-7902', 8, '1010 Inv Rd', 'Hong Kong', 'HK', '999089', '2025-01-13 09:00:00'),
('EMP014', 'EMP014', 'Manager012', 'Manager', 'Noah', 'Martin', 'noah.m@smiletoys.com', '123-456-7903', 9, '1111 Disp Ln', 'Hong Kong', 'HK', '999090', '2025-01-14 09:00:00'),
('EMP015', 'EMP015', 'Manager123', 'Manager', 'Olivia', 'Clark', 'olivia.c@smiletoys.com', '123-456-7904', 10, '1212 Proc Blvd', 'Hong Kong', 'HK', '999091', '2025-01-15 09:00:00'),
('EMP016', 'EMP016', 'Staff123', 'Staff', 'Peter', 'Lewis', 'peter.l@smiletoys.com', '123-456-7905', 1, '1313 IT St', 'Hong Kong', 'HK', '999092', '2025-01-16 09:00:00'),
('EMP017', 'EMP017', 'Staff234', 'Staff', 'Quinn', 'Walker', 'quinn.w@smiletoys.com', '123-456-7906', 1, '1414 IT Ave', 'Hong Kong', 'HK', '999093', '2025-01-17 09:00:00'),
('EMP018', 'EMP018', 'Staff345', 'Staff', 'Rose', 'Hall', 'rose.h@smiletoys.com', '123-456-7907', 2, '1515 R&D Rd', 'Hong Kong', 'HK', '999094', '2025-01-18 09:00:00'),
('EMP019', 'EMP019', 'Staff456', 'Staff', 'Sam', 'Allen', 'sam.a@smiletoys.com', '123-456-7908', 2, '1616 R&D Ln', 'Hong Kong', 'HK', '999095', '2025-01-19 09:00:00'),
('EMP020', 'EMP020', 'Staff567', 'Staff', 'Tina', 'Young', 'tina.y@smiletoys.com', '123-456-7909', 2, '1717 R&D Blvd', 'Hong Kong', 'HK', '999096', '2025-01-20 09:00:00'),
('EMP021', 'EMP021', 'Staff678', 'Staff', 'Uma', 'King', 'uma.k@smiletoys.com', '123-456-7910', 3, '1818 Prod St', 'Hong Kong', 'HK', '999097', '2025-01-21 09:00:00'),
('EMP022', 'EMP022', 'Staff789', 'Staff', 'Victor', 'Scott', 'victor.s@smiletoys.com', '123-456-7911', 3, '1919 Prod Ave', 'Hong Kong', 'HK', '999098', '2025-01-22 09:00:00'),
('EMP023', 'EMP023', 'Staff890', 'Staff', 'Wendy', 'Green', 'wendy.g@smiletoys.com', '123-456-7912', 3, '2020 Prod Rd', 'Hong Kong', 'HK', '999099', '2025-01-23 09:00:00'),
('EMP024', 'EMP024', 'Staff012', 'Staff', 'Xander', 'Adams', 'xanderr.a@smiletoys.com', '123-456-7913', 4, '2121 Fin Ln', 'Hong Kong', 'HK', '999100', '2025-01-24 09:00:00'),
('EMP025', 'EMP025', 'Staff123', 'Staff', 'Yara', 'Baker', 'yara.b@smiletoys.com', '123-456-7914', 4, '2222 Fin Blvd', 'Hong Kong', 'HK', '999101', '2025-01-25 09:00:00'),
('EMP026', 'EMP026', 'Staff234', 'Staff', 'Zane', 'Carter', 'zane.c@smiletoys.com', '123-456-7915', 4, '2323 Fin St', 'Hong Kong', 'HK', '999102', '2025-01-26 09:00:00'),
('EMP027', 'EMP027', 'Staff345', 'Staff', 'Abby', 'Davis', 'abby.d@smiletoys.com', '123-456-7916', 5, '2424 Sales Ave', 'Hong Kong', 'HK', '999103', '2025-01-27 09:00:00'),
('EMP028', 'EMP028', 'Staff456', 'Staff', 'Ben', 'Evans', 'benn.e@smiletoys.com', '123-456-7917', 5, '2525 Sales Rd', 'Hong Kong', 'HK', '999104', '2025-01-28 09:00:00'),
('EMP029', 'EMP029', 'Staff567', 'Staff', 'Clara', 'Fisher', 'claraa.f@smiletoys.com', '123-456-7918', 5, '2626 Sales Ln', 'Hong Kong', 'HK', '999105', '2025-01-29 09:00:00'),
('EMP030', 'EMP030', 'Staff678', 'Staff', 'Dan', 'Gray', 'dana.g@smiletoys.com', '123-456-7919', 6, '2727 Log St', 'Hong Kong', 'HK', '999106', '2025-01-30 09:00:00'),
('EMP031', 'EMP031', 'Staff789', 'Staff', 'Emma', 'Hill', 'emmaa.h@smiletoys.com', '123-456-7920', 6, '2828 Log Ave', 'Hong Kong', 'HK', '999107', '2025-01-31 09:00:00'),
('EMP032', 'EMP032', 'Staff890', 'Staff', 'Fred', 'Ives', 'fredd.i@smiletoys.com', '123-456-7921', 6, '2929 Log Rd', 'Hong Kong', 'HK', '999108', '2025-02-01 09:00:00'),
('EMP033', 'EMP033', 'Staff012', 'Staff', 'Gina', 'James', 'ginaa.j@smiletoys.com', '123-456-7922', 7, '3030 CS Ln', 'Hong Kong', 'HK', '999109', '2025-02-02 09:00:00'),
('EMP034', 'EMP034', 'Staff123', 'Staff', 'Harry', 'King', 'harry.k@smiletoys.com', '123-456-7923', 7, '3131 CS Blvd', 'Hong Kong', 'HK', '999110', '2025-02-03 09:00:00'),
('EMP035', 'EMP035', 'Staff234', 'Staff', 'Iris', 'Lane', 'iris.l@smiletoys.com', '123-456-7924', 7, '3232 CS St', 'Hong Kong', 'HK', '999111', '2025-02-04 09:00:00'),
('EMP036', 'EMP036', 'Staff345', 'Staff', 'Jack', 'Morris', 'jack.m@smiletoys.com', '123-456-7925', 8, '3333 Inv Ave', 'Hong Kong', 'HK', '999112', '2025-02-05 09:00:00'),
('EMP037', 'EMP037', 'Staff456', 'Staff', 'Kate', 'Nelson', 'kate.n@smiletoys.com', '123-456-7926', 8, '3434 Inv Rd', 'Hong Kong', 'HK', '999113', '2025-02-06 09:00:00'),
('EMP038', 'EMP038', 'Staff567', 'Staff', 'Leo', 'Owen', 'leo.o@smiletoys.com', '123-456-7927', 8, '3535 Inv Ln', 'Hong Kong', 'HK', '999114', '2025-02-07 09:00:00'),
('EMP039', 'EMP039', 'Staff678', 'Staff', 'Mae', 'Parks', 'mae.p@smiletoys.com', '123-456-7928', 9, '3636 Disp Blvd', 'Hong Kong', 'HK', '999115', '2025-02-08 09:00:00'),
('EMP040', 'EMP040', 'Staff789', 'Staff', 'Nick', 'Quinn', 'nick.q@smiletoys.com', '123-456-7929', 9, '3737 Disp St', 'Hong Kong', 'HK', '999116', '2025-02-09 09:00:00'),
('EMP041', 'EMP041', 'Staff890', 'Staff', 'Olivia', 'Reed', 'olivia.r@smiletoys.com', '123-456-7930', 9, '3838 Disp Ave', 'Hong Kong', 'HK', '999117', '2025-02-10 09:00:00'),
('EMP042', 'EMP042', 'Staff012', 'Staff', 'Paul', 'Stone', 'paul.s@smiletoys.com', '123-456-7931', 10, '3939 Proc Rd', 'Hong Kong', 'HK', '999118', '2025-02-11 09:00:00'),
('EMP043', 'EMP043', 'Staff123', 'Staff', 'Quincy', 'Tate', 'quincy.t@smiletoys.com', '123-456-7932', 10, '4040 Proc Ln', 'Hong Kong', 'HK', '999119', '2025-02-12 09:00:00'),
('EMP044', 'EMP044', 'Staff234', 'Staff', 'Rose', 'Upton', 'rose.u@smiletoys.com', '123-456-7933', 1, '4141 IT St', 'Hong Kong', 'HK', '999120', '2025-02-13 09:00:00'),
('EMP045', 'EMP045', 'Staff345', 'Staff', 'Sam', 'Vance', 'sam.v@smiletoys.com', '123-456-7934', 2, '4242 R&D Ave', 'Hong Kong', 'HK', '999121', '2025-02-14 09:00:00'),
('EMP046', 'EMP046', 'Staff456', 'Staff', 'Tina', 'West', 'tina.w@smiletoys.com', '123-456-7935', 3, '4343 Prod Rd', 'Hong Kong', 'HK', '999122', '2025-02-15 09:00:00'),
('EMP047', 'EMP047', 'Staff567', 'Staff', 'Uma', 'Xavier', 'uma.x@smiletoys.com', '123-456-7936', 4, '4444 Fin Ln', 'Hong Kong', 'HK', '999123', '2025-02-16 09:00:00'),
('EMP048', 'EMP048', 'Staff678', 'Staff', 'Victor', 'Young', 'victor.y@smiletoys.com', '123-456-7937', 5, '4545 Sales Blvd', 'Hong Kong', 'HK', '999124', '2025-02-17 09:00:00'),
('EMP049', 'EMP049', 'Staff789', 'Staff', 'Wendy', 'Zane', 'wendy.z@smiletoys.com', '123-456-7938', 6, '4646 Log St', 'Hong Kong', 'HK', '999125', '2025-02-18 09:00:00'),
('EMP050', 'EMP050', 'Staff890', 'Staff', 'Xander', 'Adams', 'xander.a@smiletoys.com', '123-456-7939', 7, '4747 CS Ave', 'Hong Kong', 'HK', '999126', '2025-02-19 09:00:00'),
('EMP051', 'EMP051', 'Staff012', 'Staff', 'Yara', 'Baker', 'yarra.b@smiletoys.com', '123-456-7940', 8, '4848 Inv Rd', 'Hong Kong', 'HK', '999127', '2025-02-20 09:00:00'),
('EMP052', 'EMP052', 'Staff123', 'Staff', 'Zane', 'Carter', 'zan.c@smiletoys.com', '123-456-7941', 9, '4949 Disp Ln', 'Hong Kong', 'HK', '999128', '2025-02-21 09:00:00'),
('EMP053', 'EMP053', 'Staff234', 'Staff', 'Abby', 'Davis', 'abbyy.d@smiletoys.com', '123-456-7942', 10, '5050 Proc Blvd', 'Hong Kong', 'HK', '999129', '2025-02-22 09:00:00'),
('EMP054', 'EMP054', 'Staff345', 'Staff', 'Ben', 'Evans', 'ben.e@smiletoys.com', '123-456-7943', 1, '5151 IT St', 'Hong Kong', 'HK', '999130', '2025-02-23 09:00:00'),
('EMP055', 'EMP055', 'Staff456', 'Staff', 'Clara', 'Fisher', 'clara.f@smiletoys.com', '123-456-7944', 2, '5252 R&D Ave', 'Hong Kong', 'HK', '999131', '2025-02-24 09:00:00'),
('EMP056', 'EMP056', 'Staff567', 'Staff', 'Dan', 'Gray', 'dan.g@smiletoys.com', '123-456-7945', 3, '5353 Prod Rd', 'Hong Kong', 'HK', '999132', '2025-02-25 09:00:00'),
('EMP057', 'EMP057', 'Staff678', 'Staff', 'Emma', 'Hill', 'emma.h@smiletoys.com', '123-456-7946', 4, '5454 Fin Ln', 'Hong Kong', 'HK', '999133', '2025-02-26 09:00:00'),
('EMP058', 'EMP058', 'Staff789', 'Staff', 'Fred', 'Ives', 'fred.i@smiletoys.com', '123-456-7947', 5, '5555 Sales Blvd', 'Hong Kong', 'HK', '999134', '2025-02-27 09:00:00'),
('EMP059', 'EMP059', 'Staff890', 'Staff', 'Gina', 'James', 'gina.j@smiletoys.com', '123-456-7948', 6, '5656 Log St', 'Hong Kong', 'HK', '999135', '2025-02-28 09:00:00'),
('EMP060', 'EMP060', 'Staff012', 'Staff', 'Harry', 'King', 'harrry.k@smiletoys.com', '123-456-7949', 7, '5757 CS Ave', 'Hong Kong', 'HK', '999136', '2025-03-01 09:00:00');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`CategoryID`),
  ADD UNIQUE KEY `CategoryName` (`CategoryName`);

--
-- Indexes for table `deliverynotes`
--
ALTER TABLE `deliverynotes`
  ADD PRIMARY KEY (`DeliveryNoteID`),
  ADD KEY `ShipmentID` (`ShipmentID`),
  ADD KEY `UserID` (`UserID`);

--
-- Indexes for table `departments`
--
ALTER TABLE `departments`
  ADD PRIMARY KEY (`DepartmentID`),
  ADD UNIQUE KEY `DepartmentName` (`DepartmentName`);

--
-- Indexes for table `feedback`
--
ALTER TABLE `feedback`
  ADD PRIMARY KEY (`FeedbackID`),
  ADD KEY `UserID` (`UserID`);

--
-- Indexes for table `inventory`
--
ALTER TABLE `inventory`
  ADD PRIMARY KEY (`InventoryID`),
  ADD KEY `ProductID` (`ProductID`),
  ADD KEY `SupplierID` (`SupplierID`);

--
-- Indexes for table `orderdetails`
--
ALTER TABLE `orderdetails`
  ADD PRIMARY KEY (`OrderDetailID`),
  ADD KEY `OrderID` (`OrderID`),
  ADD KEY `ProductID` (`ProductID`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`OrderID`),
  ADD KEY `CustomerID` (`CustomerID`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`ProductID`),
  ADD UNIQUE KEY `ProductName` (`ProductName`),
  ADD KEY `SupplierID` (`SupplierID`),
  ADD KEY `CategoryID` (`CategoryID`);

--
-- Indexes for table `servicerequests`
--
ALTER TABLE `servicerequests`
  ADD PRIMARY KEY (`RequestID`),
  ADD KEY `UserID` (`UserID`),
  ADD KEY `DepartmentID` (`DepartmentID`);

--
-- Indexes for table `shipments`
--
ALTER TABLE `shipments`
  ADD PRIMARY KEY (`ShipmentID`),
  ADD KEY `OrderID` (`OrderID`);

--
-- Indexes for table `suppliers`
--
ALTER TABLE `suppliers`
  ADD PRIMARY KEY (`SupplierID`),
  ADD UNIQUE KEY `SupplierName` (`SupplierName`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`UserID`),
  ADD UNIQUE KEY `Username` (`Username`),
  ADD UNIQUE KEY `Email` (`Email`),
  ADD KEY `DepartmentID` (`DepartmentID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `categories`
--
ALTER TABLE `categories`
  MODIFY `CategoryID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `deliverynotes`
--
ALTER TABLE `deliverynotes`
  MODIFY `DeliveryNoteID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `departments`
--
ALTER TABLE `departments`
  MODIFY `DepartmentID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `feedback`
--
ALTER TABLE `feedback`
  MODIFY `FeedbackID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `inventory`
--
ALTER TABLE `inventory`
  MODIFY `InventoryID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `orderdetails`
--
ALTER TABLE `orderdetails`
  MODIFY `OrderDetailID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `OrderID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `ProductID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=41;

--
-- AUTO_INCREMENT for table `servicerequests`
--
ALTER TABLE `servicerequests`
  MODIFY `RequestID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `shipments`
--
ALTER TABLE `shipments`
  MODIFY `ShipmentID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `suppliers`
--
ALTER TABLE `suppliers`
  MODIFY `SupplierID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `deliverynotes`
--
ALTER TABLE `deliverynotes`
  ADD CONSTRAINT `deliverynotes_ibfk_1` FOREIGN KEY (`ShipmentID`) REFERENCES `shipments` (`ShipmentID`),
  ADD CONSTRAINT `deliverynotes_ibfk_2` FOREIGN KEY (`UserID`) REFERENCES `users` (`UserID`);

--
-- Constraints for table `feedback`
--
ALTER TABLE `feedback`
  ADD CONSTRAINT `feedback_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `users` (`UserID`);

--
-- Constraints for table `inventory`
--
ALTER TABLE `inventory`
  ADD CONSTRAINT `inventory_ibfk_1` FOREIGN KEY (`ProductID`) REFERENCES `products` (`ProductID`),
  ADD CONSTRAINT `inventory_ibfk_2` FOREIGN KEY (`SupplierID`) REFERENCES `suppliers` (`SupplierID`);

--
-- Constraints for table `orderdetails`
--
ALTER TABLE `orderdetails`
  ADD CONSTRAINT `orderdetails_ibfk_1` FOREIGN KEY (`OrderID`) REFERENCES `orders` (`OrderID`),
  ADD CONSTRAINT `orderdetails_ibfk_2` FOREIGN KEY (`ProductID`) REFERENCES `products` (`ProductID`);

--
-- Constraints for table `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`CustomerID`) REFERENCES `users` (`UserID`);

--
-- Constraints for table `products`
--
ALTER TABLE `products`
  ADD CONSTRAINT `products_ibfk_1` FOREIGN KEY (`SupplierID`) REFERENCES `suppliers` (`SupplierID`),
  ADD CONSTRAINT `products_ibfk_2` FOREIGN KEY (`CategoryID`) REFERENCES `categories` (`CategoryID`);

--
-- Constraints for table `servicerequests`
--
ALTER TABLE `servicerequests`
  ADD CONSTRAINT `servicerequests_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `users` (`UserID`),
  ADD CONSTRAINT `servicerequests_ibfk_2` FOREIGN KEY (`DepartmentID`) REFERENCES `departments` (`DepartmentID`);

--
-- Constraints for table `shipments`
--
ALTER TABLE `shipments`
  ADD CONSTRAINT `shipments_ibfk_1` FOREIGN KEY (`OrderID`) REFERENCES `orders` (`OrderID`);

--
-- Constraints for table `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `users_ibfk_1` FOREIGN KEY (`DepartmentID`) REFERENCES `departments` (`DepartmentID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
