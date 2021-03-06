USE [LIMS]
GO
/****** Object:  StoredProcedure [dbo].[spSampleAttrs_Update]    Script Date: 11.03.2021 19:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleAttrs_Update]
	-- Add the parameters for the stored procedure here
	@SampleId int, 
	@AttrId int,
	@OldAttrId int,
	@Value varchar(100), 
	@CreateTime datetime, 
	@UpdateTime datetime, 
	@CreateUser varchar(50), 
	@UpdateUser varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE SampleAttrs  SET AttrId = @AttrId, Value = @Value, CreateTime = @CreateTime, UpdateTime = @UpdateTime, CreateUser = @CreateUser, UpdateUser = @UpdateUser
	WHERE (SampleId = @SampleId and AttrId = @OldAttrId)
END
GO
