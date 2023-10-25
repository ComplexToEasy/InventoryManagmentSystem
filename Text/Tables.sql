
CREATE TABLE [dbo].[USERS](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[name] [varchar](40) NOT NULL,
	[username] [varchar](30) NOT NULL,
	[pwd] [nvarchar](30) NOT NULL,
	[phone] [varchar](30) NOT NULL,
	[email] [varchar](30) NOT NULL,
	[status] [tinyint] NULL DEFAULT ((1)))


CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[IsActive] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE Products
(
Id int not null identity primary key,
pname varchar(50) not null,
Barcode varchar(100) not null,
price money not null,
expdate date,
CatId int not null foreign key references Category(Id)
)


CREATE TABLE PurchaseInvoice(
Id bigint not null identity primary key,
vdate date not null,
Doneby int not null,
SuplierId int not null
)

CREATE TABLE PurchaseInvoiceDetails(
Id bigint not null identity primary key,
Purchase_Id bigint not null foreign key references PurchaseInvoice(Id),
Product_Id int not null,
Qty int not null,
TotPrice money not null)


create table stock(
product_id int not null unique,
qty int not null
)




