USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetHotelCargoEstrella]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetHotelCargoEstrella]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Frutillitas].[GetHotelCargoEstrella]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT TOP 1 [incremento]
	FROM [GD2C2014].[Frutillitas].[HotelIncrementoEstrella]
END
GO