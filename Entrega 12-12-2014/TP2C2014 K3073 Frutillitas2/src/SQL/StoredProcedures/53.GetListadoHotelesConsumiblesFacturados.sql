USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetListadoHotelesConsumiblesFacturados]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetListadoHotelesConsumiblesFacturados]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Frutillitas].[GetListadoHotelesConsumiblesFacturados]
@fechaDesde datetime,
@fechaHasta datetime
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT TOP 5 (SELECT [nombre] FROM [Frutillitas].[Hotel] WHERE [id] = r.[hotelId]) as [Hotel], COUNT(1) as [CantConsumiblesFacturados]
	FROM [Frutillitas].[Estadia] e
	INNER JOIN [Frutillitas].[Reserva] r ON r.[codigo] = e.[reservaCodigo]
	INNER JOIN [Frutillitas].[Factura] f ON f.[estadiaId] = e.[id]
	INNER JOIN [Frutillitas].[EstadiaConsumible] ec ON ec.[estadiaId] = e.[id]
	WHERE r.[fechaDesde] BETWEEN @fechaDesde AND @fechaHasta
	GROUP BY r.[hotelId]
	ORDER BY COUNT(1) DESC
END
GO