USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetListadoHabitacionCantidad]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetListadoHabitacionCantidad]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Frutillitas].[GetListadoHabitacionCantidad]
@fechaDesde datetime,
@fechaHasta datetime
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT TOP 5 (SELECT [descripcion] FROM [Frutillitas].[TipoHabitacion] WHERE [codigo] = tph.[tipoHabitacionCodigo]) as [Habitacion], (SELECT [nombre] FROM [Frutillitas].[Hotel] WHERE [id] = r.[hotelId]) as [Hotel], COUNT(1) as [CantVecesOcupadas]
	FROM [Frutillitas].[ReservaTipoHabitacion] tph
	INNER JOIN [Frutillitas].[Reserva] r ON r.[codigo] = tph.[reservaCodigo]
	WHERE [estadoId] = 6 AND r.[fechaDesde] BETWEEN @fechaDesde AND @fechaHasta
	GROUP BY tph.[tipoHabitacionCodigo], r.[hotelId]
	ORDER BY COUNT(1) DESC
END
GO