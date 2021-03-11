USE [LIMS]
GO
/****** Object:  StoredProcedure [dbo].[spSampleSpecs_Insert]    Script Date: 11.03.2021 19:03:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleSpecs_Insert]
	-- Add the parameters for the stored procedure here
	@Name varchar(50),
	@Description varchar(550),
	@Version varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    INSERT INTO SampleSpecs
                         (Name, Description, Version)
VALUES        (@Name, @Description, @Version)
END
GO
