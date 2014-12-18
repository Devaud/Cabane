-- phpMyAdmin SQL Dump
-- version 3.5.8.1
-- http://www.phpmyadmin.net
--
-- Client: 127.0.0.1
-- Généré le: Jeu 18 Décembre 2014 à 16:06
-- Version du serveur: 5.6.11-log
-- Version de PHP: 5.4.14

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données: `cabanes`
--

-- --------------------------------------------------------

--
-- Structure de la table `cabane`
--

CREATE TABLE IF NOT EXISTS `cabane` (
  `idCabane` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(150) NOT NULL,
  `adresse` varchar(200) NOT NULL,
  `photo` varchar(150) NOT NULL,
  `localite` varchar(75) NOT NULL,
  `NPA` varchar(15) NOT NULL,
  `nbLits` int(11) NOT NULL,
  `prixNuit` varchar(25) NOT NULL,
  `altitude` varchar(25) NOT NULL,
  `douches` tinyint(1) NOT NULL,
  PRIMARY KEY (`idCabane`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Contenu de la table `cabane`
--

INSERT INTO `cabane` (`idCabane`, `nom`, `adresse`, `photo`, `localite`, `NPA`, `nbLits`, `prixNuit`, `altitude`, `douches`) VALUES
(1, 'test', 'test', '', 'test', '1234', 1, '235', 'test', 0),
(3, 'PraFleuri', 'Nendaz', '', 'Nendaz', '1956', 25, '12', '2012', 0);

-- --------------------------------------------------------

--
-- Structure de la table `commentaires`
--

CREATE TABLE IF NOT EXISTS `commentaires` (
  `idCommentaire` int(11) NOT NULL AUTO_INCREMENT,
  `commentaire` longtext NOT NULL,
  `dateCommentaire` date NOT NULL,
  `idPersonne` int(11) NOT NULL,
  `idCabane` int(11) NOT NULL,
  PRIMARY KEY (`idCommentaire`),
  KEY `FK_COMMENTAIRES_idPersonne` (`idPersonne`),
  KEY `FK_COMMENTAIRES_idCabane` (`idCabane`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Structure de la table `contact`
--

CREATE TABLE IF NOT EXISTS `contact` (
  `idContact` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(75) NOT NULL,
  `prenom` varchar(50) NOT NULL,
  `telephone` varchar(25) NOT NULL,
  `email` varchar(50) NOT NULL,
  `siteWeb` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idContact`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Contenu de la table `contact`
--

INSERT INTO `contact` (`idContact`, `nom`, `prenom`, `telephone`, `email`, `siteWeb`) VALUES
(1, 'Travnjak', 'Jasmina', '55568524', 'jt@edu.ge.ch', 'www.jt.com');

-- --------------------------------------------------------

--
-- Structure de la table `contactcabane`
--

CREATE TABLE IF NOT EXISTS `contactcabane` (
  `idCabane` int(11) NOT NULL,
  `idContact` int(11) NOT NULL,
  PRIMARY KEY (`idCabane`,`idContact`),
  KEY `FK_conatctCabane_idContact` (`idContact`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `personnes`
--

CREATE TABLE IF NOT EXISTS `personnes` (
  `idPersonne` int(11) NOT NULL AUTO_INCREMENT,
  `pseudo` varchar(50) NOT NULL,
  `mdp` varchar(50) NOT NULL,
  `nom` varchar(50) NOT NULL,
  `prenom` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `telephone` varchar(15) NOT NULL,
  PRIMARY KEY (`idPersonne`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Contenu de la table `personnes`
--

INSERT INTO `personnes` (`idPersonne`, `pseudo`, `mdp`, `nom`, `prenom`, `email`, `telephone`) VALUES
(2, 'test', 'test', 'test', 'test', 'test@gmail.com', '232451');

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `commentaires`
--
ALTER TABLE `commentaires`
  ADD CONSTRAINT `FK_COMMENTAIRES_idCabane` FOREIGN KEY (`idCabane`) REFERENCES `cabane` (`idCabane`),
  ADD CONSTRAINT `FK_COMMENTAIRES_idPersonne` FOREIGN KEY (`idPersonne`) REFERENCES `personnes` (`idPersonne`);

--
-- Contraintes pour la table `contactcabane`
--
ALTER TABLE `contactcabane`
  ADD CONSTRAINT `FK_conatctCabane_idCabane` FOREIGN KEY (`idCabane`) REFERENCES `cabane` (`idCabane`),
  ADD CONSTRAINT `FK_conatctCabane_idContact` FOREIGN KEY (`idContact`) REFERENCES `contact` (`idContact`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
