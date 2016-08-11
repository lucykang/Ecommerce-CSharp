-- clean up old dbs

if object_id('dbo.OrderDetails') is not null
	drop table dbo.OrderDetails;

if object_id('dbo.Orders') is not null
	drop table dbo.Orders;

if object_id('dbo.Carts') is not null
	drop table dbo.Carts;

if object_id('dbo.Products') is not null
	drop table dbo.Products;


-- recreate the databases
create table [dbo].[Products] (
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	[ProductName] nvarchar(50) not null,
	[BrandName] nvarchar(50),
	[Type] nvarchar(10) not null,
	[Description] nvarchar(MAX) not null,
	[Price] decimal(7, 2) not null,
	[ImageURL] nvarchar(50) 
);

create table [dbo].[Carts] (
	[RecordId] int not null primary key identity(1, 1),
	[CartId] nvarchar(10) not null,
	[Count] int not null default 0,
	[DateCreated] datetime not null default CURRENT_TIMESTAMP,
	[ProductId] int not null,

	constraint fk_carts_product foreign key (ProductId) references Products(Id)
);

create table [dbo].[Orders] (
	[OrderId] int not null primary key identity(1, 1),
	[Username] nvarchar(50) not null,
	[Firstname] nvarchar(50) not null,
	[Lastname] nvarchar(50) not null,
	[Address] nvarchar(150) not null,
	[City] nvarchar(50) not null,
	[Province] nvarchar(25) not null,
	[PostalCode] nvarchar(10) not null,
	[Country] nvarchar(25) not null,
	[Phone] nvarchar(25) not null,
	[Email] nvarchar(50) not null,
	[Total] decimal(7, 2) not null,
	[OrderDate] datetime not null default CURRENT_TIMESTAMP
);

create table [dbo].[OrderDetails] (
	[OrderDetailId] int not null primary key identity(1, 1),
	[Quantity] int not null,
	[UnitPrice] decimal(7, 2) not null,
	[ProductId] int not null,
	[OrderId] int not null,

	constraint fk_orderdetails_product foreign key (ProductId) references Products(Id),
	constraint fk_orderdetails_order foreign key (OrderId) references [Orders](OrderId)
);

-- sampel data here