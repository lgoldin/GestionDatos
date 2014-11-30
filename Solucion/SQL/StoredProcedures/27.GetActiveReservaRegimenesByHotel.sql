use GD2C2014
USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetActiveReservaRegimenesByHotelId]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetActiveReservaRegimenesByHotelId]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Frutillitas].[GetActiveReservaRegimenesByHotelId]
@hotelId int,
@fecha datetime
AS
BEGIN
	SET NOCOUNT ON;
	SELECT DISTINCT reg.descripcion AS descripcion, reg.codigo AS codigo	
	FROM [Frutillitas].Reserva res
	INNER JOIN [Frutillitas].Regimen reg
	ON res.regimenCodigo = reg.codigo
	WHERE
	res.hotelId = @hotelId AND
	res.estadoId <> 3 AND
	res.estadoId <> 4 AND
	res.estadoId <> 5 AND
	(res.fechaDesde > @fecha OR
	(res.fechaDesde < @fecha AND res.fechaHasta > @fecha))

END
GO
