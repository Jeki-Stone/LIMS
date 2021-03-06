USE [LIMS]
GO
/****** Object:  StoredProcedure [dbo].[spSampleSpecAnalyticals_Update]    Script Date: 11.03.2021 19:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleSpecAnalyticals_Update]
	-- Add the parameters for the stored procedure here
	@SampleSpecId int,
	@OldSampleSpecId int,
	@AnalyticalServiceId int,
	@OldAnalyticalServiceId int,
	@MinValue float,
	@MaxValue float
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE SampleSpecAnalyticals  SET SampleSpecId = @SampleSpecId, AnalyticalServiceId = @AnalyticalServiceId, MinValue = @MinValue, MaxValue = @MaxValue 
	WHERE (SampleSpecId = @OldSampleSpecId and AnalyticalServiceId = @OldAnalyticalServiceId)
END
GO
