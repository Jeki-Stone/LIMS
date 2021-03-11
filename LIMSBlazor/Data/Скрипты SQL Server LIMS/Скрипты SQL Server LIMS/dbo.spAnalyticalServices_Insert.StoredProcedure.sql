USE [LIMS]
GO
/****** Object:  StoredProcedure [dbo].[spAnalyticalServices_Insert]    Script Date: 11.03.2021 19:03:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spAnalyticalServices_Insert]
	-- Add the parameters for the stored procedure here
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
	INSERT INTO AnalyticalServices (Name, CategoryId, UnitId, Description) VALUES (@Name, @CategoryId, @UnitId, @Description)
END
GO
