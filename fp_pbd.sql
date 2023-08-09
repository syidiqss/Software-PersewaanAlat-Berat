-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 27 Jun 2021 pada 08.21
-- Versi server: 10.4.14-MariaDB
-- Versi PHP: 7.4.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `fp_pbd`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `admin`
--

CREATE TABLE `admin` (
  `ID_ADMIN` char(5) NOT NULL,
  `nama` varchar(20) NOT NULL,
  `USERNAME` varchar(50) NOT NULL,
  `PASS` varchar(50) NOT NULL,
  `EMAIL` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `admin`
--

INSERT INTO `admin` (`ID_ADMIN`, `nama`, `USERNAME`, `PASS`, `EMAIL`) VALUES
('AD001', 'Budi', 'admin', 'admin', 'admin@gmail.com'),
('AD002', 'Administrator', 'admin2', 'admin2', 'admin2@gmail.com');

-- --------------------------------------------------------

--
-- Struktur dari tabel `alat_berat`
--

CREATE TABLE `alat_berat` (
  `ID_ALAT` char(5) NOT NULL,
  `NAMA_ALAT` varchar(100) NOT NULL,
  `HARGA` int(11) NOT NULL,
  `ID_JENIS` char(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `alat_berat`
--

INSERT INTO `alat_berat` (`ID_ALAT`, `NAMA_ALAT`, `HARGA`, `ID_JENIS`) VALUES
('AB001', 'Excavator - Komatsu', 3500000, 'JA001'),
('AB002', 'Excavator - Hitachi', 3500000, 'JA001'),
('AB003', 'Forklift - Hitachi', 3500000, 'JA002');

-- --------------------------------------------------------

--
-- Struktur dari tabel `jenis_alat`
--

CREATE TABLE `jenis_alat` (
  `ID_JENIS` char(5) NOT NULL,
  `NAMA_JENIS` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `jenis_alat`
--

INSERT INTO `jenis_alat` (`ID_JENIS`, `NAMA_JENIS`) VALUES
('JA001', 'Excavator'),
('JA002', 'Forklift'),
('JA003', 'Genset');

-- --------------------------------------------------------

--
-- Struktur dari tabel `pelanggan`
--

CREATE TABLE `pelanggan` (
  `ID_PELANGGAN` char(5) NOT NULL,
  `NAMA_PELANGGAN` varchar(50) NOT NULL,
  `ALAMAT_PELANGGAN` varchar(100) NOT NULL,
  `NOHP_PELANGGAN` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `pelanggan`
--

INSERT INTO `pelanggan` (`ID_PELANGGAN`, `NAMA_PELANGGAN`, `ALAMAT_PELANGGAN`, `NOHP_PELANGGAN`) VALUES
('P0001', 'Budi', 'Yogyakarta', '08123456789'),
('P0002', 'Andi 2', 'Magelang', '08234567891');

-- --------------------------------------------------------

--
-- Struktur dari tabel `transaksi`
--

CREATE TABLE `transaksi` (
  `ID_TRANSAKSI` char(5) NOT NULL,
  `STATUS_TRANSAKSI` varchar(50) NOT NULL,
  `TANGGAL` datetime NOT NULL DEFAULT current_timestamp(),
  `WAKTU` int(11) NOT NULL,
  `ID_ADMIN` char(5) NOT NULL,
  `ID_PELANGGAN` char(5) NOT NULL,
  `ID_ALAT` char(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `transaksi`
--

INSERT INTO `transaksi` (`ID_TRANSAKSI`, `STATUS_TRANSAKSI`, `TANGGAL`, `WAKTU`, `ID_ADMIN`, `ID_PELANGGAN`, `ID_ALAT`) VALUES
('TR001', 'SELESAI', '2021-06-27 02:13:24', 2, 'AD001', 'P0001', 'AB001'),
('TR003', 'SELESAI', '2021-06-27 02:13:32', 1, 'AD001', 'P0001', 'AB001'),
('TR004', 'SELESAI', '2021-06-26 15:44:37', 2, 'AD001', 'P0001', 'AB001');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`ID_ADMIN`);

--
-- Indeks untuk tabel `alat_berat`
--
ALTER TABLE `alat_berat`
  ADD PRIMARY KEY (`ID_ALAT`),
  ADD KEY `ID_JENIS` (`ID_JENIS`);

--
-- Indeks untuk tabel `jenis_alat`
--
ALTER TABLE `jenis_alat`
  ADD PRIMARY KEY (`ID_JENIS`);

--
-- Indeks untuk tabel `pelanggan`
--
ALTER TABLE `pelanggan`
  ADD PRIMARY KEY (`ID_PELANGGAN`);

--
-- Indeks untuk tabel `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`ID_TRANSAKSI`),
  ADD KEY `ID_ADMIN` (`ID_ADMIN`),
  ADD KEY `ID_PELANGGAN` (`ID_PELANGGAN`),
  ADD KEY `ID_ALAT` (`ID_ALAT`);

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `alat_berat`
--
ALTER TABLE `alat_berat`
  ADD CONSTRAINT `alat_berat_ibfk_1` FOREIGN KEY (`ID_JENIS`) REFERENCES `jenis_alat` (`ID_JENIS`);

--
-- Ketidakleluasaan untuk tabel `transaksi`
--
ALTER TABLE `transaksi`
  ADD CONSTRAINT `transaksi_ibfk_1` FOREIGN KEY (`ID_ADMIN`) REFERENCES `admin` (`ID_ADMIN`),
  ADD CONSTRAINT `transaksi_ibfk_2` FOREIGN KEY (`ID_PELANGGAN`) REFERENCES `pelanggan` (`ID_PELANGGAN`),
  ADD CONSTRAINT `transaksi_ibfk_3` FOREIGN KEY (`ID_ALAT`) REFERENCES `alat_berat` (`ID_ALAT`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
