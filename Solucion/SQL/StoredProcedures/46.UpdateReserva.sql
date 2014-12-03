USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[UpdateReserva]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[UpdateReserva]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Frutillitas].[UpdateReserva]	
@codigo numeric(18, 0),
@fechaDesde datetime,
@fechaHasta datetime,
@regimenCodigo numeric(18, 0),
@hotelId int
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [Frutillitas].[Reserva]
	SET fechaDesde = @fechaDesde,
		fechaHasta = @fechaHasta,
		regimenCodigo = @regimenCodigo,
		hotelId = @hotelId,
		estadoId = 2
	WHERE codigo = @codigo
END 
GO
