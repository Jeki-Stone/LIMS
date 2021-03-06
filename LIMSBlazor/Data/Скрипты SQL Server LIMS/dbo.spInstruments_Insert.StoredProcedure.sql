USE [LIMS]
GO
/****** Object:  StoredProcedure [dbo].[spInstruments_Insert]    Script Date: 11.03.2021 19:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInstruments_Insert]
	-- Add the parameters for the stored procedure here
	@Name varchar(50),
	@InstrumentTypeId int,
	@SerialNumber varchar(50),
	@Description varchar(500),
	@LabId int,
	@Status int,
	@Id int out
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Instruments (Name, InstrumentTypeId, SerialNumber, Description, LabId, Status) 
	VALUES (@Name, @InstrumentTypeId, @SerialNumber, @Description, @LabId, @Status)

	--Вернём Новый ID
	SET @Id = @@Identity

	-- Заолним таблицу InstrumentAnaliticals
	INSERT INTO InstrumentAnalyticals(InstrumentId, AnalyticalServiceId)
	SELECT @Id, [AnalyticalServiceId] FROM [dbo].[InstrumentTypeAnalyticals] WHERE InstrumentTypeId = @InstrumentTypeId
END
GO
