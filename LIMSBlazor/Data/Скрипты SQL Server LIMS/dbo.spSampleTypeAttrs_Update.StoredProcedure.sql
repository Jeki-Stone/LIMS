USE [LIMS]
GO
/****** Object:  StoredProcedure [dbo].[spSampleTypeAttrs_Update]    Script Date: 11.03.2021 19:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleTypeAttrs_Update]
	-- Add the parameters for the stored procedure here
	@SampleTypeId int,
	@OldAttrId int,
	@AttrId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE SampleTypeAttrs  SET SampleTypeId = @SampleTypeId, AttrId = @AttrId 
	WHERE (SampleTypeId = @SampleTypeId and AttrId = @OldAttrId)
END
GO
