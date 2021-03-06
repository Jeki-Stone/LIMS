USE [LIMS]
GO
/****** Object:  Table [dbo].[Samples]    Script Date: 11.03.2021 19:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Samples](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RecieveTime] [datetime] NULL,
	[TestTime] [datetime] NULL,
	[ClientId] [int] NULL,
	[SampleTypeId] [int] NULL,
	[Status] [int] NULL,
	[IsFinal] [bit] NULL,
	[Note] [text] NULL,
	[LocationId] [int] NULL,
	[LastEditComment] [varchar](500) NULL,
	[CreateTime] [datetime] NULL,
	[UpdateTime] [datetime] NULL,
	[CreateUser] [varchar](50) NULL,
	[UpdateUser] [varchar](50) NULL,
	[FinalizeUser] [varchar](50) NULL,
	[FinalizeTime] [datetime] NULL,
 CONSTRAINT [PK_Пробы] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Samples]  WITH CHECK ADD  CONSTRAINT [FK_Пробы_Клиенты] FOREIGN KEY([ClientId])
REFERENCES [dbo].[Clients] ([Id])
GO
ALTER TABLE [dbo].[Samples] CHECK CONSTRAINT [FK_Пробы_Клиенты]
GO
ALTER TABLE [dbo].[Samples]  WITH CHECK ADD  CONSTRAINT [FK_Пробы_Места взятия пробы] FOREIGN KEY([LocationId])
REFERENCES [dbo].[Locs] ([Id])
GO
ALTER TABLE [dbo].[Samples] CHECK CONSTRAINT [FK_Пробы_Места взятия пробы]
GO
ALTER TABLE [dbo].[Samples]  WITH CHECK ADD  CONSTRAINT [FK_Пробы_Тип пробы] FOREIGN KEY([SampleTypeId])
REFERENCES [dbo].[SampleTypes] ([Id])
GO
ALTER TABLE [dbo].[Samples] CHECK CONSTRAINT [FK_Пробы_Тип пробы]
GO
