USE [LIMS]
GO
/****** Object:  Table [dbo].[SampleAttrs]    Script Date: 11.03.2021 19:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SampleAttrs](
	[SampleId] [int] NOT NULL,
	[AttrId] [int] NOT NULL,
	[Value] [varchar](100) NULL,
	[CreateTime] [datetime] NULL,
	[UpdateTime] [datetime] NULL,
	[CreateUser] [varchar](50) NULL,
	[UpdateUser] [varchar](50) NULL,
 CONSTRAINT [PK_SampleAttrs] PRIMARY KEY CLUSTERED 
(
	[SampleId] ASC,
	[AttrId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[SampleAttrs]  WITH CHECK ADD  CONSTRAINT [FK_SampleAttrs_Attrs] FOREIGN KEY([AttrId])
REFERENCES [dbo].[Attrs] ([Id])
GO
ALTER TABLE [dbo].[SampleAttrs] CHECK CONSTRAINT [FK_SampleAttrs_Attrs]
GO
ALTER TABLE [dbo].[SampleAttrs]  WITH CHECK ADD  CONSTRAINT [FK_SampleAttrs_Samples] FOREIGN KEY([SampleId])
REFERENCES [dbo].[Samples] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SampleAttrs] CHECK CONSTRAINT [FK_SampleAttrs_Samples]
GO
