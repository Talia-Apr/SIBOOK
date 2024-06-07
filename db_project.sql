-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 18 Des 2023 pada 00.59
-- Versi server: 10.4.28-MariaDB
-- Versi PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_project`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_anggota`
--

CREATE TABLE `tbl_anggota` (
  `id_anggota` varchar(50) NOT NULL,
  `nama` varchar(50) DEFAULT NULL,
  `jenis_kelamin` varchar(20) DEFAULT NULL,
  `telp_anggota` varchar(20) DEFAULT NULL,
  `alamat` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbl_anggota`
--

INSERT INTO `tbl_anggota` (`id_anggota`, `nama`, `jenis_kelamin`, `telp_anggota`, `alamat`) VALUES
('AG001', 'Kina', 'Perempuan', '98979888', 'Sidoarjo'),
('AG002', 'Adi', 'Laki-Laki', '7867789', 'Sidoarjo');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_buku`
--

CREATE TABLE `tbl_buku` (
  `id_buku` varchar(50) NOT NULL,
  `judul` varchar(50) DEFAULT NULL,
  `penerbit` varchar(50) DEFAULT NULL,
  `rak` varchar(20) DEFAULT NULL,
  `stok` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbl_buku`
--

INSERT INTO `tbl_buku` (`id_buku`, `judul`, `penerbit`, `rak`, `stok`) VALUES
('BK001', 'Pengantar Membuat Robot', 'Gava Media', '3', 16),
('BK002', 'Pengantar Teknologi Informasi', '	Andi Offset', '1', 41);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_detailkembali`
--

CREATE TABLE `tbl_detailkembali` (
  `id_detailkembali` int(11) NOT NULL,
  `id_kembali` varchar(50) DEFAULT NULL,
  `id_buku` varchar(50) DEFAULT NULL,
  `tgl_kembali` date NOT NULL,
  `tgl_terima` date NOT NULL,
  `denda` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_detailpinjam`
--

CREATE TABLE `tbl_detailpinjam` (
  `id_detailpinjam` int(11) NOT NULL,
  `id_pinjam` varchar(50) DEFAULT NULL,
  `id_buku` varchar(50) DEFAULT NULL,
  `jumlah` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_kembali`
--

CREATE TABLE `tbl_kembali` (
  `id_kembali` varchar(50) NOT NULL,
  `id_pinjam` varchar(50) DEFAULT NULL,
  `id_anggota` varchar(50) DEFAULT NULL,
  `tgl_kembali` date DEFAULT NULL,
  `tgl_terima` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_pinjam`
--

CREATE TABLE `tbl_pinjam` (
  `id_pinjam` varchar(50) NOT NULL,
  `id_anggota` varchar(50) DEFAULT NULL,
  `tgl_pinjam` date DEFAULT NULL,
  `tgl_kembali` date DEFAULT NULL,
  `jumlah` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_user`
--

CREATE TABLE `tbl_user` (
  `id_user` varchar(50) NOT NULL,
  `username` varchar(50) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  `role` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbl_user`
--

INSERT INTO `tbl_user` (`id_user`, `username`, `password`, `role`) VALUES
('ADM002', 'Talia', '123', 'Admin'),
('OWN001', 'Adel', '123', 'Owner'),
('PGL001', 'Nurul', '123', 'Pengelola');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbl_anggota`
--
ALTER TABLE `tbl_anggota`
  ADD PRIMARY KEY (`id_anggota`);

--
-- Indeks untuk tabel `tbl_buku`
--
ALTER TABLE `tbl_buku`
  ADD PRIMARY KEY (`id_buku`);

--
-- Indeks untuk tabel `tbl_detailkembali`
--
ALTER TABLE `tbl_detailkembali`
  ADD PRIMARY KEY (`id_detailkembali`),
  ADD KEY `id_kembali` (`id_kembali`),
  ADD KEY `id_buku` (`id_buku`);

--
-- Indeks untuk tabel `tbl_detailpinjam`
--
ALTER TABLE `tbl_detailpinjam`
  ADD PRIMARY KEY (`id_detailpinjam`),
  ADD KEY `id_pinjam` (`id_pinjam`),
  ADD KEY `id_buku` (`id_buku`);

--
-- Indeks untuk tabel `tbl_kembali`
--
ALTER TABLE `tbl_kembali`
  ADD PRIMARY KEY (`id_kembali`),
  ADD KEY `id_pinjam` (`id_pinjam`),
  ADD KEY `id_anggota` (`id_anggota`);

--
-- Indeks untuk tabel `tbl_pinjam`
--
ALTER TABLE `tbl_pinjam`
  ADD PRIMARY KEY (`id_pinjam`),
  ADD KEY `id_anggota` (`id_anggota`);

--
-- Indeks untuk tabel `tbl_user`
--
ALTER TABLE `tbl_user`
  ADD PRIMARY KEY (`id_user`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `tbl_detailkembali`
--
ALTER TABLE `tbl_detailkembali`
  MODIFY `id_detailkembali` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT untuk tabel `tbl_detailpinjam`
--
ALTER TABLE `tbl_detailpinjam`
  MODIFY `id_detailpinjam` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=68;

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `tbl_detailkembali`
--
ALTER TABLE `tbl_detailkembali`
  ADD CONSTRAINT `tbl_detailkembali_ibfk_1` FOREIGN KEY (`id_kembali`) REFERENCES `tbl_kembali` (`id_kembali`),
  ADD CONSTRAINT `tbl_detailkembali_ibfk_2` FOREIGN KEY (`id_buku`) REFERENCES `tbl_buku` (`id_buku`);

--
-- Ketidakleluasaan untuk tabel `tbl_detailpinjam`
--
ALTER TABLE `tbl_detailpinjam`
  ADD CONSTRAINT `tbl_detailpinjam_ibfk_1` FOREIGN KEY (`id_pinjam`) REFERENCES `tbl_pinjam` (`id_pinjam`),
  ADD CONSTRAINT `tbl_detailpinjam_ibfk_2` FOREIGN KEY (`id_buku`) REFERENCES `tbl_buku` (`id_buku`);

--
-- Ketidakleluasaan untuk tabel `tbl_kembali`
--
ALTER TABLE `tbl_kembali`
  ADD CONSTRAINT `tbl_kembali_ibfk_1` FOREIGN KEY (`id_pinjam`) REFERENCES `tbl_pinjam` (`id_pinjam`),
  ADD CONSTRAINT `tbl_kembali_ibfk_2` FOREIGN KEY (`id_anggota`) REFERENCES `tbl_anggota` (`id_anggota`);

--
-- Ketidakleluasaan untuk tabel `tbl_pinjam`
--
ALTER TABLE `tbl_pinjam`
  ADD CONSTRAINT `tbl_pinjam_ibfk_1` FOREIGN KEY (`id_anggota`) REFERENCES `tbl_anggota` (`id_anggota`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
