USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetListadoHotelesFueraDeServicio]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetListadoHotelesFueraDeServicio]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Frutillitas].[GetListadoHotelesFueraDeServicio]
@fechaDesde datetime,
@fechaHasta datetime
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT TOP 5 (SELECT [nombre] FROM [Frutillitas].[Hotel] WHERE [id] = hi.[hotelId]) as [Hotel], SUM(DATEDIFF(DAY, hi.[fechaInicio], hi.[fechaFin])) as [CantFueraDeServicio]
	FROM [Frutillitas].[HotelInhabilitacion] hi
	WHERE hi.[fechaInicio] BETWEEN @fechaDesde AND @fechaHasta
	GROUP BY hi.[hotelId]
	ORDER BY SUM(DATEDIFF(DAY, [fechaInicio], [fechaFin])) DESC
END
GO