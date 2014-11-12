USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetTiposDocumento]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetTiposDocumento]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetTiposDocumento]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[GetTiposDocumento]
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT
		id AS Id,
		nombre AS Nombre
	FROM [Frutillitas].TipoDocumento
END
' 
END
GO
