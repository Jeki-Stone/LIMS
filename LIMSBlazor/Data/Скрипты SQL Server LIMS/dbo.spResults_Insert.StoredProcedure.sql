USE [LIMS]
GO
/****** Object:  StoredProcedure [dbo].[spResults_Insert]    Script Date: 11.03.2021 19:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spResults_Insert]
	-- Add the parameters for the stored procedure here
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

    -- Insert statements for procedure here
	INSERT INTO Results (SampleId, AnalyticalServiceId, ValueNo, Value, IsFinal, Note, CreateTime, UpdateTime, CreateUser, UpdateUser) 
	VALUES (@SampleId, @AnalyticalServiceId, @ValueNo, @Value, @IsFinal, @Note, @CreateTime, @UpdateTime, @CreateUser, @UpdateUser)
END
GO
