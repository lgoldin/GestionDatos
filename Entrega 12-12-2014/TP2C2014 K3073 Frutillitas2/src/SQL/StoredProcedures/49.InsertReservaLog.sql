USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertReservaLog]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertReservaLog]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Frutillitas].[InsertReservaLog]
@reservaCodigo [numeric](18, 0),
@fecha datetime,
@usuarioId int,
@tipoId int,
@motivo nvarchar(255)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [Frutillitas].[ReservaLog] ([reservaCodigo], [fecha], [usuarioId], [tipoId], [motivo])
	VALUES (@reservaCodigo, @fecha, @usuarioId, @tipoId, @motivo)
END
GO