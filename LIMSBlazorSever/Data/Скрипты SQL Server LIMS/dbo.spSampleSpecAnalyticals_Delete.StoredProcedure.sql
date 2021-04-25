USE [LIMS]
GO
/****** Object:  StoredProcedure [dbo].[spSampleSpecAnalyticals_Delete]    Script Date: 11.03.2021 19:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleSpecAnalyticals_Delete]
	-- Add the parameters for the stored procedure here
	@SampleSpecId int,
	@AnalyticalServiceId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DELETE FROM SampleSpecAnalyticals
WHERE (SampleSpecId = @SampleSpecId and AnalyticalServiceId = @AnalyticalServiceId)
END
GO
