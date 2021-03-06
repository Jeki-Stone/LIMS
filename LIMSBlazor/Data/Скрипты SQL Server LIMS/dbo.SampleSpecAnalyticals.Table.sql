USE [LIMS]
GO
/****** Object:  Table [dbo].[SampleSpecAnalyticals]    Script Date: 11.03.2021 19:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SampleSpecAnalyticals](
	[SampleSpecId] [int] NOT NULL,
	[AnalyticalServiceId] [int] NOT NULL,
	[MinValue] [float] NULL,
	[MaxValue] [float] NULL,
 CONSTRAINT [PK_SampleSpecAnaliticals] PRIMARY KEY CLUSTERED 
(
	[SampleSpecId] ASC,
	[AnalyticalServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[SampleSpecAnalyticals]  WITH CHECK ADD  CONSTRAINT [FK_SampleSpecAnaliticals_AnalyticalServices] FOREIGN KEY([AnalyticalServiceId])
REFERENCES [dbo].[AnalyticalServices] ([Id])
GO
ALTER TABLE [dbo].[SampleSpecAnalyticals] CHECK CONSTRAINT [FK_SampleSpecAnaliticals_AnalyticalServices]
GO
ALTER TABLE [dbo].[SampleSpecAnalyticals]  WITH CHECK ADD  CONSTRAINT [FK_SampleSpecAnaliticals_SampleSpecs] FOREIGN KEY([SampleSpecId])
REFERENCES [dbo].[SampleSpecs] ([Id])
GO
ALTER TABLE [dbo].[SampleSpecAnalyticals] CHECK CONSTRAINT [FK_SampleSpecAnaliticals_SampleSpecs]
GO
