USE master
GO

IF DB_ID('QuanLySinhVien') IS NOT NULL
DROP DATABASE QuanLySinhVien
GO

CREATE DATABASE QuanLySinhVien;
GO
USE QuanLySinhVien;

-- 1. Bảng Lớp
CREATE TABLE Lop (
    MaLop NVARCHAR(20) PRIMARY KEY,
    TenLop NVARCHAR(100) NOT NULL
);

-- 2. Bảng Sinh Viên
CREATE TABLE SinhVien (
    MaSV NVARCHAR(20) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    MaLop NVARCHAR(20) FOREIGN KEY REFERENCES Lop(MaLop)
);

-- 3. Bảng Tài khoản (Đăng nhập)
CREATE TABLE TaiKhoan (
    TenDN NVARCHAR(50) PRIMARY KEY,
    MatKhau NVARCHAR(50) NOT NULL
);
