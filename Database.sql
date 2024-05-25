CREATE TABLE TaiKhoan (
    MaTaiKhoan INT PRIMARY KEY,
    TenDangNhap VARCHAR(50) NOT NULL,
	MatKhau VARCHAR(255) NOT NULL,
    TenKhachHang VARCHAR(100) NOT NULL,
    DiaChi VARCHAR(200),
    SoDienThoai VARCHAR(15),
    SoTienDaNap DECIMAL(10, 2)
);

INSERT INTO TaiKhoan (MaTaiKhoan, TenDangNhap, MatKhau, TenKhachHang, DiaChi, SoDienThoai, SoTienDaNap)
VALUES
(1, 'user1', 'soihoanghuhong', 'Chau Hoang Kiet', 'Quan Go Vap', '0987654321', 100000),
(2, 'user2', 'gamaide', 'Tran Quoc Tuan', 'Quan Phu Nhuan', '0654987321', 400000),
(3, 'user3', 'bayta', 'Ho Dac Minh Hoang', 'Quan Binh Thanh', '0321456987', 300000),
(4, 'user4', 'trinhtranthanhtuan', 'Trinh Tran Thanh', 'Quan 2', '0147236589', 120000),
(5, 'user5', 'nguyenronando', 'Nguyen Thanh Siu', 'Quan 7', '0777977977', 900000);

CREATE TABLE MayTinh (
    MaMayTinh INT PRIMARY KEY,
	TenDangNhap varchar(50),
    LoaiMay VARCHAR(50),
    TrangThaiHoatDong VARCHAR(20),
	ThoiGianBD time,
	ThoiGianConLai time,
	ThoiGianSD time,
    NgayBaoTri DATE,
);

INSERT INTO MayTinh (MaMayTinh, TenDangNhap, LoaiMay, TrangThaiHoatDong, ThoiGianBD, ThoiGianSD, ThoiGianConLai, NgayBaoTri)
VALUES
(01, 'user1', 'VIP', 'Dang su dung','5:00:00', '1:30:45', '3:29:15', '2024-12-12'),
(02, 'user2', 'VIP', 'Dang su dung', '4:30:25', '2:15:20', '2:14:40', '2025-06-20'),
(03, 'user3', 'Binh dan', 'Dang su dung', '3:35:32', '1:20:23', '2:15:09', '2025-04-15'),
(04, null, 'Binh dan', 'Con trong', null, null, null, '2024-11-28'),
(05, null, 'VIP', 'Con trong', null, null, null, '2025-06-25');

CREATE TABLE DichVu (
    MaDichVu INT PRIMARY KEY,
    TenDichVu VARCHAR(100) NOT NULL,
    Gia DECIMAL(10, 2) NOT NULL,
    MoTa TEXT
);
INSERT INTO DichVu (MaDichVu, TenDichVu, Gia, MoTa)
VALUES
(001, 'Oder nuoc ngot', 20000, 'Nhieu loai nuoc dong gia 20000'),
(002, 'Oder mi tom', 35000, 'Nhieu loai mi dong gia 35000'),
(003, 'Oder com', 35000, 'Nhieu loai com dong gia 35000'),
(004, 'Oder nu xinh dep choi game cung', 1000000, 'Gia ca cuc hop ly');

CREATE TABLE SuDung (
    MaTaiKhoan INT,
    MaMayTinh INT,
    MaDichVu INT,
    ThoiGianBatDau DATETIME,
    ThoiGianKetThuc DAtETIME,
    PRIMARY KEY (MaTaiKhoan, MaMayTinh, MaDichVu),
    FOREIGN KEY (MaTaiKhoan) REFERENCES TaiKhoan(MaTaiKhoan),
    FOREIGN KEY (MaMayTinh) REFERENCES MayTinh(MaMayTinh),
    FOREIGN KEY (MaDichVu) REFERENCES DichVu(MaDichVu),
);
INSERT INTO SuDung (MaTaiKhoan, MaMayTinh, MaDichVu, ThoiGianBatDau, ThoiGianKetThuc)
VALUES
(1, 01, 001, '2024-07-01 08:30:00', '2024-07-01 10:00:00'),
(2, 02, 002, '2024-07-01 09:00:00', '2024-07-01 10:30:00'),
(3, 03, 003, '2024-07-01 10:30:00', '2024-07-01 11:30:00'),
(4, 04, 004, '2024-07-01 11:30:00', '2024-07-01 12:30:00');

SELECT * FROM TaiKhoan;
SELECT * FROM MayTinh;
