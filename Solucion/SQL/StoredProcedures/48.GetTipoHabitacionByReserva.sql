USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetTipoHabitacionByReserva]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetTipoHabitacionByReserva]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Frutillitas].[GetTipoHabitacionByReserva]
@reservaCodigo [numeric](18, 0)
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT [tipoHabitacionCodigo]
	FROM [Frutillitas].[ReservaTipoHabitacion]
	WHERE [reservaCodigo] = @reservaCodigo
END
GO
