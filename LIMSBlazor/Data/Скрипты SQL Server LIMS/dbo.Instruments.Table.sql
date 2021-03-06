USE [LIMS]
GO
/****** Object:  Table [dbo].[Instruments]    Script Date: 11.03.2021 19:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Instruments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[InstrumentTypeId] [int] NULL,
	[SerialNumber] [varchar](50) NULL,
	[Description] [varchar](500) NULL,
	[LabId] [int] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_Инструменты] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Instruments]  WITH CHECK ADD  CONSTRAINT [FK_Instruments_InstrumentTypes] FOREIGN KEY([InstrumentTypeId])
REFERENCES [dbo].[InstrumentTypes] ([Id])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Instruments] CHECK CONSTRAINT [FK_Instruments_InstrumentTypes]
GO
ALTER TABLE [dbo].[Instruments]  WITH CHECK ADD  CONSTRAINT [FK_Инструменты_Лабаротории] FOREIGN KEY([LabId])
REFERENCES [dbo].[Labs] ([Id])
GO
ALTER TABLE [dbo].[Instruments] CHECK CONSTRAINT [FK_Инструменты_Лабаротории]
GO
