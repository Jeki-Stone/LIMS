USE [LIMS]
GO
/****** Object:  StoredProcedure [dbo].[spAttrs_Update]    Script Date: 11.03.2021 19:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spAttrs_Update]
	-- Add the parameters for the stored procedure here
	@Id int,
	@Name varchar(50),
	@Description varchar(500),
	@Type int,
	@Options varchar(MAX)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Attrs  SET Name = @Name, Description = @Description, Type = @Type, Options = @Options WHERE (Id=@Id)
END
GO
