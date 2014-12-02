USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetConsumibles]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetConsumibles]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetConsumibles]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[GetConsumibles]
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT
		*
	FROM [Frutillitas].[Consumible]
END
' 
END
GO
