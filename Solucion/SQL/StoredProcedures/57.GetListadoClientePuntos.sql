USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetListadoClientePuntos]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetListadoClientePuntos]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Frutillitas].[GetListadoClientePuntos]
@fechaDesde datetime,
@fechaHasta datetime
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT TOP 5 (SELECT [nombre] + ' ' + [apellido] FROM [Frutillitas].[Cliente] WHERE [id] = f.[clienteId]) as [Cliente], SUM(fi.[precio] / (CASE WHEN LEFT(fi.[descripcion], 11) = 'Consumible:' THEN 5 WHEN LEFT(fi.[descripcion], 9) = 'Descuento' THEN 5 WHEN LEFT(fi.[descripcion], 8) = 'Estadia:' THEN 10 END)) as [Puntos]
	FROM [Frutillitas].[Factura] f
	INNER JOIN [Frutillitas].[FacturaItem] fi ON fi.[facturaNumero] = f.[numero]
	WHERE f.[fecha] BETWEEN @fechaDesde AND @fechaHasta
	GROUP BY f.[clienteId]
	ORDER BY SUM(fi.[precio] / (CASE WHEN LEFT(fi.[descripcion], 11) = 'Consumible:' THEN 5 WHEN LEFT(fi.[descripcion], 9) = 'Descuento' THEN 5 WHEN LEFT(fi.[descripcion], 8) = 'Estadia:' THEN 10 END)) DESC
END
GO