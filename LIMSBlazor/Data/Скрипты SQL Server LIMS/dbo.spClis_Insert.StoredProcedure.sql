USE [LIMS]
GO
/****** Object:  StoredProcedure [dbo].[spClis_Insert]    Script Date: 11.03.2021 19:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spClis_Insert]
	-- Add the parameters for the stored procedure here
	@Name varchar(50),
	@FullName varchar(100),
	@PhoneNumber varchar(50),
	@Organization varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Clients (Name, FullName, PhoneNumber, Organization) VALUES (@Name, @FullName, @PhoneNumber, @Organization)
END
GO
