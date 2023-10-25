USE [IMS]
GO

/****** Object:  StoredProcedure [dbo].[st_GetUsersData]    Script Date: 8/31/2023 7:48:36 AM ******/
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
 
 
 CREATE procedure [dbo].[st_GetUserDetails]
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
 
 create procedure [dbo].[st_GetCategoryData]
as
select
Id as 'ID',
Name,
CASE When (IsActive = 1) then 'Yes' else 'No' end as 'Status'
from Category
order by Name asc


create procedure [dbo].[st_GetCategoryList]
as
select
id as 'ID',
Name as 'Category'
from Category
order by Name asc



create procedure st_GetProductsData
as
select
p.Id as 'ID', 
p.Pname AS 'Product',
p.Barcode, 
p.Price, 
format(p.Expdate, 'dd-MM-yyyy') as 'Expiry', 
c.Name as 'Category',
p.CatId as 'Category Id'
From Products p
inner join Category c
on c.Id = p.CatId
Order by p.Pname asc

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
 
CREATE procedure st_GetPurchaseInvoiceDetails
@pid bigint
as
select 
Product_Id as 'Product ID',
p.pname as 'Product',
pid.Qty as 'Quantity',
pid.TotPrice as 'Total Price',
p.price as 'Price'
 from PurchaseInvoice pii
inner join PurchaseInvoiceDetails pid
inner join Products p on p.Id = pid.Product_Id
on pii.Id = pid.Purchase_Id where pii.Id = @pid
 
create procedure st_GetProductQty
@product_Id int
as
select s.qty as 'Quantity' from stock s where s.product_id = @product_Id


