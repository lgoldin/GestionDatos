USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetReservasPosteriores]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetReservasPosteriores]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Frutillitas].[GetReservasPosteriores]
@codigo numeric(18,0),
@clienteId int
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT
		r.codigo
	FROM [Frutillitas].[Reserva] r
	WHERE 
		r.fechaDesde > (SELECT fechaDesde FROM [Frutillitas].[Reserva] WHERE codigo = @codigo) AND
		r.clienteId = @clienteId
END
GO
