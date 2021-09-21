/*
SQLyog Ultimate v9.02 
MySQL - 5.5.5-10.4.20-MariaDB : Database - tienda
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`tienda` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;

USE `tienda`;

/*Table structure for table `datosproductos` */

DROP TABLE IF EXISTS `datosproductos`;

CREATE TABLE `datosproductos` (
  `codigo` varchar(20) NOT NULL,
  `nombre` varchar(30) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `precio_publico` decimal(10,0) DEFAULT NULL,
  `existencias` int(10) DEFAULT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `datosproductos` */

insert  into `datosproductos`(`codigo`,`nombre`,`descripcion`,`precio_publico`,`existencias`) values ('100','coca cola','coca cola 20l','1000',25),('101','sprite','sprite 1l','100',5),('102','fanta','fanta 2l','200',10),('103','paso de los toros','paso de los toros retornable','300',50);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
