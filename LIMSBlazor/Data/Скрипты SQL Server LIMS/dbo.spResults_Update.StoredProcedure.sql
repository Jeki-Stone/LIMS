USE [LIMS]
GO
/****** Object:  StoredProcedure [dbo].[spResults_Update]    Script Date: 11.03.2021 19:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spResults_Update]
	@Id int,
	@SampleId int,
	@AnalyticalServiceId int,
	@ValueNo int,
	@Value float,
	@IsFinal int,
	@Note text,
	@CreateTime datetime,
	@UpdateTime datetime,
	@CreateUser varchar(50),
	@UpdateUser varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

UPDATE       Results
SET                SampleId = @SampleId, AnalyticalServiceId = @AnalyticalServiceId, ValueNo = @ValueNo, Value = @Value, IsFinal = @IsFinal, Note = @Note, CreateTime = @CreateTime, UpdateTime = @UpdateTime, CreateUser = @CreateUser, UpdateUser = @UpdateUser
WHERE (Id = @Id)
END
GO
