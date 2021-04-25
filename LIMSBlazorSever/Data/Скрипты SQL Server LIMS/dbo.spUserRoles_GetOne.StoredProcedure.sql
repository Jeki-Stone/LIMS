USE [LIMS]
GO
/****** Object:  StoredProcedure [dbo].[spUserRoles_GetOne]    Script Date: 11.03.2021 19:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spUserRoles_GetOne]
	-- Add the parameters for the stored procedure here
	@LabId int,
	@UserId int,
	@RoleId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT        LabId, UserId, RoleId
FROM            UserRoles
WHERE		  (LabId = @LabId and UserId = @UserId and RoleId = @RoleId)
END
GO
