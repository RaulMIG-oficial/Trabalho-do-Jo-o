-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 23/06/2025 às 23:12
-- Versão do servidor: 10.4.32-MariaDB
-- Versão do PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `criptocode`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `c_cesar_saves`
--

CREATE TABLE `c_cesar_saves` (
  `Normal_text_cesar` varchar(100) NOT NULL,
  `chave` int(2) NOT NULL,
  `Cripto_text_cesar` varchar(100) NOT NULL,
  `usuario_email` varchar(50) NOT NULL,
  `id_Cesar` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `c_cesar_saves`
--

INSERT INTO `c_cesar_saves` (`Normal_text_cesar`, `chave`, `Cripto_text_cesar`, `usuario_email`, `id_Cesar`) VALUES
('Raul', 1, 'SBVM', 'Raul@gmail.com', 1),
('Batata', 6, 'HGZGZG', 'Raul@gmail.com', 2),
('qualquer', 1, 'RVBMRVFS', 'Aline@gmail.com', 5),
('\r\nCoizinha so para', 6, '\r\nIUOFOTNG YU VGXG', 'Aline@gmail.com', 6),
('que eu possa', 9, 'ZDN ND YXBBJ', 'Aline@gmail.com', 7),
('Salvar', 12, 'EMXHMD', 'Aline@gmail.com', 8);

-- --------------------------------------------------------

--
-- Estrutura para tabela `c_hash_saves`
--

CREATE TABLE `c_hash_saves` (
  `Normal_text_hash` varchar(100) NOT NULL,
  `Cripto_text_hash` varchar(100) NOT NULL,
  `id_hash` int(4) NOT NULL,
  `usuario_email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `c_hash_saves`
--

INSERT INTO `c_hash_saves` (`Normal_text_hash`, `Cripto_text_hash`, `id_hash`, `usuario_email`) VALUES
('Batata', 'gvjT0pvDuOhGV65TnRwS4HmjEFLTKLnoNodHY34BRAQ=', 1, 'Raul@gmail.com'),
('Batata', 'gvjT0pvDuOhGV65TnRwS4HmjEFLTKLnoNodHY34BRAQ=', 2, 'Raul@gmail.com'),
('Testando', '5FxRSO/VOLKeP8uTDWiYFMACwckmeokxev81ADx1mmw=', 3, 'Aline@gmail.com'),
('Batata', 'gvjT0pvDuOhGV65TnRwS4HmjEFLTKLnoNodHY34BRAQ=', 4, 'Aline@gmail.com'),
('goiaba', 'FwkBxL1AIK6fD43B1E+tZfhFOywoz5Kpw/MNZ6OpB5E=', 5, 'Aline@gmail.com'),
('cenoura', 'uECoyqogP2XgCR57mtKkI8fQril/RSbr8mNvSAkTlRA=', 6, 'Aline@gmail.com');

-- --------------------------------------------------------

--
-- Estrutura para tabela `c_ra_saves`
--

CREATE TABLE `c_ra_saves` (
  `Normal_text_ra` varchar(100) NOT NULL,
  `Cripto_text_ra` varchar(100) NOT NULL,
  `id_ra` int(4) NOT NULL,
  `usuario_email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `c_ra_saves`
--

INSERT INTO `c_ra_saves` (`Normal_text_ra`, `Cripto_text_ra`, `id_ra`, `usuario_email`) VALUES
('padastro', 'yjmj#$\"x[9]', 1, 'Raul@gmail.com'),
('baitola', 'edlwrod[3]', 2, 'Aline@gmail.com'),
('nina', 'totg[6]', 3, 'Aline@gmail.com'),
('meu nome manu ela minha idade é 56 e *&¨%$#', 'phx#qrph#pdqx#hod#plqkd#lgdgh#:#89#h#-)R(\'&[3]', 4, 'Aline@gmail.com');

-- --------------------------------------------------------

--
-- Estrutura para tabela `usuario`
--

CREATE TABLE `usuario` (
  `Email` varchar(50) NOT NULL,
  `Apelido` varchar(20) DEFAULT NULL,
  `Senha` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `usuario`
--

INSERT INTO `usuario` (`Email`, `Apelido`, `Senha`) VALUES
('Aline@gmail.com', 'Alinezinha', 'jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI='),
('Raul@gmail.com', 'RaulMIG', 'GdeeiNIX3+4IgNmiv7XuA0goEYDuHYhR4w7ezyS0wFU='),
('test0@gmail.com', 'Balestrim', 'Ou7Z0kx7sOnjjnssrNDCeAxzyXxALnh5o3PyVGwPY3w='),
('test1@gmail.com', 'Matheus', 'BhRYCBCIQAoL1ho2aUjZXGnvxwC6cd8V+O/yY9hnUjw='),
('test2@gmail.com', 'J.J', 'zC4WaVXsSWdedJ+dziHbDL0pedSqxKhFvd41zLZCvEc='),
('Test3@gmail.com', 'Baleia', 'x3Xnt1ft5jDNCqERO9ECZhqziCnKUqZCKreChi8mhkY=');

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `c_cesar_saves`
--
ALTER TABLE `c_cesar_saves`
  ADD PRIMARY KEY (`id_Cesar`);

--
-- Índices de tabela `c_hash_saves`
--
ALTER TABLE `c_hash_saves`
  ADD PRIMARY KEY (`id_hash`);

--
-- Índices de tabela `c_ra_saves`
--
ALTER TABLE `c_ra_saves`
  ADD PRIMARY KEY (`id_ra`);

--
-- Índices de tabela `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`Email`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `c_cesar_saves`
--
ALTER TABLE `c_cesar_saves`
  MODIFY `id_Cesar` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de tabela `c_hash_saves`
--
ALTER TABLE `c_hash_saves`
  MODIFY `id_hash` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de tabela `c_ra_saves`
--
ALTER TABLE `c_ra_saves`
  MODIFY `id_ra` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
