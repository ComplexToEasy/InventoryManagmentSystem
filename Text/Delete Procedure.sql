USE [IMS]
GO

/****** Object:  StoredProcedure [dbo].[st_DeleteUsers]    Script Date: 8/31/2023 7:48:19 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[st_DeleteUsers]
@id int
as
delete from users where id = @id
GO



CREATE procedure [dbo].[st_DeleteCategory]
@id int
as
Delete From Category where Id = @id


create procedure st_DeleteProducts
@id int
as
Delete From Products where Id = @id


truncate table PurchaseInvoice
truncate table PurchaseInvoicedetails

delete from PurchaseInvoice
DBCC CHECKIDENT('PURCHASEINVOICE',RESEED,0)
