USE [LIMS]
GO
/****** Object:  StoredProcedure [dbo].[spAnalyticalServices_GetAll]    Script Date: 11.03.2021 18:50:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[spAnalyticalServices_GetAll]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT        Id, Name, CategoryId, UnitId, Description
FROM            AnalyticalServices
END
