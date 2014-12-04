USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetReservasVencidas]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetReservasVencidas]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Frutillitas].[GetReservasVencidas]
@fecha smalldatetime
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT
		r.codigo
	FROM [Frutillitas].[Reserva] r
	WHERE 
		r.fechaDesde < @fecha AND
		r.estadoId IN (1, 2)
END
GO
