USE [LIMS]
GO
/****** Object:  StoredProcedure [dbo].[spResults_GetOne]    Script Date: 11.03.2021 19:03:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spResults_GetOne]
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT Id, SampleId, AnalyticalServiceId, ValueNo, Value, IsFinal, Note, CreateTime, UpdateTime, CreateUser, UpdateUser
FROM Results
WHERE (Id = @Id)
END
GO
