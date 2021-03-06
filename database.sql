USE [teknik_servis]
GO
/****** Object:  Table [dbo].[brands]    Script Date: 11.6.2020 09:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[brands](
	[brand_id] [int] IDENTITY(1,1) NOT NULL,
	[brand_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_brands] PRIMARY KEY CLUSTERED 
(
	[brand_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[customers]    Script Date: 11.6.2020 09:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[customers](
	[customer_ID] [int] IDENTITY(1,1) NOT NULL,
	[identificationNumber] [char](11) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[surname] [varchar](50) NOT NULL,
	[phoneNumber] [char](10) NOT NULL,
 CONSTRAINT [PK_customers] PRIMARY KEY CLUSTERED 
(
	[identificationNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[faultInfos]    Script Date: 11.6.2020 09:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[faultInfos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[customer_ID] [int] NOT NULL,
	[faultProduct_ID] [int] NOT NULL,
	[model] [varchar](max) NOT NULL,
	[component] [varchar](max) NULL,
	[detail] [varchar](max) NULL,
	[price] [decimal](18, 0) NULL,
	[statusID] [tinyint] NOT NULL,
	[startDate] [datetime2](7) NOT NULL,
	[finishDate] [date] NULL,
	[solutionDetail] [varchar](max) NULL,
 CONSTRAINT [PK_faultProducts] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[faultProduct]    Script Date: 11.6.2020 09:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[faultProduct](
	[faultProduct_ID] [int] IDENTITY(1,1) NOT NULL,
	[faultProduct_reason] [varchar](50) NOT NULL,
 CONSTRAINT [PK_faultProduct] PRIMARY KEY CLUSTERED 
(
	[faultProduct_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[faultStatus]    Script Date: 11.6.2020 09:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[faultStatus](
	[fault_statusID] [tinyint] NOT NULL,
	[fault_status] [char](50) NOT NULL,
 CONSTRAINT [PK_faultStatus] PRIMARY KEY CLUSTERED 
(
	[fault_statusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[mainCategory]    Script Date: 11.6.2020 09:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[mainCategory](
	[mainCategory_ID] [int] IDENTITY(1,1) NOT NULL,
	[mainCategory_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_category] PRIMARY KEY CLUSTERED 
(
	[mainCategory_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[products]    Script Date: 11.6.2020 09:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[products](
	[product_ID] [int] IDENTITY(1,1) NOT NULL,
	[product_name] [varchar](50) NOT NULL,
	[product_stock] [int] NOT NULL,
	[product_subCategoryID] [int] NOT NULL,
	[product_brandID] [int] NOT NULL,
	[product_purchaseprice] [decimal](18, 0) NOT NULL,
	[product_saleprice] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_products] PRIMARY KEY CLUSTERED 
(
	[product_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[productSoldReason]    Script Date: 11.6.2020 09:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[productSoldReason](
	[reason_ID] [int] IDENTITY(1,1) NOT NULL,
	[reason_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_productUseReason] PRIMARY KEY CLUSTERED 
(
	[reason_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[soldProducts]    Script Date: 11.6.2020 09:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[soldProducts](
	[productSold_ID] [int] IDENTITY(1,1) NOT NULL,
	[productSold_customerID] [int] NOT NULL,
	[productSold_productID] [int] NOT NULL,
	[productSold_unit] [int] NOT NULL,
	[productSold_reasonID] [int] NOT NULL,
	[productSold_totalPrice] [int] NOT NULL,
	[productSold_soldDate] [date] NULL,
 CONSTRAINT [PK_soldProducts] PRIMARY KEY CLUSTERED 
(
	[productSold_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[subCategory]    Script Date: 11.6.2020 09:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[subCategory](
	[subCategory_ID] [int] IDENTITY(1,1) NOT NULL,
	[subCategory_name] [varchar](50) NOT NULL,
	[subCategory_mainCatgID] [int] NOT NULL,
 CONSTRAINT [PK_subCategory] PRIMARY KEY CLUSTERED 
(
	[subCategory_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[brands] ON 

INSERT [dbo].[brands] ([brand_id], [brand_name]) VALUES (1, N'Abit')
INSERT [dbo].[brands] ([brand_id], [brand_name]) VALUES (2, N'Acer')
INSERT [dbo].[brands] ([brand_id], [brand_name]) VALUES (3, N'Asus')
INSERT [dbo].[brands] ([brand_id], [brand_name]) VALUES (4, N'Casper')
INSERT [dbo].[brands] ([brand_id], [brand_name]) VALUES (5, N'Dell')
INSERT [dbo].[brands] ([brand_id], [brand_name]) VALUES (6, N'Gigabyte')
INSERT [dbo].[brands] ([brand_id], [brand_name]) VALUES (7, N'HP')
INSERT [dbo].[brands] ([brand_id], [brand_name]) VALUES (8, N'Intel')
INSERT [dbo].[brands] ([brand_id], [brand_name]) VALUES (9, N'Lenovo')
INSERT [dbo].[brands] ([brand_id], [brand_name]) VALUES (10, N'LG')
INSERT [dbo].[brands] ([brand_id], [brand_name]) VALUES (11, N'Nvidia')
INSERT [dbo].[brands] ([brand_id], [brand_name]) VALUES (12, N'Samsung')
INSERT [dbo].[brands] ([brand_id], [brand_name]) VALUES (13, N'Sapphire')
INSERT [dbo].[brands] ([brand_id], [brand_name]) VALUES (14, N'Vestek')
INSERT [dbo].[brands] ([brand_id], [brand_name]) VALUES (15, N'Via')
INSERT [dbo].[brands] ([brand_id], [brand_name]) VALUES (16, N'Vida')
INSERT [dbo].[brands] ([brand_id], [brand_name]) VALUES (17, N'Sanddisk')
INSERT [dbo].[brands] ([brand_id], [brand_name]) VALUES (18, N'GMC')
INSERT [dbo].[brands] ([brand_id], [brand_name]) VALUES (19, N'MSI')
SET IDENTITY_INSERT [dbo].[brands] OFF
SET IDENTITY_INSERT [dbo].[customers] ON 

INSERT [dbo].[customers] ([customer_ID], [identificationNumber], [name], [surname], [phoneNumber]) VALUES (7, N'12536958745', N'İlyas', N'Yalçıntaş', N'5318160425')
INSERT [dbo].[customers] ([customer_ID], [identificationNumber], [name], [surname], [phoneNumber]) VALUES (23, N'12536958746', N'deneme', N'deneme', N'5318162059')
INSERT [dbo].[customers] ([customer_ID], [identificationNumber], [name], [surname], [phoneNumber]) VALUES (2, N'12563264552', N'Seda', N'Başaran', N'5362650102')
INSERT [dbo].[customers] ([customer_ID], [identificationNumber], [name], [surname], [phoneNumber]) VALUES (3, N'15263265493', N'Ezel', N'Bayrakta', N'5356958645')
INSERT [dbo].[customers] ([customer_ID], [identificationNumber], [name], [surname], [phoneNumber]) VALUES (12, N'15426325648', N'Meral', N'Yeşil', N'5368152456')
INSERT [dbo].[customers] ([customer_ID], [identificationNumber], [name], [surname], [phoneNumber]) VALUES (8, N'25632546789', N'Sezen', N'Aksu', N'5312465958')
INSERT [dbo].[customers] ([customer_ID], [identificationNumber], [name], [surname], [phoneNumber]) VALUES (24, N'25645236254', N'Recep', N'Yeşil', N'5318162022')
INSERT [dbo].[customers] ([customer_ID], [identificationNumber], [name], [surname], [phoneNumber]) VALUES (4, N'39802277261', N'ibrahim', N'yeşil', N'5458456234')
INSERT [dbo].[customers] ([customer_ID], [identificationNumber], [name], [surname], [phoneNumber]) VALUES (5, N'45869563651', N'Merve', N'Boluğur', N'5053214578')
INSERT [dbo].[customers] ([customer_ID], [identificationNumber], [name], [surname], [phoneNumber]) VALUES (6, N'56236546957', N'Kuzey', N'Tekinoğlu', N'5336523478')
INSERT [dbo].[customers] ([customer_ID], [identificationNumber], [name], [surname], [phoneNumber]) VALUES (25, N'75456235666', N'Furkan', N'Emirce', N'5323345689')
SET IDENTITY_INSERT [dbo].[customers] OFF
SET IDENTITY_INSERT [dbo].[faultInfos] ON 

INSERT [dbo].[faultInfos] ([id], [customer_ID], [faultProduct_ID], [model], [component], [detail], [price], [statusID], [startDate], [finishDate], [solutionDetail]) VALUES (3, 12, 2, N'de', N'de', N'de', CAST(1125 AS Decimal(18, 0)), 2, CAST(0x0700000000000E410B AS DateTime2), CAST(0xC6410B00 AS Date), N'eeee')
INSERT [dbo].[faultInfos] ([id], [customer_ID], [faultProduct_ID], [model], [component], [detail], [price], [statusID], [startDate], [finishDate], [solutionDetail]) VALUES (4, 23, 2, N'deneme', N'denem', N'dene', CAST(222 AS Decimal(18, 0)), 1, CAST(0x0700000000004B410B AS DateTime2), NULL, NULL)
INSERT [dbo].[faultInfos] ([id], [customer_ID], [faultProduct_ID], [model], [component], [detail], [price], [statusID], [startDate], [finishDate], [solutionDetail]) VALUES (5, 1, 3, N'', N'', N'', CAST(0 AS Decimal(18, 0)), 1, CAST(0x0700000000004B410B AS DateTime2), NULL, NULL)
INSERT [dbo].[faultInfos] ([id], [customer_ID], [faultProduct_ID], [model], [component], [detail], [price], [statusID], [startDate], [finishDate], [solutionDetail]) VALUES (6, 23, 1, N'asd', N'sd', N'', CAST(300 AS Decimal(18, 0)), 2, CAST(0x0700000000004D410B AS DateTime2), CAST(0x32410B00 AS Date), N'ddd')
INSERT [dbo].[faultInfos] ([id], [customer_ID], [faultProduct_ID], [model], [component], [detail], [price], [statusID], [startDate], [finishDate], [solutionDetail]) VALUES (7, 23, 1, N'd', N'd', N'd', CAST(500 AS Decimal(18, 0)), 1, CAST(0x0700000000004B410B AS DateTime2), NULL, NULL)
INSERT [dbo].[faultInfos] ([id], [customer_ID], [faultProduct_ID], [model], [component], [detail], [price], [statusID], [startDate], [finishDate], [solutionDetail]) VALUES (8, 23, 1, N'd', N'd', N'd', CAST(700 AS Decimal(18, 0)), 1, CAST(0x0700000000004B410B AS DateTime2), NULL, NULL)
INSERT [dbo].[faultInfos] ([id], [customer_ID], [faultProduct_ID], [model], [component], [detail], [price], [statusID], [startDate], [finishDate], [solutionDetail]) VALUES (9, 23, 1, N'D', N'D', N'D', CAST(500 AS Decimal(18, 0)), 1, CAST(0x0700000000004B410B AS DateTime2), NULL, NULL)
INSERT [dbo].[faultInfos] ([id], [customer_ID], [faultProduct_ID], [model], [component], [detail], [price], [statusID], [startDate], [finishDate], [solutionDetail]) VALUES (10, 23, 1, N'D', N'D', N'', CAST(300 AS Decimal(18, 0)), 1, CAST(0x0700000000004B410B AS DateTime2), NULL, NULL)
INSERT [dbo].[faultInfos] ([id], [customer_ID], [faultProduct_ID], [model], [component], [detail], [price], [statusID], [startDate], [finishDate], [solutionDetail]) VALUES (11, 23, 1, N'D', N'D', N'D', CAST(1650 AS Decimal(18, 0)), 1, CAST(0x0700000000004B410B AS DateTime2), NULL, NULL)
INSERT [dbo].[faultInfos] ([id], [customer_ID], [faultProduct_ID], [model], [component], [detail], [price], [statusID], [startDate], [finishDate], [solutionDetail]) VALUES (12, 23, 1, N'D', N'D', N'', CAST(1500 AS Decimal(18, 0)), 1, CAST(0x0700000000004B410B AS DateTime2), NULL, NULL)
INSERT [dbo].[faultInfos] ([id], [customer_ID], [faultProduct_ID], [model], [component], [detail], [price], [statusID], [startDate], [finishDate], [solutionDetail]) VALUES (13, 12, 3, N'deneme', N'dde', N'', CAST(323 AS Decimal(18, 0)), 1, CAST(0x0700000000004B410B AS DateTime2), NULL, NULL)
INSERT [dbo].[faultInfos] ([id], [customer_ID], [faultProduct_ID], [model], [component], [detail], [price], [statusID], [startDate], [finishDate], [solutionDetail]) VALUES (14, 7, 1, N'de', N'de', N'de', CAST(0 AS Decimal(18, 0)), 1, CAST(0x0700000000004B410B AS DateTime2), NULL, NULL)
INSERT [dbo].[faultInfos] ([id], [customer_ID], [faultProduct_ID], [model], [component], [detail], [price], [statusID], [startDate], [finishDate], [solutionDetail]) VALUES (15, 7, 1, N'de', N'de', N'de', CAST(444 AS Decimal(18, 0)), 1, CAST(0x0700000000004B410B AS DateTime2), NULL, NULL)
INSERT [dbo].[faultInfos] ([id], [customer_ID], [faultProduct_ID], [model], [component], [detail], [price], [statusID], [startDate], [finishDate], [solutionDetail]) VALUES (16, 25, 3, N'fff', N'ff', N'fff', CAST(0 AS Decimal(18, 0)), 3, CAST(0x0700000000004B410B AS DateTime2), CAST(0xC6410B00 AS Date), N'çözülemedi')
INSERT [dbo].[faultInfos] ([id], [customer_ID], [faultProduct_ID], [model], [component], [detail], [price], [statusID], [startDate], [finishDate], [solutionDetail]) VALUES (17, 3, 1, N'eyşan', N'eyşan', N'ddd', CAST(2 AS Decimal(18, 0)), 2, CAST(0x0700000000004B410B AS DateTime2), CAST(0xC6410B00 AS Date), N'asdsad')
INSERT [dbo].[faultInfos] ([id], [customer_ID], [faultProduct_ID], [model], [component], [detail], [price], [statusID], [startDate], [finishDate], [solutionDetail]) VALUES (18, 6, 1, N'deneem', N'dene', N'deneme', CAST(0 AS Decimal(18, 0)), 1, CAST(0x0700000000004B410B AS DateTime2), NULL, NULL)
INSERT [dbo].[faultInfos] ([id], [customer_ID], [faultProduct_ID], [model], [component], [detail], [price], [statusID], [startDate], [finishDate], [solutionDetail]) VALUES (19, 5, 4, N'gts', N'güç kablosu', N'kasa açılmıyor', CAST(1500 AS Decimal(18, 0)), 1, CAST(0x07000000000089410B AS DateTime2), NULL, NULL)
SET IDENTITY_INSERT [dbo].[faultInfos] OFF
SET IDENTITY_INSERT [dbo].[faultProduct] ON 

INSERT [dbo].[faultProduct] ([faultProduct_ID], [faultProduct_reason]) VALUES (1, N'Kasa')
INSERT [dbo].[faultProduct] ([faultProduct_ID], [faultProduct_reason]) VALUES (2, N'Monitör')
INSERT [dbo].[faultProduct] ([faultProduct_ID], [faultProduct_reason]) VALUES (3, N'İşlemci')
INSERT [dbo].[faultProduct] ([faultProduct_ID], [faultProduct_reason]) VALUES (4, N'Format')
SET IDENTITY_INSERT [dbo].[faultProduct] OFF
INSERT [dbo].[faultStatus] ([fault_statusID], [fault_status]) VALUES (1, N'Bekliyor                                          ')
INSERT [dbo].[faultStatus] ([fault_statusID], [fault_status]) VALUES (2, N'Çözüldü                                           ')
INSERT [dbo].[faultStatus] ([fault_statusID], [fault_status]) VALUES (3, N'Çözülemedi(İade)                                  ')
SET IDENTITY_INSERT [dbo].[mainCategory] ON 

INSERT [dbo].[mainCategory] ([mainCategory_ID], [mainCategory_name]) VALUES (1, N'Masaüstü')
INSERT [dbo].[mainCategory] ([mainCategory_ID], [mainCategory_name]) VALUES (2, N'Laptop')
INSERT [dbo].[mainCategory] ([mainCategory_ID], [mainCategory_name]) VALUES (3, N'Tablet')
INSERT [dbo].[mainCategory] ([mainCategory_ID], [mainCategory_name]) VALUES (4, N'IDEAPAD')
INSERT [dbo].[mainCategory] ([mainCategory_ID], [mainCategory_name]) VALUES (5, N'Cep Telefonu')
SET IDENTITY_INSERT [dbo].[mainCategory] OFF
SET IDENTITY_INSERT [dbo].[products] ON 

INSERT [dbo].[products] ([product_ID], [product_name], [product_stock], [product_subCategoryID], [product_brandID], [product_purchaseprice], [product_saleprice]) VALUES (11, N'G180 X', 6, 9, 3, CAST(650 AS Decimal(18, 0)), CAST(700 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[products] OFF
SET IDENTITY_INSERT [dbo].[productSoldReason] ON 

INSERT [dbo].[productSoldReason] ([reason_ID], [reason_name]) VALUES (1, N'Satış')
INSERT [dbo].[productSoldReason] ([reason_ID], [reason_name]) VALUES (2, N'Arıza')
SET IDENTITY_INSERT [dbo].[productSoldReason] OFF
SET IDENTITY_INSERT [dbo].[soldProducts] ON 

INSERT [dbo].[soldProducts] ([productSold_ID], [productSold_customerID], [productSold_productID], [productSold_unit], [productSold_reasonID], [productSold_totalPrice], [productSold_soldDate]) VALUES (20, 2, 11, 2, 1, 1400, CAST(0x32410B00 AS Date))
INSERT [dbo].[soldProducts] ([productSold_ID], [productSold_customerID], [productSold_productID], [productSold_unit], [productSold_reasonID], [productSold_totalPrice], [productSold_soldDate]) VALUES (21, 2, 11, 2, 1, 1400, CAST(0x32410B00 AS Date))
SET IDENTITY_INSERT [dbo].[soldProducts] OFF
SET IDENTITY_INSERT [dbo].[subCategory] ON 

INSERT [dbo].[subCategory] ([subCategory_ID], [subCategory_name], [subCategory_mainCatgID]) VALUES (2, N'İşlemci', 2)
INSERT [dbo].[subCategory] ([subCategory_ID], [subCategory_name], [subCategory_mainCatgID]) VALUES (3, N'İşlemci', 1)
INSERT [dbo].[subCategory] ([subCategory_ID], [subCategory_name], [subCategory_mainCatgID]) VALUES (8, N'Ekran Kartı', 1)
INSERT [dbo].[subCategory] ([subCategory_ID], [subCategory_name], [subCategory_mainCatgID]) VALUES (9, N'Anakart', 1)
SET IDENTITY_INSERT [dbo].[subCategory] OFF
ALTER TABLE [dbo].[products] ADD  CONSTRAINT [DF_products_product_unitprice]  DEFAULT ((0)) FOR [product_saleprice]
GO
ALTER TABLE [dbo].[faultInfos]  WITH CHECK ADD  CONSTRAINT [FK_faultInfos_faultProduct] FOREIGN KEY([faultProduct_ID])
REFERENCES [dbo].[faultProduct] ([faultProduct_ID])
GO
ALTER TABLE [dbo].[faultInfos] CHECK CONSTRAINT [FK_faultInfos_faultProduct]
GO
ALTER TABLE [dbo].[faultInfos]  WITH CHECK ADD  CONSTRAINT [FK_faultInfos_status] FOREIGN KEY([statusID])
REFERENCES [dbo].[faultStatus] ([fault_statusID])
GO
ALTER TABLE [dbo].[faultInfos] CHECK CONSTRAINT [FK_faultInfos_status]
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD  CONSTRAINT [FK_products_brands] FOREIGN KEY([product_brandID])
REFERENCES [dbo].[brands] ([brand_id])
GO
ALTER TABLE [dbo].[products] CHECK CONSTRAINT [FK_products_brands]
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD  CONSTRAINT [FK_products_subCategory] FOREIGN KEY([product_subCategoryID])
REFERENCES [dbo].[subCategory] ([subCategory_ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[products] CHECK CONSTRAINT [FK_products_subCategory]
GO
ALTER TABLE [dbo].[soldProducts]  WITH CHECK ADD  CONSTRAINT [FK_soldProducts_products] FOREIGN KEY([productSold_productID])
REFERENCES [dbo].[products] ([product_ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[soldProducts] CHECK CONSTRAINT [FK_soldProducts_products]
GO
ALTER TABLE [dbo].[soldProducts]  WITH CHECK ADD  CONSTRAINT [FK_soldProducts_productSoldReason] FOREIGN KEY([productSold_reasonID])
REFERENCES [dbo].[productSoldReason] ([reason_ID])
GO
ALTER TABLE [dbo].[soldProducts] CHECK CONSTRAINT [FK_soldProducts_productSoldReason]
GO
ALTER TABLE [dbo].[subCategory]  WITH CHECK ADD  CONSTRAINT [FK_subCategory_mainCategory] FOREIGN KEY([subCategory_mainCatgID])
REFERENCES [dbo].[mainCategory] ([mainCategory_ID])
GO
ALTER TABLE [dbo].[subCategory] CHECK CONSTRAINT [FK_subCategory_mainCategory]
GO
