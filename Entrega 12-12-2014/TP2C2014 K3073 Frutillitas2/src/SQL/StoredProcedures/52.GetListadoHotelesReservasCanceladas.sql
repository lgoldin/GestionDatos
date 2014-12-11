USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetListadoHotelesReservasCanceladas]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetListadoHotelesReservasCanceladas]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Frutillitas].[GetListadoHotelesReservasCanceladas]
@fechaDesde datetime,
@fechaHasta datetime
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT TOP 5 (SELECT [nombre] FROM [Frutillitas].[Hotel] WHERE [id] = r.[hotelId]) as [Hotel], COUNT(1) as [CantReservasCanceladas]
	FROM [Frutillitas].[Reserva] r
	WHERE ([estadoId] = 3 OR r.[estadoId] = 4 OR r.[estadoId] = 5) AND r.[fechaDesde] BETWEEN @fechaDesde AND @fechaHasta
	GROUP BY r.[hotelId]
	ORDER BY COUNT(1) DESC
END
GO