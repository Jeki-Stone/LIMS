USE [LIMS]
GO
/****** Object:  StoredProcedure [dbo].[spSampleAnalyticals_Delete]    Script Date: 11.03.2021 19:03:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleAnalyticals_Delete]
	-- Add the parameters for the stored procedure here
	@SampleId int,
	@AnalyticalServiceId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DELETE FROM SampleAnalyticals
WHERE (SampleId = @SampleId and AnalyticalServiceId = @AnalyticalServiceId)
END
GO
