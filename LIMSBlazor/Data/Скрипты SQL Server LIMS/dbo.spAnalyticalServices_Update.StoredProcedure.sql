USE [LIMS]
GO
/****** Object:  StoredProcedure [dbo].[spAnalyticalServices_Update]    Script Date: 11.03.2021 19:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spAnalyticalServices_Update]
	-- Add the parameters for the stored procedure here
	@Id int,
	@Name varchar(50),
	@CategoryId int,
	@UnitId int,
	@Description varchar(500)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE AnalyticalServices  SET Name = @Name, CategoryId = @CategoryId, UnitId = @UnitId, Description = @Description WHERE (id=@Id)
END
GO
