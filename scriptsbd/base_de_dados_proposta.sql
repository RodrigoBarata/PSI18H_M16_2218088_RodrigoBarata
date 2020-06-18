-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 18-Jun-2020 às 18:32
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
-- Banco de dados: `base_de_dados/proposta`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `area`
--

CREATE TABLE `area` (
  `idarea` int(11) NOT NULL,
  `nome_area` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `area`
--

INSERT INTO `area` (`idarea`, `nome_area`) VALUES
(1, 'Banca'),
(2, 'Normas'),
(3, 'Sistema'),
(4, 'Turismo e Hotelaria');

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
--

CREATE TABLE `cliente` (
  `idcliente` int(11) NOT NULL,
  `nome` varchar(25) NOT NULL,
  `morada` varchar(45) NOT NULL,
  `contribuinte` int(11) NOT NULL,
  `n_telefone` int(11) NOT NULL,
  `perfil_de_cliente` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `cliente`
--

INSERT INTO `cliente` (`idcliente`, `nome`, `morada`, `contribuinte`, `n_telefone`, `perfil_de_cliente`) VALUES
(1, 'Homer Simpson', 'Evergreen Terrace, 632', 534543535, 876876867, 'Entidade'),
(2, 'Marge Simpson', 'Evergreen Terrace, 632', 2147483647, 2147483647, 'Entidade'),
(3, 'Bart Simpson', 'Evergreen Terrace, 632', 4543534, 423423, 'Particular'),
(4, 'Abu', '8006 Al Bardi, Al Mursalat', 43242343, 6546546, 'Particular');

-- --------------------------------------------------------

--
-- Estrutura da tabela `curso`
--

CREATE TABLE `curso` (
  `idcursos` int(11) NOT NULL,
  `nome_curso` varchar(100) NOT NULL,
  `subarea_idsubarea` int(11) NOT NULL,
  `subarea_area_idarea` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `curso`
--

INSERT INTO `curso` (`idcursos`, `nome_curso`, `subarea_idsubarea`, `subarea_area_idarea`) VALUES
(1, 'A FUNÇÃO DE COMPLIANCE NA BANCA COMERCIAL', 1, 1),
(2, 'ANÁLISE DE CRÉDITO', 1, 1),
(3, 'ANÁLISE E GESTÃO DE RISCO DE CRÉDITO', 1, 1),
(4, 'ANÁLISE TÉCNICA DE AÇÕES', 2, 1),
(5, 'CORPORATE FINANCE', 2, 1),
(6, 'A FUNÇÃO DE PROCUREMENT NO SECTOR BANCÁRIO - BOAS PRÁTICAS', 3, 1),
(7, 'A IMPORTÂNCIA DE UMA ADEQUADA COORDENAÇÃO COMERCIAL NA BANCA', 3, 1),
(8, 'AUDITORIAS A SISTEMAS HACCP', 4, 2),
(9, 'HACCP E SEGURANÇA ALIMENTAR', 4, 2),
(10, 'AUDITORIA VDA 6.3\r\n', 5, 2),
(11, 'AUDITORIAS AMBIENTAIS', 5, 2),
(12, 'Cisco', 6, 3),
(13, 'Microsoft', 7, 3),
(14, 'ATENDIMENTO E RECEÇÃO DO CLIENTE – ESPECIAL SECTOR DO TURISMO', 8, 4),
(15, 'GESTÃO DE ALIMENTOS E BEBIDAS - FOOD & BEVERAGE (F&B) MGT.', 8, 4),
(16, 'AS RELAÇÕES COM O EXTERIOR E A PROMOÇÃO DOS SERVIÇOS DA UNIDADE HOTELEIRA', 9, 4),
(17, 'GESTÃO DE SPA\'S', 9, 4);

-- --------------------------------------------------------

--
-- Estrutura da tabela `formacao`
--

CREATE TABLE `formacao` (
  `idformacao` int(11) NOT NULL,
  `data_de_inicio` datetime NOT NULL,
  `data_final` datetime NOT NULL,
  `formador_idformador` int(11) NOT NULL,
  `curso_idcursos` int(11) NOT NULL,
  `curso_subarea_idsubarea` int(11) NOT NULL,
  `curso_subarea_area_idarea` int(11) NOT NULL,
  `cliente_idcliente` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `formacao`
--

INSERT INTO `formacao` (`idformacao`, `data_de_inicio`, `data_final`, `formador_idformador`, `curso_idcursos`, `curso_subarea_idsubarea`, `curso_subarea_area_idarea`, `cliente_idcliente`) VALUES
(1, '2020-06-18 00:00:00', '2020-06-18 00:00:00', 1, 1, 1, 1, 1),
(2, '2020-06-26 00:00:00', '2020-07-10 00:00:00', 2, 11, 5, 2, 2),
(3, '2020-06-26 00:00:00', '2020-08-07 00:00:00', 2, 12, 6, 3, 3),
(4, '2020-06-09 00:00:00', '2020-08-11 00:00:00', 2, 13, 7, 3, 3),
(5, '2020-06-09 00:00:00', '2020-08-11 00:00:00', 1, 17, 9, 4, 2);

-- --------------------------------------------------------

--
-- Estrutura da tabela `formador`
--

CREATE TABLE `formador` (
  `idformador` int(11) NOT NULL,
  `nome` varchar(25) NOT NULL,
  `morada` varchar(45) NOT NULL,
  `contribuinte` int(11) NOT NULL,
  `n_telefone` int(11) NOT NULL,
  `perfil_de_formador` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `formador`
--

INSERT INTO `formador` (`idformador`, `nome`, `morada`, `contribuinte`, `n_telefone`, `perfil_de_formador`) VALUES
(1, 'Raul Olaf', 'Froz City', 5435435, 55435435, 'Ativo'),
(2, 'Elsa ', 'Frozen City', 543535, 454655756, 'Ativo');

-- --------------------------------------------------------

--
-- Estrutura da tabela `subarea`
--

CREATE TABLE `subarea` (
  `idsubarea` int(11) NOT NULL,
  `nome_subarea` varchar(45) NOT NULL,
  `area_idarea` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `subarea`
--

INSERT INTO `subarea` (`idsubarea`, `nome_subarea`, `area_idarea`) VALUES
(1, 'Controlo', 1),
(2, 'Mercados Financeiros', 1),
(3, 'Estratégia e Produtividade', 1),
(4, 'Alimentar', 2),
(5, 'Ambiente', 2),
(6, 'Cisco', 3),
(7, 'Microsoft', 3),
(8, 'Hotelaria e Restauração', 4),
(9, 'Turismo', 4);

-- --------------------------------------------------------

--
-- Estrutura da tabela `utilizador`
--

CREATE TABLE `utilizador` (
  `idutilizador` int(11) NOT NULL,
  `nome` varchar(45) NOT NULL,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `utilizador`
--

INSERT INTO `utilizador` (`idutilizador`, `nome`, `username`, `password`) VALUES
(1, 'Administrador', 'Admin', 'Admin');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `area`
--
ALTER TABLE `area`
  ADD PRIMARY KEY (`idarea`);

--
-- Índices para tabela `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`idcliente`);

--
-- Índices para tabela `curso`
--
ALTER TABLE `curso`
  ADD PRIMARY KEY (`idcursos`,`subarea_idsubarea`,`subarea_area_idarea`),
  ADD KEY `fk_curso_subarea1_idx` (`subarea_idsubarea`,`subarea_area_idarea`);

--
-- Índices para tabela `formacao`
--
ALTER TABLE `formacao`
  ADD PRIMARY KEY (`idformacao`,`formador_idformador`,`curso_idcursos`,`curso_subarea_idsubarea`,`curso_subarea_area_idarea`,`cliente_idcliente`),
  ADD KEY `fk_formacao_formador1_idx` (`formador_idformador`),
  ADD KEY `fk_formacao_curso1_idx` (`curso_idcursos`,`curso_subarea_idsubarea`,`curso_subarea_area_idarea`),
  ADD KEY `fk_formacao_cliente1_idx` (`cliente_idcliente`);

--
-- Índices para tabela `formador`
--
ALTER TABLE `formador`
  ADD PRIMARY KEY (`idformador`);

--
-- Índices para tabela `subarea`
--
ALTER TABLE `subarea`
  ADD PRIMARY KEY (`idsubarea`,`area_idarea`),
  ADD KEY `fk_subarea_area1_idx` (`area_idarea`);

--
-- Índices para tabela `utilizador`
--
ALTER TABLE `utilizador`
  ADD PRIMARY KEY (`idutilizador`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `area`
--
ALTER TABLE `area`
  MODIFY `idarea` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `cliente`
--
ALTER TABLE `cliente`
  MODIFY `idcliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `curso`
--
ALTER TABLE `curso`
  MODIFY `idcursos` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT de tabela `formacao`
--
ALTER TABLE `formacao`
  MODIFY `idformacao` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de tabela `formador`
--
ALTER TABLE `formador`
  MODIFY `idformador` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `subarea`
--
ALTER TABLE `subarea`
  MODIFY `idsubarea` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de tabela `utilizador`
--
ALTER TABLE `utilizador`
  MODIFY `idutilizador` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `curso`
--
ALTER TABLE `curso`
  ADD CONSTRAINT `fk_curso_subarea1` FOREIGN KEY (`subarea_idsubarea`,`subarea_area_idarea`) REFERENCES `subarea` (`idsubarea`, `area_idarea`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `formacao`
--
ALTER TABLE `formacao`
  ADD CONSTRAINT `fk_formacao_cliente1` FOREIGN KEY (`cliente_idcliente`) REFERENCES `cliente` (`idcliente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_formacao_curso1` FOREIGN KEY (`curso_idcursos`,`curso_subarea_idsubarea`,`curso_subarea_area_idarea`) REFERENCES `curso` (`idcursos`, `subarea_idsubarea`, `subarea_area_idarea`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_formacao_formador1` FOREIGN KEY (`formador_idformador`) REFERENCES `formador` (`idformador`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `subarea`
--
ALTER TABLE `subarea`
  ADD CONSTRAINT `fk_subarea_area1` FOREIGN KEY (`area_idarea`) REFERENCES `area` (`idarea`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
