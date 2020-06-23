-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 22-Jun-2020 às 23:29
-- Versão do servidor: 10.4.11-MariaDB
-- versão do PHP: 7.4.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `ourivesariadb`
--
CREATE DATABASE IF NOT EXISTS `ourivesariadb` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `ourivesariadb`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `encomendas`
--

DROP TABLE IF EXISTS `encomendas`;
CREATE TABLE IF NOT EXISTS `encomendas` (
  `idencomenda` int(11) NOT NULL AUTO_INCREMENT,
  `nrcliente` int(255) NOT NULL,
  `nomeencomenda` varchar(200) NOT NULL,
  `tipoencomenda` varchar(50) NOT NULL,
  `pedirorc` varchar(11) NOT NULL,
  `descricao` varchar(300) NOT NULL,
  `statusencomenda` varchar(40) NOT NULL,
  `pvporc` decimal(11,0) NOT NULL,
  `preco` int(20) NOT NULL,
  `começa` varchar(100) NOT NULL,
  `termina` varchar(100) NOT NULL,
  `data` varchar(100) NOT NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`idencomenda`),
  KEY `nrcliente` (`nrcliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `fichascliente`
--

DROP TABLE IF EXISTS `fichascliente`;
CREATE TABLE IF NOT EXISTS `fichascliente` (
  `nrcliente` int(255) NOT NULL AUTO_INCREMENT,
  `nomecliente` varchar(200) NOT NULL,
  `telefone` int(120) NOT NULL,
  `telefonefixo` varchar(120) NOT NULL,
  `email` varchar(300) NOT NULL,
  `morada` varchar(300) NOT NULL,
  `Data` datetime NOT NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`nrcliente`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `horçamento`
--

DROP TABLE IF EXISTS `horçamento`;
CREATE TABLE IF NOT EXISTS `horçamento` (
  `idorçamento` int(11) NOT NULL AUTO_INCREMENT,
  `idencomenda` int(11) NOT NULL,
  `metal` int(11) NOT NULL,
  `pedras` int(11) NOT NULL,
  `pedras1` int(11) NOT NULL,
  `pedras2` int(11) NOT NULL,
  `pedras3` int(11) NOT NULL,
  `pedras4` int(11) NOT NULL,
  `pedras5` int(11) NOT NULL,
  `fundicao` int(11) NOT NULL,
  `feitio` int(11) NOT NULL,
  `cravacao` int(11) NOT NULL,
  `polimento` int(11) NOT NULL,
  `banhorodio` int(11) NOT NULL,
  `incm` int(11) NOT NULL,
  `abertura` int(11) NOT NULL,
  `preco` int(11) NOT NULL,
  PRIMARY KEY (`idorçamento`),
  KEY `idencomenda` (`idencomenda`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `login`
--

DROP TABLE IF EXISTS `login`;
CREATE TABLE IF NOT EXISTS `login` (
  `user` varchar(100) NOT NULL,
  `pass` varchar(100) NOT NULL,
  `atendimento` tinyint(1) NOT NULL,
  `oficina` tinyint(1) NOT NULL,
  `orçamento` tinyint(1) NOT NULL,
  `administrador` tinyint(1) NOT NULL,
  PRIMARY KEY (`user`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- INSERE O USER ADMIN
--

INSERT INTO LOGIN (user, pass, atendimento, oficina, orçamento, administrador) VALUES ('Administrador', 'kQNv2mj3A8qvpMAM', '0', '0', '0', '1');

-- --------------------------------------------------------

--
-- Estrutura da tabela `porçamento`
--

DROP TABLE IF EXISTS `porçamento`;
CREATE TABLE IF NOT EXISTS `porçamento` (
  `precoid` int(11) NOT NULL AUTO_INCREMENT,
  `metal` decimal(10,2) NOT NULL,
  `pedras` decimal(10,2) NOT NULL,
  `pedras1` decimal(10,2) NOT NULL,
  `pedras2` decimal(10,2) NOT NULL,
  `pedras3` decimal(10,2) NOT NULL,
  `pedras4` decimal(10,2) NOT NULL,
  `pedras5` decimal(10,2) NOT NULL,
  `fundicao` decimal(10,2) NOT NULL,
  `feitio` decimal(10,2) NOT NULL,
  `cravacao` decimal(10,2) NOT NULL,
  `polimento` decimal(10,2) NOT NULL,
  `banhorodio` decimal(10,2) NOT NULL,
  `incm` decimal(10,2) NOT NULL,
  `abertura` decimal(10,2) NOT NULL,
  PRIMARY KEY (`precoid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `stock`
--

DROP TABLE IF EXISTS `stock`;
CREATE TABLE IF NOT EXISTS `stock` (
  `produtoid` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(123) NOT NULL,
  `Quantidade` int(11) NOT NULL,
  `Preço` decimal(10,2) NOT NULL,
  `Fornecedor` varchar(100) NOT NULL,
  PRIMARY KEY (`produtoid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `encomendas`
--
ALTER TABLE `encomendas`
  ADD CONSTRAINT `encomendas_ibfk_1` FOREIGN KEY (`nrcliente`) REFERENCES `fichascliente` (`nrcliente`);

--
-- Limitadores para a tabela `horçamento`
--
ALTER TABLE `horçamento`
  ADD CONSTRAINT `horçamento_ibfk_1` FOREIGN KEY (`idencomenda`) REFERENCES `encomendas` (`idencomenda`),
  ADD CONSTRAINT `horçamento_ibfk_2` FOREIGN KEY (`idencomenda`) REFERENCES `encomendas` (`idencomenda`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
