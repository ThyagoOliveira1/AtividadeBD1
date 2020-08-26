-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 27/08/2020 às 00:54
-- Versão do servidor: 10.4.11-MariaDB
-- Versão do PHP: 7.4.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `brasil`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `capital`
--

CREATE TABLE `capital` (
  `idCapital` int(11) NOT NULL,
  `NomeCapital` varchar(100) CHARACTER SET utf8 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `capital`
--

INSERT INTO `capital` (`idCapital`, `NomeCapital`) VALUES
(1, 'Rio Branco'),
(2, 'Macapá'),
(3, 'Manaus'),
(4, 'Belém'),
(5, 'Porto Velho'),
(6, 'Boa Vista'),
(7, 'Palmas'),
(8, 'Maceió'),
(9, 'Salvador'),
(10, 'Fortaleza'),
(11, 'São Luís'),
(12, 'João Pessoa'),
(13, 'Recife'),
(14, 'Teresina'),
(15, 'Natal'),
(16, 'Aracaju'),
(17, 'Goiânia'),
(18, 'Cuiabá'),
(19, 'Campo Grande'),
(20, 'Brasília'),
(21, 'Vitória'),
(22, 'Belo Horizonte'),
(23, 'São Paulo'),
(24, 'Rio de Janeiro'),
(25, 'Curitiba'),
(26, 'Porto Alegre'),
(27, 'Florianópolis');

-- --------------------------------------------------------

--
-- Estrutura para tabela `cidade`
--

CREATE TABLE `cidade` (
  `idCidade` int(11) NOT NULL,
  `NomeCidade` varchar(100) CHARACTER SET utf8 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `cidade`
--

INSERT INTO `cidade` (`idCidade`, `NomeCidade`) VALUES
(2, 'Rio de Janeiro'),
(3, 'São Paulo');

-- --------------------------------------------------------

--
-- Estrutura para tabela `estado`
--

CREATE TABLE `estado` (
  `idEstado` int(11) NOT NULL,
  `SiglaEstado` varchar(2) CHARACTER SET utf8 NOT NULL,
  `NomeEstado` varchar(100) CHARACTER SET utf8 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `estado`
--

INSERT INTO `estado` (`idEstado`, `SiglaEstado`, `NomeEstado`) VALUES
(1, 'AC', 'Acre'),
(2, 'AP', 'Amapá'),
(3, 'AM', 'Amazonas'),
(4, 'PA', 'Pará'),
(5, 'RO', 'Rondônia'),
(6, 'RR', 'Roraima'),
(7, 'TO', 'Tocantins'),
(8, 'AL', 'Alagoas'),
(9, 'BH', 'Bahia'),
(10, 'CE', 'Ceará'),
(11, 'MA', 'Maranhão'),
(12, 'PB', 'Paraíba'),
(13, 'PE', 'Pernambuco'),
(14, 'PI', 'Piauí'),
(15, 'RN', 'Rio Grande do Norte'),
(16, 'SE', 'Sergipe'),
(17, 'GO', 'Goiás'),
(18, 'MT', 'Mato Grosso'),
(19, 'MS', 'Mato Grosso do Sul'),
(20, 'DF', 'Distrito Federal'),
(21, 'ES', 'Espírito Santo'),
(22, 'MG', 'Minas Gerais'),
(23, 'SP', 'São Paulo'),
(24, 'RJ', 'Rio de Janeiro'),
(25, 'PR', 'Paraná'),
(26, 'RS', 'Rio Grande do Sul'),
(27, 'SC', 'Santa Catarina');

-- --------------------------------------------------------

--
-- Estrutura para tabela `regiao`
--

CREATE TABLE `regiao` (
  `idRegiao` int(11) NOT NULL,
  `idRegiaoEstado` int(11) NOT NULL,
  `idCapitalEstadoRegiao` int(11) NOT NULL,
  `SiglaRegiao` varchar(4) CHARACTER SET utf8 NOT NULL,
  `NomeRegiao` varchar(100) CHARACTER SET utf8 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `regiao`
--

INSERT INTO `regiao` (`idRegiao`, `idRegiaoEstado`, `idCapitalEstadoRegiao`, `SiglaRegiao`, `NomeRegiao`) VALUES
(1, 1, 1, 'N', 'Norte'),
(2, 2, 2, 'NE', 'Nordeste'),
(3, 3, 3, 'S', 'Sul'),
(4, 4, 4, 'SE', 'Sudeste'),
(5, 5, 5, 'CO', 'Centro-Oeste');

--
-- Índices de tabelas apagadas
--

--
-- Índices de tabela `capital`
--
ALTER TABLE `capital`
  ADD PRIMARY KEY (`idCapital`);

--
-- Índices de tabela `cidade`
--
ALTER TABLE `cidade`
  ADD PRIMARY KEY (`idCidade`);

--
-- Índices de tabela `estado`
--
ALTER TABLE `estado`
  ADD PRIMARY KEY (`idEstado`);

--
-- Índices de tabela `regiao`
--
ALTER TABLE `regiao`
  ADD PRIMARY KEY (`idRegiao`);

--
-- AUTO_INCREMENT de tabelas apagadas
--

--
-- AUTO_INCREMENT de tabela `capital`
--
ALTER TABLE `capital`
  MODIFY `idCapital` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT de tabela `cidade`
--
ALTER TABLE `cidade`
  MODIFY `idCidade` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `estado`
--
ALTER TABLE `estado`
  MODIFY `idEstado` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT de tabela `regiao`
--
ALTER TABLE `regiao`
  MODIFY `idRegiao` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
