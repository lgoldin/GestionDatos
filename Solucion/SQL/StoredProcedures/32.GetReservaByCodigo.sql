USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetReservaByCodigo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetReservaByCodigo]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Frutillitas].[GetReservaByCodigo]
@codigo [numeric](18, 0),
@hotelId int = null
AS
BEGIN
	SET NOCOUNT ON;
	SELECT res.[codigo], res.[fechaDesde], res.[fechaHasta], res.[regimenCodigo], res.[hotelId], res.[clienteId]
	FROM [Frutillitas].[Reserva] res
	WHERE 
		res.[codigo] = @codigo AND 
		(@hotelId IS NULL OR res.hotelId = @hotelId) AND
		res.estadoId IN (1,2)
END
GO
