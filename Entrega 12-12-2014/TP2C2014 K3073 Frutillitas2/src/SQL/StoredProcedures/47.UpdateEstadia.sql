USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[UpdateEstadia]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[UpdateEstadia]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Frutillitas].[UpdateEstadia]
@estadiaId int,
@codigoReserva numeric(18,0),
@usuarioId int
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [Frutillitas].[Estadia]
	SET
		fechaHasta = GETDATE(),
		usuarioCheckOutId = @usuarioId
	WHERE
		reservaCodigo = @codigoReserva AND
		id = @estadiaId
END
GO
