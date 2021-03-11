USE [LIMS]
GO
/****** Object:  StoredProcedure [dbo].[spInstrumentTypeAnalyticals_Insert]    Script Date: 11.03.2021 19:03:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInstrumentTypeAnalyticals_Insert]
	-- Add the parameters for the stored procedure here
	@InstrumentTypeId int,
	@AnalyticalServiceId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO InstrumentTypeAnalyticals (InstrumentTypeId, AnalyticalServiceId) 
	VALUES (@InstrumentTypeId, @AnalyticalServiceId)
END
GO
