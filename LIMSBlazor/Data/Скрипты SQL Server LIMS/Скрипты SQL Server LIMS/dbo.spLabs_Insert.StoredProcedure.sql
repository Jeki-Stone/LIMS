USE [LIMS]
GO
/****** Object:  StoredProcedure [dbo].[spLabs_Insert]    Script Date: 11.03.2021 19:03:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spLabs_Insert]
	-- Add the parameters for the stored procedure here
	@Code varchar(50),
	@Name varchar(50),
	@LocId int,
	@Description varchar(500)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
INSERT INTO Labs (Code, Name, LocId, Description) VALUES (@Code, @Name, @LocId, @Description)

END
GO
