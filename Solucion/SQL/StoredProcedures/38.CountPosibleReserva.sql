USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[CountPosibleReserva]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[CountPosibleReserva]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Frutillitas].[CountPosibleReserva]
@hotelId int,
@fechaDesde datetime,
@fechaHasta datetime,
@tipoHabitacionCodigo numeric(18, 0)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT COUNT(DISTINCT hab.id)
	FROM [Frutillitas].[Habitacion] hab	
	WHERE hab.hotelId = @hotelId
		AND NOT EXISTS (SELECT 1 FROM [Frutillitas].[HotelInhabilitacion] WHERE [hotelId] = hab.hotelId AND (@fechaDesde BETWEEN [fechaInicio] AND [fechaFin] OR @fechaHasta BETWEEN [fechaInicio] AND [fechaFin]))
		AND hab.tipoCodigo = @tipoHabitacionCodigo
		AND hab.id NOT IN (
			SELECT DISTINCT hab2.id
			FROM [Frutillitas].[Habitacion] hab2
			JOIN [Frutillitas].[Reserva] res ON res.hotelId = hab2.hotelId
			JOIN [Frutillitas].[ReservaTipoHabitacion] resTipo ON resTipo.tipoHabitacionCodigo = hab2.tipoCodigo AND resTipo.reservaCodigo = res.codigo
			WHERE hab2.hotelId = @hotelId
				AND hab2.tipoCodigo = @tipoHabitacionCodigo 
				AND ((res.fechaDesde BETWEEN @fechaDesde AND @fechaHasta) OR 
					(res.fechaDesde BETWEEN @fechaDesde AND @fechaHasta))
				AND res.estadoId = 1 OR res.estadoId = 2)
END
GO