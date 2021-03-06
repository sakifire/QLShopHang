USE [WatchShopGroup]
GO
/****** Object:  UserDefinedFunction [dbo].[loginacc]    Script Date: 11/14/2021 9:20:43 AM ******/
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
/****** Object:  UserDefinedFunction [dbo].[findkey]    Script Date: 11/14/2021 9:20:43 AM ******/
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
/****** Object:  UserDefinedFunction [dbo].[getPhone]    Script Date: 11/14/2021 9:20:43 AM ******/
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
/****** Object:  UserDefinedFunction [dbo].[LoaiSPDoanhSoCao]    Script Date: 11/14/2021 9:20:43 AM ******/
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
/****** Object:  UserDefinedFunction [dbo].[phanloaisp]    Script Date: 11/14/2021 9:20:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[phanloaisp]() returns table
as return select type, (sum(amount) -sum(curnumber)) as N'Tổng sản phẩm đã bán'
			from Product
			group by type
GO
/****** Object:  UserDefinedFunction [dbo].[thongtinkh]    Script Date: 11/14/2021 9:20:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[thongtinkh](@phone char(10)) returns table
as return select name, Bill.phone, addr, product, amount, total, daytime
		from Customer CUS inner join Bill on Bill.phone=CUS.phone 
		where CUS.phone =@phone
GO
/****** Object:  UserDefinedFunction [dbo].[thongtinkhachhangquaphone]    Script Date: 11/14/2021 9:20:43 AM ******/
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
/****** Object:  UserDefinedFunction [dbo].[timsanpham]    Script Date: 11/14/2021 9:20:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[timsanpham](@idsp int) returns table
as return select id,name, (amount - curnumber) as N'Số sản phẩm đã bán'
		from Product
		where id = @idsp
GO
/****** Object:  View [dbo].[chuongtrinhsale]    Script Date: 11/14/2021 9:20:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[chuongtrinhsale] as
select name, startdate, finishdate, sale  from Sales
where sale <> 0
GO
/****** Object:  View [dbo].[nhanviendacheckin]    Script Date: 11/14/2021 9:20:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[nhanviendacheckin] as
select Staff.id as EmployeeID, lastname as Lastname, firstname as Firstname, Timedate as Date, currstate as Status 
                from Staff inner join Timekeeping on Staff.id=Timekeeping.id 
                where convert(date,Timedate)=convert(date, GETDATE())
GO
/****** Object:  View [dbo].[thongtinquanly]    Script Date: 11/14/2021 9:20:43 AM ******/
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
/****** Object:  StoredProcedure [dbo].[addaccount]    Script Date: 11/14/2021 9:20:43 AM ******/
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
/****** Object:  StoredProcedure [dbo].[HienTrangNhanVien]    Script Date: 11/14/2021 9:20:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HienTrangNhanVien](@ngay Date) as
	select Timekeeping.id as EmployeeID, firstname,lastname, currstate as Status,checkin as Checkin, checkout as Checkout 
	from Timekeeping inner join Staff on Staff.id =Timekeeping.id 
	WHERE convert(date,Timedate) =@ngay
GO
/****** Object:  StoredProcedure [dbo].[nhanvientrongthang]    Script Date: 11/14/2021 9:20:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[nhanvientrongthang] @id int, @thang int as
select Staff.id, lastname, firstname, Timedate, currstate, checkin, checkout
from Staff inner join Timekeeping on Staff.id=Timekeeping.id
where Staff.id=@id and MONTH(timedate)=@thang
GO
