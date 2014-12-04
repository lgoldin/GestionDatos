USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetActiveReservaBetweenDatesByHotel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetActiveReservaBetweenDatesByHotel]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Frutillitas].[GetActiveReservaBetweenDatesByHotel]
@hotelId int,
@fechaDesde smalldatetime,
@fechaHasta smalldatetime
AS
BEGIN
	SET NOCOUNT ON;
	SELECT res.codigo
	FROM [Frutillitas].Reserva res
	WHERE
	res.hotelId = @hotelId AND
	res.estadoId <> 3 AND
	res.estadoId <> 4 AND
	res.estadoId <> 5 AND
	((res.fechaDesde between @fechaDesde and @fechaHasta) or 
	(res.fechaHasta between @fechaDesde and @fechaHasta))

END
GO
