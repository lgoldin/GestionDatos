USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetFuncionalidadesByRol]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetFuncionalidadesByRol]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetFuncionalidadesByRol]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[GetFuncionalidadesByRol]

@rolId int

AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT
      [funcionalidadId]
  FROM [GD2C2014].[Frutillitas].[RolFuncionalidad]
  WHERE [rolId] = @rolId
END
' 
END
GO
