USE [cactus1337]
GO
/****** Object:  Table [dbo].[Cactus]    Script Date: 08.09.2024 14:22:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cactus](
	[id_cactus] [int] NOT NULL,
	[name] [nvarchar](50) NULL,
	[tipe] [nvarchar](50) NULL,
	[origin] [nvarchar](50) NULL,
	[age] [int] NULL,
	[price] [int] NULL,
	[id_instruction] [int] NULL,
 CONSTRAINT [PK_Cactus] PRIMARY KEY CLUSTERED 
(
	[id_cactus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Collection1]    Script Date: 08.09.2024 14:22:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Collection1](
	[id_collection] [int] NOT NULL,
	[name] [nvarchar](50) NULL,
	[all_price] [int] NULL,
 CONSTRAINT [PK_Collection] PRIMARY KEY CLUSTERED 
(
	[id_collection] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Exhibition1]    Script Date: 08.09.2024 14:22:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exhibition1](
	[id_exhibition] [int] NOT NULL,
	[name] [nvarchar](50) NULL,
	[date] [date] NULL,
	[place] [nvarchar](50) NULL,
 CONSTRAINT [PK_Exhibition] PRIMARY KEY CLUSTERED 
(
	[id_exhibition] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[instruction]    Script Date: 08.09.2024 14:22:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[instruction](
	[id_instruction] [int] NOT NULL,
	[description] [nvarchar](100) NULL,
 CONSTRAINT [PK_instruction] PRIMARY KEY CLUSTERED 
(
	[id_instruction] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[list_collection]    Script Date: 08.09.2024 14:22:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[list_collection](
	[id_list_collection] [int] NOT NULL,
	[id_cactus] [int] NULL,
	[id_collection] [int] NULL,
 CONSTRAINT [PK_list_collection] PRIMARY KEY CLUSTERED 
(
	[id_list_collection] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[list_exhibition]    Script Date: 08.09.2024 14:22:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[list_exhibition](
	[id_list_exhibition] [int] NOT NULL,
	[id_cactus] [int] NULL,
	[id_exhibition] [int] NULL,
 CONSTRAINT [PK_list_exhibition] PRIMARY KEY CLUSTERED 
(
	[id_list_exhibition] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Cactus] ([id_cactus], [name], [tipe], [origin], [age], [price], [id_instruction]) VALUES (1, N'Кактус обыкновенный', N'Обычный', N'Пустыня', 3, 1000, 1)
GO
INSERT [dbo].[Collection1] ([id_collection], [name], [all_price]) VALUES (1, N'Красивые кактусы', 1000)
GO
INSERT [dbo].[Exhibition1] ([id_exhibition], [name], [date], [place]) VALUES (1, N'Пустынная фауна', CAST(N'2024-01-01' AS Date), N'г.Казань')
INSERT [dbo].[Exhibition1] ([id_exhibition], [name], [date], [place]) VALUES (2, N'Растения дикого запа', CAST(N'2024-02-02' AS Date), N'г.Казань')
GO
INSERT [dbo].[instruction] ([id_instruction], [description]) VALUES (1, N'Не требует какого-либо жесткого ухода, раз в неделю поливать 100 мл воды.')
GO
INSERT [dbo].[list_collection] ([id_list_collection], [id_cactus], [id_collection]) VALUES (1, 1, 1)
GO
INSERT [dbo].[list_exhibition] ([id_list_exhibition], [id_cactus], [id_exhibition]) VALUES (1, 1, 1)
GO
ALTER TABLE [dbo].[Cactus]  WITH CHECK ADD  CONSTRAINT [FK_Cactus_instruction] FOREIGN KEY([id_instruction])
REFERENCES [dbo].[instruction] ([id_instruction])
GO
ALTER TABLE [dbo].[Cactus] CHECK CONSTRAINT [FK_Cactus_instruction]
GO
ALTER TABLE [dbo].[list_collection]  WITH CHECK ADD  CONSTRAINT [FK_list_collection_Cactus] FOREIGN KEY([id_cactus])
REFERENCES [dbo].[Cactus] ([id_cactus])
GO
ALTER TABLE [dbo].[list_collection] CHECK CONSTRAINT [FK_list_collection_Cactus]
GO
ALTER TABLE [dbo].[list_collection]  WITH CHECK ADD  CONSTRAINT [FK_list_collection_Collection] FOREIGN KEY([id_collection])
REFERENCES [dbo].[Collection1] ([id_collection])
GO
ALTER TABLE [dbo].[list_collection] CHECK CONSTRAINT [FK_list_collection_Collection]
GO
ALTER TABLE [dbo].[list_exhibition]  WITH CHECK ADD  CONSTRAINT [FK_list_exhibition_Cactus] FOREIGN KEY([id_cactus])
REFERENCES [dbo].[Cactus] ([id_cactus])
GO
ALTER TABLE [dbo].[list_exhibition] CHECK CONSTRAINT [FK_list_exhibition_Cactus]
GO
ALTER TABLE [dbo].[list_exhibition]  WITH CHECK ADD  CONSTRAINT [FK_list_exhibition_Exhibition] FOREIGN KEY([id_exhibition])
REFERENCES [dbo].[Exhibition1] ([id_exhibition])
GO
ALTER TABLE [dbo].[list_exhibition] CHECK CONSTRAINT [FK_list_exhibition_Exhibition]
GO
