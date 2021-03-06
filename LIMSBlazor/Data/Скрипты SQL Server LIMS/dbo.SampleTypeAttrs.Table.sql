USE [LIMS]
GO
/****** Object:  Table [dbo].[SampleTypeAttrs]    Script Date: 11.03.2021 19:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SampleTypeAttrs](
	[SampleTypeId] [int] NOT NULL,
	[AttrId] [int] NOT NULL,
 CONSTRAINT [PK_SampleTypeAttrs] PRIMARY KEY CLUSTERED 
(
	[SampleTypeId] ASC,
	[AttrId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[SampleTypeAttrs]  WITH CHECK ADD  CONSTRAINT [FK_Атрибуты_Типов_Проб_Атрибуты] FOREIGN KEY([AttrId])
REFERENCES [dbo].[Attrs] ([Id])
GO
ALTER TABLE [dbo].[SampleTypeAttrs] CHECK CONSTRAINT [FK_Атрибуты_Типов_Проб_Атрибуты]
GO
ALTER TABLE [dbo].[SampleTypeAttrs]  WITH CHECK ADD  CONSTRAINT [FK_Атрибуты_Типов_Проб_Тип пробы] FOREIGN KEY([SampleTypeId])
REFERENCES [dbo].[SampleTypes] ([Id])
GO
ALTER TABLE [dbo].[SampleTypeAttrs] CHECK CONSTRAINT [FK_Атрибуты_Типов_Проб_Тип пробы]
GO
