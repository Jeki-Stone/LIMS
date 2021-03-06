USE [LIMS]
GO
/****** Object:  StoredProcedure [dbo].[spSampleSpecs_Update]    Script Date: 11.03.2021 19:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleSpecs_Update]
	-- Add the parameters for the stored procedure here
	@Id int,
	@Name varchar(50),
	@Description varchar(500),
	@Version varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE SampleSpecs  SET Name = @Name, Description = @Description, Version = @Version WHERE (Id=@Id)
END
GO
