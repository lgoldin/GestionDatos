USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertEstadiaConsumible]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertEstadiaConsumible]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertEstadiaConsumible]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[InsertEstadiaConsumible]
@consumibleCodigo numeric(18,0),
@idEstadia int
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [Frutillitas].[EstadiaConsumible]
	(
		estadiaId,
		consumibleCodigo
	)
	VALUES
	(
		@idEstadia,
		@consumibleCodigo
	)
END
' 
END
GO
