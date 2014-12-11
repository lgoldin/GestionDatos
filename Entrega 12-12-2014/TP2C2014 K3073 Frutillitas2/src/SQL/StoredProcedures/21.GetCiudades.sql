USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetCiudades]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetCiudades]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetCiudades]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[GetCiudades]

AS
BEGIN
	SET NOCOUNT ON;
	
SELECT [id]
      ,[nombre]
	  ,[paisId]
  FROM [GD2C2014].[Frutillitas].[Ciudad]
END
' 
END
GO
