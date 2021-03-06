USE [LIMS]
GO
/****** Object:  Table [dbo].[SampleTypeAnalyticals]    Script Date: 11.03.2021 19:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SampleTypeAnalyticals](
	[SampleTypeId] [int] NOT NULL,
	[AnalyticalServiceId] [int] NOT NULL,
 CONSTRAINT [PK_SampleTypeAnaliticals] PRIMARY KEY CLUSTERED 
(
	[SampleTypeId] ASC,
	[AnalyticalServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[SampleTypeAnalyticals]  WITH CHECK ADD  CONSTRAINT [FK_Шаблон испытаний_Аналетические сервисы] FOREIGN KEY([AnalyticalServiceId])
REFERENCES [dbo].[AnalyticalServices] ([Id])
GO
ALTER TABLE [dbo].[SampleTypeAnalyticals] CHECK CONSTRAINT [FK_Шаблон испытаний_Аналетические сервисы]
GO
ALTER TABLE [dbo].[SampleTypeAnalyticals]  WITH CHECK ADD  CONSTRAINT [FK_Шаблон испытаний_Тип пробы] FOREIGN KEY([SampleTypeId])
REFERENCES [dbo].[SampleTypes] ([Id])
GO
ALTER TABLE [dbo].[SampleTypeAnalyticals] CHECK CONSTRAINT [FK_Шаблон испытаний_Тип пробы]
GO
