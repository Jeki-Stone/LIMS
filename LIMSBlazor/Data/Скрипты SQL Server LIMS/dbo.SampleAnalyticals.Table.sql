USE [LIMS]
GO
/****** Object:  Table [dbo].[SampleAnalyticals]    Script Date: 11.03.2021 19:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SampleAnalyticals](
	[SampleId] [int] NOT NULL,
	[AnalyticalServiceId] [int] NOT NULL,
 CONSTRAINT [PK_SampleAnaliticals] PRIMARY KEY CLUSTERED 
(
	[SampleId] ASC,
	[AnalyticalServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[SampleAnalyticals]  WITH CHECK ADD  CONSTRAINT [FK_SampleAnaliticals_AnalyticalServices] FOREIGN KEY([AnalyticalServiceId])
REFERENCES [dbo].[AnalyticalServices] ([Id])
GO
ALTER TABLE [dbo].[SampleAnalyticals] CHECK CONSTRAINT [FK_SampleAnaliticals_AnalyticalServices]
GO
ALTER TABLE [dbo].[SampleAnalyticals]  WITH CHECK ADD  CONSTRAINT [FK_SampleAnaliticals_Samples] FOREIGN KEY([SampleId])
REFERENCES [dbo].[Samples] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SampleAnalyticals] CHECK CONSTRAINT [FK_SampleAnaliticals_Samples]
GO
