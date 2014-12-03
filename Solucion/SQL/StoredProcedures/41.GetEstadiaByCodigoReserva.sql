USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetEstadiaByCodigoReserva]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetEstadiaByCodigoReserva]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetEstadiaByCodigoReserva]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[GetEstadiaByCodigoReserva]
@codigoReserva numeric(18,0),
@hotelId numeric(18,0)
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT
		e.*
	FROM [Frutillitas].[Estadia] e
	INNER JOIN [Frutillitas].[Reserva] r ON e.reservaCodigo = r.codigo
	WHERE
		e.reservaCodigo = @codigoReserva AND
		r.hotelId = @hotelId
END
' 
END
GO
