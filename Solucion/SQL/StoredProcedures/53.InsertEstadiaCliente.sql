USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertEstadiaCliente]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertEstadia]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Frutillitas].[InsertEstadiaCliente]
@estadiaId int,
@clienteId int
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [Frutillitas].[EstadiaCliente]
           ([estadiaId]
           ,[clienteId])
     VALUES
           (@estadiaId
           ,@clienteId)

END
GO
