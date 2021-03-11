USE [LIMS]
GO
/****** Object:  StoredProcedure [dbo].[spLocs_Update]    Script Date: 11.03.2021 19:03:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spLocs_Update]
	-- Add the parameters for the stored procedure here
	@Id int,
	@Name varchar(150),
	@Description varchar(500)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Locs  SET Name = @Name, Description = @Description WHERE (Id=@Id)
END
GO
