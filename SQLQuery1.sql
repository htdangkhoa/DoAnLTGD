--drop database QL_SinhVien
--create database QL_SinhVien ON primary
--	( NAME = 'QL_Nuoc',
--	filename = 'C:\TuyenSinh\TuyenSinh.mdf',
--	size = 3072KB,
--	maxsize = unlimited,
--	filegrowth = 1024KB)
--log on
--	( name = 'QL_SinhVien_log',
--	filename = 'C:\TuyenSinh\TuyenSinh_log.ldf',
--	SIZE = 1024KB ,
--	MAXSIZE = 2048KB ,
--	FILEGROWTH = 10%)
--Go
--use QL_SinhVien
--create table ThiSinh_DuThi
--	(MaSo_DuThi Char(10) NOT NULL,
--	Ho_TenLot varchar(15),
--	Ten_ThiSinh varchar(15),
--	CMND Char(10),
--	DiaChi varchar(15),
--	SDT varchar(15),
--	Email varchar(15),
--	Ma_DoiTuong varchar(15) NOT NULL)
--Go
--create table DoiTuong
--	(Ma_DoiTuong varchar(15) NOT NULL,
--	Ten_DoiTuong varchar(15),
--	Nhom_UuTien varchar(15),
--	Diem_Cong Char(10))
--Go
--create table ToHop_Mon
--	(Ma_ToHopMon Char(10) NOT NULL,
--	He_SoMon varchar(15),
--	Mon_NangKhieu varchar(15),
--	Ma_Mon1 Char(10) NOT NULL,
--	Ma_Mon2 Char(10) NOT NULL,
--	Ma_Mon3 Char(10) NOT NULL)
--Go
--create table KQ_Thi
--	(Ma_Mon Char(10) NOT NULL,
--	Diem char(15),
--	MaSo_DuThi char(10) NOT NULL)
--Go
--create table Mon
--	(Ma_Mon Char(10) NOT NULL,
--	Ten_Mon varchar(15),
--	Nang_Khieu varchar(15))
--Go
--create table Nganh_TS
--	(Ma_Nganh char(15) NOT NULL,
--	Ten_Nganh varchar(15),
--	Chi_Tieu char(15),
--	Nang_Khieu varchar(15),
--	Ma_ToHopMon char(10) NOT NULL,
--	Ma_Truong char(10) NOT NULL)
--Go
--create table XetTuyen
--	(Uu_Tien Char(10),
--	Ma_Nganh char(15) NOT NULL,
--	MaSo_DuThi char(10) NOT NULL)
--Go
--create table Xet
--	(Ma_Nganh Char(15) NOT NULL,
--	Ma_ToHopMon char(10) NOT NULL)
--Go
--create table Truong
--	(Ma_Truong Char(10) NOT NULL,
--	Ten_Truong varchar(15),
--	Dia_Chi varchar(15))
--Go

--create table username
--(
--	id char(10) NOT NULL,
--	username char(50),
--	pass char(50)
--)


--alter table username
--	add constraint pk_id primary key (id)
--GO

--alter table DoiTuong
--	add constraint pk_MaDoiTuong primary key (Ma_DoiTuong)
--GO
--alter table ThiSinh_DuThi
--	add constraint pk_MSDT primary key (MaSo_DuThi)
--GO
--alter table Mon
--	add constraint pk_MaMon primary key (Ma_Mon)
--GO
--alter table XetTuyen
--	add constraint pk_XetTuyen primary key (Ma_Nganh,MaSo_DuThi)
--GO
--alter table Nganh_TS
--	add constraint pk_MaNganh primary key (Ma_Nganh)
--GO
--alter table ToHop_Mon
--	add constraint pk_MaTHM primary key (Ma_ToHopMon)
--GO
--alter table Xet
--	add constraint pk_Xet primary key (Ma_Nganh,Ma_ToHopMon)
--GO
--alter table Truong
--	add constraint pk_MaTruong primary key (Ma_Truong)
--GO
--alter table ThiSinh_DuThi
--add constraint fk_TSDT_MDT foreign key (Ma_DoiTuong) references DoiTuong(Ma_DoiTuong)
--GO
--alter table KQ_Thi
--add constraint fk_KQT_MSDT foreign key (MaSo_DuThi) references ThiSinh_DuThi(MaSo_DuThi)
--GO
--alter table KQ_Thi
--add constraint fk_KQT_MM foreign key (Ma_Mon) references Mon(Ma_Mon)
--GO
--alter table XetTuyen
--add constraint fk_XT_MSoDT foreign key (MaSo_DuThi) references ThiSinh_DuThi(MaSo_DuThi)
--GO
--alter table XetTuyen
--add constraint fk_XT_MNganh foreign key (Ma_Nganh) references Nganh_TS(Ma_Nganh)
--GO
--alter table Nganh_TS
--add constraint fk_NTS_MSoDT foreign key (Ma_Truong) references Truong(Ma_Truong)
--GO
--alter table Xet
--add constraint fk_Xet_MN foreign key (Ma_Nganh) references Nganh_TS(Ma_Nganh)
--GO
--alter table Xet
--add constraint fk_Xet_MTHM foreign key (Ma_ToHopMon) references ToHop_Mon(Ma_ToHopMon)
--GO
--alter table ToHop_Mon
--add constraint fk_THM_MM1 foreign key (Ma_Mon1) references Mon(Ma_Mon)
--GO
--alter table ToHop_Mon
--add constraint fk_THM_MM2 foreign key (Ma_Mon2) references Mon(Ma_Mon)
--GO
--alter table ToHop_Mon
--add constraint fk_THM_MM3 foreign key (Ma_Mon3) references Mon(Ma_Mon)
--GO