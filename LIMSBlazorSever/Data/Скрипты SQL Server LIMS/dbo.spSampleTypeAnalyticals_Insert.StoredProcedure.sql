USE [LIMS]
GO
/****** Object:  StoredProcedure [dbo].[spSampleTypeAnalyticals_Insert]    Script Date: 11.03.2021 19:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleTypeAnalyticals_Insert]
	-- Add the parameters for the stored procedure here
	@SampleTypeId int,
	@AnalyticalServiceId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO SampleTypeAnalyticals (SampleTypeId, AnalyticalServiceId) VALUES (@SampleTypeId, @AnalyticalServiceId)
END
GO
