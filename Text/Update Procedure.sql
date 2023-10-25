USE [IMS]
GO

/****** Object:  StoredProcedure [dbo].[st_UpdateUsers]    Script Date: 8/31/2023 7:48:44 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[st_UpdateUsers]
@name varchar(40),
@username  varchar(30),
@pwd nvarchar(30),
@phone varchar(30),
@email varchar(30),
@id int,
@status tinyint
as
update users set 
name =@name,
username = @username,
pwd =@pwd,
phone =@phone,
email =@email,
status = @status
where id = @id;
GO


CREATE procedure [dbo].[st_UpdateCategory]
@name varchar(50),
@isactive tinyint,
@id int
as
Update Category set Name = @name, IsActive = @isactive where Id = @id


create procedure st_UpdateProducts
@name varchar(50),
@barcode varchar(100),
@price money,
@expdate date,
@catId int,
@id int
as
Update Products Set  Pname = @name,Barcode = @barcode,Price = @price,Expdate = @expdate,CatId = @catId where Id = @id


create procedure st_UpdateStock
@product_id int,
@qty int
as
Update stock set qty = @qty where product_id = @product_id

