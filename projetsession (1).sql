-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3308
-- Généré le :  mer. 07 oct. 2020 à 20:09
-- Version du serveur :  8.0.18
-- Version de PHP :  7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `projetsession`
--

DELIMITER $$
--
-- Fonctions
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
-- Structure de la table `categorie`
--

DROP TABLE IF EXISTS `categorie`;
CREATE TABLE IF NOT EXISTS `categorie` (
  `noCategorie` int(10) NOT NULL AUTO_INCREMENT,
  `nom` varchar(30) NOT NULL,
  `quantite` int(5) NOT NULL,
  PRIMARY KEY (`noCategorie`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `categorie`
--

INSERT INTO `categorie` (`noCategorie`, `nom`, `quantite`) VALUES
(4, 'Ordis', 1);

-- --------------------------------------------------------

--
-- Structure de la table `emprunt`
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
) ENGINE=MyISAM AUTO_INCREMENT=28 DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `equipement`
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
-- Déchargement des données de la table `equipement`
--

INSERT INTO `equipement` (`noEquipement`, `nom`, `noCategorie`, `etat`, `disponibilite`) VALUES
('rferg', 'Mac', 4, 'Neuf', 'oui');

-- --------------------------------------------------------

--
-- Structure de la table `personne`
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
) ENGINE=MyISAM AUTO_INCREMENT=235 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `personne`
--

INSERT INTO `personne` (`noPersonne`, `matricule`, `nom`, `prenom`, `statut`, `nomDepartement`, `nomService`, `noBureau`, `telephone`, `poste`, `email`) VALUES
(234, 0, 'Navarro', 'Daniel', 'Administration', 'Soins', 'Directeur', 'hf5449', '(819) 316-4641', 616648, 'daniel@cegeptr.qc.ca');

-- --------------------------------------------------------

--
-- Structure de la table `retour`
--

DROP TABLE IF EXISTS `retour`;
CREATE TABLE IF NOT EXISTS `retour` (
  `noRetour` int(10) NOT NULL AUTO_INCREMENT,
  `nomReception` varchar(30) NOT NULL,
  `noPersonne` int(20) NOT NULL,
  `noEquipement` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `dateRetour` datetime NOT NULL,
  `note` text NOT NULL,
  PRIMARY KEY (`noRetour`,`noEquipement`) USING BTREE,
  KEY `fk_noPersonne` (`noPersonne`),
  KEY `fk_noEquipement` (`noEquipement`)
) ENGINE=MyISAM AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `retour`
--

INSERT INTO `retour` (`noRetour`, `nomReception`, `noPersonne`, `noEquipement`, `dateRetour`, `note`) VALUES
(1, 'Camilo', 234, 'rferg', '2020-09-02 16:10:36', '');

-- --------------------------------------------------------

--
-- Structure de la table `utilisateur`
--

DROP TABLE IF EXISTS `utilisateur`;
CREATE TABLE IF NOT EXISTS `utilisateur` (
  `matricule` int(7) NOT NULL,
  `password` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `statut` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`matricule`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
