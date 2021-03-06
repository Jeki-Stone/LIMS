USE [LIMS]
GO
/****** Object:  Table [dbo].[AnalyticalServices]    Script Date: 11.03.2021 19:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnalyticalServices](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[CategoryId] [int] NULL,
	[UnitId] [int] NULL,
	[Description] [varchar](500) NULL,
 CONSTRAINT [PK_Аналетические сервисы] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AnalyticalServices]  WITH CHECK ADD  CONSTRAINT [FK_Аналетические сервисы_Единицы измерения] FOREIGN KEY([UnitId])
REFERENCES [dbo].[Units] ([Id])
GO
ALTER TABLE [dbo].[AnalyticalServices] CHECK CONSTRAINT [FK_Аналетические сервисы_Единицы измерения]
GO
ALTER TABLE [dbo].[AnalyticalServices]  WITH CHECK ADD  CONSTRAINT [FK_Аналетические сервисы_Категория испытаний] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
GO
ALTER TABLE [dbo].[AnalyticalServices] CHECK CONSTRAINT [FK_Аналетические сервисы_Категория испытаний]
GO
