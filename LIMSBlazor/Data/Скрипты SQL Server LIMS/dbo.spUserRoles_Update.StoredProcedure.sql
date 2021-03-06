USE [LIMS]
GO
/****** Object:  StoredProcedure [dbo].[spUserRoles_Update]    Script Date: 11.03.2021 19:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spUserRoles_Update]
	-- Add the parameters for the stored procedure here
	@LabId int,
	@UserId int,
	@RoleId int,
	@OldLabId int,
	@OldRoleId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE UserRoles  SET LabId = @LabId,  UserId = @UserId,  RoleId = @RoleId
	WHERE (LabId = @OldLabId and UserId = @UserId and RoleId = @OldRoleId)
END
GO
