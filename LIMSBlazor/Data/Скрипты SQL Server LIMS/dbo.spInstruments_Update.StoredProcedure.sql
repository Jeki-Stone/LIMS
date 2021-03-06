USE [LIMS]
GO
/****** Object:  StoredProcedure [dbo].[spInstruments_Update]    Script Date: 11.03.2021 19:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInstruments_Update]

	@Id int,
	@Name varchar(50),
	@InstrumentTypeId int,
	@SerialNumber varchar(50),
	@Description varchar(500),
	@LabId int,
	@Status int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

UPDATE       Instruments
SET                Name = @Name, InstrumentTypeId = @InstrumentTypeId, SerialNumber = @SerialNumber, Description = @Description, LabId = @LabId, Status = @Status
WHERE (Id = @Id)

--Удалим старые значения
DELETE FROM InstrumentAnalyticals WHERE InstrumentId = @Id

-- Заолним таблицу InstrumentAnaliticals
INSERT INTO InstrumentAnalyticals(InstrumentId, AnalyticalServiceId)
SELECT @Id, [AnalyticalServiceId] FROM [dbo].[InstrumentTypeAnalyticals] WHERE InstrumentTypeId = @InstrumentTypeId
END
GO
