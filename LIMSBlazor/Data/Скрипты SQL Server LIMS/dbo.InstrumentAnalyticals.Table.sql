USE [LIMS]
GO
/****** Object:  Table [dbo].[InstrumentAnalyticals]    Script Date: 11.03.2021 19:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InstrumentAnalyticals](
	[InstrumentId] [int] NOT NULL,
	[AnalyticalServiceId] [int] NOT NULL,
 CONSTRAINT [PK_InstrumentAnalyticals] PRIMARY KEY CLUSTERED 
(
	[InstrumentId] ASC,
	[AnalyticalServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[InstrumentAnalyticals]  WITH CHECK ADD  CONSTRAINT [FK_InstrumentAnalyticals_Instruments] FOREIGN KEY([InstrumentId])
REFERENCES [dbo].[Instruments] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[InstrumentAnalyticals] CHECK CONSTRAINT [FK_InstrumentAnalyticals_Instruments]
GO
ALTER TABLE [dbo].[InstrumentAnalyticals]  WITH CHECK ADD  CONSTRAINT [FK_Инструменты_Сервисы_Аналетические сервисы] FOREIGN KEY([AnalyticalServiceId])
REFERENCES [dbo].[AnalyticalServices] ([Id])
GO
ALTER TABLE [dbo].[InstrumentAnalyticals] CHECK CONSTRAINT [FK_Инструменты_Сервисы_Аналетические сервисы]
GO
