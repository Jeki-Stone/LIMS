USE [LIMS]
GO
/****** Object:  StoredProcedure [dbo].[spAnalyticalServices_Delete]    Script Date: 11.03.2021 18:51:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[spAnalyticalServices_Delete]
	-- Add the parameters for the stored procedure here
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.	 
	SET NOCOUNT ON;

    DELETE FROM AnalyticalServices
WHERE (Id = @Id)
END
