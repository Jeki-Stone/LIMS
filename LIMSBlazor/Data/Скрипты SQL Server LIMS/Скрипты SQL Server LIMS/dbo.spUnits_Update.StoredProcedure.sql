USE [LIMS]
GO
/****** Object:  StoredProcedure [dbo].[spUnits_Update]    Script Date: 11.03.2021 19:03:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spUnits_Update]
	-- Add the parameters for the stored procedure here
	@Id int,
	@Name varchar(50),
	@Scale varchar(50),
	@BaseUnitId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Units  SET Name = @Name, Scale = @Scale, BaseUnitId = @BaseUnitId WHERE (id=@Id)
END
GO
