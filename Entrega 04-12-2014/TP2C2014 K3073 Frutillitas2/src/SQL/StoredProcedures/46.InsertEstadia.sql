USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertEstadia]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertEstadia]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Frutillitas].[InsertEstadia]
@codigoReserva numeric(18,0),
@usuarioId int
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [Frutillitas].[Estadia]
	(
		reservaCodigo,
		fechaDesde,
		fechaHasta,
		usuarioCheckInId,
		usuarioCheckOutId	
	)
	VALUES
	(
		@codigoReserva,
		GETDATE(),
		null,
		@usuarioId,
		null
	)
	
	DECLARE @id int
	set @id = SCOPE_IDENTITY()
	select @id
END
GO
