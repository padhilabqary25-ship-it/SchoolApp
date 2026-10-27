-- =====================================================
--  School App - database untuk XAMPP (MySQL / MariaDB)
--  Cara pakai:
--  1. Jalankan Apache + MySQL di XAMPP Control Panel
--  2. Buka http://localhost/phpmyadmin
--  3. Klik tab "SQL", tempel seluruh isi file ini, klik "Go/Kirim"
-- =====================================================

CREATE DATABASE IF NOT EXISTS pi_school
  CHARACTER SET utf8mb4
  COLLATE utf8mb4_general_ci;

USE pi_school;

-- ---------- Tabel siswa ----------
CREATE TABLE IF NOT EXISTS students (
  id         INT          NOT NULL AUTO_INCREMENT,
  nis        VARCHAR(20)  NOT NULL,
  name       VARCHAR(100) NOT NULL,
  class_name VARCHAR(50)  NOT NULL,
  address    VARCHAR(255) NOT NULL DEFAULT '',
  PRIMARY KEY (id),
  UNIQUE KEY uq_students_nis (nis)      -- dipakai app untuk pesan "NIS sudah terdaftar"
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ---------- Tabel visitor ----------
CREATE TABLE IF NOT EXISTS visitors (
  id          INT          NOT NULL AUTO_INCREMENT,
  visitors    VARCHAR(100) NOT NULL,
  institution VARCHAR(150) NOT NULL,
  PRIMARY KEY (id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ---------- Data contoh (boleh dihapus) ----------
INSERT IGNORE INTO students (nis, name, class_name, address) VALUES
  ('2024001', 'Andi Pratama',  'XII RPL 1', 'Jl. Merdeka No. 10, Bandung'),
  ('2024002', 'Siti Aisyah',   'XII RPL 1', 'Jl. Dago No. 25, Bandung'),
  ('2024003', 'Budi Santoso',  'XI TKJ 2',  'Jl. Cihampelas No. 8, Bandung');

INSERT INTO visitors (visitors, institution)
SELECT * FROM (
  SELECT 'Ahmad Fauzi' AS visitors, 'Dinas Pendidikan Kota Bandung' AS institution
  UNION ALL
  SELECT 'Rina Marlina', 'Universitas Pendidikan Indonesia'
) AS contoh
WHERE NOT EXISTS (SELECT 1 FROM visitors);
