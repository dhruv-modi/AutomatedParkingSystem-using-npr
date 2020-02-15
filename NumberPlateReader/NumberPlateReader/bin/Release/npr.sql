-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Mar 30, 2019 at 04:10 AM
-- Server version: 5.7.23
-- PHP Version: 7.2.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `npr`
--

-- --------------------------------------------------------

--
-- Table structure for table `oldrecord`
--

DROP TABLE IF EXISTS `oldrecord`;
CREATE TABLE IF NOT EXISTS `oldrecord` (
  `vehicleno` varchar(8) DEFAULT NULL,
  `plotno` varchar(4) DEFAULT NULL,
  `vehiclein` datetime DEFAULT NULL,
  `vehicleout` datetime DEFAULT CURRENT_TIMESTAMP,
  `vip` int(1) DEFAULT '0'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `plotmaster`
--

DROP TABLE IF EXISTS `plotmaster`;
CREATE TABLE IF NOT EXISTS `plotmaster` (
  `plotno` varchar(4) NOT NULL,
  `counter` int(1) DEFAULT '0',
  `value` int(2) NOT NULL DEFAULT '1',
  PRIMARY KEY (`plotno`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `plotmaster`
--

INSERT INTO `plotmaster` (`plotno`, `counter`, `value`) VALUES
('P1', 1, 1),
('P2', 1, 3),
('P3', 1, 4),
('P4', 1, 5),
('P5', 1, 4),
('p6', 1, 5),
('p7', 1, 7);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `id` varchar(10) NOT NULL,
  `password` varchar(10) NOT NULL,
  `timein` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `password`, `timein`) VALUES
('user1', 'admin', '2019-03-29 15:43:50');

-- --------------------------------------------------------

--
-- Table structure for table `vehiclemaster`
--

DROP TABLE IF EXISTS `vehiclemaster`;
CREATE TABLE IF NOT EXISTS `vehiclemaster` (
  `vehicleno` varchar(9) NOT NULL,
  `plotno` varchar(4) DEFAULT NULL,
  `vehiclein` datetime DEFAULT CURRENT_TIMESTAMP,
  `vip` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`vehicleno`),
  KEY `plotno` (`plotno`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `vehiclemaster`
--

INSERT INTO `vehiclemaster` (`vehicleno`, `plotno`, `vehiclein`, `vip`) VALUES
('GJ1MV2312', 'P1', '2019-03-29 13:29:57', 0),
('GJ1MV1259', 'P2', '2019-03-29 14:58:59', 0),
('GJ1MV1VIP', 'P3', '2019-03-29 13:34:00', 1),
('GJ1MV1VIL', 'p7', '2019-03-29 13:49:51', 0),
('GJ1MV1VI0', 'P4', '2019-03-29 14:40:49', 0),
('GJ1MV1256', 'P2', '2019-03-29 15:00:00', 0),
('GJ1MV1253', 'P2', '2019-03-29 15:01:20', 0),
('GJ1MV1252', 'P2', '2019-03-29 15:02:29', 0),
('GJ1MV1278', 'P2', '2019-03-29 15:06:28', 0);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
