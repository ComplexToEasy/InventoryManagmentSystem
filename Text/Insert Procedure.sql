USE [IMS]
GO

/****** Object:  StoredProcedure [dbo].[st_insertUsers]    Script Date: 8/31/2023 7:48:40 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[st_insertUsers]
@name varchar(40),
@username  varchar(30),
@pwd nvarchar(30),
@phone varchar(30),
@email varchar(30),
@status tinyint
as
insert into users(name,username,pwd,phone,email, status) values(@name, @username,@pwd,@phone,@email, @status)
GO


CREATE procedure [dbo].[st_InsertCategory]
@name varchar(50),
@isactive tinyint
as
insert into Category values(@name, @isactive)




create procedure st_InsertProducts
@name varchar(50),
@barcode varchar(100),
@price money,
@expdate date,
@catId int
as
Insert into Products Values(@name,@barcode, @price, @expdate, @catId)


drop table supplier;
create table Supplier(
Id int not null identity primary key,
Company varchar(100) not null unique,
ContactNo varchar(20),
Phone varchar(20),
Addr varchar(100),
NTN varchar(25),
Status tinyint not null);

create procedure st_DeleteSupplier
@id int
as
delete from Supplier where id = @id;

create procedure st_GetSupplierData
as
select
id as 'ID',
Company as 'Name',
ContactNo as 'Contact No',
Phone as 'Phone',
Addr as 'Address',
NTN,
CASE when (status = 1) then 'Active' else 'In-active' end as 'Status'
 from Supplier
 order by Company asc

 create procedure st_insertSupplier
 @name varchar(40),
@contactno  varchar(30),
@phone varchar(30),
@addr varchar(100),
@ntn varchar(20),
@status tinyint
as
insert into Supplier(Company,ContactNo,Phone,Addr,ntn, status) values(@name, @contactno,@phone,@addr,@ntn, @status)


create procedure st_InsertPurchaseInvoice
@vdate date,
@doneby int,
@supplierId int
as
insert into PurchaseInvoice values(@vdate, @doneby,@supplierId)
go

create procedure st_GetLastPurchaseId
as
select top 1 Id from PurchaseInvoice order by Id desc
go

create procedure st_InsertPurchaseInvoiceDetails
@purchase_id bigint,
@product_Id int,
@qty int,
@totprice money
as
insert into PurchaseInvoiceDetails values(@purchase_id, @product_Id,@qty,@totprice)
go

create procedure st_InsertStock
@product_id int,
@qty int
as
insert into stock values(@product_id, @qty)
