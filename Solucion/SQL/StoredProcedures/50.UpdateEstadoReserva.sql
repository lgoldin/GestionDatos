USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[UpdateEstadoReserva]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[UpdateEstadoReserva]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Frutillitas].[UpdateEstadoReserva]
@codigo numeric(18, 0),
@estadoId int
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [Frutillitas].[Reserva] SET [estadoId] = @estadoId
	WHERE [codigo] = @codigo
END
GO