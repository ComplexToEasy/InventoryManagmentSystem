USE [master]
GO
/****** Object:  Database [IMS]    Script Date: 10/17/2023 8:02:12 AM ******/
CREATE DATABASE [IMS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'IMS', FILENAME = N'E:\Projects\InventoryManagmentSystem\Database\IMS.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'IMS_log', FILENAME = N'E:\Projects\InventoryManagmentSystem\Database\IMS_log.ldf' , SIZE = 1536KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [IMS] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [IMS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [IMS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [IMS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [IMS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [IMS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [IMS] SET ARITHABORT OFF 
GO
ALTER DATABASE [IMS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [IMS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [IMS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [IMS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [IMS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [IMS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [IMS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [IMS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [IMS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [IMS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [IMS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [IMS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [IMS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [IMS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [IMS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [IMS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [IMS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [IMS] SET RECOVERY FULL 
GO
ALTER DATABASE [IMS] SET  MULTI_USER 
GO
ALTER DATABASE [IMS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [IMS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [IMS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [IMS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [IMS] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'IMS', N'ON'
GO
USE [IMS]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 10/17/2023 8:02:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[IsActive] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductPrice]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductPrice](
	[Product_id] [int] NOT NULL,
	[PPrice] [money] NULL,
	[SPrice] [money] NULL,
	[Discount] [float] NULL,
	[Profit] [float] NULL,
UNIQUE NONCLUSTERED 
(
	[Product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[pname] [varchar](50) NOT NULL,
	[Barcode] [varchar](100) NOT NULL,
	[expdate] [date] NULL,
	[CatId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PurchaseInvoice]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseInvoice](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[vdate] [date] NOT NULL,
	[Doneby] [int] NOT NULL,
	[SuplierId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PurchaseInvoiceDetails]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseInvoiceDetails](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Purchase_Id] [bigint] NOT NULL,
	[Product_Id] [int] NOT NULL,
	[Qty] [int] NOT NULL,
	[TotPrice] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SaleInvoice]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaleInvoice](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[vdate] [date] NOT NULL,
	[Doneby] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SaleInvoiceDetails]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaleInvoiceDetails](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Sale_Id] [bigint] NOT NULL,
	[Product_Id] [int] NOT NULL,
	[Qty] [int] NOT NULL,
	[TotPrice] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[stock]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stock](
	[product_id] [int] NOT NULL,
	[qty] [int] NOT NULL,
UNIQUE NONCLUSTERED 
(
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Supplier](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Company] [varchar](100) NOT NULL,
	[ContactNo] [varchar](20) NULL,
	[Phone] [varchar](20) NULL,
	[Addr] [varchar](100) NULL,
	[NTN] [varchar](25) NULL,
	[Status] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Company] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[USERS]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[USERS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](40) NOT NULL,
	[username] [varchar](30) NOT NULL,
	[pwd] [nvarchar](30) NOT NULL,
	[phone] [varchar](30) NOT NULL,
	[email] [varchar](30) NOT NULL,
	[status] [tinyint] NULL DEFAULT ((1)),
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [Email_Unique] UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [Username_Unique] UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[ProductPrice]  WITH CHECK ADD FOREIGN KEY([Product_id])
REFERENCES [dbo].[Products] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD FOREIGN KEY([CatId])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[PurchaseInvoiceDetails]  WITH CHECK ADD FOREIGN KEY([Purchase_Id])
REFERENCES [dbo].[PurchaseInvoice] ([Id])
GO
ALTER TABLE [dbo].[SaleInvoiceDetails]  WITH CHECK ADD FOREIGN KEY([Sale_Id])
REFERENCES [dbo].[SaleInvoice] ([Id])
GO
/****** Object:  StoredProcedure [dbo].[st_CheckProductPriceExist]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_CheckProductPriceExist]
@product_id int
as
select * from ProductPrice where Product_id = @product_id
GO
/****** Object:  StoredProcedure [dbo].[st_DeleteCategory]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[st_DeleteCategory]
@id int
as
Delete From Category where Id = @id

GO
/****** Object:  StoredProcedure [dbo].[st_DeleteProducts]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[st_DeleteProducts]
@id int
as
Delete From Products where Id = @id



GO
/****** Object:  StoredProcedure [dbo].[st_DeletePurchaseInvoiceDetails]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[st_DeletePurchaseInvoiceDetails]
@id bigint
as
delete from PurchaseInvoiceDetails
where Id = @id
GO
/****** Object:  StoredProcedure [dbo].[st_DeleteSupplier]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[st_DeleteSupplier]
@id int
as
delete from Supplier where id = @id;

GO
/****** Object:  StoredProcedure [dbo].[st_DeleteUsers]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_DeleteUsers]
@id int
as
delete from users where id = @id

GO
/****** Object:  StoredProcedure [dbo].[st_GetAllStock]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_GetAllStock]
as
select
s.product_id as 'Product ID',
s.qty as 'Available Stock',
p.pname as 'Product',
c.Name as 'Category',
p.Barcode,
FORMAT(p.expdate,'dd-MM-yyyy') as 'Expiry',
p.price as 'Price',
case when (s.qty < 50) then 'LOW' else case when (s.qty <100 and s.qty >= 50) then 'Average' 
else case when (s.qty >= 100)  then 'Good' end end end as 'Status',
ROUND(p.price * s.qty,0) as 'Amount'
from stock s inner join
Products p 
on s.product_id = p.Id
inner join
Category c
on c.Id = CatId
GO
/****** Object:  StoredProcedure [dbo].[st_GetCategoryData]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create procedure [dbo].[st_GetCategoryData]
as
select
Id as 'ID',
Name,
CASE When (IsActive = 1) then 'Yes' else 'No' end as 'Status'
from Category
order by Name asc

GO
/****** Object:  StoredProcedure [dbo].[st_GetCategoryList]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_GetCategoryList]
as
select
id as 'ID',
Name as 'Category'
from Category
order by Name asc

GO
/****** Object:  StoredProcedure [dbo].[st_GetLastPurchaseId]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_GetLastPurchaseId]
as
select top 1 Id from PurchaseInvoice order by Id desc

GO
/****** Object:  StoredProcedure [dbo].[st_GetProductByBarcode]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_GetProductByBarcode]
@barcode nvarchar(100)
as
select
p.id as 'ID',
p.pname as 'Product',
p.barcode as 'Barcode',
pp.SPrice as 'Selling Price',
pp.SPrice*pp.Discount/100 as 'Discount',
pp.SPrice - (pp.SPrice*pp.Discount/100) as 'Final Price'
from Products p
inner join
ProductPrice pp
on p.Id = pp.Product_id
where Barcode = @barcode
order by pname asc

GO
/****** Object:  StoredProcedure [dbo].[st_GetProductByCategory]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_GetProductByCategory]
@id int
as
select
p.Id as 'Product ID',
p.pname as 'Product',
pp.PPrice as 'Purchase Price',
case when (pp.SPrice is null) then 0 else pp.SPrice end as 'Sale Price',
case when (pp.discount is null) then 0 else pp.discount end as 'Discount',
case when (pp.profit is null) then 0 else pp.profit end as 'Profit'
 from
ProductPrice pp
inner join Products p
on pp.product_id = p.Id
inner join Category c
on p.CatId = c.Id
where c.Id = @id
GO
/****** Object:  StoredProcedure [dbo].[st_GetProductQty]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_GetProductQty]
@product_Id int
as
select s.qty as 'Quantity' from stock s where s.product_id = @product_Id
GO
/****** Object:  StoredProcedure [dbo].[st_GetProductsData]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_GetProductsData]
as
select
p.Id as 'ID', 
p.Pname AS 'Product',
p.Barcode, 
format(p.Expdate, 'dd-MM-yyyy') as 'Expiry', 
c.Name as 'Category',
p.CatId as 'Category Id'
From Products p
inner join Category c
on c.Id = p.CatId
Order by p.Pname asc


GO
/****** Object:  StoredProcedure [dbo].[st_GetPurchaseInvoiceDetails]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_GetPurchaseInvoiceDetails]
@pid bigint
as
select 
pid.Id as 'ID',
pid.Product_Id as 'Product ID',
p.pname as 'Product',
pid.Qty as 'Quantity',
pid.TotPrice as 'Total Price',
pp.pprice as 'Price'
 from PurchaseInvoice pii
inner join PurchaseInvoiceDetails pid
inner join ProductPrice pp
on pid.Product_Id = pp.Product_Id 
inner join Products p on p.Id = pid.Product_Id
on pii.Id = pid.Purchase_Id 

GO
/****** Object:  StoredProcedure [dbo].[st_GetPurchaseInvoiceList]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_GetPurchaseInvoiceList]
@month int,
@year int
as
select pii.Id as 'ID',
company + ' ' + format(pii.vdate, 'dd-MM-yyyy')  as 'Company'
 from PurchaseInvoice pii
 inner join Supplier s 
 on s.Id = pii.SuplierId
 where MONTH(pii.vdate) = @month and YEAR(pii.vdate) = @year
GO
/****** Object:  StoredProcedure [dbo].[st_GetSuplierList]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_GetSuplierList]
as
select
id as 'ID',
Company
from Supplier
order by Company asc

GO
/****** Object:  StoredProcedure [dbo].[st_GetSupplierData]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_GetSupplierData]
as
select
id as 'ID',
Company as 'Name',
contactno as 'Contact No',
phone as 'Phone',
addr as 'Address',
NTN AS 'NTN',
CASE when (status = 1) then 'Active' else 'In-active' end as 'Status'
 from Supplier
 order by Company asc

GO
/****** Object:  StoredProcedure [dbo].[st_GetSupplierDataLike]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create procedure [dbo].[st_GetSupplierDataLike]
@data varchar(50)
as
select
id as 'ID',
Company as 'Name',
contactno as 'Contact No',
phone as 'Phone',
addr as 'Address',
CASE when (status = 1) then 'Active' else 'In-active' end as 'Status'
 from Supplier
 where upper(Company) like '%' + upper(@data) + '%' or
upper(ContactNo) like '%' + upper(@data) + '%' or
upper(Addr) like '%' + upper(@data) + '%'
 order by Company
 
GO
/****** Object:  StoredProcedure [dbo].[st_GetUserDetails]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_GetUserDetails]
@username varchar(30),
@pswd varchar(30)
as
SELECT 

Id as 'ID',
name as 'Name',
username as 'Username',
pwd as 'Password'
from USERS
where username = @username
and pwd = @pswd
GO
/****** Object:  StoredProcedure [dbo].[st_GetUsersData]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_GetUsersData]
as
select
u.id as 'ID',
u.name as 'Name',
u.username as 'Username',
u.pwd as 'Password',
u.phone as 'Phone',
u.email as 'Email',
CASE when (status = 1) then 'Active' else 'In-active' end as 'Status'
 from users u
 order by u.name asc

GO
/****** Object:  StoredProcedure [dbo].[st_GetUsersDataLike]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_GetUsersDataLike]
@data varchar(50)
as
select
u.id as 'ID',
u.name as 'Name',
u.username as 'Username',
u.pwd as 'Password',
u.phone as 'Phone',
u.email as 'Email',
CASE when (status = 1) then 'Active' else 'In-active' end as 'Status'
 from users u
 where upper(u.name) like '%' + upper(@data) + '%' or
upper(u.name) like '%' + upper(@data) + '%' or
upper(u.email) like '%' + upper(@data) + '%' or
upper(u.phone) like '%' + upper(@data) + '%'
 order by u.name
 
GO
/****** Object:  StoredProcedure [dbo].[st_InsertCategory]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[st_InsertCategory]
@name varchar(50),
@isactive tinyint
as
insert into Category values(@name, @isactive)


GO
/****** Object:  StoredProcedure [dbo].[st_InsertProductPrice]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_InsertProductPrice]
@product_id int,
@pprice int,
@sprice int
as
insert ProductPrice(Product_id,PPrice,SPrice) values(@Product_id, @pprice,@sprice)

GO
/****** Object:  StoredProcedure [dbo].[st_InsertProducts]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[st_InsertProducts]
@name varchar(50),
@barcode varchar(100),
@expdate date,
@catId int
as
Insert into Products Values(@name,@barcode, @expdate, @catId)


GO
/****** Object:  StoredProcedure [dbo].[st_InsertPurchaseInvoice]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_InsertPurchaseInvoice]
@vdate date,
@doneby int,
@supplierId int
as
insert into PurchaseInvoice values(@vdate, @doneby,@supplierId)

GO
/****** Object:  StoredProcedure [dbo].[st_InsertPurchaseInvoiceDetails]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_InsertPurchaseInvoiceDetails]
@purchase_id bigint,
@product_Id int,
@qty int,
@totprice money
as
insert into PurchaseInvoiceDetails values(@purchase_id, @product_Id,@qty,@totprice)

GO
/****** Object:  StoredProcedure [dbo].[st_InsertStock]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_InsertStock]
@product_id int,
@qty int
as
insert into stock values(@product_id, @qty)

GO
/****** Object:  StoredProcedure [dbo].[st_insertSupplier]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_insertSupplier]
 @name varchar(40),
@contactno  varchar(30),
@phone varchar(30),
@addr varchar(100),
@ntn varchar(20),
@status tinyint
as
insert into Supplier(Company,ContactNo,Phone,Addr,ntn, status) values(@name, @contactno,@phone,@addr,@ntn, @status)

GO
/****** Object:  StoredProcedure [dbo].[st_insertUsers]    Script Date: 10/17/2023 8:02:13 AM ******/
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
/****** Object:  StoredProcedure [dbo].[st_UpdateCategory]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[st_UpdateCategory]
@name varchar(50),
@isactive tinyint,
@id int
as
Update Category set Name = @name, IsActive = @isactive where Id = @id

GO
/****** Object:  StoredProcedure [dbo].[st_UpdateProductPrice]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_UpdateProductPrice]
@product_id int,
@pprice int,
@sprice int,
@dis int,
@profit int
as
update ProductPrice set 
PPrice = @pprice, SPrice = @sprice,discount = @dis, profit = @profit 
where Product_id = @product_id

GO
/****** Object:  StoredProcedure [dbo].[st_UpdateProducts]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_UpdateProducts]
@name varchar(50),
@barcode varchar(100),
@expdate date,
@catId int,
@id int
as
Update Products Set  Pname = @name,Barcode = @barcode,Expdate = @expdate,CatId = @catId where Id = @id

GO
/****** Object:  StoredProcedure [dbo].[st_UpdateStock]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[st_UpdateStock]
@product_id int,
@qty int
as
Update stock set qty = @qty where product_id = @product_id

GO
/****** Object:  StoredProcedure [dbo].[st_UpdateSupplier]    Script Date: 10/17/2023 8:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_UpdateSupplier]
@name varchar(40),
@contactno  varchar(30),
@phone varchar(30),
@addr varchar(100),
@ntn varchar(20),
@status tinyint,
@id int
as
Update Supplier set Company =@name,ContactNo =@contactno,Phone =@phone,Addr=@addr,ntn=@ntn, status=@status
where id = @id;

GO
/****** Object:  StoredProcedure [dbo].[st_UpdateUsers]    Script Date: 10/17/2023 8:02:13 AM ******/
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
USE [master]
GO
ALTER DATABASE [IMS] SET  READ_WRITE 
GO
