USE [db_QuanLyBanHangThietBiMayTinh]
GO
/****** Object:  StoredProcedure [dbo].[sp_AddHangBan]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_AddHangBan]
@mahd nvarchar(10),
@mahb nvarchar(10),
@soluong int,
@giaban float,
@thoigianbaohanh int
as
begin
	insert into tblHangBan
	values (@mahb, @mahd,  @soluong, @giaban, @thoigianbaohanh)
end

GO
/****** Object:  StoredProcedure [dbo].[sp_AddHangHoa]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_AddHangHoa]

@mahang nvarchar(10),
@manhomhang nvarchar(10),
@tenhang nvarchar(50),
@mausac nvarchar(50),
@dactinh nvarchar(50)
as
begin
	insert into tblHangHoa
	values (@mahang, @manhomhang,  @tenhang, @mausac, @dactinh)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_AddHangNhap]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_AddHangNhap]

@mahang nvarchar(10),
@mahoadon nvarchar(10),
@ten nvarchar(50),
@mausac nvarchar(50),
@dactinh nvarchar(50)
as
begin
	insert into tblHangNhap
	values (@mahang, @mahoadon,  @ten, @mausac, @dactinh)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_AddHoaDonBanHang]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_AddHoaDonBanHang]

@mahoadon nvarchar(10),
@manv nvarchar(10),
@tenkh nvarchar(50),
@thoigianban date,
@tinhtrang nvarchar(50)
as
begin
	insert into tblHoaDonBanHang
	values (@mahoadon, @manv,  @tenkh, @thoigianban, @tinhtrang)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_AddHoaDonNhap]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_AddHoaDonNhap]

@mahoadon nvarchar(10),
@manv nvarchar(10),
@mancc nvarchar(10),
@ngaynhap date
as
begin
	insert into tblHoaDonNhapHang
	values (@mahoadon, @manv,  @mancc, @ngaynhap)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_AddNCC]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_AddNCC]

@ma nvarchar(10),
@ten nvarchar(50),
@diachi nvarchar(50),
@sodienthoai nvarchar(50)
as
begin
	insert into tblNhaCungCap
	values (@ma, @ten,  @diachi, @sodienthoai)
end

GO
/****** Object:  StoredProcedure [dbo].[sp_AddNhanVien]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_AddNhanVien]
@sMaNV nvarchar(10),
@sTenNV nvarchar(50),
@bGioiTinh bit,
@dNgaySinh date,
@sDiaChi nvarchar(50),
@sSoDienThoai nvarchar(50)
as
begin 
	insert into tblNhanVien 
	values (@sMaNV, @sTenNV, @bGioiTinh, @dNgaySinh, @sDiaChi, @sSoDienThoai)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_AddNhomHang]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_AddNhomHang]
@ma nvarchar(10),
@ten nvarchar(50),
@mota nvarchar(100)
as
begin
	insert into tblNhomHang
	values( @ma, @ten, @mota)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteHangBan]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[sp_DeleteHangBan]
@mahb nvarchar(10)
as
begin
	DELETE FROM tblHangBan
	WHERE sMaHangBan=@mahb 
end
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteHangHoa]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_DeleteHangHoa]
@mahang nvarchar(10)
as
begin
	DELETE FROM tblHangHoa
	WHERE sMaHang = @mahang
end
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteHangNhap]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_DeleteHangNhap]
@mahang nvarchar(10)
as
begin
	DELETE FROM tblHangNhap
	WHERE sMaHang=@mahang 
end

GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteHoaDonBan]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_DeleteHoaDonBan]
@mahoadon nvarchar(10)
as
begin
	DELETE FROM tblHoaDonBanHang
	WHERE sMaHoaDonBan=@mahoadon
end
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteHoaDonNhap]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[sp_DeleteHoaDonNhap]
@mahoadon nvarchar(10)
as
begin
	DELETE FROM tblHoaDonNhapHang
	WHERE sMaHoaDonNhap=@mahoadon
end
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteNCC]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_DeleteNCC]
@ma nvarchar(10)
as
begin
	DELETE FROM tblNhaCungCap
	WHERE sMaNCC=@ma 
end



GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteNhanVien]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_DeleteNhanVien]
@manv nvarchar(10)
as
begin
	DELETE FROM tblNhanVien
	WHERE sMaNhanVien = @manv
end
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteNhomHang]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_DeleteNhomHang]
@ma nvarchar(10)
as
begin
	delete from tblNhomHang where sMaNhomHang=@ma
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_EditHangBan]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_EditHangBan]
@mahd nvarchar(10),
@mahb nvarchar(10),
@soluong int,
@giaban float,
@thoigianbaohanh int
as
begin
	UPDATE tblHangBan
SET sMaHoaDonBan=@mahd, iSoLuong=@soluong, fGiaBan=@giaban
WHERE sMaHangBan= @mahb 
end

GO
/****** Object:  StoredProcedure [dbo].[sp_EditHangHoa]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_EditHangHoa]
@mahang nvarchar(10),
@manhomhang nvarchar(10),
@tenhang nvarchar(50),
@mausac nvarchar(50),
@dactinh nvarchar(50)
as
begin


	UPDATE tblHangHoa
SET sMaNhomHang = @manhomhang , sTenHang= @tenhang, sMauSac= @mausac, sDacTinhKyThuat= @dactinh
WHERE sMaHang = @mahang
end
GO
/****** Object:  StoredProcedure [dbo].[sp_EditHangNhap]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_EditHangNhap]
@mahang nvarchar(10),
@mahoadon nvarchar(10),
@ten nvarchar(50),
@mausac nvarchar(50),
@dactinh nvarchar(50)
as
begin
	UPDATE tblHangNhap
SET sDacTinhKyThuat=@dactinh, sMaHoaDonNhap=@mahoadon, sTenHang=@ten, sMauSac=@mausac
WHERE sMaHang=@mahang 
end
GO
/****** Object:  StoredProcedure [dbo].[sp_EditHoaDonBanHang]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_EditHoaDonBanHang]
@mahoadon nvarchar(10),
@manv nvarchar(10),
@tenkh nvarchar(50),
@thoigianban date,
@tinhtrang nvarchar(50)
as
begin
	UPDATE tblHoaDonBanHang
SET sMaNhanVien=@manv, sTenKhachHang=@tenkh, dThoiGianBan=@thoigianban, sTinhTrangThanhToan=@tinhtrang
WHERE sMaHoaDonBan=@mahoadon
end

GO
/****** Object:  StoredProcedure [dbo].[sp_EditHoaDonNhap]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_EditHoaDonNhap]
@mahoadon nvarchar(10),
@manv nvarchar(10),
@mancc nvarchar(10),
@ngaynhap date
as
begin
	UPDATE tblHoaDonNhapHang
SET sMaNhanVien=@manv, sMaNhaCungCap=@mancc, dNgayNhap=@ngaynhap
WHERE sMaHoaDonNhap=@mahoadon
end
GO
/****** Object:  StoredProcedure [dbo].[sp_EditNCC]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_EditNCC]
@ma nvarchar(10),
@ten nvarchar(50),
@diachi nvarchar(50),
@sodienthoai nvarchar(50)
as
begin
	UPDATE tblNhaCungCap
SET sTenNCC=@ten, sDiaChi=@diachi, sSoDienThoai=@sodienthoai
WHERE sMaNCC=@ma 
end

GO
/****** Object:  StoredProcedure [dbo].[sp_EditNhanVien]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_EditNhanVien]
@sMaNV nvarchar(10),
@sTenNV nvarchar(50),
@bGioiTinh bit,
@dNgaySinh date,
@sDiaChi nvarchar(50),
@sSoDienThoai nvarchar(50)
as
begin
	UPDATE tblNhanVien
	SET sTenNhanVien = @sTenNV , bGioiTinh= @bGioiTinh, dNgaySinh= @dNgaySinh, sDiaChi= @sDiaChi, sSoDienThoai= @sSoDienThoai
	WHERE sMaNhanVien = @sMaNV
end
GO
/****** Object:  StoredProcedure [dbo].[sp_EditNhomHang]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_EditNhomHang]
@ma nvarchar(10),
@ten nvarchar(50),
@mota nvarchar(100)
as
begin
	update tblNhomHang
	set  sTenNhomHang=@ten, sMoTa=@mota
	where sMaNhomHang= @ma
end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllHangBan]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GetAllHangBan]
as 
begin
select * from tblHangBan
end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllHangHoa]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_GetAllHangHoa]
as 
begin
select sMaHang, sTenHang, sTenNhomHang, sMauSac, sDacTinhKyThuat from tblHangHoa inner join tblNhomHang on tblHangHoa.sMaNhomHang= tblNhomHang.sMaNhomHang

end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllHangNhap]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GetAllHangNhap]
as 
begin
select *  from tblHangNhap
end

GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllHoaDonBanHang]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GetAllHoaDonBanHang]
as 
begin
select sMaHoaDonBan, sTenNhanVien, sTenKhachHang, dThoiGianBan, sTinhTrangThanhToan
from tblHoaDonBanHang inner join tblNhanVien 
on tblHoaDonBanHang.sMaNhanVien=tblNhanVien.sMaNhanVien 
end

GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllHoaDonNhapHang]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GetAllHoaDonNhapHang]
as 
begin
--select sMaHang, sTenHang, sTenNhomHang, sMauSac, sDacTinhKyThuat from tblHangHoa inner join tblNhomHang on tblHangHoa.sMaNhomHang= tblNhomHang.sMaNhomHang
select tblHoaDonNhapHang.sMaHoaDonNhap,  tblNhanVien.sTenNhanVien, tblNhaCungCap.sTenNCC, tblHoaDonNhapHang.dNgayNhap
from tblHoaDonNhapHang inner join tblNhanVien on tblHoaDonNhapHang.sMaNhanVien= tblNhanVien.sMaNhanVien
						inner join tblNhaCungCap on tblHoaDonNhapHang.sMaNhaCungCap= tblNhaCungCap.sMaNCC

end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllNCC]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_GetAllNCC]
as 
begin
select * from tblNhaCungCap
end

GO
/****** Object:  StoredProcedure [dbo].[sp_GetNhomHang]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GetNhomHang]
as
begin
select *from tblNhomHang
end
GO
/****** Object:  StoredProcedure [dbo].[sp_GettAllNhanVien]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[sp_GettAllNhanVien]
as
begin
	select * from tblNhanVien
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetUser]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GetUser]
as
begin
	select * from tblUser
	end
GO
/****** Object:  Table [dbo].[tblHangBan]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHangBan](
	[sMaHangBan] [nvarchar](10) NOT NULL,
	[sMaHoaDonBan] [nvarchar](10) NULL,
	[iSoLuong] [int] NULL,
	[fGiaBan] [float] NULL,
	[iThoiGianBanHanh] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[sMaHangBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblHangBan_HangHoa]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHangBan_HangHoa](
	[sMaHangBan] [nvarchar](10) NOT NULL,
	[sMaHangHoa] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_HBHH] PRIMARY KEY CLUSTERED 
(
	[sMaHangBan] ASC,
	[sMaHangHoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblHangHoa]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHangHoa](
	[sMaHang] [nvarchar](10) NOT NULL,
	[sMaNhomHang] [nvarchar](10) NULL,
	[sTenHang] [nvarchar](50) NULL,
	[sMauSac] [nvarchar](50) NULL,
	[sDacTinhKyThuat] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[sMaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblHangNhap]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHangNhap](
	[sMaHang] [nvarchar](10) NOT NULL,
	[sMaHoaDonNhap] [nvarchar](10) NULL,
	[sTenHang] [nvarchar](50) NULL,
	[sMauSac] [nvarchar](50) NULL,
	[sDacTinhKyThuat] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[sMaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblHangNhap_HangHoa]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHangNhap_HangHoa](
	[sMaHangNhap] [nvarchar](10) NOT NULL,
	[sMaHangHoa] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_HNHH] PRIMARY KEY CLUSTERED 
(
	[sMaHangNhap] ASC,
	[sMaHangHoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblHoaDonBanHang]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHoaDonBanHang](
	[sMaHoaDonBan] [nvarchar](10) NOT NULL,
	[sMaNhanVien] [nvarchar](10) NULL,
	[sTenKhachHang] [nvarchar](50) NULL,
	[dThoiGianBan] [datetime] NULL,
	[sTinhTrangThanhToan] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[sMaHoaDonBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblHoaDonNhapHang]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHoaDonNhapHang](
	[sMaHoaDonNhap] [nvarchar](10) NOT NULL,
	[sMaNhanVien] [nvarchar](10) NULL,
	[sMaNhaCungCap] [nvarchar](10) NULL,
	[dNgayNhap] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[sMaHoaDonNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblNhaCungCap]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhaCungCap](
	[sMaNCC] [nvarchar](10) NOT NULL,
	[sTenNCC] [nvarchar](50) NULL,
	[sDiaChi] [nvarchar](50) NULL,
	[sSoDienThoai] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[sMaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblNhanVien]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhanVien](
	[sMaNhanVien] [nvarchar](10) NOT NULL,
	[sTenNhanVien] [nvarchar](50) NULL,
	[bGioiTinh] [bit] NULL,
	[dNgaySinh] [date] NULL,
	[sDiaChi] [nvarchar](50) NULL,
	[sSoDienThoai] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[sMaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblNhomHang]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhomHang](
	[sMaNhomHang] [nvarchar](10) NOT NULL,
	[sTenNhomHang] [nvarchar](50) NULL,
	[sMoTa] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[sMaNhomHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblUser]    Script Date: 10-Apr-19 10:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblUser](
	[sUserName] [varchar](50) NOT NULL,
	[sPassword] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[sUserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[tblHangBan]  WITH CHECK ADD  CONSTRAINT [FK_HANGBAN_HOADONBANHANG] FOREIGN KEY([sMaHoaDonBan])
REFERENCES [dbo].[tblHoaDonBanHang] ([sMaHoaDonBan])
GO
ALTER TABLE [dbo].[tblHangBan] CHECK CONSTRAINT [FK_HANGBAN_HOADONBANHANG]
GO
ALTER TABLE [dbo].[tblHangBan_HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HBHH_HANGBAN] FOREIGN KEY([sMaHangBan])
REFERENCES [dbo].[tblHangBan] ([sMaHangBan])
GO
ALTER TABLE [dbo].[tblHangBan_HangHoa] CHECK CONSTRAINT [FK_HBHH_HANGBAN]
GO
ALTER TABLE [dbo].[tblHangBan_HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HBHH_HANGHOA] FOREIGN KEY([sMaHangHoa])
REFERENCES [dbo].[tblHangHoa] ([sMaHang])
GO
ALTER TABLE [dbo].[tblHangBan_HangHoa] CHECK CONSTRAINT [FK_HBHH_HANGHOA]
GO
ALTER TABLE [dbo].[tblHangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HANGHOA_NHOMHANG] FOREIGN KEY([sMaNhomHang])
REFERENCES [dbo].[tblNhomHang] ([sMaNhomHang])
GO
ALTER TABLE [dbo].[tblHangHoa] CHECK CONSTRAINT [FK_HANGHOA_NHOMHANG]
GO
ALTER TABLE [dbo].[tblHangNhap]  WITH CHECK ADD  CONSTRAINT [FK_HANGNHAP_HOADONNHAPHANG] FOREIGN KEY([sMaHoaDonNhap])
REFERENCES [dbo].[tblHoaDonNhapHang] ([sMaHoaDonNhap])
GO
ALTER TABLE [dbo].[tblHangNhap] CHECK CONSTRAINT [FK_HANGNHAP_HOADONNHAPHANG]
GO
ALTER TABLE [dbo].[tblHangNhap_HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HNHH_HANGHOA] FOREIGN KEY([sMaHangHoa])
REFERENCES [dbo].[tblHangHoa] ([sMaHang])
GO
ALTER TABLE [dbo].[tblHangNhap_HangHoa] CHECK CONSTRAINT [FK_HNHH_HANGHOA]
GO
ALTER TABLE [dbo].[tblHangNhap_HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HNHH_HANGNHAP] FOREIGN KEY([sMaHangNhap])
REFERENCES [dbo].[tblHangNhap] ([sMaHang])
GO
ALTER TABLE [dbo].[tblHangNhap_HangHoa] CHECK CONSTRAINT [FK_HNHH_HANGNHAP]
GO
ALTER TABLE [dbo].[tblHoaDonBanHang]  WITH CHECK ADD  CONSTRAINT [FK_HOADONBANHANG_NHANVIEN] FOREIGN KEY([sMaNhanVien])
REFERENCES [dbo].[tblNhanVien] ([sMaNhanVien])
GO
ALTER TABLE [dbo].[tblHoaDonBanHang] CHECK CONSTRAINT [FK_HOADONBANHANG_NHANVIEN]
GO
ALTER TABLE [dbo].[tblHoaDonNhapHang]  WITH CHECK ADD  CONSTRAINT [FK_HOADONNHAPHANG_NHACUNGCAP] FOREIGN KEY([sMaNhaCungCap])
REFERENCES [dbo].[tblNhaCungCap] ([sMaNCC])
GO
ALTER TABLE [dbo].[tblHoaDonNhapHang] CHECK CONSTRAINT [FK_HOADONNHAPHANG_NHACUNGCAP]
GO
ALTER TABLE [dbo].[tblHoaDonNhapHang]  WITH CHECK ADD  CONSTRAINT [FK_HOADONNHAPHANG_NHANVIEN] FOREIGN KEY([sMaNhanVien])
REFERENCES [dbo].[tblNhanVien] ([sMaNhanVien])
GO
ALTER TABLE [dbo].[tblHoaDonNhapHang] CHECK CONSTRAINT [FK_HOADONNHAPHANG_NHANVIEN]
GO
