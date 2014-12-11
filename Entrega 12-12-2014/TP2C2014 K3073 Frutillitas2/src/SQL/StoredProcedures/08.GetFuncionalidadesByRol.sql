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
      rf.[funcionalidadId] AS [funcionalidadId],
      f.[nombre] AS [nombre]
  FROM [GD2C2014].[Frutillitas].[RolFuncionalidad] rf
  INNER JOIN [Frutillitas].[Funcionalidad] f ON rf.funcionalidadId = f.id
  WHERE [rolId] = @rolId
END
' 
END
GO
