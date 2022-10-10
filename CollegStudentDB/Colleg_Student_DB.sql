-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: localhost    Database: colleg_student_db
-- ------------------------------------------------------
-- Server version	8.0.27

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
-- Table structure for table `authorization`
--

DROP TABLE IF EXISTS `authorization`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `authorization` (
  `LoginID` int NOT NULL AUTO_INCREMENT,
  `Login` varchar(10) NOT NULL,
  `LoginPass` varchar(10) NOT NULL,
  PRIMARY KEY (`LoginID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `authorization`
--

LOCK TABLES `authorization` WRITE;
/*!40000 ALTER TABLE `authorization` DISABLE KEYS */;
INSERT INTO `authorization` VALUES (1,'admin','admin'),(2,'1111','1111');
/*!40000 ALTER TABLE `authorization` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `learninggroup`
--

DROP TABLE IF EXISTS `learninggroup`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `learninggroup` (
  `LearningGroupID` int NOT NULL AUTO_INCREMENT,
  `GroupNumber` varchar(12) NOT NULL,
  `Speciality` varchar(50) NOT NULL,
  `Curator` int NOT NULL,
  PRIMARY KEY (`LearningGroupID`),
  KEY `Curator` (`Curator`),
  CONSTRAINT `learninggroup_ibfk_1` FOREIGN KEY (`Curator`) REFERENCES `teachers` (`TeacherID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `learninggroup`
--

LOCK TABLES `learninggroup` WRITE;
/*!40000 ALTER TABLE `learninggroup` DISABLE KEYS */;
INSERT INTO `learninggroup` VALUES (1,'9АБД-1.19','Администратор баз данных',1),(2,'9АБД-2.19','Администратор баз данных',2),(3,'9ПР-1.20','Программист',10),(4,'9ИС-1.22','Информационные системы',8),(5,'ПР-1.21','Программист',11);
/*!40000 ALTER TABLE `learninggroup` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `students`
--

DROP TABLE IF EXISTS `students`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `students` (
  `StudentID` int NOT NULL AUTO_INCREMENT,
  `NumberStudentCard` varchar(10) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `LearningGroup` int NOT NULL,
  `LastName` varchar(20) NOT NULL,
  `FirstName` varchar(20) NOT NULL,
  `MiddleName` varchar(20) NOT NULL,
  `Birthday` date NOT NULL,
  `Address` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Phone` char(20) DEFAULT NULL,
  PRIMARY KEY (`StudentID`),
  KEY `LearningGroup` (`LearningGroup`),
  CONSTRAINT `students_ibfk_1` FOREIGN KEY (`LearningGroup`) REFERENCES `learninggroup` (`LearningGroupID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `students`
--

LOCK TABLES `students` WRITE;
/*!40000 ALTER TABLE `students` DISABLE KEYS */;
INSERT INTO `students` VALUES (1,'0700КР',1,'Малышев','Илья','Олегович','2003-06-03','г. Красноярск, ул. Ленина, д. 3, кв. 4','+7 (563) 214-78-52'),(2,'0701КР',2,'Владимиров','Виктор','Николаевич','2003-02-12','г. Красноярск, ул. Мира, д. 10, кв. 12','+7 (456) 987-45-21'),(7,'0705КР',2,'Калугин','Николай','Викторович','2004-02-15','г. Красноярск, ул 9 мая, д. 3, кв. 4','+7 (546) 321-21-32'),(8,'0709КР',1,'Орлова','Ксения','Алексеевна','2003-01-01','г. Красноярск, ул. 9 мая, д. 1, кв. 1','+7 (431) 286-74-53'),(12,'0710КР',3,'Карпова','Анна','Алексеевна','2003-10-10','г. Красноярск, ул. Шахтеров, д. 3, кв. 4','+7 (321) 321-22-21'),(13,'0708КР',4,'Денисов','Николай','Максимович','2003-02-25','г. Красноярск. ул. Октябрьская, д. 5, кв. 10','+7 (545) 647-87-97');
/*!40000 ALTER TABLE `students` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `teachers`
--

DROP TABLE IF EXISTS `teachers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `teachers` (
  `TeacherID` int NOT NULL AUTO_INCREMENT,
  `LastName` varchar(20) NOT NULL,
  `FirstName` varchar(20) NOT NULL,
  `MiddleName` varchar(20) NOT NULL,
  `Birthday` date NOT NULL,
  PRIMARY KEY (`TeacherID`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `teachers`
--

LOCK TABLES `teachers` WRITE;
/*!40000 ALTER TABLE `teachers` DISABLE KEYS */;
INSERT INTO `teachers` VALUES (1,'Сергеев','Илья','Владимирович','2003-05-06'),(2,'Шишкин','Олег','Денисович','2022-10-09'),(3,'Волков','Дмитрий','Петрович','1990-01-31'),(4,'Чайкин','Виктор','Павлович','1983-05-10'),(5,'Дроздова','Дарья','Викторовна','1995-07-13'),(6,'Жуков','Денис','Андреевич','1973-10-24'),(7,'Никифоров','Владимир','Григорьевич','1981-10-12'),(8,'Антонов','Ник','Дмитриевич','2000-10-25'),(9,'Печкин','Федор','Валентинович','1969-10-29'),(10,'Самойлова','Наталья','Андреевна','1965-10-28'),(11,'Круглова','Вера','Васильевна','1988-02-12'),(12,'Щукин','Михаил','Николаевич','1981-06-12'),(13,'Кошкин','Виктор','Борисович','1976-05-10');
/*!40000 ALTER TABLE `teachers` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-10-10 23:43:03
