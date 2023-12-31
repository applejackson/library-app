USE [dbLibrary]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 27.04.2023 22:34:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Author](
	[FIO] [char](100) NOT NULL,
	[dateLife] [date] NULL,
 CONSTRAINT [PK__Author__C1BEAA5DB95E5B64] PRIMARY KEY CLUSTERED 
(
	[FIO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bilet]    Script Date: 27.04.2023 22:34:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bilet](
	[biletId] [int] IDENTITY(1,1) NOT NULL,
	[name] [char](50) NULL,
	[surname] [char](50) NULL,
	[patronymic] [char](50) NULL,
	[numberTelephone] [varchar](50) NULL,
	[passwords] [varchar](50) NULL,
 CONSTRAINT [PK__bilet__E366AFCF38AAFAF0] PRIMARY KEY CLUSTERED 
(
	[biletId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 27.04.2023 22:34:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[booksId] [int] IDENTITY(1,1) NOT NULL,
	[FIO] [char](100) NULL,
	[namebook] [char](200) NULL,
	[genre] [char](100) NULL,
	[publisher] [char](50) NULL,
	[obloshka] [char](50) NULL,
	[pages] [char](5) NULL,
	[took] [bit] NULL,
 CONSTRAINT [PK__Books__7D8C943440673686] PRIMARY KEY CLUSTERED 
(
	[booksId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[manInfo]    Script Date: 27.04.2023 22:34:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[manInfo](
	[manTookFIO] [int] IDENTITY(1,1) NOT NULL,
	[booksId] [int] NULL,
	[dateTook] [date] NULL,
	[biletId] [int] NULL,
	[dateGave] [date] NULL,
	[took] [bit] NULL,
 CONSTRAINT [PK__manTook__CA75B8D1D6087CB9] PRIMARY KEY CLUSTERED 
(
	[manTookFIO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[manInfo]  WITH CHECK ADD  CONSTRAINT [FK_manTook_bilet] FOREIGN KEY([biletId])
REFERENCES [dbo].[bilet] ([biletId])
GO
ALTER TABLE [dbo].[manInfo] CHECK CONSTRAINT [FK_manTook_bilet]
GO
ALTER TABLE [dbo].[manInfo]  WITH CHECK ADD  CONSTRAINT [FK_manTook_Books] FOREIGN KEY([booksId])
REFERENCES [dbo].[Books] ([booksId])
GO
ALTER TABLE [dbo].[manInfo] CHECK CONSTRAINT [FK_manTook_Books]
GO
