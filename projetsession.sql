-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3308
-- Generation Time: Oct 30, 2020 at 01:35 AM
-- Server version: 5.7.31
-- PHP Version: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `projetsession`
--

DELIMITER $$
--
-- Functions
--
DROP FUNCTION IF EXISTS `initcap`$$
CREATE DEFINER=`root`@`localhost` FUNCTION `initcap` (`x` VARCHAR(100)) RETURNS VARCHAR(100) CHARSET utf8 BEGIN
SET @str='';
SET @l_str='';
WHILE x REGEXP ' ' DO
SELECT SUBSTRING_INDEX(x, ' ', 1) INTO @l_str;
SELECT SUBSTRING(x, LOCATE(' ', x)+1) INTO x;
SELECT CONCAT(@str, ' ', CONCAT(UPPER(SUBSTRING(@l_str,1,1)),LOWER(SUBSTRING(@l_str,2)))) INTO @str;
END WHILE;
RETURN LTRIM(CONCAT(@str, ' ', CONCAT(UPPER(SUBSTRING(x,1,1)),LOWER(SUBSTRING(x,2)))));
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `categorie`
--

DROP TABLE IF EXISTS `categorie`;
CREATE TABLE IF NOT EXISTS `categorie` (
  `noCategorie` int(10) NOT NULL AUTO_INCREMENT,
  `nom` varchar(30) NOT NULL,
  `quantite` int(5) NOT NULL,
  PRIMARY KEY (`noCategorie`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `categorie`
--

INSERT INTO `categorie` (`noCategorie`, `nom`, `quantite`) VALUES
(4, 'Ordis', 1),
(2, 'Équipements', 4),
(3, 'Combo', 0);

-- --------------------------------------------------------

--
-- Table structure for table `emprunt`
--

DROP TABLE IF EXISTS `emprunt`;
CREATE TABLE IF NOT EXISTS `emprunt` (
  `ID` int(15) NOT NULL AUTO_INCREMENT,
  `noPersonne` int(20) NOT NULL,
  `noEquipement` varchar(15) NOT NULL,
  `autorisation` varchar(30) NOT NULL,
  `DateEmprunt` datetime NOT NULL,
  `duree` varchar(30) NOT NULL,
  `dateRetour` datetime NOT NULL,
  `commentaires` text NOT NULL,
  PRIMARY KEY (`ID`,`noEquipement`) USING BTREE,
  KEY `fk_personne` (`noPersonne`),
  KEY `fk_equipement_emprunt` (`noEquipement`)
) ENGINE=MyISAM AUTO_INCREMENT=33 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `emprunt`
--

INSERT INTO `emprunt` (`ID`, `noPersonne`, `noEquipement`, `autorisation`, `DateEmprunt`, `duree`, `dateRetour`, `commentaires`) VALUES
(29, 3, '4', 'Marc-Antoine', '2020-10-30 20:31:57', '5', '2020-10-30 20:34:03', ''),
(31, 235, '7', 'Marc-Antoine', '2020-10-30 21:29:52', '4', '2020-10-31 21:29:52', ''),
(32, 4, '9', 'Marc-Antoine', '2020-10-30 21:29:52', '4', '2020-10-31 21:29:52', '');

-- --------------------------------------------------------

--
-- Table structure for table `equipement`
--

DROP TABLE IF EXISTS `equipement`;
CREATE TABLE IF NOT EXISTS `equipement` (
  `noEquipement` varchar(15) NOT NULL,
  `nom` varchar(30) NOT NULL,
  `noCategorie` int(10) NOT NULL,
  `etat` varchar(20) NOT NULL,
  `disponibilite` varchar(20) NOT NULL,
  PRIMARY KEY (`noEquipement`),
  KEY `fk_categorie` (`noCategorie`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `equipement`
--

INSERT INTO `equipement` (`noEquipement`, `nom`, `noCategorie`, `etat`, `disponibilite`) VALUES
('1', 'Cable hdmi', 2, 'Neuf', 'oui'),
('2', 'Clavier', 2, 'Neuf', 'oui'),
('3', 'Ordinateur portable', 1, 'Neuf', 'oui'),
('4', 'Écran', 2, 'Brisé', 'non'),
('5', 'tapis', 2, 'En réparation', 'non'),
('6', 'Portable et Écran', 3, 'neuf', 'oui'),
('7', 'Clavier et souris', 3, 'neuf', 'oui'),
('8', 'Haut-parler', 2, 'neuf', 'oui'),
('9', 'Écouteur', 2, 'brisé', 'non');

-- --------------------------------------------------------

--
-- Table structure for table `personne`
--

DROP TABLE IF EXISTS `personne`;
CREATE TABLE IF NOT EXISTS `personne` (
  `noPersonne` int(20) NOT NULL AUTO_INCREMENT,
  `matricule` int(7) NOT NULL,
  `nom` varchar(30) NOT NULL,
  `prenom` varchar(30) NOT NULL,
  `statut` varchar(30) NOT NULL,
  `nomDepartement` varchar(30) NOT NULL,
  `nomService` varchar(30) NOT NULL,
  `noBureau` varchar(10) NOT NULL,
  `telephone` varchar(14) NOT NULL,
  `poste` int(5) NOT NULL,
  `email` varchar(50) NOT NULL,
  PRIMARY KEY (`noPersonne`),
  UNIQUE KEY `unique` (`matricule`)
) ENGINE=MyISAM AUTO_INCREMENT=236 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `personne`
--

INSERT INTO `personne` (`noPersonne`, `matricule`, `nom`, `prenom`, `statut`, `nomDepartement`, `nomService`, `noBureau`, `telephone`, `poste`, `email`) VALUES
(2, 1659420, 'Montoya', 'Camilo', 'Administration', 'Info', '0', '0', '(819) 123-4567', 0, 'camilo@outlook.com'),
(1, 1659462, 'Fillion', 'Marc-Antoine', 'Administration', 'Info', '0', '0', '(819) 944-6358', 0, 'marc@outlook.com'),
(3, 1659430, 'Beaumier', 'Olivier', 'Administration', 'Info', '0', '0', '(819) 987-3212', 0, 'olivier@outlook.com'),
(4, 1857365, 'Pelletier', 'Vincent', 'Étudiant', 'Info', '0', '0', '(819) 222-3141', 0, 'vincent@outlook.com'),
(235, 1867266, 'Doe', 'Jhon', 'Étudiant', 'Info', '0', '0', '(819) 583-1384', 0, 'jhon@outlook.com');

-- --------------------------------------------------------

--
-- Table structure for table `retour`
--

DROP TABLE IF EXISTS `retour`;
CREATE TABLE IF NOT EXISTS `retour` (
  `noRetour` int(10) NOT NULL AUTO_INCREMENT,
  `nomReception` varchar(30) NOT NULL,
  `noPersonne` int(20) NOT NULL,
  `noEquipement` varchar(15) NOT NULL,
  `dateRetour` datetime NOT NULL,
  `note` text NOT NULL,
  PRIMARY KEY (`noRetour`,`noEquipement`) USING BTREE,
  KEY `fk_noPersonne` (`noPersonne`),
  KEY `fk_noEquipement` (`noEquipement`)
) ENGINE=MyISAM AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `retour`
--

INSERT INTO `retour` (`noRetour`, `nomReception`, `noPersonne`, `noEquipement`, `dateRetour`, `note`) VALUES
(1, 'Camilo', 234, 'rferg', '2020-09-02 16:10:36', ''),
(28, 'Marc-Antoine', 1, '2', '2020-10-29 20:33:34', ''),
(30, 'Marc-Antoine', 2, '1', '2020-10-29 21:32:46', '');

-- --------------------------------------------------------

--
-- Table structure for table `utilisateur`
--

DROP TABLE IF EXISTS `utilisateur`;
CREATE TABLE IF NOT EXISTS `utilisateur` (
  `matricule` int(7) NOT NULL,
  `password` varchar(30) NOT NULL,
  `statut` varchar(30) NOT NULL,
  PRIMARY KEY (`matricule`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `utilisateur`
--

INSERT INTO `utilisateur` (`matricule`, `password`, `statut`) VALUES
(1659462, '1659462', 'Étudiant');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
