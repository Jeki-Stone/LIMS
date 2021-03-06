USE [LIMS]
GO
/****** Object:  StoredProcedure [dbo].[spSamples_Update]    Script Date: 11.03.2021 19:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSamples_Update]
	-- Add the parameters for the stored procedure here
	@Id int,
	@RecieveTime datetime,
	@TestTime datetime,
	@ClientId int,
	@SampleTypeId int,
	@Status int,
	@IsFinal bit,
	@Note text,
	@LocationId int,
	@LastEditComment varchar(500),
	@CreateTime datetime,
	@UpdateTime datetime,
	@CreateUser varchar(50),
	@UpdateUser varchar(50),
	@FinalizeUser varchar(50),
	@FinalizeTime datetime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
UPDATE       Samples
SET                RecieveTime = @RecieveTime, TestTime = @TestTime, ClientId = @ClientId, SampleTypeId = @SampleTypeId, Status = @Status, IsFinal = @IsFinal, Note = @Note, LocationId = @LocationId, LastEditComment = @LastEditComment, CreateTime = @CreateTime, UpdateTime = @UpdateTime, CreateUser = @CreateUser, UpdateUser = @UpdateUser, FinalizeUser = @FinalizeUser, FinalizeTime = @FinalizeTime
WHERE        (Id = @Id)

--Удалим старые значения
DELETE FROM SampleAnalyticals WHERE SampleId = @Id

-- Заолним таблицу SampleAnaliticals
INSERT INTO SampleAnalyticals(SampleId, AnalyticalServiceId)
SELECT @Id, [AnalyticalServiceId] FROM [dbo].[SampleTypeAnalyticals] WHERE SampleTypeId = @SampleTypeId

END
GO
