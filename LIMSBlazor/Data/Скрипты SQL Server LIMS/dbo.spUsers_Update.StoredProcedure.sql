USE [LIMS]
GO
/****** Object:  StoredProcedure [dbo].[spUsers_Update]    Script Date: 11.03.2021 19:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spUsers_Update]

	@Id int,
	@Name varchar(50),
	@FullName varchar(100),
	@PhoneNumber varchar(50),
	@Password varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

UPDATE       Users
SET                Name = @Name, FullName = @FullName, PhoneNumber = @PhoneNumber, Password = @Password
WHERE (Id = @Id)
END
GO
