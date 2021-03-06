USE [LIMS]
GO
/****** Object:  StoredProcedure [dbo].[spSamples_GetOne]    Script Date: 11.03.2021 19:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSamples_GetOne]
	-- Add the parameters for the stored procedure here
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT        Id, RecieveTime, TestTime, ClientId, SampleTypeId, Status, IsFinal, Note, LocationId, LastEditComment, CreateTime, UpdateTime, CreateUser, UpdateUser, FinalizeUser, FinalizeTime
FROM            Samples
WHERE        (Id = @Id)
END
GO
