USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertReserva]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertReserva]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Frutillitas].[InsertReserva]	
@fechaDesde datetime,
@fechaHasta datetime,
@regimenCodigo numeric(18, 0),
@hotelId int,
@estadoId int,
@clienteId int,
@fechaCreacion datetime
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @id int
	
	INSERT INTO [Frutillitas].[Reserva](fechaDesde, fechaHasta, regimenCodigo, hotelId, estadoId, clienteId, fechaCreacion)
	VALUES (@fechaDesde, @fechaHasta, @regimenCodigo, @hotelId, @estadoId, @clienteId, @fechaCreacion)
		
	SET @id = SCOPE_IDENTITY()
	SELECT @id
END 
GO
