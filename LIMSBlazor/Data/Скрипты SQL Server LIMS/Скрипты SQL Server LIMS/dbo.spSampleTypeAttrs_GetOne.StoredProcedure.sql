USE [LIMS]
GO
/****** Object:  StoredProcedure [dbo].[spSampleTypeAttrs_GetOne]    Script Date: 11.03.2021 19:03:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleTypeAttrs_GetOne]
	-- Add the parameters for the stored procedure here
	@SampleTypeId int,
	@AttrId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT        SampleTypeId, AttrId
FROM            SampleTypeAttrs
WHERE		  (SampleTypeId = @SampleTypeId and AttrId = @AttrId)
END
GO
