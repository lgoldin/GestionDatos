USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetConsumiblesByIdEstadia]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetConsumiblesByIdEstadia]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetConsumiblesByIdEstadia]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[GetConsumiblesByIdEstadia]
@idEstadia int
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT
		c.*
	FROM [Frutillitas].[EstadiaConsumible] e
	LEFT JOIN [Frutillitas].[Consumible] c ON c.codigo = e.consumibleCodigo
	WHERE
		e.estadiaId = @idEstadia
END
' 
END
GO
