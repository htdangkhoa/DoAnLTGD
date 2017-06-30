
DROP DATABASE TuyenSinh
--use master

--Create Database

--CREATE DATABASE [TuyenSinh] ON PRIMARY
--(
--	NAME = 'TuyenSinh',
--	FILENAME = 'C:\TuyenSinh\TuyenSinh.mdf',
--	SIZE = 4MB,
--	MAXSIZE = UNLIMITED,
--	FILEGROWTH = 1024KB
--)

--LOG ON
--(
--	NAME = 'TuyenSinh_log',
--	FILENAME = 'C:\TuyenSinh\TuyenSinh_log.ldf',
--	SIZE = 1024KB,
--	MAXSIZE = 2048KB,
--	FILEGROWTH = 10%
--)
--GO

---- Use Database

--use TuyenSinh
--GO

-- Create table
--CREATE TABLE ThiSinhDuThi
--(
--	MaSoDuThi char NOT NULL,
--	HoTenLot Text,
--	TenThiSinh Text,
--	CMND Int,
--	DiaChi Text,
--	SDT Int,
--	Email Text,
--	MaDoiTuong char NOT NULL
--)
--GO

--CREATE TABLE XetTuyen
--(
--	MaNganh char NOT NULL,
--	MaSoDuThi char NOT NULL,
--	UuTien Text
--)
--GO

--CREATE TABLE NganhTuyenSinh
--(
--	MaNganh char NOT NULL,
--	MaTruong char NOT NULL,
--	TenNganh Text,
--	ChiTieu Text,
--	NangKhieu Text
--)
--GO

--CREATE TABLE Truong
--(
--	MaTruong char NOT NULL,
--	TenTruong Text,
--	DiaChi Text
--)
--GO

--CREATE TABLE KiemTra
--(
--	MaNganh char NOT NULL,
--	MaCacMonThi char NOT NULL
--)
--GO

--CREATE TABLE CacMonThi
--(
--	MaCacMonThi char NOT NULL,
--	MaMon1 char NOT NULL,
--	MaMon2 char NOT NULL,
--	MaMon3 char NOT NULL,
--	HeSoMon Text,
--	MonNangKhieu Text
--)
--GO

--CREATE TABLE Mon
--(
--	TenMon Text,
--	NangKhieu Text,
--	MaMon char NOT NULL
--)
--GO

--CREATE TABLE KetQuaThi
--(
--	MaSoDuThi char NOT NULL,
--	MaMon char NOT NULL,
--	Diem Float
--)
--GO

--CREATE TABLE DoiTuongUuTien
--(
--	TenDoiTuong Text,
--	DiemCong Float,
--	MaDoiTuong char NOT NULL
--)
--GO

--CREATE TABLE Username
--(
--	id int NOT NULL,
--	username Text,
--	pass Text
--)
--GO

--Primary key

--ALTER TABLE ThiSinhDuThi
--	ADD CONSTRAINT pk_ThiSinhDuThi PRIMARY KEY (MaSoDuThi);

--ALTER TABLE XetTuyen
--	ADD CONSTRAINT pk_XetTuyen PRIMARY KEY (MaNganh, MaSoDuThi);

--ALTER TABLE NganhTuyenSinh
--	ADD CONSTRAINT pk_NganhTuyenSinh PRIMARY KEY (MaNganh);

--ALTER TABLE Truong 
--	ADD CONSTRAINT pk_Truong PRIMARY KEY (MaTruong);

--ALTER TABLE KiemTra 
--	ADD CONSTRAINT pk_KiemTra PRIMARY KEY (MaNganh, MaCacMonThi);

--ALTER TABLE CacMonthi 
--	ADD CONSTRAINT pk_CacMonThi PRIMARY KEY (MaCacMonThi);

--ALTER TABLE Mon 
--	ADD CONSTRAINT pk_Mon PRIMARY KEY (MaMon);

--ALTER TABLE DoiTuongUuTien 
--	ADD CONSTRAINT pk_DoiTuongUuTien PRIMARY KEY (MaDoiTuong);
	
--ALTER TABLE username 
--	ADD CONSTRAINT pk_username PRIMARY KEY (id);

--Foreign key

--ALTER TABLE ThiSinhDuThi
--	ADD CONSTRAINT fk_ThiSinhDuThi FOREIGN KEY(MaDoiTuong) REFERENCES DoiTuongUuTien(MaDoiTuong);

--ALTER TABLE XetTuyen
--	ADD CONSTRAINT fk_XetTuyen FOREIGN KEY(MaSoDuThi) REFERENCES ThiSinhDuThi(MaSoDuThi),
--							   FOREIGN KEY(MaNganh) REFERENCES NganhTuyenSinh(MaNganh);

--ALTER TABLE NganhTuyenSinh
--	ADD CONSTRAINT fk_NganhTuyenSinh FOREIGN KEY(MaTruong) REFERENCES Truong(MaTruong);

--ALTER TABLE KiemTra
--	ADD CONSTRAINT fk_KiemTra FOREIGN KEY(MaNganh) REFERENCES NganhTuyenSinh(MaNganh),
--							  FOREIGN KEY(MaCacMonThi) REFERENCES CacMonThi(MaCacMonThi);

--ALTER TABLE KetQuaThi
--	ADD CONSTRAINT fk_KetQuaThi FOREIGN KEY(MaSoDuThi) REFERENCES ThiSinhDuThi(MaSoDuThi),
--								FOREIGN KEY(MaMon) REFERENCES Mon(MaMon);

--ALTER TABLE CacMonThi
--	ADD CONSTRAINT fk_CacMonthi FOREIGN KEY(MaMon1) REFERENCES Mon(MaMon),
--								FOREIGN KEY(MaMon2) REFERENCES Mon(MaMon),
--								FOREIGN KEY(MaMon3) REFERENCES Mon(MaMon);
	