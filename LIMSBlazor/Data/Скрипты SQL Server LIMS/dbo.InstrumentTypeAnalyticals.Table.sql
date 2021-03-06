USE [LIMS]
GO
/****** Object:  Table [dbo].[InstrumentTypeAnalyticals]    Script Date: 11.03.2021 19:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InstrumentTypeAnalyticals](
	[InstrumentTypeId] [int] NOT NULL,
	[AnalyticalServiceId] [int] NOT NULL,
 CONSTRAINT [PK_InstrumentTypeAnaliticals] PRIMARY KEY CLUSTERED 
(
	[InstrumentTypeId] ASC,
	[AnalyticalServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[InstrumentTypeAnalyticals]  WITH CHECK ADD  CONSTRAINT [FK_InstrumentTypeAnaliticals_AnalyticalServices] FOREIGN KEY([AnalyticalServiceId])
REFERENCES [dbo].[AnalyticalServices] ([Id])
GO
ALTER TABLE [dbo].[InstrumentTypeAnalyticals] CHECK CONSTRAINT [FK_InstrumentTypeAnaliticals_AnalyticalServices]
GO
ALTER TABLE [dbo].[InstrumentTypeAnalyticals]  WITH CHECK ADD  CONSTRAINT [FK_InstrumentTypeAnaliticals_InstrumentTypes] FOREIGN KEY([InstrumentTypeId])
REFERENCES [dbo].[InstrumentTypes] ([Id])
GO
ALTER TABLE [dbo].[InstrumentTypeAnalyticals] CHECK CONSTRAINT [FK_InstrumentTypeAnaliticals_InstrumentTypes]
GO
