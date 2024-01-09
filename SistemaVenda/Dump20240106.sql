-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: localhost    Database: bdvendas2
-- ------------------------------------------------------
-- Server version	8.0.32

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tb_clientes`
--

DROP TABLE IF EXISTS `tb_clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_clientes` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) DEFAULT NULL,
  `apelido` varchar(50) DEFAULT NULL,
  `rg` varchar(30) DEFAULT NULL,
  `cpf` varchar(20) DEFAULT NULL,
  `email` varchar(200) DEFAULT NULL,
  `telefone` varchar(30) DEFAULT NULL,
  `celular` varchar(30) DEFAULT NULL,
  `cep` varchar(100) DEFAULT NULL,
  `logradouro` varchar(255) DEFAULT NULL,
  `numero` int DEFAULT NULL,
  `complemento` varchar(200) DEFAULT NULL,
  `bairro` varchar(100) DEFAULT NULL,
  `cidade` varchar(100) DEFAULT NULL,
  `estado` varchar(2) DEFAULT NULL,
  `imagem` bit() DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_clientes`
--

LOCK TABLES `tb_clientes` WRITE;
/*!40000 ALTER TABLE `tb_clientes` DISABLE KEYS */;
INSERT INTO `tb_clientes` VALUES (7,'Adolfo Nalin Júnior','Dorfo','58,232,300-5','493,234,628-02','nalinadolfo33@gmail.com','(14) 3765-1430','(14) 9990-47231','18770-000','Rua Três',95,'','CDHU 3','Águas de Santa Bárbara','SP',NULL),(11,'Ana Julia Pela','Juh','72,975,892-3','584,814,815-15','','(95) 0590-3503','(14) 9985-07231','18770-000','Rua das mangueiras',520,'Estrada indo para Cerqueira Cesar','Jd Aero porto','Águas de Santa Bárbara','SP',NULL),(12,'Ana Carolina Pontes Lima','Carol','  ,   ,   -','   ,   ,   -','','(  )     -','(  )     -','18770-000','Rua José Teodoro',10,'','CDHU 1','Águas de Santa Bárbara','SP',NULL),(13,'Caio Willian','Caio','  ,   ,   -','   ,   ,   -','','(  )     -','(  )     -','18770-000','Rua José Teodoro',10,'','CDHU 1','Águas de Santa Bárbara','SP',NULL);
/*!40000 ALTER TABLE `tb_clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_devolucao`
--

DROP TABLE IF EXISTS `tb_devolucao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_devolucao` (
  `id` int NOT NULL AUTO_INCREMENT,
  `venda_id` int DEFAULT NULL,
  `cliente_id` int DEFAULT NULL,
  `produto_id` int DEFAULT NULL,
  `quantuidade` int DEFAULT NULL,
  `motivo` varchar(100) DEFAULT NULL,
  `total` decimal(10,2) DEFAULT NULL,
  `observacoes` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `venda_id` (`venda_id`),
  KEY `cliente_id` (`cliente_id`),
  KEY `produto_id` (`produto_id`),
  CONSTRAINT `tb_devolucao_ibfk_1` FOREIGN KEY (`venda_id`) REFERENCES `tb_vendas` (`id`),
  CONSTRAINT `tb_devolucao_ibfk_2` FOREIGN KEY (`cliente_id`) REFERENCES `tb_clientes` (`id`),
  CONSTRAINT `tb_devolucao_ibfk_3` FOREIGN KEY (`produto_id`) REFERENCES `tb_produtos` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_devolucao`
--

LOCK TABLES `tb_devolucao` WRITE;
/*!40000 ALTER TABLE `tb_devolucao` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_devolucao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_fornecedores`
--

DROP TABLE IF EXISTS `tb_fornecedores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_fornecedores` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) DEFAULT NULL,
  `vendedor` varchar(100) DEFAULT NULL,
  `cnpj` varchar(100) DEFAULT NULL,
  `email` varchar(200) DEFAULT NULL,
  `telefone` varchar(30) DEFAULT NULL,
  `celular` varchar(30) DEFAULT NULL,
  `cep` varchar(100) DEFAULT NULL,
  `endereco` varchar(255) DEFAULT NULL,
  `numero` int DEFAULT NULL,
  `complemento` varchar(200) DEFAULT NULL,
  `bairro` varchar(100) DEFAULT NULL,
  `cidade` varchar(100) DEFAULT NULL,
  `estado` varchar(2) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_fornecedores`
--

LOCK TABLES `tb_fornecedores` WRITE;
/*!40000 ALTER TABLE `tb_fornecedores` DISABLE KEYS */;
INSERT INTO `tb_fornecedores` VALUES (1,'Construfort','Ana Carolina Pontes Lima','   .   .   -','Adofo','(  )     -','(  )     -','18770-000','Tv Joaquim Golçalves da Silva',404,'','VL candizani','Águas de Santa Bárbara','SP');
/*!40000 ALTER TABLE `tb_fornecedores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_funcionarios`
--

DROP TABLE IF EXISTS `tb_funcionarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_funcionarios` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) DEFAULT NULL,
  `apelido` varchar(50) DEFAULT NULL,
  `rg` varchar(30) DEFAULT NULL,
  `cpf` varchar(20) DEFAULT NULL,
  `email` varchar(200) DEFAULT NULL,
  `senha` varchar(10) DEFAULT NULL,
  `cargo` varchar(100) DEFAULT NULL,
  `nivel_acesso` varchar(50) DEFAULT NULL,
  `telefone` varchar(30) DEFAULT NULL,
  `celular` varchar(30) DEFAULT NULL,
  `cep` varchar(100) DEFAULT NULL,
  `endereco` varchar(255) DEFAULT NULL,
  `numero` int DEFAULT NULL,
  `complemento` varchar(200) DEFAULT NULL,
  `bairro` varchar(100) DEFAULT NULL,
  `cidade` varchar(100) DEFAULT NULL,
  `estado` varchar(2) DEFAULT NULL,
  `imagem` bit(1) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_funcionarios`
--

LOCK TABLES `tb_funcionarios` WRITE;
/*!40000 ALTER TABLE `tb_funcionarios` DISABLE KEYS */;
INSERT INTO `tb_funcionarios` VALUES (1,'Adolfo',NULL,'   ,   ,   -','493,234,628-02','','1234','Dono','Dono','(  )     -','(  )     -','18770-000','Rua Tres ',95,'','CDHU 3','Águas de Santa Bárbara','SP',_binary '\0'),(2,'Adolfo Nalin júnior',NULL,'755.181.548-45','493.234.628-20','','456566','','','(95) 9186-5895','(14) 9990-47231','18770-000','Rua 3',95,'Ao lado da casa da Patricia Malta','CDHU 3 ','Águas de Santa Bárbara','SP',_binary '\0'),(3,'Adolfo','Adolfo',NULL,NULL,NULL,'1234',NULL,NULL,NULL,NULL,NULL,NULL,0,NULL,NULL,NULL,NULL,_binary '\0'),(4,'Ana Julia','Ana Julia',NULL,NULL,NULL,'1234',NULL,NULL,NULL,NULL,NULL,NULL,0,NULL,NULL,NULL,NULL,_binary '\0');
/*!40000 ALTER TABLE `tb_funcionarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_itensorcamento`
--

DROP TABLE IF EXISTS `tb_itensorcamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_itensorcamento` (
  `id` int NOT NULL AUTO_INCREMENT,
  `orcamento_id` int DEFAULT NULL,
  `produto_id` int DEFAULT NULL,
  `qtd` int DEFAULT NULL,
  `subtotal_produto` decimal(10,0) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `orcamento_id` (`orcamento_id`),
  KEY `produto_id` (`produto_id`),
  CONSTRAINT `tb_itensorcamento_ibfk_1` FOREIGN KEY (`orcamento_id`) REFERENCES `tb_orcamento` (`id`),
  CONSTRAINT `tb_itensorcamento_ibfk_2` FOREIGN KEY (`produto_id`) REFERENCES `tb_produtos` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=38 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_itensorcamento`
--

LOCK TABLES `tb_itensorcamento` WRITE;
/*!40000 ALTER TABLE `tb_itensorcamento` DISABLE KEYS */;
INSERT INTO `tb_itensorcamento` VALUES (1,20,2,15,45),(2,20,2,15,45),(3,21,2,14,42),(4,22,2,14,42),(5,23,2,14,42),(6,24,2,10,30),(7,24,2,10,30),(8,25,2,10,30),(9,26,2,10,30),(10,27,2,10,30),(11,27,2,10,30),(12,28,2,10,30),(13,28,2,10,30),(14,29,2,10,30),(15,29,2,10,30),(16,30,2,10,30),(17,30,2,10,30),(18,31,2,10,30),(19,32,2,10,30),(20,33,2,10,30),(21,34,2,10,30),(22,35,2,10,30),(23,36,2,10,30),(24,37,2,10,30),(25,38,2,10,30),(26,39,2,10,30),(27,40,2,10,30),(28,43,2,10,30),(29,44,2,10,30),(30,46,2,150,450),(31,50,2,10,30),(32,52,2,10,30),(33,53,2,10,30),(34,54,2,1500,4500),(35,55,2,1500,4500),(36,56,2,1500,4500),(37,57,2,10,30);
/*!40000 ALTER TABLE `tb_itensorcamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_itensvendas`
--

DROP TABLE IF EXISTS `tb_itensvendas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_itensvendas` (
  `id` int NOT NULL AUTO_INCREMENT,
  `venda_id` int DEFAULT NULL,
  `produto_id` int DEFAULT NULL,
  `qtd` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `venda_id` (`venda_id`),
  KEY `produto_id` (`produto_id`),
  CONSTRAINT `tb_itensvendas_ibfk_1` FOREIGN KEY (`venda_id`) REFERENCES `tb_vendas` (`id`),
  CONSTRAINT `tb_itensvendas_ibfk_2` FOREIGN KEY (`produto_id`) REFERENCES `tb_produtos` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_itensvendas`
--

LOCK TABLES `tb_itensvendas` WRITE;
/*!40000 ALTER TABLE `tb_itensvendas` DISABLE KEYS */;
INSERT INTO `tb_itensvendas` VALUES (1,29,2,150),(2,30,2,150),(3,31,2,150),(4,31,2,150),(5,32,2,60),(6,33,2,150),(7,34,2,760),(8,35,2,1500),(9,35,2,1500),(10,36,2,100),(11,37,2,150),(12,38,2,1500),(13,39,2,1500),(14,40,2,500),(15,41,2,1500),(16,42,2,1500),(17,43,2,1500),(18,44,2,10),(19,45,2,600),(20,46,2,150),(21,47,2,90),(22,48,2,1500),(23,49,2,150),(24,50,2,50),(25,51,2,80),(26,52,2,150);
/*!40000 ALTER TABLE `tb_itensvendas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_orcamento`
--

DROP TABLE IF EXISTS `tb_orcamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_orcamento` (
  `id` int NOT NULL AUTO_INCREMENT,
  `cliente_id` int DEFAULT NULL,
  `funcionario_id` int DEFAULT NULL,
  `desconto_porcentagem` decimal(10,2) DEFAULT NULL,
  `descoto_real` decimal(10,2) DEFAULT NULL,
  `acrescimo_porcentagem` decimal(10,0) DEFAULT NULL,
  `acrescimo_real` decimal(10,0) DEFAULT NULL,
  `subtotal_orcamento` decimal(10,2) DEFAULT NULL,
  `total` decimal(10,2) DEFAULT NULL,
  `alteracoes` decimal(10,2) DEFAULT NULL,
  `data_orcamento` datetime DEFAULT NULL,
  `hora_orcamento` datetime DEFAULT NULL,
  `quantidade_total` double DEFAULT NULL,
  `obs` varchar(1000) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `cliente_id` (`cliente_id`),
  KEY `funcionario_id` (`funcionario_id`),
  CONSTRAINT `tb_orcamento_ibfk_1` FOREIGN KEY (`cliente_id`) REFERENCES `tb_clientes` (`id`),
  CONSTRAINT `tb_orcamento_ibfk_2` FOREIGN KEY (`funcionario_id`) REFERENCES `tb_funcionarios` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=58 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_orcamento`
--

LOCK TABLES `tb_orcamento` WRITE;
/*!40000 ALTER TABLE `tb_orcamento` DISABLE KEYS */;
INSERT INTO `tb_orcamento` VALUES (6,7,1,0.00,0.00,0,0,0.00,469.00,0.00,'2023-11-05 00:00:00','2023-11-05 11:37:00',134,NULL),(7,7,1,0.00,0.00,0,0,0.00,45.50,0.00,'2023-11-05 00:00:00','2023-11-05 15:44:00',13,NULL),(8,7,1,0.00,0.00,0,0,0.00,525.00,0.00,'2023-11-05 00:00:00','2023-11-05 17:51:00',150,NULL),(9,7,1,0.00,0.00,0,0,0.00,525.00,0.00,'2023-11-05 00:00:00','2023-11-05 17:52:00',150,NULL),(10,7,1,0.00,0.00,0,0,0.00,49.00,0.00,'2023-11-05 00:00:00','2023-11-05 17:53:00',14,NULL),(11,7,1,0.00,0.00,0,0,0.00,49.00,0.00,'2023-11-05 00:00:00','2023-11-05 17:55:00',14,NULL),(12,7,1,0.00,0.00,0,0,0.00,56.00,0.00,'2023-11-05 00:00:00','2023-11-05 17:57:00',16,NULL),(13,7,1,0.00,0.00,0,0,0.00,49.00,0.00,'2023-11-05 00:00:00','2023-11-05 17:59:00',14,NULL),(14,7,1,0.00,0.00,0,0,0.00,49.00,0.00,'2023-11-05 00:00:00','2023-11-05 18:02:00',14,NULL),(15,7,1,0.00,0.00,0,0,0.00,49.00,0.00,'2023-11-05 00:00:00','2023-11-05 18:19:00',14,NULL),(16,7,1,0.00,0.00,0,0,0.00,49.00,0.00,'2023-11-05 00:00:00','2023-11-05 18:23:00',14,NULL),(17,7,1,0.00,0.00,0,0,0.00,49.00,0.00,'2023-11-05 00:00:00','2023-11-05 18:24:00',14,NULL),(18,7,1,0.00,0.00,0,0,0.00,49.00,0.00,'2023-11-05 00:00:00','2023-11-05 18:26:00',14,NULL),(19,7,1,0.00,0.00,0,0,0.00,49.00,0.00,'2023-11-05 00:00:00','2023-11-05 18:29:00',14,NULL),(20,7,1,0.00,0.00,0,0,0.00,52.50,0.00,'2023-11-05 00:00:00','2023-11-05 18:30:00',15,NULL),(21,7,1,0.00,0.00,0,0,0.00,49.00,0.00,'2023-11-05 00:00:00','2023-11-05 18:32:00',14,NULL),(22,7,1,0.00,0.00,0,0,0.00,49.00,0.00,'2023-11-11 00:00:00','2023-11-11 19:06:00',14,NULL),(23,7,1,0.00,0.00,0,0,0.00,49.00,0.00,'2023-11-11 00:00:00','2023-11-11 19:06:00',14,NULL),(24,11,4,0.00,0.00,0,0,70.00,70.00,0.00,'2023-12-12 00:00:00','2023-12-12 19:37:00',10,NULL),(25,7,1,0.00,0.00,0,0,35.00,35.00,0.00,'2023-12-16 00:00:00','2023-12-16 19:18:00',10,NULL),(26,7,1,0.00,0.00,0,0,35.00,35.00,0.00,'2023-12-16 00:00:00','2023-12-16 19:40:00',10,NULL),(27,7,1,0.00,0.00,0,0,210.00,210.00,0.00,'2023-12-17 00:00:00','2023-12-17 07:57:00',10,NULL),(28,7,1,0.00,0.00,0,0,210.00,210.00,0.00,'2023-12-17 00:00:00','2023-12-17 07:57:00',10,NULL),(29,7,1,0.00,0.00,0,0,2310.00,2310.00,0.00,'2023-12-17 00:00:00','2023-12-17 08:00:00',10,NULL),(30,11,1,0.00,0.00,0,0,105.00,105.00,0.00,'2023-12-17 00:00:00','2023-12-17 08:09:00',10,NULL),(31,7,1,0.00,0.00,0,0,35.00,35.00,0.00,'2023-12-17 00:00:00','2023-12-17 08:12:00',10,NULL),(32,7,1,0.00,0.00,0,0,35.00,35.00,0.00,'2023-12-26 00:00:00','2023-12-26 22:09:00',10,NULL),(33,7,1,0.00,0.00,0,0,35.00,35.00,0.00,'2023-12-27 00:00:00','2023-12-27 20:43:00',10,NULL),(34,7,1,0.00,0.00,0,0,35.00,35.00,0.00,'2023-12-27 00:00:00','2023-12-27 21:28:00',10,NULL),(35,7,1,0.00,0.00,0,0,35.00,35.00,0.00,'2023-12-27 00:00:00','2023-12-27 21:42:00',10,NULL),(36,7,1,0.00,0.00,0,0,35.00,35.00,0.00,'2023-12-27 00:00:00','2023-12-27 22:14:00',10,NULL),(37,7,1,0.00,0.00,0,0,35.00,35.00,0.00,'2023-12-27 00:00:00','2023-12-27 22:16:00',10,NULL),(38,7,1,0.00,0.00,0,0,35.00,35.00,0.00,'2023-12-27 00:00:00','2023-12-27 22:17:00',10,NULL),(39,7,1,0.00,0.00,0,0,35.00,35.00,0.00,'2023-12-27 00:00:00','2023-12-27 22:18:00',10,NULL),(40,7,1,0.00,0.00,0,0,35.00,35.00,0.00,'2023-12-27 00:00:00','2023-12-27 22:20:00',10,NULL),(41,7,1,0.00,0.00,0,0,0.00,0.00,0.00,'2023-12-27 00:00:00','2023-12-27 22:22:00',10,NULL),(42,7,1,0.00,0.00,0,0,0.00,0.00,0.00,'2023-12-28 00:00:00','2023-12-28 20:42:00',10,NULL),(43,7,1,0.00,0.00,0,0,35.00,35.00,0.00,'2023-12-28 00:00:00','2023-12-28 22:06:00',10,NULL),(44,7,1,0.00,0.00,0,0,35.00,35.00,0.00,'2023-12-28 00:00:00','2023-12-28 22:08:00',10,NULL),(45,7,1,0.00,0.00,0,0,0.00,0.00,0.00,'2023-12-29 00:00:00','2023-12-29 21:04:00',10,NULL),(46,7,1,0.00,0.00,0,0,525.00,525.00,0.00,'2023-12-29 00:00:00','2023-12-29 21:17:00',150,NULL),(47,7,1,0.00,0.00,0,0,0.00,0.00,0.00,'2023-12-29 00:00:00','2023-12-29 21:34:00',10,NULL),(48,7,1,0.00,0.00,0,0,0.00,0.00,0.00,'2023-12-29 00:00:00','2023-12-29 21:34:00',10,NULL),(49,7,1,0.00,0.00,0,0,0.00,0.00,0.00,'2024-01-02 00:00:00','2024-01-02 20:52:00',10,NULL),(50,7,1,0.00,0.00,0,0,35.00,35.00,0.00,'2024-01-03 00:00:00','2024-01-03 19:55:00',10,NULL),(51,7,1,0.00,0.00,0,0,0.00,0.00,0.00,'2024-01-03 00:00:00','2024-01-03 21:37:00',10,NULL),(52,7,1,0.00,0.00,0,0,0.00,0.00,0.00,'2024-01-03 00:00:00','2024-01-03 21:50:00',10,NULL),(53,7,1,0.00,0.00,0,0,0.00,0.00,0.00,'2024-01-03 00:00:00','2024-01-03 21:50:00',10,NULL),(54,11,2,0.00,0.00,0,0,5250.00,5250.00,0.00,'2024-01-05 00:00:00','2024-01-05 20:19:00',1500,NULL),(55,7,1,0.00,0.00,0,0,4500.00,4500.00,0.00,'2024-01-05 00:00:00','2024-01-05 20:27:00',1500,NULL),(56,7,1,0.00,0.00,0,0,4500.00,4500.00,0.00,'2024-01-05 00:00:00','2024-01-05 20:27:00',1500,NULL),(57,12,4,0.00,0.00,0,0,30.00,30.00,0.00,'2024-01-05 00:00:00','2024-01-05 20:31:00',10,NULL);
/*!40000 ALTER TABLE `tb_orcamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_produtos`
--

DROP TABLE IF EXISTS `tb_produtos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_produtos` (
  `id` int NOT NULL AUTO_INCREMENT,
  `descricao_completa` varchar(150) DEFAULT NULL,
  `descricao_resumida` varchar(50) DEFAULT NULL,
  `preco_vista` decimal(10,2) DEFAULT NULL,
  `preco_prazo` decimal(10,2) DEFAULT NULL,
  `valor_entrada` decimal(10,2) DEFAULT NULL,
  `valor_total` decimal(10,2) DEFAULT NULL,
  `quantidade` int DEFAULT NULL,
  `unid_medida` varchar(50) DEFAULT NULL,
  `data_entrada` date DEFAULT NULL,
  `hora_entrada` time DEFAULT NULL,
  `imagem` bit(1) DEFAULT NULL,
  `for_id` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `for_id` (`for_id`),
  CONSTRAINT `tb_produtos_ibfk_1` FOREIGN KEY (`for_id`) REFERENCES `tb_fornecedores` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_produtos`
--

LOCK TABLES `tb_produtos` WRITE;
/*!40000 ALTER TABLE `tb_produtos` DISABLE KEYS */;
INSERT INTO `tb_produtos` VALUES (2,'Bloco de cimento 19x19x39','Bloco19x19x39',3.00,3.50,2.00,9000.00,-8940,'Unitário','2023-10-16','20:58:00',NULL,1);
/*!40000 ALTER TABLE `tb_produtos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_vendas`
--

DROP TABLE IF EXISTS `tb_vendas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_vendas` (
  `id` int NOT NULL AUTO_INCREMENT,
  `cliente_id` int DEFAULT NULL,
  `forma_pagamento` varchar(50) DEFAULT NULL,
  `sub_total` decimal(10,2) DEFAULT NULL,
  `desconto_procentagem` decimal(10,2) DEFAULT NULL,
  `desconto_real` decimal(10,2) DEFAULT NULL,
  `total_venda` decimal(10,2) DEFAULT NULL,
  `observacoes` text,
  `subtotal` decimal(10,2) DEFAULT NULL,
  `data_venda` datetime DEFAULT NULL,
  `hora_venda` datetime DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `cliente_id` (`cliente_id`),
  CONSTRAINT `tb_vendas_ibfk_1` FOREIGN KEY (`cliente_id`) REFERENCES `tb_clientes` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=54 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_vendas`
--

LOCK TABLES `tb_vendas` WRITE;
/*!40000 ALTER TABLE `tb_vendas` DISABLE KEYS */;
INSERT INTO `tb_vendas` VALUES (21,7,'Dinheiro',450.00,0.00,0.00,450.00,'Nada a dizer',450.00,NULL,NULL),(27,7,NULL,0.00,0.00,0.00,6.00,'',0.00,NULL,NULL),(28,7,NULL,0.00,0.00,0.00,450.00,'',0.00,NULL,NULL),(29,7,NULL,0.00,0.00,0.00,450.00,'',0.00,NULL,NULL),(30,7,NULL,0.00,0.00,0.00,450.00,'',0.00,NULL,NULL),(31,7,NULL,0.00,0.00,0.00,900.00,'',0.00,NULL,NULL),(32,7,NULL,0.00,0.00,0.00,180.00,'',0.00,NULL,NULL),(33,7,NULL,0.00,0.00,0.00,450.00,'',0.00,NULL,NULL),(34,7,NULL,0.00,0.00,0.00,2280.00,'',0.00,NULL,NULL),(35,11,NULL,0.00,0.00,0.00,4500.00,'',0.00,NULL,NULL),(36,11,NULL,0.00,0.00,0.00,300.00,'',0.00,NULL,NULL),(37,11,NULL,0.00,0.00,0.00,450.00,'',0.00,NULL,NULL),(38,11,NULL,0.00,0.00,0.00,4500.00,'',0.00,NULL,NULL),(39,11,NULL,0.00,0.00,0.00,4500.00,'',0.00,NULL,NULL),(40,11,NULL,0.00,0.00,0.00,1500.00,'',0.00,NULL,NULL),(41,11,NULL,0.00,0.00,0.00,4500.00,'',0.00,NULL,NULL),(42,11,NULL,0.00,0.00,0.00,4500.00,'',0.00,NULL,NULL),(43,11,NULL,0.00,0.00,0.00,4500.00,'',0.00,NULL,NULL),(44,7,NULL,0.00,0.00,0.00,30.00,'',0.00,NULL,NULL),(45,7,NULL,0.00,0.00,0.00,1760.00,'',0.00,NULL,NULL),(46,7,NULL,0.00,0.00,0.00,450.00,'',0.00,NULL,NULL),(47,7,NULL,0.00,0.00,0.00,270.00,'',0.00,NULL,NULL),(48,7,NULL,0.00,0.00,0.00,4500.00,'',0.00,NULL,NULL),(49,7,NULL,0.00,0.00,0.00,450.00,'',0.00,NULL,NULL),(50,7,NULL,0.00,0.00,0.00,150.00,'',0.00,NULL,NULL),(51,7,NULL,0.00,0.00,0.00,240.00,'',0.00,NULL,NULL),(52,7,NULL,0.00,0.00,0.00,450.00,'',0.00,NULL,NULL);
/*!40000 ALTER TABLE `tb_vendas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-01-06 16:15:09
