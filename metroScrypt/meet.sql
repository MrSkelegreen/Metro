USE Metro
GO
/****** Object:  Table [dbo].[Coupon]    Script Date: 13.06.2022 19:00:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Coupon](
	[IDCoupon] [int] IDENTITY(1,1) NOT NULL,
	[Balance] [money] NULL,
	[EndDate] [date] NOT NULL,
 CONSTRAINT [PK_Coupon] PRIMARY KEY CLUSTERED 
(
	[IDCoupon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Letters]    Script Date: 13.06.2022 19:00:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Letters](
	[IDLetter] [int] IDENTITY(1,1) NOT NULL,
	[IDUser] [int] NOT NULL,
	[LetterType] [bit] NOT NULL,
	[Text] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Letters] PRIMARY KEY CLUSTERED 
(
	[IDLetter] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LetterTypes]    Script Date: 13.06.2022 19:00:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LetterTypes](
	[IDLetterType] [bit] NOT NULL,
	[Type] [nvarchar](50) NULL,
 CONSTRAINT [PK_LetterTypes] PRIMARY KEY CLUSTERED 
(
	[IDLetterType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pay]    Script Date: 13.06.2022 19:00:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pay](
	[IDPay] [int] IDENTITY(1,1) NOT NULL,
	[Sum] [money] NOT NULL,
	[Date] [date] NOT NULL,
	[PayType] [bit] NOT NULL,
	[IDCoupon] [int] NOT NULL,
 CONSTRAINT [PK_AutoPay] PRIMARY KEY CLUSTERED 
(
	[IDPay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tickets]    Script Date: 13.06.2022 19:00:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tickets](
	[IDTicket] [int] IDENTITY(1,1) NOT NULL,
	[Price] [money] NOT NULL,
	[Date] [date] NOT NULL,
	[IDUser] [int] NOT NULL,
 CONSTRAINT [PK_Tickets] PRIMARY KEY CLUSTERED 
(
	[IDTicket] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 13.06.2022 19:00:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Firtsname] [nvarchar](50) NOT NULL,
	[Lastname] [nvarchar](50) NULL,
	[IdCoupon] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Coupon] ON 

INSERT [dbo].[Coupon] ([IDCoupon], [Balance], [EndDate]) VALUES (1, 0.0000, CAST(N'2025-01-01' AS Date))
SET IDENTITY_INSERT [dbo].[Coupon] OFF
GO
INSERT [dbo].[LetterTypes] ([IDLetterType], [Type]) VALUES (0, N'Жалоба')
INSERT [dbo].[LetterTypes] ([IDLetterType], [Type]) VALUES (1, N'Предложение')
GO
SET IDENTITY_INSERT [dbo].[Pay] ON 

INSERT [dbo].[Pay] ([IDPay], [Sum], [Date], [PayType], [IDCoupon]) VALUES (1, 20.0000, CAST(N'2022-06-13' AS Date), 0, 1)
INSERT [dbo].[Pay] ([IDPay], [Sum], [Date], [PayType], [IDCoupon]) VALUES (2, 20.0000, CAST(N'2022-06-13' AS Date), 0, 1)
INSERT [dbo].[Pay] ([IDPay], [Sum], [Date], [PayType], [IDCoupon]) VALUES (3, 20.0000, CAST(N'2022-06-13' AS Date), 0, 1)
INSERT [dbo].[Pay] ([IDPay], [Sum], [Date], [PayType], [IDCoupon]) VALUES (4, 20.0000, CAST(N'2022-06-13' AS Date), 0, 1)
SET IDENTITY_INSERT [dbo].[Pay] OFF
GO
SET IDENTITY_INSERT [dbo].[Tickets] ON 

INSERT [dbo].[Tickets] ([IDTicket], [Price], [Date], [IDUser]) VALUES (3, 20.0000, CAST(N'2022-06-13' AS Date), 1)
INSERT [dbo].[Tickets] ([IDTicket], [Price], [Date], [IDUser]) VALUES (4, 20.0000, CAST(N'2022-06-13' AS Date), 1)
INSERT [dbo].[Tickets] ([IDTicket], [Price], [Date], [IDUser]) VALUES (5, 20.0000, CAST(N'2022-06-13' AS Date), 1)
INSERT [dbo].[Tickets] ([IDTicket], [Price], [Date], [IDUser]) VALUES (6, 20.0000, CAST(N'2022-06-13' AS Date), 1)
SET IDENTITY_INSERT [dbo].[Tickets] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([id], [Login], [Password], [Firtsname], [Lastname], [IdCoupon]) VALUES (1, N'sa', N'1', N'Никита', N'Огнев', 1)
INSERT [dbo].[Users] ([id], [Login], [Password], [Firtsname], [Lastname], [IdCoupon]) VALUES (2, N'as', N'2', N'Garri', N'Ognev', NULL)
INSERT [dbo].[Users] ([id], [Login], [Password], [Firtsname], [Lastname], [IdCoupon]) VALUES (3, N'dasg', N'12234', N'qwefrqw', N'qewtq', NULL)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Letters]  WITH CHECK ADD  CONSTRAINT [FK_Letters_LetterTypes] FOREIGN KEY([LetterType])
REFERENCES [dbo].[LetterTypes] ([IDLetterType])
GO
ALTER TABLE [dbo].[Letters] CHECK CONSTRAINT [FK_Letters_LetterTypes]
GO
ALTER TABLE [dbo].[Letters]  WITH CHECK ADD  CONSTRAINT [FK_Letters_Users] FOREIGN KEY([IDUser])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[Letters] CHECK CONSTRAINT [FK_Letters_Users]
GO
ALTER TABLE [dbo].[Pay]  WITH CHECK ADD  CONSTRAINT [FK_Pay_Coupon] FOREIGN KEY([IDCoupon])
REFERENCES [dbo].[Coupon] ([IDCoupon])
GO
ALTER TABLE [dbo].[Pay] CHECK CONSTRAINT [FK_Pay_Coupon]
GO
ALTER TABLE [dbo].[Tickets]  WITH CHECK ADD  CONSTRAINT [FK_Tickets_Users] FOREIGN KEY([IDUser])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[Tickets] CHECK CONSTRAINT [FK_Tickets_Users]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Coupon] FOREIGN KEY([IdCoupon])
REFERENCES [dbo].[Coupon] ([IDCoupon])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Coupon]
GO
