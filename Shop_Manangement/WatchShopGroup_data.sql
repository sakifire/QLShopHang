USE [WatchShopGroup]
GO
/****** Object:  UserDefinedFunction [dbo].[loginacc]    Script Date: 11/14/2021 9:21:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[loginacc] (@username char(50), @pass char(50))  returns @table table (id int null, feature int null)
as
begin
	insert @table select id,feature
			      from Account
				  where  username = @username and pass =@pass
	return
end
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 11/14/2021 9:21:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[phone] [varchar](10) NOT NULL,
	[name] [nvarchar](50) NULL,
	[addr] [nvarchar](max) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[phone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[getPhone]    Script Date: 11/14/2021 9:21:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[getPhone](@phone int) returns table as
return (
		select *
		from Customer
		where phone = @phone
)
GO
/****** Object:  Table [dbo].[Product]    Script Date: 11/14/2021 9:21:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[id] [int] NOT NULL,
	[name] [nvarchar](max) NULL,
	[type] [nvarchar](50) NULL,
	[price] [float] NULL,
	[description] [nvarchar](max) NULL,
	[inputday] [datetime] NULL,
	[amount] [int] NULL,
	[curnumber] [int] NULL,
	[picture] [image] NULL,
	[state] [int] NULL,
 CONSTRAINT [PK__Product__3213E83FB54B374A] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[findkey]    Script Date: 11/14/2021 9:21:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[findkey] (@key nvarchar(MAX)) returns table
as return (
	select * 
	from Product
	where state = 1 and type=@key
)
GO
/****** Object:  UserDefinedFunction [dbo].[thongtinkhachhangquaphone]    Script Date: 11/14/2021 9:21:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[thongtinkhachhangquaphone](@phone varchar(20)) returns table as
return
	select  kh.name, kh.addr, kh.phone
	from Customer kh	
	where kh.phone = @phone
GO
/****** Object:  UserDefinedFunction [dbo].[timsanpham]    Script Date: 11/14/2021 9:21:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[timsanpham](@idsp int) returns table
as return select id,name, (amount - curnumber) as N'Số sản phẩm đã bán'
		from Product
		where id = @idsp
GO
/****** Object:  UserDefinedFunction [dbo].[phanloaisp]    Script Date: 11/14/2021 9:21:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[phanloaisp]() returns table
as return select type, (sum(amount) -sum(curnumber)) as N'Tổng sản phẩm đã bán'
			from Product
			group by type
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 11/14/2021 9:21:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[id] [int] NOT NULL,
	[phone] [varchar](10) NULL,
	[amount] [int] NULL,
	[product] [nvarchar](max) NULL,
	[price] [float] NULL,
	[total] [float] NULL,
	[daytime] [datetime] NULL,
	[sale] [int] NULL,
	[manv] [varchar](10) NULL,
	[idpro] [int] NULL,
 CONSTRAINT [PK__Bill__3213E83F488D2013] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[thongtinkh]    Script Date: 11/14/2021 9:21:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[thongtinkh](@phone char(10)) returns table
as return select name, Bill.phone, addr, product, amount, total, daytime
		from Customer CUS inner join Bill on Bill.phone=CUS.phone 
		where CUS.phone =@phone
GO
/****** Object:  UserDefinedFunction [dbo].[LoaiSPDoanhSoCao]    Script Date: 11/14/2021 9:21:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[LoaiSPDoanhSoCao](@thang int) returns table as
return
select type, (sum(Product.amount) -sum(curnumber)) as N'Tổng sản phẩm đã bán', total
from Bill inner join Product on Product.id=Bill.idpro		
where total =(
			select MAX(total) as MaxDoanhSo from 
				(select type,  total
					from Bill inner join Product on Product.id=Bill.idpro
					where MONTH(daytime)=@thang)as A) 
group by type, total
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 11/14/2021 9:21:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[id] [varchar](10) NOT NULL,
	[firstname] [nvarchar](50) NULL,
	[lastname] [nvarchar](50) NULL,
	[phone] [varchar](10) NULL,
	[gender] [nvarchar](6) NULL,
	[addr] [nvarchar](max) NULL,
	[picture] [image] NULL,
	[idpos] [int] NULL,
 CONSTRAINT [PK__Staff__3213E83F3312E9CD] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[thongtinquanly]    Script Date: 11/14/2021 9:21:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[thongtinquanly]
as
select id, firstname, lastname, phone, gender, addr
from Staff
where idpos=1
GO
/****** Object:  Table [dbo].[Timekeeping]    Script Date: 11/14/2021 9:21:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Timekeeping](
	[Timedate] [datetime] NOT NULL,
	[id] [varchar](10) NOT NULL,
	[currstate] [char](1) NULL,
	[checkin] [datetime] NULL,
	[checkout] [datetime] NULL,
 CONSTRAINT [PK__Timekeep__9908E00A8B79F13A] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[Timedate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[nhanviendacheckin]    Script Date: 11/14/2021 9:21:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[nhanviendacheckin] as
select Staff.id as EmployeeID, lastname as Lastname, firstname as Firstname, Timedate as Date, currstate as Status 
                from Staff inner join Timekeeping on Staff.id=Timekeeping.id 
                where convert(date,Timedate)=convert(date, GETDATE())
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 11/14/2021 9:21:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[saleid] [int] NOT NULL,
	[startdate] [datetime] NULL,
	[finishdate] [datetime] NULL,
	[name] [nvarchar](50) NULL,
	[sale] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[saleid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[chuongtrinhsale]    Script Date: 11/14/2021 9:21:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[chuongtrinhsale] as
select name, startdate, finishdate, sale  from Sales
where sale <> 0
GO
/****** Object:  Table [dbo].[Account]    Script Date: 11/14/2021 9:21:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[username] [varchar](50) NOT NULL,
	[pass] [varchar](50) NULL,
	[feature] [int] NULL,
	[id] [varchar](10) NULL,
 CONSTRAINT [PK__Account__F3DBC573BBF154E8] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Position]    Script Date: 11/14/2021 9:21:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Position](
	[id] [int] NOT NULL,
	[Nameposition] [nvarchar](20) NULL,
	[NumSalary] [float] NULL,
	[Salary] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salary]    Script Date: 11/14/2021 9:21:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salary](
	[id] [varchar](10) NOT NULL,
	[month] [int] NOT NULL,
	[year] [int] NOT NULL,
	[salary] [real] NULL,
 CONSTRAINT [PK_Salary] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[month] ASC,
	[year] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK__Account__id__1A14E395] FOREIGN KEY([id])
REFERENCES [dbo].[Staff] ([id])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK__Account__id__1A14E395]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK__Bill__manv__2A4B4B5E] FOREIGN KEY([manv])
REFERENCES [dbo].[Staff] ([id])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK__Bill__manv__2A4B4B5E]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_Customer] FOREIGN KEY([phone])
REFERENCES [dbo].[Customer] ([phone])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_Customer]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_Product] FOREIGN KEY([idpro])
REFERENCES [dbo].[Product] ([id])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_Product]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_Sales] FOREIGN KEY([sale])
REFERENCES [dbo].[Sales] ([saleid])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_Sales]
GO
ALTER TABLE [dbo].[Salary]  WITH CHECK ADD  CONSTRAINT [FK_Salary_Staff] FOREIGN KEY([id])
REFERENCES [dbo].[Staff] ([id])
GO
ALTER TABLE [dbo].[Salary] CHECK CONSTRAINT [FK_Salary_Staff]
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD  CONSTRAINT [FK_Staff_Position] FOREIGN KEY([idpos])
REFERENCES [dbo].[Position] ([id])
GO
ALTER TABLE [dbo].[Staff] CHECK CONSTRAINT [FK_Staff_Position]
GO
ALTER TABLE [dbo].[Timekeeping]  WITH CHECK ADD  CONSTRAINT [FK__Timekeeping__id__1DE57479] FOREIGN KEY([id])
REFERENCES [dbo].[Staff] ([id])
GO
ALTER TABLE [dbo].[Timekeeping] CHECK CONSTRAINT [FK__Timekeeping__id__1DE57479]
GO
ALTER TABLE [dbo].[Timekeeping]  WITH CHECK ADD  CONSTRAINT [FK_Timekeeping_Staff] FOREIGN KEY([id])
REFERENCES [dbo].[Staff] ([id])
GO
ALTER TABLE [dbo].[Timekeeping] CHECK CONSTRAINT [FK_Timekeeping_Staff]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [slhon0] CHECK  (([Bill].[amount]>(0)))
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [slhon0]
GO
/****** Object:  StoredProcedure [dbo].[addaccount]    Script Date: 11/14/2021 9:21:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[addaccount] @username varchar(50), @pass varchar(50), @feature int, @phone char(50), @id int
as
begin
	DECLARE @sql varchar(MAX),@cmd varchar(4000)
	if @phone in (select phone from Staff)
	begin
		if @id in (select id from Staff)
		begin
		 insert into Account values(  @username,  @pass, @feature, @id )
		end
	end	
end
GO
/****** Object:  StoredProcedure [dbo].[HienTrangNhanVien]    Script Date: 11/14/2021 9:21:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HienTrangNhanVien](@ngay Date) as
	select Timekeeping.id as EmployeeID, firstname,lastname, currstate as Status,checkin as Checkin, checkout as Checkout 
	from Timekeeping inner join Staff on Staff.id =Timekeeping.id 
	WHERE convert(date,Timedate) =@ngay
GO
/****** Object:  StoredProcedure [dbo].[nhanvientrongthang]    Script Date: 11/14/2021 9:21:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[nhanvientrongthang] @id int, @thang int as
select Staff.id, lastname, firstname, Timedate, currstate, checkin, checkout
from Staff inner join Timekeeping on Staff.id=Timekeeping.id
where Staff.id=@id and MONTH(timedate)=@thang
GO
