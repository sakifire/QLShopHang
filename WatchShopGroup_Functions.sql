USE [WatchShopGroup]
GO
/*Toàn*/
/****** Object:  UserDefinedFunction [dbo].[loginacc]    Script Date: 11/14/2021 9:20:43 AM ******/
SET ANSI_NULLS ON /*Trả về 0 nếu câu lệnh trả về giá trị null*/
GO
SET QUOTED_IDENTIFIER ON /*Các kí tự trong ngoặc kép được coi là 1 identifier*/
GO
/* Hàm kiểm tra login*/
create function [dbo].[loginacc] (@username char(50), @pass char(50))  returns @table table (id int null, feature int null) /*Tạo function*/
as /*Gán tạm vào*/
begin
	insert @table select id,feature 
			      from Account
				  where  username = @username and pass =@pass
	/*Thêm một bảng với id, feature được lấy từ bảng Account nơi mà username và password bằng với giá trị truyền vào*/
	return
end
GO
/*Toàn*/
/****** Object:  StoredProcedure [dbo].[addaccount]    Script Date: 11/14/2021 9:20:43 AM ******/
SET ANSI_NULLS ON /*Trả về 0 nếu câu lệnh trả về giá trị null*/
GO
SET QUOTED_IDENTIFIER ON /*Các kí tự trong ngoặc kép được coi là 1 identifier*/
GO
/*tạo strored procedure thêm tài khoản*/
create proc [dbo].[addaccount] @username varchar(50), @pass varchar(50), @feature int, @phone char(50), @id int /*Tạo Stored Procedure*/
as
begin
	DECLARE @sql varchar(MAX),@cmd varchar(4000) /*Khai báo biến*/
	if @phone in (select phone from Staff) /*Nếu giá trị phone truyền vào tồn tại trong Staff*/
	begin
		if @id in (select id from Staff) /*Nếu giá trị id truyền vào tồn tại trong Staff*/
		begin
		 insert into Account values(  @username,  @pass, @feature, @id ) /*Thêm vào Account*/
		end
	end	
end
GO





/****** Object:  UserDefinedFunction [dbo].[findkey]    Script Date: 11/14/2021 9:20:43 AM ******/
SET ANSI_NULLS ON /*Trả về 0 nếu câu lệnh trả về giá trị null*/
GO
SET QUOTED_IDENTIFIER ON /*Các kí tự trong ngoặc kép được coi là 1 identifier*/
GO
/* Hàm lấy sản phẩm chưa bị xóa và theo loại = key*/
create function [dbo].[findkey] (@key nvarchar(MAX)) returns table /*Tạo function trả về bảng*/ 
as return (
	select * 
	from Product
	where state = 1 and type=@key
	/*Giá trị là từ bẳng Product nơi mà State = 1 và type = key truyền vào*/
)
GO



/****** Object:  UserDefinedFunction [dbo].[getPhone]    Script Date: 11/14/2021 9:20:43 AM ******/
SET ANSI_NULLS ON /*Trả về 0 nếu câu lệnh trả về giá trị null*/
GO
SET QUOTED_IDENTIFIER ON /*Các kí tự trong ngoặc kép được coi là 1 identifier*/
GO
/* Kiểm tra xem số điện thoại khách hàng đã có hay chưa*/
CREATE function [dbo].[getPhone](@phone int) returns table /*Tạo function trả về bảng*/ 
as
return (
		select *
		from Customer
		where phone = @phone
		/*Giá trị là từ bảng Customer nơi mà phone = giá trị truyền vào*/
)
GO



/****** Object:  UserDefinedFunction [dbo].[LoaiSPDoanhSoCao]    Script Date: 11/14/2021 9:20:43 AM ******/
SET ANSI_NULLS ON /*Trả về 0 nếu câu lệnh trả về giá trị null*/
GO
SET QUOTED_IDENTIFIER ON /*Các kí tự trong ngoặc kép được coi là 1 identifier*/
GO
/* Hàm tìm loại sản phẩm có doanh số bán cao trong tháng*/
create function [dbo].[LoaiSPDoanhSoCao](@thang int) returns table /*Tạo function trả về bảng*/ 
as
return
select type, (sum(Product.amount) - sum(curnumber)) as N'Tổng sản phẩm đã bán', total 
from Bill inner join Product on Product.id=Bill.idpro		
/*Chọn type, total và phép tính được tính bằng Product.amout - curnumber và gán vào Cột tổng sản phẩm đã bán, được lấy từ Bill và Product thông qua phép kết tại Product.id = Bill.idpro*/
where total =(
			select MAX(total) as MaxDoanhSo from 
				(select type,  total
					from Bill inner join Product on Product.id=Bill.idpro
					where MONTH(daytime)=@thang)as A) 
/*Nơi mà total là kết quả của việc chọn total lớn nhất (gán vào MaxDoanhSo) 
từ việc chọn type từ phép kết giữa Bill và Product tại Product.id = Bill.idpro, nơi mà Month bằng giá trị truyền vào và được gán vào A.*/
group by type, total /*Nhóm theo type*/
GO



/****** Object:  UserDefinedFunction [dbo].[phanloaisp]    Script Date: 11/14/2021 9:20:43 AM ******/
SET ANSI_NULLS ON /*Trả về 0 nếu câu lệnh trả về giá trị null*/
GO
SET QUOTED_IDENTIFIER ON /*Các kí tự trong ngoặc kép được coi là 1 identifier*/
GO
/* Hàm lấy thông tin loại sản phẩm và số lượng đã bán*/
Create function [dbo].[phanloaisp]() returns table /*Tạo function trả về bảng*/ 
as 
return select type, (sum(amount) -sum(curnumber)) as N'Tổng sản phẩm đã bán' /*Chọn type và phép tính được tính bằng Product.amout - curnumber và gán vào Cột tổng sản phẩm đã bán*/
			from Product /*Từ product*/
			group by type /*Nhóm theo type*/
GO



/****** Object:  UserDefinedFunction [dbo].[thongtinkh]    Script Date: 11/14/2021 9:20:43 AM ******/
SET ANSI_NULLS ON /*Trả về 0 nếu câu lệnh trả về giá trị null*/
GO
SET QUOTED_IDENTIFIER ON /*Các kí tự trong ngoặc kép được coi là 1 identifier*/
GO
/* Lấy thông tin khách hàng và thông tin đơn hàng bằng số điện thoại*/
Create function [dbo].[thongtinkh](@phone char(10)) returns table /*Tạo function trả về bảng*/ 
as 
return select name, Bill.phone, addr, product, amount, total, daytime /*Chọn Bill.phone, addr, product, amount, total, daytime*/
		from Customer CUS inner join Bill on Bill.phone=CUS.phone /*Từ phép kết Customer CUS và Bill tài Bill.phone = CUS.phone*/
		where CUS.phone =@phone /*Chọn tại nơi mà CUS.phone = giá trị truyền vào*/
GO



/****** Object:  UserDefinedFunction [dbo].[timsanpham]    Script Date: 11/14/2021 9:20:43 AM ******/
SET ANSI_NULLS ON /*Trả về 0 nếu câu lệnh trả về giá trị null*/
GO
SET QUOTED_IDENTIFIER ON /*Các kí tự trong ngoặc kép được coi là 1 identifier*/
GO
/* Hàm lấy thông tin sản phẩm theo id*/
Create function [dbo].[timsanpham](@idsp int) returns table /*Tạo function trả về bảng*/
as 
return select id,name, (amount - curnumber) as N'Số sản phẩm đã bán' /*Chọn id, name, phép tính được gán vào Số sản phẩm đã bán*/
		from Product /*Từ Product*/
		where id = @idsp /*Nơi id = giá trị truyền vào*/
GO



/****** Object:  View [dbo].[chuongtrinhsale]    Script Date: 11/14/2021 9:20:43 AM ******/
SET ANSI_NULLS ON /*Trả về 0 nếu câu lệnh trả về giá trị null*/
GO
SET QUOTED_IDENTIFIER ON /*Các kí tự trong ngoặc kép được coi là 1 identifier*/
GO
/*Tạo view để xem thông tin các chương trình sale*/
create view [dbo].[chuongtrinhsale] as /*Tạo view*/
select name, startdate, finishdate, sale  from Sales /*Chọn name, startdate, finishdate, sale từ Sales*/
where sale <> 0 /*sale khác 0*/
GO



/****** Object:  View [dbo].[nhanviendacheckin]    Script Date: 11/14/2021 9:20:43 AM ******/
SET ANSI_NULLS ON /*Trả về 0 nếu câu lệnh trả về giá trị null*/
GO
SET QUOTED_IDENTIFIER ON /*Các kí tự trong ngoặc kép được coi là 1 identifier*/
GO
/* Hàm Tạo view xem thông tin checkin của nhân viên theo ngày*/
create view [dbo].[nhanviendacheckin] as /*Tạo view*/
select Staff.id as EmployeeID, lastname as Lastname, firstname as Firstname, Timedate as Date, currstate as Status 
/*Gán Staff.id vào EmployeeID, lastname vào Lastname....*/
                from Staff inner join Timekeeping on Staff.id=Timekeeping.id /*Từ phép kết Staff và Timekeeping, tại Staff.id = Timekeeping.id*/
                where convert(date,Timedate)=convert(date, GETDATE()) /*Nơi mà giá trị date = giá trị từ GETDATE()*/
GO



/****** Object:  View [dbo].[thongtinquanly]    Script Date: 11/14/2021 9:20:43 AM ******/
SET ANSI_NULLS ON /*Trả về 0 nếu câu lệnh trả về giá trị null*/
GO
SET QUOTED_IDENTIFIER ON /*Các kí tự trong ngoặc kép được coi là 1 identifier*/
GO
/*Tạo view xem thông tin của các quản lý*/
create view [dbo].[thongtinquanly] /*Tạo view*/
as
select id, firstname, lastname, phone, gender, addr /*Chọn id, firstname, lastname, phone, gender, addr*/
from Staff /*Từ Staff*/
where idpos=1 /*Nơi idpos = 1 (quản lý)*/
GO




/****** Object:  StoredProcedure [dbo].[HienTrangNhanVien]    Script Date: 11/14/2021 9:20:43 AM ******/
SET ANSI_NULLS ON /*Trả về 0 nếu câu lệnh trả về giá trị null*/
GO
SET QUOTED_IDENTIFIER ON /*Các kí tự trong ngoặc kép được coi là 1 identifier*/
GO
/*tạo stored procedure xem trang thái nhân viên theo ngày*/
create proc [dbo].[HienTrangNhanVien](@ngay Date) /*Tạo Stored Procedure*/
as 
	select Timekeeping.id as EmployeeID, firstname,lastname, currstate as Status,checkin as Checkin, checkout as Checkout /* Chọn và gán thuộc tính*/
	from Timekeeping inner join Staff on Staff.id =Timekeeping.id /*Từ phép kết giữa Timekeeping và Staff, tại Staff.id = Timekeeping.id*/
	WHERE convert(date,Timedate) =@ngay /*Tại nơi mà Timedate=ngay*/
GO

/*tạo stored procedure xem trang thái nhân viên theo tháng*/
/****** Object:  StoredProcedure [dbo].[nhanvientrongthang]    Script Date: 11/14/2021 9:20:43 AM ******/
SET ANSI_NULLS ON /*Trả về 0 nếu câu lệnh trả về giá trị null*/
GO
SET QUOTED_IDENTIFIER ON /*Các kí tự trong ngoặc kép được coi là 1 identifier*/
GO
create proc [dbo].[nhanvientrongthang] (@id int, @thang int)
as
select Staff.id, lastname, firstname, Timedate, currstate, checkin, checkout  /* Chọn và gán thuộc tính*/
from Staff inner join Timekeeping on Staff.id=Timekeeping.id /*Từ phép kết giữa Timekeeping và Staff, tại Staff.id = Timekeeping.id*/
where Staff.id=@id and MONTH(timedate)=@thang /*Tại nơi mà timedate = thang, Staf.id = id*/
GO

/*Bổ sung về trigger */
/* Kiểm tra số lượng hàng có bằng 0 khi thêm đơn hàng */ 
create trigger addbill on Bill 
after insert as
begin
	declare @sl int, @id int, @sl1 int
	select @sl = ne.amount, @id = ne.idpro
	from inserted ne
	update Product
	set curnumber = curnumber - @sl
	where id = @id
	select @sl1 = curnumber
	from Product
	where id = @id
	if @sl1 = 0
		update Product set state = 0 where id = @id
	else 
		update Product set state = 1 where id = @id
end

/* Xóa đơn hàng và cập nhật số lượng sản phẩm */
create trigger deletebill on Bill 
after delete as
begin
	declare @sl int, @id int, @sl1 int
	select @sl= de.amount, @id = de.idpro
	from deleted de
	update Product
	set curnumber = curnumber + @sl 
	where id = @id
	select @sl1 = curnumber
	from Product
	where id = @id
	if @sl1 = 0
		update Product set state = 0 where id = @id
	else 
		update Product set state = 1 where id = @id
end
/* Kiểm tra số điện thoại khách hàng */
create trigger checkphone on Bill 
after insert as
begin
	declare @phone char(20)
	select @phone= ne.phone
	from inserted ne
	if @phone not in (select phone from Customer)
	begin
		insert into Customer values (@phone,1,1)
	end
end