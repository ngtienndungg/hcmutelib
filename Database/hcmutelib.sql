-- TẠO DATABASE --

IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'QuanLyThuVien')
BEGIN
    CREATE DATABASE [QuanLyThuVien]
END
GO

USE [QuanLyThuVien]
GO






-- TẠO BẢNG CÙNG VỚI CÁC RÀNG BUỘC CƠ BẢN (NHƯ KHOÁ CHÍNH, NOT NULL) --

-- Bảng Nhà xuất bản
CREATE TABLE NHA_XUAT_BAN (
		MaNhaXuatBan varchar(10) primary key,
		TenNhaXuatBan nvarchar(50) not null,
		);
-- Bảng Tác giả
CREATE TABLE TAC_GIA (
		MaTacGia varchar(10) primary key,
		TenTacGia nvarchar(50) not null,
		);
-- Bảng Chuyên ngành	
CREATE TABLE CHUYEN_NGANH (
		MaChuyenNganh varchar(10) primary key,
		TenChuyenNganh nvarchar(50) not null,
		);
-- Bảng Sách
CREATE TABLE SACH (
		MaSach varchar(10) primary key,
		TenSach nvarchar(100) not null,
		LoaiSach bit not null, -- 0: giáo trình  -- 1: sách tham khảo
		MaNhaXuatBan varchar(10) not null,
		MaChuyenNganh varchar(10) not null,
		GiaBia decimal(9,3) not null,
		SoLuong int not null,
		);
-- Bảng Sách Tác Giả
CREATE TABLE SACH_TAC_GIA (
		MaSach varchar(10) not null,
		MaTacGia varchar(10) not null,
		);
-- Bảng Đối tượng độc giả
CREATE TABLE DOI_TUONG_DOC_GIA (
		MaDoiTuong int identity(1,1) primary key,
		TenDoiTuong nvarchar (50) not null,
		);
-- Bảng Độc giả
CREATE TABLE DOC_GIA (
		MaDocGia varchar(10) primary key,
		MaDoiTuong int not null,
		HoTen nvarchar(50) not null,
		GioiTinh bit not null,
		NgaySinh date not null,
		SoDienThoai varchar(10),
		Email varchar(50),
		NgayLamThe date not null,
		NgayHetHan date not null,
		);
-- Bảng Nhân viên
CREATE TABLE NHAN_VIEN (
		MaNhanVien varchar(10) primary key,
		HoTen nvarchar(50) not null,
		GioiTinh bit not null,
		NgaySinh date,
		SoDienThoai varchar(10),
		Email varchar(50),
		NgayVaoLam date not null,
		TinhTrangLamViec bit default 1 , -- 1: còn làm việc  -- 0: nghỉ việc
		);
-- Bảng Đăng nhập
CREATE TABLE DANG_NHAP (
		MaNhanVien varchar(10) primary key,
		TenDangNhap varchar(20) unique not null,
		MatKhau varchar(20) not null,
		LoaiTaiKhoan bit not null, -- 0: quản trị viên  -- 1: thủ thư
		);
-- Bảng Phiếu mượn
CREATE TABLE PHIEU_MUON (
		MaPhieuMuon varchar(10) primary key,
		MaDocGia varchar(10) not null,
		MaNhanVien varchar(10) not null,
		NgayMuon date not null,
		SoLuong int not null default 0,
		);
-- Bảng Tình trạng sách
CREATE TABLE TINH_TRANG_SACH (
		MaTinhTrangSach smallint identity(1,1) primary key,
		TinhTrangSach nvarchar(50) not null,
		);
-- Bảng chi tiết mượn trả
CREATE TABLE CHI_TIET_MUON_TRA (
		MaPhieuMuon varchar(10) not null,
		MaSach varchar(10) not null,
		NgayHetHan date not null,
		NgayTra date,
		MaNhanVienTra varchar(10),
		MaTinhTrangSach smallint,
		PhatHuHong decimal(9,3),
		PhatQuaHan decimal(9,3),
		);
GO




-- FUNCTION --

-- TỰ ĐỘNG TẠO MÃ SÁCH THEO DẠNG (VÍ DỤ: SACH00004)
CREATE FUNCTION [Auto_MaSach]()
RETURNS VARCHAR(10)
AS
BEGIN
	DECLARE @MaSach VARCHAR(9)
	IF (SELECT COUNT(*) FROM SACH) = 0
		SET @MaSach = '0'
	ELSE
		SELECT @MaSach = MAX(RIGHT(MaSach, 5)) FROM SACH
		SELECT @MaSach = CASE 
			WHEN @MaSach >=0 AND @MaSach <9 THEN 'SACH0000' +  CONVERT(CHAR, CONVERT(INT, @MaSach) + 1)
			WHEN @MaSach >=9 AND @MaSach < 99 THEN 'SACH000' + CONVERT(CHAR, CONVERT(INT, @MaSach) + 1)
			WHEN @MaSach >=99 AND @MaSach < 999 THEN 'SACH00' + CONVERT(CHAR, CONVERT(INT, @MaSach) + 1)
			WHEN @MaSach >=999 THEN 'SACH0' + CONVERT(CHAR, CONVERT(INT, @MaSach) + 1)
		END
	RETURN @MaSach
END
GO

CREATE FUNCTION [Auto_MaPhieuMuon]()
RETURNS VARCHAR(10)
AS
BEGIN
	DECLARE @MaPM VARCHAR(9)
	IF (SELECT COUNT(*) FROM PHIEU_MUON) = 0
		SET @MaPM = '0'
	ELSE
		SELECT @MaPM = MAX(RIGHT(MaPhieuMuon, 9)) FROM PHIEU_MUON
		SELECT @MaPM = CASE 
			WHEN @MaPM >=0 AND @MaPM <9 THEN '00000000' +  CONVERT(CHAR, CONVERT(INT, @MaPM) + 1)
			WHEN @MaPM >=9 AND @MaPM < 99 THEN '0000000' + CONVERT(CHAR, CONVERT(INT, @MaPM) + 1)
			WHEN @MaPM >=99 AND @MaPM < 999 THEN '000000' + CONVERT(CHAR, CONVERT(INT, @MaPM) + 1)
			WHEN @MaPM >=999 AND @MaPM < 9999 THEN '00000' + CONVERT(CHAR, CONVERT(INT, @MaPM) + 1)
			WHEN @MaPM >=9999 AND @MaPM < 99999 THEN '0000' + CONVERT(CHAR, CONVERT(INT, @MaPM) + 1)
			WHEN @MaPM >=99999 AND @MaPM < 999999 THEN '000' + CONVERT(CHAR, CONVERT(INT, @MaPM) + 1)
			WHEN @MaPM >=999999 AND @MaPM < 9999999 THEN '00' + CONVERT(CHAR, CONVERT(INT, @MaPM) + 1)
			WHEN @MaPM >=9999999 AND @MaPM < 99999999 THEN '0' + CONVERT(CHAR, CONVERT(INT, @MaPM) + 1)
		END
	RETURN @MaPM
END
GO

-- TỰ ĐỘNG TẠO MÃ NHÂN VIÊN THEO DẠNG (VÍ DỤ: NV009)
CREATE FUNCTION [dbo].[Auto_MaNhanVien] ()
RETURNS VARCHAR(5)
AS
BEGIN 
		DECLARE @MaNV VARCHAR(10)
		IF (SELECT COUNT(*) FROM NHAN_VIEN ) = 0
				SET @MaNV = '0'
		ELSE 
			SELECT @MaNV = MAX(RIGHT(MaNhanVien, 3)) FROM NHAN_VIEN 
			SELECT @MaNV = CASE
					WHEN @MaNV >= 0 and @MaNV <9 THEN 'NV00' + CONVERT(CHAR, CONVERT(INT,@MaNV) + 1)
					WHEN @MaNV >= 9 THEN 'NV0' + CONVERT(CHAR, CONVERT(INT, @MaNV) +1 )
			END
		RETURN @MaNV
END
GO

-- TỰ ĐỘNG TẠO MÃ TÁC GIẢ THEO DẠNG (VÍ DỤ: TG0003)
CREATE FUNCTION [dbo].[Auto_MaTacGia] ()
RETURNS VARCHAR(6)
AS
BEGIN 
		DECLARE @MaTG VARCHAR(10)
		IF (SELECT COUNT(*) FROM TAC_GIA ) = 0
				SET @MaTG = '0'
		ELSE 
			SELECT @MaTG = MAX(RIGHT(MaTacGia, 4)) FROM TAC_GIA
			SELECT @MaTG = CASE
					WHEN @MaTG >= 0 and @MaTG <9 THEN 'TG000' + CONVERT(CHAR, CONVERT(INT,@MaTG) + 1)
					WHEN @MaTG >= 9 and @MaTG < 99 THEN 'TG00' + CONVERT(CHAR, CONVERT(INT, @MaTG) +1 )
					WHEN @MaTG >= 99 THEN 'TG0' + CONVERT(CHAR, CONVERT(INT, @MaTG) +1 )
			END
		RETURN @MaTG
END
GO

-- TỰ ĐỘNG TẠO MÃ NXB THEO DẠNG (VÍ DỤ: NXB0009)
CREATE FUNCTION [dbo].[Auto_MaNhaXuatBan] ()
RETURNS VARCHAR(10)
AS
BEGIN 
		DECLARE @MaNXB VARCHAR(7)
		IF (SELECT COUNT(*) FROM NHA_XUAT_BAN ) = 0
				SET @MaNXB = '0'
		ELSE 
			SELECT @MaNXB = MAX(RIGHT(MaNhaXuatBan, 4)) FROM NHA_XUAT_BAN
			SELECT @MaNXB = CASE
					WHEN @MaNXB >= 0 and @MaNXB <9 THEN 'NXB000' + CONVERT(CHAR, CONVERT(INT,@MaNXB) + 1)
					WHEN @MaNXB >= 9 and @MaNXB < 99 THEN 'NXB00' + CONVERT(CHAR, CONVERT(INT, @MaNXB) +1 )
					WHEN @MaNXB >= 99 THEN 'NXB0' + CONVERT(CHAR, CONVERT(INT, @MaNXB) +1 )
			END
		RETURN @MaNXB
END
GO

-- TỰ ĐỘNG TẠO MÃ CHUYÊN NGÀNH THEO DẠNG (VÍ DỤ: CN0004)
CREATE FUNCTION [dbo].[Auto_MaChuyenNganh] ()
RETURNS VARCHAR(10)
AS
BEGIN 
		DECLARE @MaCN VARCHAR(6)
		IF (SELECT COUNT(*) FROM CHUYEN_NGANH ) = 0
				SET @MaCN = '0'
		ELSE 
			SELECT @MaCN = MAX(RIGHT(MaChuyenNganh, 4)) FROM CHUYEN_NGANH
			SELECT @MaCN = CASE
					WHEN @MaCN >= 0 and @MaCN <9 THEN 'CN000' + CONVERT(CHAR, CONVERT(INT,@MaCN) + 1)
					WHEN @MaCN >= 9 and @MaCN < 99 THEN 'CN00' + CONVERT(CHAR, CONVERT(INT, @MaCN) +1 )
					WHEN @MaCN >= 99 THEN 'CN0' + CONVERT(CHAR, CONVERT(INT, @MaCN) +1 )
			END
		RETURN @MaCN
END
GO 






-- CÁC RÀNG BUỘC KHÁC (KHOÁ NGOẠI, CHECK, DEFAULT) --

-- MẶC ĐỊNH THÊM MÃ TÁC GIẢ THEO FUNCTION AUTO_MATACGIA() 
ALTER TABLE TAC_GIA
ADD CONSTRAINT default_matacgia DEFAULT dbo.Auto_MatacGia() FOR MaTacGia
GO

-- MẶC ĐỊNH THÊM MÃ NHÀ XUẤT BẢN THEO FUNCTION AUTO_MANHAXUATBAN()
ALTER TABLE NHA_XUAT_BAN
ADD CONSTRAINT default_manhaxuatban DEFAULT dbo.Auto_MaNhaXuatBan() FOR MaNhaXuatBan
GO

-- MẶC ĐỊNH THÊM MÃ CHUYÊN NGÀNH THEO FUNCTION AUTO_MACHUYENNGANH()
ALTER TABLE CHUYEN_NGANH
ADD CONSTRAINT default_machuyennganh DEFAULT dbo.Auto_MaChuyenNganh() FOR MaChuyenNganh
GO

-- CÁC RÀNG BUỘC KHOÁ NGOẠI
-- MẶC ĐỊNH THÊM MÃ SÁCH THEO FUNCTION AUTO_MASACH()
ALTER TABLE SACH
ADD CONSTRAINT fk_manhaxuatban_sach_nhaxuatban FOREIGN KEY (MaNhaXuatBan) REFERENCES NHA_XUAT_BAN(MaNhaXuatBan) ON UPDATE CASCADE ON DELETE CASCADE,
	CONSTRAINT fk_machuyennganh_sach_chuyennganh FOREIGN KEY (MaChuyenNganh) REFERENCES CHUYEN_NGANH(MaChuyenNganh) ON UPDATE CASCADE ON DELETE CASCADE,
	CONSTRAINT default_masach DEFAULT dbo.Auto_MaSach() FOR MaSach
GO

ALTER TABLE SACH_TAC_GIA
ADD CONSTRAINT fk_matacgia_sachtacgia_tacgia FOREIGN KEY (MaTacGia) REFERENCES TAC_GIA(MaTacGia) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT fk_masach_sachtacgia_sach FOREIGN KEY (MaSach) REFERENCES SACH(MaSach) ON DELETE CASCADE ON UPDATE CASCADE;
GO

-- CÁC RÀNG BUỘC KHOÁ NGOẠI
ALTER TABLE DOC_GIA
ADD CONSTRAINT fk_madoituong_docgia_doituongdocgia FOREIGN KEY (MaDoiTuong) REFERENCES DOI_TUONG_DOC_GIA(MaDoiTuong) ON UPDATE CASCADE ON DELETE CASCADE,
	CONSTRAINT check_ngaysinh_docgia CHECK (DATEDIFF(year, NgaySinh, GETDATE())>=18),
	CONSTRAINT check_sdt_docgia CHECK (len(SoDienThoai)=10),
	CONSTRAINT check_email_docgia CHECK (Email like '%___@___%.__%');
GO

-- CÁC RÀNG BUỘC CHECK ĐỂ KIỂM TRA HỢP LỆ CỦA NGÀY SINH, SĐT, EMAIL KHI THÊM VÀO BẢNG
-- MẶC ĐỊNH THÊM MÃ NHÂN VIÊN THEO FUNCTION AUTO_MANHAN VIEN()
ALTER TABLE NHAN_VIEN
ADD CONSTRAINT check_ngaysinh_nhanvien CHECK (DATEDIFF(year, NgaySinh, GETDATE())>=18),
	CONSTRAINT check_sdt_nhanvien CHECK (len(SoDienThoai)=10),
	CONSTRAINT check_email_nhanvien CHECK (Email like '%___@___%.__%'),
	CONSTRAINT default_manhanvien DEFAULT dbo.Auto_MaNhanVien() FOR MaNhanVien
GO


-- CÁC RÀNG BUỘC KHOÁ NGOẠI
-- RÀNG BUỘC CHECK KIỂM TRA HỢP LỆ CỦA MẬT KHẨU (ĐỘ DÀI 8 KÍ TỰ TRỞ LÊN)
ALTER TABLE DANG_NHAP
ADD CONSTRAINT fk_manhanvien_dangnhap_nhanvien FOREIGN KEY (MaNhanVien) REFERENCES NHAN_VIEN(MaNhanVien),
	CONSTRAINT check_matkhau_dangnhap CHECK (len(MatKhau)>7);
GO

-- CÁC RÀNG BUỘC KHOÁ NGOẠI
ALTER TABLE PHIEU_MUON
ADD CONSTRAINT fk_madocgia_phieumuon_docgia FOREIGN KEY (MaDocGia) REFERENCES DOC_GIA(MaDocGia) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT fk_manhanvien_phieumuon_nhanvien FOREIGN KEY (MaNhanVien) REFERENCES NHAN_VIEN(MaNhanVien) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT default_maphieumuon DEFAULT dbo.Auto_MaPhieuMuon() FOR MaPhieuMuon;
GO

-- CÁC RÀNG BUỘC KHOÁ NGOẠI
ALTER TABLE CHI_TIET_MUON_TRA
ADD CONSTRAINT fk_maphieumuon_chitietphieumuon_phieumuon FOREIGN KEY (MaPhieuMuon) REFERENCES PHIEU_MUON(MaPhieuMuon) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT fk_masach_chitietphieumuon_sach FOREIGN KEY (MaSach) REFERENCES SACH(MaSach) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT fk_manhanvien_chitietmuontra_nhanvien FOREIGN KEY (MaNhanVienTra) REFERENCES NHAN_VIEN(MaNhanVien),
	CONSTRAINT fk_matinhtrangsach_chitietmuontra_tinhtrangsach FOREIGN KEY (MaTinhTrangSach) REFERENCES TINH_TRANG_SACH(MaTinhTrangSach) ON DELETE CASCADE ON UPDATE CASCADE;
GO






-- VIEW --

-- VIEW CHI TIẾT THÔNG TIN SÁCH
CREATE VIEW [VIEW_CHI_TIET_SACH] AS
SELECT s.MaSach [Mã sách], s.TenSach [Tên sách],
CASE WHEN LoaiSach = 1 THEN N'Sách tham khảo' ELSE N'Giáo trình' END [Loại sách],
(SELECT STRING_AGG([TenTacGia], ' - ') FROM [TAC_GIA] tg, [SACH_TAC_GIA] stg
WHERE tg.MaTacGia = stg.MaTacGia AND s.MaSach = stg.MaSach) [Tác giả],
nxb.TenNhaXuatBan [Nhà xuất bản], cn.TenChuyenNganh [Chuyên ngành], s.GiaBia [Giá bìa], s.SoLuong [Số lượng]
FROM [SACH] s JOIN [NHA_XUAT_BAN] nxb ON s.MaNhaXuatBan = nxb.MaNhaXuatBan 
JOIN [CHUYEN_NGANH] cn ON s.MaChuyenNganh = cn.MaChuyenNganh
GO


-- VIEW CHI TIẾT THÔNG TIN NHÂN VIÊN
CREATE OR ALTER VIEW [VIEW_CHI_TIET_NHAN_VIEN] AS
SELECT nv.MaNhanVien [Mã nhân viên], HoTen [Họ tên],
CASE WHEN GioiTinh = 1 THEN 'Nam' ELSE N'Nữ' END [Giới tính],
NgaySinh [Ngày sinh], SoDienThoai [SĐT], Email, NgayVaoLam [Ngày vào làm], 
CASE WHEN TinhTrangLamViec = 1 THEN N'Còn làm việc' ELSE N'Đã nghỉ việc' END [Tình trạng làm việc]
FROM [NHAN_VIEN] nv
GO

-- VIEW CHI TIẾT THÔNG TIN ĐỘC GIẢ
CREATE VIEW [VIEW_CHI_TIET_THE_DOC_GIA] AS
SELECT MaDocGia [Mã độc giả], HoTen [Họ tên], TenDoiTuong [Đối tượng],
CASE WHEN dg.GioiTinh = 1 THEN 'Nam' ELSE N'Nữ' END [Giới tính], NgaySinh [Ngày sinh],
SoDienThoai [SĐT], Email, NgayLamThe [Ngày làm thẻ], NgayHetHan [Ngày hết hạn]
FROM [DOC_GIA] dg JOIN [DOI_TUONG_DOC_GIA] ddg ON dg.MaDoiTuong = ddg.MaDoiTuong
GO

-- VIEW CHI TIẾT THÔNG TIN CÁC SÁCH MƯỢN TRẢ
CREATE VIEW [VIEW_CHI_TIET_MUON_TRA] AS
SELECT pm.MaPhieuMuon [Mã phiếu mượn], pm.MaDocGia [Mã người mượn], 
dg.HoTen [Họ tên], s.MaSach [Mã sách], TenSach [Tên sách], NgayMuon [Ngày mượn],
ctmt.NgayHetHan [Ngày hết hạn], NgayTra AS [Ngày trả], nv.HoTen [Nhân viên cho mượn], 
tts.TinhTrangSach [Tình trạng sách], PhatHuHong [Phạt hư hỏng], PhatQuaHan [Phạt quá hạn]
FROM [CHI_TIET_MUON_TRA] ctmt JOIN [PHIEU_MUON] pm ON ctmt.MaPhieuMuon = pm.MaPhieuMuon
JOIN [DOC_GIA] dg ON pm.MaDocGia = dg.MaDocGia
JOIN [SACH] s ON s.MaSach = ctmt.MaSach
JOIN [NHAN_VIEN] nv ON nv.MaNhanVien = pm.MaNhanVien
LEFT OUTER JOIN [TINH_TRANG_SACH] tts ON ctmt.MaTinhTrangSach = tts.MaTinhTrangSach
GO

-- VIEW THÔNG TIN CÁC SÁCH ĐANG ĐƯỢC MƯỢN --
CREATE VIEW [VIEW_SACH_DANG_MUON] AS
SELECT pm.MaPhieuMuon [Mã phiếu mượn], pm.MaDocGia [Mã người mượn], 
dg.HoTen [Họ tên], s.MaSach [Mã sách], s.TenSach [Tên sách], 
pm.NgayMuon [Ngày mượn], ctmt.NgayHetHan [Ngày hết hạn], nv.HoTen [Nhân viên cho mượn]
FROM [CHI_TIET_MUON_TRA] ctmt JOIN [PHIEU_MUON] pm ON ctmt.MaPhieuMuon = pm.MaPhieuMuon
JOIN [DOC_GIA] dg ON pm.MaDocGia = dg.MaDocGia
JOIN [SACH] s ON s.MaSach = ctmt.MaSach
JOIN [NHAN_VIEN] nv ON nv.MaNhanVien = pm.MaNhanVien
WHERE NgayTra IS NULL
GO

-- VIEW THÔNG TIN CÁC SÁCH TRỄ HẠN CHƯA TRẢ
CREATE VIEW [VIEW_SACH_TRE_HAN] AS
SELECT pm.MaPhieuMuon [Mã phiếu mượn], pm.MaDocGia [Mã người mượn], 
dg.HoTen [Họ tên], s.MaSach [Mã sách], s.TenSach [Tên sách], 
pm.NgayMuon [Ngày mượn], ctmt.NgayHetHan [Ngày hết hạn], nv.HoTen [Nhân viên cho mượn]
FROM [CHI_TIET_MUON_TRA] ctmt JOIN [PHIEU_MUON] pm ON ctmt.MaPhieuMuon = pm.MaPhieuMuon
JOIN [DOC_GIA] dg ON pm.MaDocGia = dg.MaDocGia
JOIN [SACH] s ON s.MaSach = ctmt.MaSach
JOIN [NHAN_VIEN] nv ON nv.MaNhanVien = pm.MaNhanVien
WHERE (GETDATE()>ctmt.NgayHetHan) AND NgayTra IS NULL
GO

-- VIEW THÔNG TIN CÁC SÁCH ĐÃ TRẢ
CREATE VIEW [VIEW_SACH_DA_TRA] AS
SELECT pm.MaPhieuMuon [Mã phiếu mượn], pm.MaDocGia [Mã người mượn], 
dg.HoTen [Họ tên], s.MaSach [Mã sách], TenSach [Tên sách], NgayMuon [Ngày mượn],
ctmt.NgayHetHan [Ngày hết hạn], NgayTra AS [Ngày trả], nv.HoTen [Nhân viên cho mượn],
tts.TinhTrangSach [Tình trạng sách], PhatHuHong [Phạt hư hỏng], PhatQuaHan [Phạt quá hạn]
FROM [CHI_TIET_MUON_TRA] ctmt JOIN [PHIEU_MUON] pm ON ctmt.MaPhieuMuon = pm.MaPhieuMuon
JOIN [DOC_GIA] dg ON pm.MaDocGia = dg.MaDocGia
JOIN [SACH] s ON s.MaSach = ctmt.MaSach
JOIN [NHAN_VIEN] nv ON nv.MaNhanVien = pm.MaNhanVien
JOIN [TINH_TRANG_SACH] tts ON ctmt.MaTinhTrangSach = tts.MaTinhTrangSach
WHERE NgayTra IS NOT NULL
GO

-- VIEW THÔNG TIN CÁC ĐỘC GIẢ ĐANG MƯỢN SÁCH
CREATE VIEW [VIEW_DOC_GIA_DANG_MUON_SACH] AS
SELECT DISTINCT dg.MaDocGia [Độc giả], HoTen [Họ tên], NgaySinh [Ngày sinh],
CASE WHEN GioiTinh = 1 THEN 'Nam' ELSE N'Nữ' END [Giới tính], SoDienThoai [SĐT], Email
FROM [DOC_GIA] dg JOIN [PHIEU_MUON] pm ON dg.MaDocGia = pm.MaDocGia
JOIN [CHI_TIET_MUON_TRA] ctmt ON pm.MaPhieuMuon = ctmt.MaPhieuMuon
JOIN [SACH] s ON ctmt.MaSach = s.MaSach
WHERE NgayTra IS NULL
GO

-- VIEW CÁC ĐỘC GIẢ ĐÃ TRỄ HẠN TRẢ SÁCH
CREATE VIEW [VIEW_DOC_GIA_DANG_TRE_HAN] AS
SELECT DISTINCT dg.MaDocGia [Độc giả], HoTen [Họ tên], NgaySinh [Ngày sinh],
CASE WHEN GioiTinh = 1 THEN 'Nam' ELSE N'Nữ' END [Giới tính], SoDienThoai [SĐT], Email
FROM [DOC_GIA] dg JOIN [PHIEU_MUON] pm ON dg.MaDocGia = pm.MaDocGia
JOIN [CHI_TIET_MUON_TRA] ctmt ON pm.MaPhieuMuon = ctmt.MaPhieuMuon
JOIN [SACH] s ON ctmt.MaSach = s.MaSach
WHERE NgayTra IS NULL AND GETDATE()>ctmt.NgayHetHan
GO 

-- VIEW ĐỘC GIẢ CÒN HẠN THẺ
CREATE VIEW [VIEW_DOC_GIA_CON_HAN] AS
SELECT MaDocGia [Mã độc giả], HoTen [Họ tên], TenDoiTuong [Đối tượng],
CASE WHEN dg.GioiTinh = 1 THEN 'Nam' ELSE N'Nữ' END [Giới tính], NgaySinh [Ngày sinh],
SoDienThoai [SĐT], Email, NgayLamThe [Ngày làm thẻ], NgayHetHan [Ngày hết hạn]
FROM [DOC_GIA] dg JOIN [DOI_TUONG_DOC_GIA] ddg ON dg.MaDoiTuong = ddg.MaDoiTuong
WHERE GETDATE()<NgayHetHan
GO

-- VIEW NHÂN VIÊN CÒN LÀM VIỆC
CREATE OR ALTER VIEW [VIEW_NHAN_VIEN_LAM_VIEC] AS
SELECT nv.MaNhanVien [Mã nhân viên], HoTen [Họ tên],
CASE WHEN GioiTinh = 1 THEN 'Nam' ELSE N'Nữ' END [Giới tính],
NgaySinh [Ngày sinh], SoDienThoai [SĐT], Email, NgayVaoLam [Ngày vào làm]
FROM [NHAN_VIEN] nv 
WHERE TinhTrangLamViec = 1
GO

-- VIEW THÔNG TIN TÁC GIẢ
CREATE VIEW [VIEW_TAC_GIA] AS
SELECT MaTacGia AS [Mã tác giả], TenTacGia AS [Tên tác giả]
FROM TAC_GIA
GO

-- VIEW THÔNG TIN CHUYÊN NGÀNH
CREATE VIEW [VIEW_CHUYEN_NGANH] AS
SELECT MaChuyenNganh AS [Mã chuyên ngành], TenChuyenNganh AS [Tên chuyên ngành]
FROM CHUYEN_NGANH
GO

-- VIEW THÔNG TIN NHÀ XUẤT BẢN
CREATE VIEW [VIEW_NHA_XUAT_BAN] AS
SELECT MaNhaXuatBan AS [Mã NXB], TenNhaXuatBan AS [Tên NXB]
FROM NHA_XUAT_BAN
GO




-- TRIGGER --

-- Trigger tăng giá trị SoLuong trong PHIEUMUON khi một CHITIETPHIEUMUON được thêm
CREATE TRIGGER [TRIGGER_THEM_SL_SACH_PHIEU_MUON]
ON CHI_TIET_MUON_TRA AFTER INSERT
AS 
BEGIN
	UPDATE PHIEU_MUON
	SET SoLuong = SoLuong + 1
	FROM inserted
	WHERE [PHIEU_MUON].MaPhieuMuon = inserted.MaPhieuMuon
END
GO

-- 4.3.2 Trigger giảm giá trị cột SoLuong trong bảng PHIEUMUON sau khi Delete giá trị trong CHITIETPHIEUMUON
CREATE TRIGGER [TRIGGER_GIAM_SL_SACH_PHIEU_MUON]
ON CHI_TIET_MUON_TRA AFTER DELETE
AS 
BEGIN
	UPDATE PHIEU_MUON
	SET SoLuong = SoLuong - 1
	FROM deleted
	WHERE [PHIEU_MUON].MaPhieuMuon = deleted.MaPhieuMuon
END
GO

-- Trigger giảm SoLuong trong Sach sau khi sách đó bị mượn
CREATE TRIGGER [TRIGGER_SL_SACH_SAU_MUON]
ON [CHI_TIET_MUON_TRA] AFTER INSERT
AS
BEGIN
	UPDATE SACH
	SET SoLuong = SoLuong - 1
	FROM inserted
	WHERE [SACH].MaSach = inserted.MaSach
END
GO

-- Trigger tăng SoLuong trong Sach sau khi sách đó được trả lại
CREATE TRIGGER [TRIGGER_SL_SACH_SAU_TRA]
ON [CHI_TIET_MUON_TRA] AFTER UPDATE
AS IF (UPDATE(NgayTra))
BEGIN
	UPDATE SACH
	SET SoLuong = SoLuong + 1
	FROM inserted
	WHERE [SACH].MaSach = inserted.MaSach
END
GO

-- Trigger kiểm tra điều kiện mượn xem độc giả có đang vi phạm chính sách gì không
CREATE TRIGGER [TRIGGER_KIEM_TRA_DIEU_KIEN_MUON]
ON PHIEU_MUON FOR UPDATE
AS IF (UPDATE(SoLuong))
BEGIN
	DECLARE @MaPM varchar(10), @MaLoaiDT int, @GioiHanGT int, @GioiHanSTK int
	SELECT @MaPM = MaPhieuMuon FROM inserted
	-- Kiểm tra nếu có sách trễ hạn chưa trả
	IF ((SELECT COUNT(*) FROM [CHI_TIET_MUON_TRA] ctmt 
		JOIN inserted i ON i.MaPhieuMuon = ctmt.MaPhieuMuon
		JOIN [DOC_GIA] dg ON i.MaDocGia = dg.MaDocGia
		WHERE dg.MaDocGia = i.MaDocGia AND NgayTra IS NULL
		AND GETDATE()>ctmt.NgayHetHan)>0)
		BEGIN
			DELETE FROM PHIEU_MUON WHERE MaPhieuMuon = @MaPM
			PRINT 'Có sách trễ hạn chưa trả'
		END
	-- Gán giới hạn sách tham khảo và giáo trình đối với từng đối tượng
	SELECT @MaLoaiDT = dg.MaDoiTuong FROM inserted i JOIN [DOC_GIA] dg ON i.MaDocGia = dg.MaDocGia
	IF (@MaLoaiDT = 1 OR @MaLoaiDT = 3) 
	BEGIN
		SELECT @GioiHanSTK = 10
		SELECT @GioiHanGT = 15
	END
	ELSE IF (@MaLoaiDT = 2) 
	BEGIN
		SELECT @GioiHanSTK = 10
		SELECT @GioiHanGT = 20
	END
	ELSE IF (@MaLoaiDT = 4) 
	BEGIN
		SELECT @GioiHanSTK = 5
		SELECT @GioiHanGT = 5
	END
	ELSE IF (@MaLoaiDT = 5) 
	BEGIN
		SELECT @GioiHanSTK = 10
		SELECT @GioiHanGT = 5
	END
	-- Kiểm tra nếu số lượng sách mượn vượt quá quy định
	IF ((SELECT COUNT(*) FROM [CHI_TIET_MUON_TRA] ctmt 
		JOIN inserted i ON i.MaPhieuMuon = ctmt.MaPhieuMuon			
		JOIN [DOC_GIA] dg ON i.MaDocGia = dg.MaDocGia
		JOIN [SACH] s ON s.MaSach = ctmt.MaSach
		WHERE dg.MaDocGia = i.MaDocGia AND NgayTra IS NULL
		AND s.LoaiSach = 1)>@GioiHanSTK)
		BEGIN
			DELETE FROM PHIEU_MUON WHERE MaPhieuMuon = @MaPM
			PRINT N'Vượt quá sách tham khảo'
		END
	IF ((SELECT COUNT(*) FROM [CHI_TIET_MUON_TRA] ctmt 
			JOIN inserted i ON i.MaPhieuMuon = ctmt.MaPhieuMuon
			JOIN [DOC_GIA] dg ON i.MaDocGia = dg.MaDocGia
			JOIN [SACH] s ON s.MaSach = ctmt.MaSach
			WHERE dg.MaDocGia = i.MaDocGia AND NgayTra IS NULL
			AND s.LoaiSach = 0)>@GioiHanGT)
			BEGIN
				DELETE FROM PHIEU_MUON WHERE MaPhieuMuon = @MaPM
				PRINT N'Vượt quá giáo trình'
			END
	-- Kiểm tra nếu có sách đang mượn trùng lặp
	IF ((SELECT COUNT(*) FROM [CHI_TIET_MUON_TRA] ctmt 
		JOIN inserted i ON i.MaPhieuMuon = ctmt.MaPhieuMuon			
		JOIN [DOC_GIA] dg ON i.MaDocGia = dg.MaDocGia
		WHERE dg.MaDocGia = i.MaDocGia AND NgayTra IS NULL
		GROUP BY ctmt.MaSach HAVING COUNT(*)>1)>1)
		BEGIN
			DELETE FROM PHIEU_MUON WHERE MaPhieuMuon = @MaPM
			PRINT N'2 sách trùng lặp'
		END
END
GO

-- Trigger tạo một user trên SQL khi thêm một nhân viên
CREATE OR ALTER TRIGGER TRIGGER_SQL_ACCOUNT ON DANG_NHAP
AFTER INSERT
AS
	DECLARE @userName nvarchar(20), @passWord nvarchar(20)
	SELECT @userName=i.TenDangNhap, @passWord=i.MatKhau
	FROM inserted i
	BEGIN
	DECLARE @sqlString nvarchar(2000)
	-- Tạo tài khoản login cho nhân viên, tên người dùng và mật khẩu là tài khoản được tạo trên bảng Đăng nhập
	SET @sqlString= 'CREATE LOGIN [' + @userName +'] WITH PASSWORD='''+ @passWord +''', 
	DEFAULT_DATABASE=[QuanLyThuVien], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF'
	EXEC (@sqlString)
	-- Tạo tài khoản người dùng đối với nhân viên đó trên database (tên người dùng trùng với tên login)
	SET @sqlString= 'CREATE USER ' + @userName +' FOR LOGIN '+ @userName
	EXEC (@sqlString)
	DECLARE @role bit
	SELECT @role = i.LoaiTaiKhoan FROM inserted i
	IF (@role = 0)
		SET @sqlString =  'ALTER SERVER ROLE sysadmin ADD MEMBER ' + @userName;
	ELSE
		SET @sqlString = 'ALTER ROLE NhanVien ADD MEMBER ' + @userName;
	EXEC (@sqlString)
END
GO

-- Trigger khi xóa nhân viên thì sẽ đánh dấu nhân viên nghỉ và xóa tài khoản đăng nhập của người đó khỏi hệ thống
CREATE TRIGGER TRIGGER_XOA_NHAN_VIEN ON NHAN_VIEN 
INSTEAD OF DELETE
AS
DECLARE @MaNV varchar(10)
SELECT @MaNV= d.MaNhanVien
FROM deleted d
SET XACT_ABORT ON
BEGIN TRAN
	BEGIN TRY
		-- Cập nhật tình trạng tình việc của nhân viên là đã nghỉ
		UPDATE NHAN_VIEN SET TinhTrangLamViec=0 WHERE MaNhanVien=@maNV
		DECLARE @TenDangNhap varchar(20)
		SELECT @TenDangNhap=TenDangNhap FROM DANG_NHAP WHERE MaNhanVien=@MaNV
		-- Xóa user của nhân viên
		DECLARE @sql varchar(100)
		SET @sql = 'DROP USER '+ @TenDangNhap
		EXEC (@sql)
		-- Xóa tài khoản login của nhân viên khỏi server
		SET @sql = 'DROP LOGIN '+ @TenDangNhap
		EXEC (@sql)
		-- Xóa tài khoản đăng nhập của nhân viên khỏi bảng Đăng nhập
		DELETE FROM DANG_NHAP WHERE MaNhanVien=@MaNV;
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		print error_message()
		ROLLBACK
	END CATCH
GO



-- PROCEDURES --

-- QUẢN LÝ SÁCH
-- THÊM SÁCH
CREATE OR ALTER PROCEDURE THEM_SACH (@TenSach nvarchar(100), @LoaiSach bit, @MaNhaXuatBan varchar(10), @MaChuyenNganh varchar(10),
							@GiaBia decimal(9,3), @SoLuong int, @MaTacGia1 varchar(10), @MaTacGia2 varchar(10), @MaTacGia3 varchar(10))
AS 
BEGIN
	SET XACT_ABORT ON
	BEGIN TRAN
			IF (@MaTacGia1 IS NULL AND @MaTacGia2 IS NULL AND @MaTacGia3 IS NULL)
			BEGIN
				RAISERROR(N'Chưa có tác giả!!', 16,1)
			END
   
			BEGIN
				DECLARE @MaSach varchar(10) = dbo.Auto_MaSach()
				INSERT INTO SACH (TenSach, LoaiSach, MaNhaXuatBan, MaChuyenNganh, GiaBia, SoLuong) 
				VALUES (@TenSach, @LoaiSach, @MaNhaXuatBan, @MaChuyenNganh, @GiaBia, @SoLuong);
				IF (@MaTacGia1 IS NOT NULL)
					INSERT INTO SACH_TAC_GIA (MaSach, MaTacGia) VALUES (@MaSach, @MaTacGia1)
				IF (@MaTacGia2 IS NOT NULL)
					INSERT INTO SACH_TAC_GIA (MaSach, MaTacGia) VALUES (@MaSach, @MaTacGia2)
				IF (@MaTacGia3 IS NOT NULL)
					INSERT INTO SACH_TAC_GIA (MaSach, MaTacGia) VALUES (@MaSach, @MaTacGia3)	
			END
		COMMIT TRAN
END
GO

-- SỬA SÁCH
CREATE PROCEDURE SUA_SACH (@MaSach varchar(10), @TenSach nvarchar(100), @LoaiSach bit, @MaNhaXuatBan varchar(10), @MaChuyenNganh varchar(10),
							@GiaBia decimal(9,3), @SoLuong int, @MaTacGia1 varchar(10), @MaTacGia2 varchar(10), @MaTacGia3 varchar(10))
AS 
BEGIN
	DELETE SACH_TAC_GIA WHERE MaSach = @MaSach
	IF (@MaTacGia1 IS NOT NULL)
		INSERT INTO SACH_TAC_GIA (MaSach, MaTacGia) VALUES (@MaSach, @MaTacGia1)
	IF (@MaTacGia2 IS NOT NULL)
		INSERT INTO SACH_TAC_GIA (MaSach, MaTacGia) VALUES (@MaSach, @MaTacGia2)
	IF (@MaTacGia3 IS NOT NULL)
		INSERT INTO SACH_TAC_GIA (MaSach, MaTacGia) VALUES (@MaSach, @MaTacGia3)

	UPDATE SACH
	SET TenSach = @TenSach, LoaiSach = @LoaiSach, MaNhaXuatBan = @MaNhaXuatBan, MaChuyenNganh = @MaChuyenNganh, GiaBia = @GiaBia, SoLuong = @SoLuong
	WHERE MaSach = @MaSach
END
GO

-- XOÁ SÁCH
CREATE PROCEDURE XOA_SACH (@MaSach varchar(10))
AS
BEGIN 
	DELETE SACH WHERE MaSach = @MaSach
END
GO

-- QUẢN LÝ ĐỘC GIẢ
-- THÊM ĐỘC GIẢ
CREATE PROCEDURE THEM_DOC_GIA (@MaDocGia varchar(10), @MaDoiTuong int, @HoTen nvarchar(50), @GioiTinh bit, @NgaySinh date, 
							   @SDT varchar(10), @Email varchar(50))
AS 
BEGIN
	INSERT INTO DOC_GIA (MaDocGia, MaDoiTuong, HoTen, GioiTinh, NgaySinh, SoDienThoai, Email, NgayLamThe, NgayHetHan)
	VALUES (@MaDocGia, @MaDoiTuong, @HoTen, @GioiTinh, @NgaySinh, @SDT, @Email, GETDATE(), DATEADD(yyyy, 1, GETDATE()))
END
GO

-- SỬA ĐỘC GIẢ
CREATE PROCEDURE SUA_DOC_GIA (@MaDocGia varchar(10), @MaDoiTuong int, @HoTen nvarchar(50), @GioiTinh bit, @NgaySinh date, 
							   @SDT varchar(10), @Email varchar(50))
AS 
BEGIN
	UPDATE DOC_GIA
	SET MaDoiTuong = @MaDoiTuong, HoTen = @HoTen, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, SoDienThoai = @SDT, Email = @Email
	WHERE MaDocGia = @MaDocGia
END
GO

-- XOÁ ĐỘC GIẢ
CREATE PROCEDURE XOA_DOC_GIA (@MaDocGia varchar(10))
AS
BEGIN 
	DELETE DOC_GIA WHERE MaDocGia = @MaDocGia
END
GO

-- GIA HẠN THẺ ĐỘC GIẢ
CREATE PROCEDURE GIA_HAN (@MaDocGia varchar(10))
AS
BEGIN
	UPDATE DOC_GIA
	SET NgayHetHan = DATEADD(yyyy, 1, NgayHetHan)
	WHERE MaDocGia = @MaDocGia
END
GO

-- QUẢN LÝ MƯỢN TRẢ	
-- THÊM PHIẾU MƯỢN
CREATE PROCEDURE THEM_PHIEU_MUON (@MaDocGia varchar(10), @MaNhanVien varchar(10))
AS 
BEGIN
	INSERT INTO PHIEU_MUON(MaDocGia, MaNhanVien, NgayMuon, SoLuong)
	VALUES (@MaDocGia, @MaNhanVien, GETDATE(), 0)
END
GO

-- THÊM SÁCH MƯỢN
CREATE OR ALTER PROCEDURE THEM_SACH_MUON (@MaPhieuMuon varchar(10), @MaSach varchar(10))
AS
BEGIN
	SET XACT_ABORT ON
	BEGIN TRAN
		BEGIN TRY
			DECLARE @DoiTuong int = (SELECT TOP 1 dg.MaDoiTuong
									 FROM CHI_TIET_MUON_TRA ctmt JOIN PHIEU_MUON pm ON ctmt.MaPhieuMuon = pm.MaPhieuMuon
									 JOIN DOC_GIA dg ON pm.MaDocGia = dg.MaDocGia WHERE pm.MaPhieuMuon = @MaPhieuMuon
									 )
			DECLARE @LoaiSach bit = (SELECT TOP 1 s.LoaiSach FROM CHI_TIET_MUON_TRA ctmt JOIN SACH s ON ctmt.MaSach = s.MaSach
									 WHERE s.MaSach = @MaSach)
			DECLARE @NgayHetHan date
			IF (@LoaiSach = 1)
			BEGIN
				IF (@DoiTuong = 5)
					SET @NgayHetHan = DATEADD(yyyy, 1, GETDATE())
				ELSE 
					SET @NgayHetHan = DATEADD(dd, 28, GETDATE())
			END
			ELSE BEGIN
				IF (@DoiTuong = 4)
					SET @NgayHetHan = DATEADD(dd, 56, GETDATE())
				ELSE IF (@DoiTuong = 5)
					SET @NgayHetHan = DATEADD(yyyy, 1, GETDATE())
				ELSE 
					SET @NgayHetHan = DATEADD(mm, 4, GETDATE())
			END
			INSERT INTO CHI_TIET_MUON_TRA(MaPhieuMuon, MaSach, NgayHetHan)
			VALUES (@MaPhieuMuon, @MaSach, @NgayHetHan)
		COMMIT TRAN
		END TRY
		BEGIN CATCH
			ROLLBACK
			DECLARE @err varchar(MAX)
			SELECT @err = 'Lỗi: ' + ERROR_MESSAGE()
			RAISERROR(@err, 16,1)
		END CATCH
END
GO

-- GIA HẠN THỜI GIAN MƯỢN SÁCH
CREATE OR ALTER PROCEDURE GIA_HAN_SACH (@MaPhieuMuon varchar(10), @MaSach varchar(10))
AS
BEGIN
	SET XACT_ABORT ON
	BEGIN TRAN
		BEGIN TRY
			DECLARE @DoiTuong int = (SELECT TOP 1 dg.MaDoiTuong
									 FROM CHI_TIET_MUON_TRA ctmt JOIN PHIEU_MUON pm ON ctmt.MaPhieuMuon = pm.MaPhieuMuon
									 JOIN DOC_GIA dg ON pm.MaDocGia = dg.MaDocGia WHERE pm.MaPhieuMuon = @MaPhieuMuon
									 )
			DECLARE @LoaiSach bit = (SELECT TOP 1 s.LoaiSach FROM CHI_TIET_MUON_TRA ctmt JOIN SACH s ON ctmt.MaSach = s.MaSach
									 WHERE s.MaSach = @MaSach)
			DECLARE @NgayHetHan date
			IF (@LoaiSach = 1)
			BEGIN
				IF (@DoiTuong = 5)
					SET @NgayHetHan = DATEADD(yyyy, 1, GETDATE())
				ELSE 
					SET @NgayHetHan = DATEADD(dd, 28, GETDATE())
			END
			ELSE BEGIN
				IF (@DoiTuong = 4)
					SET @NgayHetHan = DATEADD(dd, 56, GETDATE())
				ELSE IF (@DoiTuong = 5)
					SET @NgayHetHan = DATEADD(yyyy, 1, GETDATE())
				ELSE 
					SET @NgayHetHan = DATEADD(mm, 4, GETDATE())
			END
			UPDATE CHI_TIET_MUON_TRA
			SET NgayHetHan = @NgayHetHan
			WHERE MaPhieuMuon = @MaPhieuMuon AND MaSach = @MaSach
		COMMIT TRAN
		END TRY
		BEGIN CATCH
			ROLLBACK
			DECLARE @err varchar(MAX)
			SELECT @err = 'Lỗi: ' + ERROR_MESSAGE()
			RAISERROR(@err, 16,1)
		END CATCH
END 
GO

-- TRẢ SÁCH
CREATE PROCEDURE TRA_SACH (@MaPhieuMuon varchar(10), @MaNhanVienTra varchar(10), @TinhTrang int, @MaSach varchar(10), @PhatHuHong decimal, @PhatQuaHan decimal)
AS
BEGIN
	UPDATE CHI_TIET_MUON_TRA
	SET NgayTra = GETDATE(), MaTinhTrangSach = @TinhTrang, MaNhanVienTra = @MaNhanVienTra, PhatHuHong = @PhatHuHong, PhatQuaHan = @PhatQuaHan
	WHERE MaPhieuMuon = @MaPhieuMuon AND MaSach = @MaSach
END
GO

-- QUẢN LÝ TÁC GIẢ
-- THÊM TÁC GIẢ
CREATE PROCEDURE THEM_TAC_GIA (@TenTacGia nvarchar(50))
AS 
BEGIN
	INSERT INTO TAC_GIA(TenTacGia) VALUES (@TenTacGia)
END
GO

-- SỬA TÁC GIẢ
CREATE PROCEDURE SUA_TAC_GIA (@MaTacGia varchar(10), @TenTacGia nvarchar(50))
AS 
BEGIN
	UPDATE TAC_GIA
	SET TenTacGia = @TenTacGia
	WHERE MaTacGia = @MaTacGia
END
GO

-- XOÁ TÁC GIẢ
CREATE PROCEDURE XOA_TAC_GIA (@MaTacGia varchar(10))
AS
BEGIN 
	DELETE TAC_GIA WHERE MaTacGia = @MaTacGia
END
GO


-- QUẢN LÝ NHÀ XUẤT BẢN
-- THÊM NHÀ XUẤT BẢN
CREATE PROCEDURE THEM_NHA_XUAT_BAN (@TenNhaXuatBan nvarchar(50))
AS 
BEGIN
	INSERT INTO NHA_XUAT_BAN(TenNhaXuatBan) VALUES (@TenNhaXuatBan)
END
GO

-- SỬA NHÀ XUẤT BẢN
CREATE PROCEDURE SUA_NHA_XUAT_BAN (@MaNhaXuatBan varchar(10), @TenNhaXuatBan nvarchar(50))
AS 
BEGIN
	UPDATE NHA_XUAT_BAN
	SET TenNhaXuatBan = @TenNhaXuatBan
	WHERE MaNhaXuatBan = @MaNhaXuatBan
END
GO

-- XOÁ NHÀ XUẤT BẢN
CREATE PROCEDURE XOA_NHA_XUAT_BAN (@MaNhaXuatBan varchar(10))
AS
BEGIN 
	DELETE NHA_XUAT_BAN WHERE MaNhaXuatBan = @MaNhaXuatBan
END
GO


-- QUẢN LÝ CHUYÊN NGÀNH
-- THÊM CHUYÊN NGÀNH
CREATE PROCEDURE THEM_CHUYEN_NGANH (@TenChuyenNganh nvarchar(50))
AS 
BEGIN
	INSERT INTO CHUYEN_NGANH(TenChuyenNganh) VALUES (@TenChuyenNganh)
END
GO

-- SỬA CHUYÊN NGÀNH
CREATE PROCEDURE SUA_CHUYEN_NGANH (@MaChuyenNganh varchar(10), @TenChuyenNganh nvarchar(50))
AS 
BEGIN
	UPDATE CHUYEN_NGANH
	SET TenChuyenNganh = @TenChuyenNganh
	WHERE MaChuyenNganh = @MaChuyenNganh
END
GO

-- XOÁ CHUYÊN NGÀNH
CREATE OR ALTER PROCEDURE XOA_CHUYEN_NGANH (@MaChuyenNganh varchar(10))
AS
BEGIN 
	DELETE CHUYEN_NGANH WHERE MaChuyenNganh = @MaChuyenNganh
END
GO


-- QUẢN LÝ NHÂN VIÊN
-- THÊM NHÂN VIÊN
CREATE PROCEDURE THEM_NHAN_VIEN (@HoTen nvarchar(50), @GioiTinh bit, @NgaySinh date, 
								 @SDT varchar(10), @Email varchar(50), @Username varchar(20), @Password varchar(20))
AS 
BEGIN
	DECLARE @MaNhanVien varchar(10) = dbo.Auto_MaNhanVien()
	INSERT INTO NHAN_VIEN (HoTen, GioiTinh, NgaySinh, SoDienThoai, Email, NgayVaoLam)
	VALUES (@HoTen, @GioiTinh, @NgaySinh, @SDT, @Email, GETDATE())
	INSERT INTO DANG_NHAP(TenDangNhap, MatKhau, MaNhanVien, LoaiTaiKhoan)
	VALUES (@Username, @Password, @MaNhanVien, 1)
END
GO

-- SỬA NHÂN VIÊN
CREATE PROCEDURE SUA_NHAN_VIEN (@MaNhanVien varchar(10), @HoTen nvarchar(50), @GioiTinh bit,
								@NgaySinh date, @SDT varchar(10), @Email varchar(50))
AS 
BEGIN
	UPDATE NHAN_VIEN
	SET HoTen = @HoTen, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, SoDienThoai = @SDT, Email = @Email
	WHERE MaNhanVien = @MaNhanVien
END
GO

-- XOÁ NHÂN VIÊN
CREATE PROCEDURE XOA_NHAN_VIEN (@MaNhanVien varchar(10))
AS
BEGIN 
	DELETE NHAN_VIEN WHERE MaNhanVien = @MaNhanVien
END
GO

-- QUẢN LÝ ĐĂNG NHẬP
-- THÊM ĐĂNG NHẬP

-- THAY ĐỔI MẬT KHẨU
CREATE OR ALTER PROCEDURE DOI_MAT_KHAU (@TenDangNhap varchar(20), @MatKhauCu varchar(20), @MatKhauMoi varchar(20))
AS 
BEGIN
	IF (@MatKhauCu = (SELECT TOP 1 MatKhau FROM DANG_NHAP WHERE TenDangNhap = @TenDangNhap))
	BEGIN
		UPDATE DANG_NHAP
		SET MatKhau = @MatKhauMoi
		WHERE TenDangNhap = @TenDangNhap

		DECLARE @sqlString varchar(MAX) = 'ALTER LOGIN [' + @TenDangNhap +'] WITH PASSWORD = N' + QUOTENAME(@MatKhauMoi,'''')
		+ 'OLD_PASSWORD = N' + QUOTENAME(@MatKhauCu,'''') + N';';
		EXEC (@sqlString)
	END
	ELSE PRINT 'Sai mật khẩu'
END
GO

-- FUNCTION --

-- TÌM KIẾM ĐỘC GIẢ THEO MÃ ĐỘC GIẢ
CREATE FUNCTION TIM_KIEM_MA_DOC_GIA (@MaDocGia varchar(10))
RETURNS TABLE
AS RETURN (
	SELECT * FROM VIEW_CHI_TIET_THE_DOC_GIA 
	WHERE [Mã độc giả] = @MaDocGia)
GO

-- TÌM KIẾM SÁCH THEO TÊN
CREATE FUNCTION TIM_KIEM_SACH (@TenSach nvarchar(100))
RETURNS TABLE
AS RETURN (
	SELECT * FROM VIEW_CHI_TIET_SACH
	WHERE [Tên sách] = @TenSach)
GO

-- TÌM KIẾM NHÂN VIÊN THEO TÊN
CREATE FUNCTION TIM_KIEM_NHAN_VIEN (@TenNhanVien nvarchar(50))
RETURNS TABLE
AS RETURN (
	SELECT * FROM VIEW_CHI_TIET_NHAN_VIEN
	WHERE [Họ tên] = @TenNhanVien)
GO

-- TÌM KIẾM CÁC SÁCH ĐANG MƯỢN THEO MÃ ĐỘC GIẢ
CREATE FUNCTION TIM_KIEM_SACH_DANG_MUON_MA_DOC_GIA (@MaDocGia varchar(10))
RETURNS TABLE
AS RETURN (
	SELECT * FROM VIEW_SACH_DANG_MUON
	WHERE [Mã người mượn] = @MaDocGia)
GO

-- TÌM KIẾM CÁC SÁCH ĐÃ TRẢ THEO MÃ ĐỘC GIẢ
CREATE FUNCTION TIM_KIEM_SACH_DA_TRA_MA_DOC_GIA (@MaDocGia varchar(10))
RETURNS TABLE
AS RETURN (
	SELECT * FROM VIEW_SACH_DA_TRA
	WHERE [Mã người mượn] = @MaDocGia)
GO

-- TÌM KIẾM TOÀN BỘ MƯỢN TRẢ THEO MÃ ĐỘC GIẢ
CREATE FUNCTION TIM_KIEM_MUON_TRA_MA_DOC_GIA (@MaDocGia varchar(10))
RETURNS TABLE
AS RETURN (
	SELECT * FROM VIEW_CHI_TIET_MUON_TRA
	WHERE [Mã người mượn] = @MaDocGia)
GO

-- TÌM KIẾM CÁC SÁCH ĐANG MƯỢN THEO MÃ PHIẾU MƯỢN
CREATE FUNCTION TIM_KIEM_SACH_DANG_MUON_PHIEU_MUON (@MaPhieuMuon varchar(10))
RETURNS TABLE
AS RETURN (
	SELECT * FROM VIEW_SACH_DANG_MUON
	WHERE [Mã phiếu mượn] = @MaPhieuMuon)
GO

-- TÌM KIẾM CÁC SÁCH ĐÃ TRẢ THEO MÃ PHIẾU MƯỢN
CREATE FUNCTION TIM_KIEM_SACH_DA_TRA_PHIEU_MUON(@MaPhieuMuon varchar(10))
RETURNS TABLE
AS RETURN (
	SELECT * FROM VIEW_SACH_DA_TRA
	WHERE [Mã phiếu mượn] = @MaPhieuMuon)
GO

-- TÌM KIẾM CÁC SÁCH ĐÃ TRẢ THEO MÃ PHIẾU MƯỢN
CREATE FUNCTION TIM_KIEM_MUON_TRA_PHIEU_MUON (@MaPhieuMuon varchar(10))
RETURNS TABLE
AS RETURN (
	SELECT * FROM VIEW_CHI_TIET_MUON_TRA
	WHERE [Mã phiếu mượn] = @MaPhieuMuon)
GO

-- LẤY MÃ NHÂN VIÊN SAU KHI ĐĂNG NHẬP THÀNH CÔNG
CREATE OR ALTER FUNCTION LAY_MA_NHAN_VIEN (@Username varchar(20))
RETURNS VARCHAR(10)
AS 
BEGIN
	DECLARE @MaNhanVien varchar(10) 
	SET @MaNhanVien= (SELECT MaNhanVien FROM DANG_NHAP WHERE TenDangNhap = @Username)
	RETURN @MaNhanVien
END
GO


-- TÍNH TIỀN PHẠT KHI LÀM MẤT/ HƯ HỎNG
CREATE FUNCTION TINH_PHAT_HU_HONG (@MaSach varchar(10), @TinhTrang int)
RETURNS DECIMAL
AS
BEGIN
	DECLARE @GiaBia decimal = (SELECT GiaBia FROM SACH WHERE MaSach = @MaSach)
	IF (@TinhTrang = 2)
		RETURN (@GiaBia * 5)
	RETURN 0
END
GO

-- TÍNH TIỀN PHẠT TRỄ HẠN
CREATE OR ALTER FUNCTION TINH_PHAT_TRE_HAN (@NgayHetHan date)
RETURNS DECIMAL
AS
BEGIN
	IF (GETDATE() > @NgayHetHan)
		RETURN 1000 * DATEDIFF(dd, @NgayHetHan, GETDATE())
	RETURN 0
END
GO


CREATE ROLE NhanVien
--Gán các quyền trên table cho các tài khoản đăng nhập với vai trò Nhân viên
GRANT SELECT, INSERT, UPDATE, DELETE, REFERENCES ON CHI_TIET_MUON_TRA TO NhanVien
GRANT SELECT, INSERT, UPDATE, DELETE, REFERENCES ON CHUYEN_NGANH TO NhanVien
GRANT SELECT, INSERT, UPDATE, DELETE, REFERENCES ON DOC_GIA TO NhanVien
GRANT SELECT, INSERT, UPDATE, DELETE, REFERENCES ON NHA_XUAT_BAN TO NhanVien
GRANT SELECT, INSERT, UPDATE, DELETE, REFERENCES ON PHIEU_MUON TO NhanVien
GRANT SELECT, INSERT, UPDATE, DELETE, REFERENCES ON SACH TO NhanVien
GRANT SELECT, INSERT, UPDATE, DELETE, REFERENCES ON SACH_TAC_GIA TO NhanVien
GRANT SELECT, INSERT, UPDATE, DELETE, REFERENCES ON TAC_GIA TO NhanVien
GRANT SELECT, REFERENCES ON DOI_TUONG_DOC_GIA TO NhanVien
GRANT SELECT, REFERENCES ON TINH_TRANG_SACH TO NhanVien
GRANT SELECT, UPDATE, REFERENCES ON DANG_NHAP TO NhanVien
GRANT SELECT, REFERENCES ON NHAN_VIEN TO NhanVien
-- Gán quyền thực thi trên các procedure, function cho role Staff
GRANT EXECUTE TO NhanVien
GRANT SELECT TO NhanVien
DENY UPDATE, INSERT, DELETE ON NHAN_VIEN to NhanVien
DENY EXECUTE ON SUA_NHAN_VIEN to NhanVien
DENY EXECUTE ON THEM_NHAN_VIEN to NhanVien
DENY EXECUTE ON XOA_NHAN_VIEN to NhanVien
GO



-- THÊM DỮ LIỆU VÀO DATABASE --

INSERT INTO DOI_TUONG_DOC_GIA VALUES(N'Sinh viên đại trà')
INSERT INTO DOI_TUONG_DOC_GIA VALUES(N'Sinh viên Khoa đào tạo Chất lượng cao')
INSERT INTO DOI_TUONG_DOC_GIA VALUES(N'Sinh viên Khoa đào tạo Quốc tế')
INSERT INTO DOI_TUONG_DOC_GIA VALUES(N'Học viên cao học')
INSERT INTO DOI_TUONG_DOC_GIA VALUES(N'Cán bộ viên chức')

INSERT INTO DOC_GIA (MaDocGia, MaDoiTuong, HoTen, GioiTinh, NgaySinh, SoDienThoai, Email, NgayLamThe, NgayHetHan)
VALUES ('20110127', 2, N'Nguyễn Tiến Dũng', 1, '2002/03/30', '0982087932', 'tiendung@gmail.com', '2023/03/19', '2024/03/19')
INSERT INTO DOC_GIA (MaDocGia, MaDoiTuong, HoTen, GioiTinh, NgaySinh, SoDienThoai, Email, NgayLamThe, NgayHetHan)
VALUES ('20110000', 2, N'Nguyễn Như Ngọc', 0, '2002/04/22', '0982087333', 'nhungoc@gmail.com', '2023/03/19', '2024/03/19')
INSERT INTO DOC_GIA (MaDocGia, MaDoiTuong, HoTen, GioiTinh, NgaySinh, SoDienThoai, Email, NgayLamThe, NgayHetHan)
VALUES ('20149023', 2, N'Nguyễn Hoàng Việt', 1, '2002/03/20', '0982087123', 'nghoangviet@gmail.com', '2023/03/19', '2024/03/19')
INSERT INTO DOC_GIA (MaDocGia, MaDoiTuong, HoTen, GioiTinh, NgaySinh, SoDienThoai, Email, NgayLamThe, NgayHetHan)
VALUES ('20149020', 2, N'Ngô Gia Minh', 1, '2002/03/21', '0982187123', 'minhth@gmail.com', '2023/03/19', '2024/03/19')
INSERT INTO DOC_GIA (MaDocGia, MaDoiTuong, HoTen, GioiTinh, NgaySinh, SoDienThoai, Email, NgayLamThe, NgayHetHan)
VALUES ('20199013', 1, N'Ngô Yến Nhi', 0, '2002/01/20', '0982081223', 'yennhi@gmail.com', '2023/03/19', '2024/03/19')
INSERT INTO DOC_GIA (MaDocGia, MaDoiTuong, HoTen, GioiTinh, NgaySinh, SoDienThoai, Email, NgayLamThe, NgayHetHan)
VALUES ('17199023', 4, N'Hoàng Ánh Thi', 0, '1999/09/20', '0983111223', 'thianhhoang@gmail.com', '2023/03/19', '2024/03/19')
INSERT INTO DOC_GIA (MaDocGia, MaDoiTuong, HoTen, GioiTinh, NgaySinh, SoDienThoai, Email, NgayLamThe, NgayHetHan)
VALUES ('20199033', 1, N'Nguyễn Văn Đạt', 1, '2002/09/20', '0983081223', 'datpq@gmail.com', '2023/03/19', '2024/03/19')
INSERT INTO DOC_GIA (MaDocGia, MaDoiTuong, HoTen, GioiTinh, NgaySinh, SoDienThoai, Email, NgayLamThe, NgayHetHan)
VALUES ('20199043', 3, N'Nguyễn Văn Thọ', 1, '2002/12/20', '0983081333', 'thone@gmail.com', '2023/03/19', '2024/03/19')

INSERT INTO TINH_TRANG_SACH VALUES (N'Bình thường')
INSERT INTO TINH_TRANG_SACH VALUES (N'Hư hỏng/mất sách nhưng không thể tìm mua trả')
INSERT INTO TINH_TRANG_SACH VALUES (N'Mất sách đã mua trả lại')
INSERT INTO TINH_TRANG_SACH VALUES (N'Khác')

INSERT INTO CHUYEN_NGANH (TenChuyenNganh) VALUES(N'Công nghệ thông tin')
INSERT INTO CHUYEN_NGANH (TenChuyenNganh) VALUES(N'Hệ thống nhúng và IoT')
INSERT INTO CHUYEN_NGANH (TenChuyenNganh) VALUES(N'Điện - điện tử')
INSERT INTO CHUYEN_NGANH (TenChuyenNganh) VALUES(N'Điều khiển và tự động hoá')
INSERT INTO CHUYEN_NGANH (TenChuyenNganh) VALUES(N'Cơ khí chế tạo máy')
INSERT INTO CHUYEN_NGANH (TenChuyenNganh) VALUES(N'Công nghệ sinh học')
INSERT INTO CHUYEN_NGANH (TenChuyenNganh) VALUES(N'Kế toán')
INSERT INTO CHUYEN_NGANH (TenChuyenNganh) VALUES(N'Ngôn ngữ Anh')
INSERT INTO CHUYEN_NGANH (TenChuyenNganh) VALUES(N'Thiết kế thời trang')
INSERT INTO CHUYEN_NGANH (TenChuyenNganh) VALUES(N'Công nghệ kỹ thuật ô tô')
INSERT INTO CHUYEN_NGANH (TenChuyenNganh) VALUES(N'Kỹ thuật nữ công')
INSERT INTO CHUYEN_NGANH (TenChuyenNganh) VALUES(N'Xây dựng')
INSERT INTO CHUYEN_NGANH (TenChuyenNganh) VALUES(N'Kiến trúc')
INSERT INTO CHUYEN_NGANH (TenChuyenNganh) VALUES(N'Công nghệ in')
INSERT INTO CHUYEN_NGANH (TenChuyenNganh) VALUES(N'Quản lý công nghiệp')


INSERT INTO NHA_XUAT_BAN (TenNhaXuatBan) VALUES(N'Đại học Quốc gia Tp.HCM')
INSERT INTO NHA_XUAT_BAN (TenNhaXuatBan) VALUES(N'Tổng hợp Tp.HCM')
INSERT INTO NHA_XUAT_BAN (TenNhaXuatBan) VALUES(N'Giáo dục Việt Nam')
INSERT INTO NHA_XUAT_BAN (TenNhaXuatBan) VALUES(N'Phụ nữ')
INSERT INTO NHA_XUAT_BAN (TenNhaXuatBan) VALUES(N'Đại học Sư phạm')
INSERT INTO NHA_XUAT_BAN (TenNhaXuatBan) VALUES(N'Xây dựng')

INSERT INTO TAC_GIA (TenTacGia) VALUES (N'Đỗ Văn Dũng') -- Giáo trình thiết kế ô tô
INSERT INTO TAC_GIA (TenTacGia) VALUES (N'Đặng Quý')
INSERT INTO TAC_GIA (TenTacGia) VALUES (N'Dương Tuấn Tùng')
INSERT INTO TAC_GIA (TenTacGia) VALUES (N'Huỳnh Hoàng Hà') -- Thực hành cơ sở và ứng dụng IOTS
INSERT INTO TAC_GIA (TenTacGia) VALUES (N'Trương Quang Phúc')
INSERT INTO TAC_GIA (TenTacGia) VALUES (N'Đỗ Duy Tân')
INSERT INTO TAC_GIA (TenTacGia) VALUES (N'Quách Thanh Hải') -- Điện tử công suất
INSERT INTO TAC_GIA (TenTacGia) VALUES (N'Phạm Anh Tuấn') -- Chuyển đổi số (sách tham khảo)
INSERT INTO TAC_GIA (TenTacGia) VALUES (N'Phương Văn Quang') -- Giải pháp thiết kế bộ xoay pha số hoạt động ở băng tần C
INSERT INTO TAC_GIA (TenTacGia) VALUES (N'Vũ Đình Tuấn')
INSERT INTO TAC_GIA (TenTacGia) VALUES (N'Nguyễn Sỹ Quyền')
INSERT INTO TAC_GIA (TenTacGia) VALUES (N'Hồ Đình Linh') 
INSERT INTO TAC_GIA (TenTacGia) VALUES (N'Chu Văn Mẫn') -- Tin học trong công nghệ sinh học
INSERT INTO TAC_GIA (TenTacGia) VALUES (N'Huỳnh Thu Dung') -- Nghệ thuật trang điểm
INSERT INTO TAC_GIA (TenTacGia) VALUES (N'Vũ Đình Hoà') -- Chương trình dịch
INSERT INTO TAC_GIA (TenTacGia) VALUES (N'Đỗ Bích Ngọc')
INSERT INTO TAC_GIA (TenTacGia) VALUES (N'Nguyễn Thế Bá') -- Quy hoạch xây dựng phát triển đô thị


INSERT INTO NHAN_VIEN (HoTen, GioiTinh, NgaySinh, SoDienThoai, Email, NgayVaoLam) VALUES (N'Nguyễn Tiến Dũng', 1, '2002/03/30', '0982087932', 'tiendung@gmail.com', '2023/01/01')
INSERT INTO NHAN_VIEN (HoTen, GioiTinh, NgaySinh, SoDienThoai, Email, NgayVaoLam) VALUES (N'Nguyễn Hoàng Quang Trung', 1, '2002/01/26', '0983334910', 'nhqtrung@gmail.com', '2023/01/01')
INSERT INTO NHAN_VIEN (HoTen, GioiTinh, NgaySinh, SoDienThoai, Email, NgayVaoLam) VALUES (N'Lê Ngọc Linh', 0, '2002/02/03', '0983924345', 'ngoclinh@gmail.com', '2023/01/10')
/* INSERT INTO NHAN_VIEN (HoTen, GioiTinh, NgaySinh, SoDienThoai, Email, NgayVaoLam) VALUES (N'Hoàng Trọng Thắng', 1, '2002/02/03', '0983924567', 'htthang@gmail.com', '2023/01/10')
INSERT INTO NHAN_VIEN (HoTen, GioiTinh, NgaySinh, SoDienThoai, Email, NgayVaoLam) VALUES (N'Đỗ Ngọc Quỳnh', 0, '2002/02/01', '0983924561', 'ngquynh@gmail.com', '2023/01/10')
INSERT INTO NHAN_VIEN (HoTen, GioiTinh, NgaySinh, SoDienThoai, Email, NgayVaoLam) VALUES (N'Lê Thu Hằng', 0, '2002/02/23', '0983924562', 'hangle@gmail.com', '2023/01/10') */

INSERT INTO DANG_NHAP VALUES ('NV001', 'admin', 'admin123', 0)
INSERT INTO DANG_NHAP VALUES ('NV002', 'hoangtrung', 'trung123', 1)
INSERT INTO DANG_NHAP VALUES ('NV003', 'ngoclinh', 'ngoclinh123', 1)
/* INSERT INTO DANG_NHAP VALUES ('NV004', 'trongthang', 'trongthang0123', 1)
INSERT INTO DANG_NHAP VALUES ('NV005', 'ngocquynh', 'quynh000', 1)
INSERT INTO DANG_NHAP VALUES ('NV006', 'thuhang', '00001111', 1) */

INSERT INTO SACH (TenSach, LoaiSach, MaNhaXuatBan, MaChuyenNganh, GiaBia, SoLuong) VALUES (N'Thiết kế ô tô', 0, 'NXB0001', 'CN0003', 60000, 120)
INSERT INTO SACH (TenSach, LoaiSach, MaNhaXuatBan, MaChuyenNganh, GiaBia, SoLuong) VALUES (N'Thực hành cơ sở và ứng dụng IoT', 0, 'NXB0001', 'CN0002', 45000, 80)
INSERT INTO SACH (TenSach, LoaiSach, MaNhaXuatBan, MaChuyenNganh, GiaBia, SoLuong) VALUES (N'Điện tử công suất', 0, 'NXB0001', 'CN0003', 75000, 115)
INSERT INTO SACH (TenSach, LoaiSach, MaNhaXuatBan, MaChuyenNganh, GiaBia, SoLuong) VALUES (N'Chuyển đổi số thời đại 4.0', 1, 'NXB0001', 'CN0002', 60000, 50)
INSERT INTO SACH (TenSach, LoaiSach, MaNhaXuatBan, MaChuyenNganh, GiaBia, SoLuong) VALUES (N'Giải pháp thiết kế bộ xoay pha hoạt động ở băng tần C', 0, 'NXB0002', 'CN0004', 30000, 30)
INSERT INTO SACH (TenSach, LoaiSach, MaNhaXuatBan, MaChuyenNganh, GiaBia, SoLuong) VALUES (N'Tin học trong Công nghệ sinh học', 1, 'NXB0003', 'CN0006', 60000, 50)
INSERT INTO SACH (TenSach, LoaiSach, MaNhaXuatBan, MaChuyenNganh, GiaBia, SoLuong) VALUES (N'Nghệ thuật trang điểm', 1, 'NXB0004', 'CN0011', 20000, 30)
INSERT INTO SACH (TenSach, LoaiSach, MaNhaXuatBan, MaChuyenNganh, GiaBia, SoLuong) VALUES (N'Chương trình dịch', 1, 'NXB0005', 'CN0002', 65000, 45)
INSERT INTO SACH (TenSach, LoaiSach, MaNhaXuatBan, MaChuyenNganh, GiaBia, SoLuong) VALUES (N'Quy hoạch xây dựng phát triển đô thị', 1, 'NXB0006', 'CN0012', 85000, 95)

INSERT INTO SACH_TAC_GIA VALUES ('SACH00001', 'TG0001')
INSERT INTO SACH_TAC_GIA VALUES ('SACH00001', 'TG0002')
INSERT INTO SACH_TAC_GIA VALUES ('SACH00001', 'TG0003')
INSERT INTO SACH_TAC_GIA VALUES ('SACH00002', 'TG0004')
INSERT INTO SACH_TAC_GIA VALUES ('SACH00002', 'TG0005')
INSERT INTO SACH_TAC_GIA VALUES ('SACH00002', 'TG0006')
INSERT INTO SACH_TAC_GIA VALUES ('SACH00003', 'TG0007')
INSERT INTO SACH_TAC_GIA VALUES ('SACH00004', 'TG0008')
INSERT INTO SACH_TAC_GIA VALUES ('SACH00005', 'TG0009')
INSERT INTO SACH_TAC_GIA VALUES ('SACH00005', 'TG0010')
INSERT INTO SACH_TAC_GIA VALUES ('SACH00005', 'TG0011')
INSERT INTO SACH_TAC_GIA VALUES ('SACH00005', 'TG0012')
INSERT INTO SACH_TAC_GIA VALUES ('SACH00006', 'TG0013')
INSERT INTO SACH_TAC_GIA VALUES ('SACH00007', 'TG0014')
INSERT INTO SACH_TAC_GIA VALUES ('SACH00008', 'TG0015')
INSERT INTO SACH_TAC_GIA VALUES ('SACH00008', 'TG0016')
INSERT INTO SACH_TAC_GIA VALUES ('SACH00009', 'TG0017')

/* INSERT INTO PHIEU_MUON (MaDocGia, MaNhanVien, NgayMuon) VALUES ('20110127', 'NV002', '2023/02/01')
INSERT INTO PHIEU_MUON (MaDocGia, MaNhanVien, NgayMuon) VALUES ('20110000', 'NV003', '2023/03/01')
INSERT INTO PHIEU_MUON (MaDocGia, MaNhanVien, NgayMuon) VALUES ('20149023', 'NV001', '2023/03/05')
INSERT INTO PHIEU_MUON (MaDocGia, MaNhanVien, NgayMuon) VALUES ('20110127', 'NV003', '2023/03/09')
INSERT INTO PHIEU_MUON (MaDocGia, MaNhanVien, NgayMuon) VALUES ('17199023', 'NV006', '2023/03/09')

INSERT INTO CHI_TIET_MUON_TRA (MaPhieuMuon, MaSach, NgayHetHan) VALUES ('000000001', 'SACH00004', '2024/03/22')
INSERT INTO CHI_TIET_MUON_TRA (MaPhieuMuon, MaSach, NgayHetHan) VALUES ('000000001', 'SACH00003', '2024/03/23')
INSERT INTO CHI_TIET_MUON_TRA (MaPhieuMuon, MaSach, NgayHetHan) VALUES ('000000002', 'SACH00005', '2024/04/01')
INSERT INTO CHI_TIET_MUON_TRA (MaPhieuMuon, MaSach, NgayHetHan) VALUES ('000000002', 'SACH00001', '2024/03/30')
INSERT INTO CHI_TIET_MUON_TRA (MaPhieuMuon, MaSach, NgayHetHan) VALUES ('000000003', 'SACH00002', '2024/03/25')
INSERT INTO CHI_TIET_MUON_TRA (MaPhieuMuon, MaSach, NgayHetHan) VALUES ('000000004', 'SACH00002', '2024/03/25')
INSERT INTO CHI_TIET_MUON_TRA (MaPhieuMuon, MaSach, NgayHetHan) VALUES ('000000004', 'SACH00005', '2024/03/22')
-- INSERT INTO CHI_TIET_MUON_TRA (MaPhieuMuon, MaSach, NgayHetHan) VALUES ('000000004', 'SACH00002', '2023/03/19')
INSERT INTO CHI_TIET_MUON_TRA (MaPhieuMuon, MaSach, NgayHetHan) VALUES ('000000004', 'SACH00001', '2024/03/30')
INSERT INTO CHI_TIET_MUON_TRA (MaPhieuMuon, MaSach, NgayHetHan) VALUES ('000000005', 'SACH00006', '2024/03/30')
INSERT INTO CHI_TIET_MUON_TRA (MaPhieuMuon, MaSach, NgayHetHan) VALUES ('000000005', 'SACH00007', '2024/03/30')
/* INSERT INTO CHI_TIET_MUON_TRA (MaPhieuMuon, MaSach, NgayHetHan) VALUES ('000000005', 'SACH00008', '2024/03/30')
INSERT INTO CHI_TIET_MUON_TRA (MaPhieuMuon, MaSach, NgayHetHan) VALUES ('000000005', 'SACH00009', '2024/03/30')
INSERT INTO CHI_TIET_MUON_TRA (MaPhieuMuon, MaSach, NgayHetHan) VALUES ('000000005', 'SACH00010', '2024/03/30')
INSERT INTO CHI_TIET_MUON_TRA (MaPhieuMuon, MaSach, NgayHetHan) VALUES ('000000005', 'SACH00011', '2024/03/30')
INSERT INTO CHI_TIET_MUON_TRA (MaPhieuMuon, MaSach, NgayHetHan) VALUES ('000000005', 'SACH00012', '2024/03/30')
INSERT INTO CHI_TIET_MUON_TRA (MaPhieuMuon, MaSach, NgayHetHan) VALUES ('000000005', 'SACH00013', '2024/03/30') */ */


