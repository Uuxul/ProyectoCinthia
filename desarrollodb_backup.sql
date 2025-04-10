-- MySQL dump 10.13  Distrib 8.0.35, for Win64 (x86_64)
--
-- Host: localhost    Database: desarrollodb
-- ------------------------------------------------------
-- Server version	8.0.35

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `herramientas`
--

DROP TABLE IF EXISTS `herramientas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `herramientas` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  `cantidad` int NOT NULL,
  `descripcion` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `herramientas`
--

LOCK TABLES `herramientas` WRITE;
/*!40000 ALTER TABLE `herramientas` DISABLE KEYS */;
INSERT INTO `herramientas` VALUES (1,'Pala',30,'Pala de acero inoxidable de la marca Golden, mango de madera de 1.2 metros\r\nme pica la vrg'),(2,'Azadón',15,'Azadón manual tipo profesional con hoja de acero al carbono y mango de madera de 1 metro.'),(3,'Rastrillo',12,'Rastrillo de acero inoxidable de 16 dientes con mango ergonómico de 1.5 metros.'),(4,'Machete',30,'Machete de acero de alta resistencia, hoja de 50 cm, mango de plástico antideslizante.'),(5,'Carretilla',10,'Carretilla de 100 litros, estructura de acero, neumáticos de goma resistentes.'),(6,'Tijeras de podar',18,'Tijeras de podar tipo Bypass, hoja de acero inoxidable de 20 cm y mango de aluminio.'),(7,'Pulverizador',8,'Pulverizador manual de 5 litros, boquilla ajustable, pistón de alta presión.'),(8,'Guantes de trabajo',25,'Guantes de trabajo de nitrilo, resistencia a abrasiones, talla L.'),(9,'Cuchillo apicultor',14,'Cuchillo apicultor modelo BeeMaster, hoja de acero inoxidable de 20 cm, mango ergonómico.'),(10,'Cepillo para abejas',10,'Cepillo suave para apicultura, cerdas de nylon, mango de madera.'),(11,'Ahumador',7,'Ahumador profesional para apicultura, 25 cm de alto, acero inoxidable, con válvula regulable.'),(12,'Extractor de miel',5,'Extractor manual de miel de 4 cuadros, acero inoxidable, con manivela.'),(13,'Sembradora manual',9,'Sembradora manual tipo SeedMaster, capacidad de 1 litro, rueda de ajuste de profundidad.'),(14,'Regadera',22,'Regadera de 8 litros, con boquilla regulable, fabricada en plástico resistente UV.'),(15,'Motoazada',6,'Motoazada de 6 HP, motor a gasolina, ancho de trabajo de 50 cm, con 4 cuchillas.'),(17,'holi',12,'cads<'),(18,'pito ',2,'pito goldenchiken'),(19,'PITODOBLE',23,'DURO ');
/*!40000 ALTER TABLE `herramientas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-02-26 14:42:47
