USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetReservaCountByDatesAndHotel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetReservaCountByDatesAndHotel]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetReservaCountByDatesAndHotel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[GetReservaCountByDatesAndHotel]

@fechaDesde datetime,
@fechaHasta datetime,
@hotelId int

AS
BEGIN
	SET NOCOUNT ON;
	
SELECT COUNT([codigo])
  FROM [Frutillitas].[Reserva]
  WHERE
   [hotelId] = @hotelId AND
  (([fechaDesde] >= @fechaDesde AND [fechaDesde] <= @fechaHasta) OR
  ([fechaHasta] >= @fechaDesde AND [fechaHasta] <= @fechaHasta))
END
' 
END
GO
