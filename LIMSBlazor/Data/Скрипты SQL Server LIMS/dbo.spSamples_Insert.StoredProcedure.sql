USE [LIMS]
GO
/****** Object:  StoredProcedure [dbo].[spSamples_Insert]    Script Date: 11.03.2021 19:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSamples_Insert]
	-- Add the parameters for the stored procedure here
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
	@FinalizeTime datetime,
	@Id int out
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    INSERT INTO Samples
                         (RecieveTime, TestTime, ClientId, SampleTypeId, Status, IsFinal, Note, LocationId, LastEditComment, CreateTime, UpdateTime, CreateUser, UpdateUser, FinalizeUser, FinalizeTime)
VALUES        (@RecieveTime, @TestTime, @ClientId, @SampleTypeId, @Status, @IsFinal, @Note, @LocationId, @LastEditComment, @CreateTime, @UpdateTime, @CreateUser, @UpdateUser, @FinalizeUser, @FinalizeTime)
	--Вернём Новый ID
	SET @Id = @@Identity

	-- Заолним таблицу SampleAnaliticals
	INSERT INTO SampleAnalyticals(SampleId, AnalyticalServiceId)
	SELECT @Id, [AnalyticalServiceId] FROM [dbo].[SampleTypeAnalyticals] WHERE SampleTypeId = @SampleTypeId
END
GO
