USE [LIMS]
GO
/****** Object:  StoredProcedure [dbo].[spLabs_Update]    Script Date: 11.03.2021 19:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spLabs_Update]
	-- Add the parameters for the stored procedure here
	@Id int,
	@Code varchar(50),
	@Name varchar(50),
	@LocId int,
	@Description varchar(500)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
UPDATE       Labs
SET                Code = @Code, Name = @Name, LocId = @LocId, Description = @Description
WHERE        (Id = @Id)

END
GO
