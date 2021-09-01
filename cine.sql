-- phpMyAdmin SQL Dump
-- version 4.7.9
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 01-09-2021 a las 15:26:03
-- Versión del servidor: 5.7.21
-- Versión de PHP: 5.6.35

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `cine`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `actores`
--

DROP TABLE IF EXISTS `actores`;
CREATE TABLE IF NOT EXISTS `actores` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(30) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `actores`
--

INSERT INTO `actores` (`id`, `nombre`) VALUES
(1, 'Kang-ho Song'),
(2, 'Sun-kyun Lee'),
(3, 'Yeo-jeong Cho'),
(4, 'Viggo Mortensen'),
(5, 'Mahershala Ali'),
(6, 'Linda Cardellini'),
(7, 'Sally Hawkins'),
(8, 'Octavia Spencer'),
(9, 'Michael Shannon'),
(10, 'Naomie Harris'),
(11, 'Trevante Rhodes'),
(12, 'Mark Ruffalo'),
(13, 'Michael Keaton'),
(14, 'Rachel McAdams'),
(15, 'Zach Galifianakis'),
(16, 'Edward Norton'),
(17, 'Chiwetel Ejiofor'),
(18, 'Michael Kenneth Williams'),
(19, 'Michael Fassbender'),
(20, 'Ben Affleck'),
(21, 'Brian Cranston'),
(22, 'John Goodman'),
(23, 'Jean Dujardin'),
(24, 'Berénice Bejo'),
(25, 'Colin Firth'),
(26, 'Geoffrey Rush'),
(27, 'Helena Bonham Carter');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `actorespelicula`
--

DROP TABLE IF EXISTS `actorespelicula`;
CREATE TABLE IF NOT EXISTS `actorespelicula` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idactor` int(11) NOT NULL,
  `idpelicula` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `idactor` (`idactor`),
  KEY `idpelicula` (`idpelicula`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `actorespelicula`
--

INSERT INTO `actorespelicula` (`id`, `idactor`, `idpelicula`) VALUES
(1, 1, 1),
(2, 2, 1),
(3, 3, 1),
(4, 4, 2),
(5, 5, 2),
(6, 6, 2),
(9, 7, 4),
(10, 8, 4),
(11, 9, 4);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categorias`
--

DROP TABLE IF EXISTS `categorias`;
CREATE TABLE IF NOT EXISTS `categorias` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `categorias`
--

INSERT INTO `categorias` (`id`, `nombre`) VALUES
(1, 'Drama'),
(2, 'Biografía'),
(3, 'Fantasía'),
(4, 'Comedia'),
(5, 'Animación');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `directores`
--

DROP TABLE IF EXISTS `directores`;
CREATE TABLE IF NOT EXISTS `directores` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(30) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `directores`
--

INSERT INTO `directores` (`id`, `nombre`) VALUES
(1, 'Bong Joon-ho'),
(2, 'Peter Farrely'),
(3, 'Guillermo del Toro'),
(4, 'Barry Jenkins'),
(5, 'Tom McCarthy'),
(6, 'Alejandro González Iñárritu'),
(7, 'Steve McQueen'),
(8, 'Ben Affleck'),
(9, 'Tom Hopper'),
(10, 'Michel Hazanavicius');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `peliculas`
--

DROP TABLE IF EXISTS `peliculas`;
CREATE TABLE IF NOT EXISTS `peliculas` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(30) NOT NULL,
  `anio` int(11) NOT NULL,
  `duracion` decimal(10,0) NOT NULL,
  `idDirector` int(11) NOT NULL,
  `IMDB` decimal(10,0) NOT NULL,
  `idCategoria` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `idCategoria` (`idCategoria`),
  KEY `idDirector` (`idDirector`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `peliculas`
--

INSERT INTO `peliculas` (`id`, `nombre`, `anio`, `duracion`, `idDirector`, `IMDB`, `idCategoria`) VALUES
(1, 'Parasite', 2019, '132', 1, '9', 1),
(2, 'Green Book', 2018, '130', 2, '8', 2),
(4, 'La forma del agua', 2017, '123', 3, '7', 3),
(5, 'Moonlight', 2016, '111', 4, '7', 1),
(8, 'Spotlight', 2015, '139', 5, '8', 2),
(9, 'Birdman', 2014, '119', 6, '8', 4),
(10, '12 años de esclavitud', 2013, '134', 7, '8', 2),
(11, 'Argo', 2012, '120', 8, '8', 1),
(12, 'El Artista', 2011, '100', 10, '8', 4),
(13, 'El discurso del rey', 2010, '118', 9, '8', 1);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `actorespelicula`
--
ALTER TABLE `actorespelicula`
  ADD CONSTRAINT `actorespelicula_ibfk_1` FOREIGN KEY (`idpelicula`) REFERENCES `peliculas` (`id`),
  ADD CONSTRAINT `actorespelicula_ibfk_2` FOREIGN KEY (`idactor`) REFERENCES `actores` (`id`);

--
-- Filtros para la tabla `peliculas`
--
ALTER TABLE `peliculas`
  ADD CONSTRAINT `peliculas_ibfk_1` FOREIGN KEY (`idCategoria`) REFERENCES `categorias` (`id`),
  ADD CONSTRAINT `peliculas_ibfk_2` FOREIGN KEY (`idDirector`) REFERENCES `directores` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
