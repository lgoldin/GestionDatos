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
@codigo [numeric](18, 0)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT res.[codigo], res.[fechaDesde], res.[fechaHasta], res.[regimenCodigo]
	FROM [Frutillitas].[Reserva] res
	WHERE res.[codigo] = @codigo
END
GO
