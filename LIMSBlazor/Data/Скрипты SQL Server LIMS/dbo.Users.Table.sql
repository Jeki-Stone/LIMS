USE [LIMS]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 11.03.2021 19:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[FullName] [varchar](100) NULL,
	[PhoneNumber] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
 CONSTRAINT [PK_Пользователи] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
