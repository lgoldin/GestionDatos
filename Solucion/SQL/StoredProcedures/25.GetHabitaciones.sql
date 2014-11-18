USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetHabitaciones]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetHabitaciones]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Frutillitas].[GetHabitaciones]
@frente bit = null,
@numero numeric(18,0) = null,
@piso numeric(18,0) = null,
@descripcion nvarchar(255) = null,
@hotelId int = null,
@tipoHabitacion int = null,
@activa bit = null
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT
		habitacion.*,
		tipo.codigo AS CodigoTipoHabitacion,
		tipo.descripcion AS DescripcionTipoHabitacion,
		tipo.porcentual AS Porcentual,
		tipo.cantHuespedes AS CantidadHuespedes,
		hotel.id AS IdHotel,
		hotel.nombre AS Nombre,
		hotel.direccion AS Direccion,
		hotel.estrellas AS Estrellas,
		hotel.recargaEstrella AS RecargaEstrella,
		hotel.mail AS Mail,
		hotel.fechaCreacion AS FechaCreacion,
		hotel.telefono AS Telefono,
		c.id AS CiudadId,
		c.nombre AS CiudadNombre,
		p.id AS PaisId,
		p.nombre AS PaisNombre,
		p.nacionalidad AS PaisNacionalidad
	FROM [Frutillitas].Habitacion habitacion
	INNER JOIN [Frutillitas].TipoHabitacion tipo ON tipo.codigo = habitacion.tipoCodigo
	INNER JOIN [Frutillitas].Hotel hotel ON hotel.id = habitacion.hotelId
	LEFT JOIN [Frutillitas].Ciudad c ON c.id = hotel.ciudadId
	LEFT JOIN [Frutillitas].Pais p ON p.id = c.paisId
	WHERE
		(@frente IS NULL OR habitacion.frente = @frente) AND
		(@activa IS NULL OR habitacion.activa = @activa) AND
		(@numero IS NULL OR habitacion.numero = @numero) AND
		(@piso IS NULL OR habitacion.piso = @piso) AND
		(@descripcion IS NULL OR habitacion.descripcion LIKE '%' + @descripcion + '%') AND
		(@hotelId IS NULL OR habitacion.hotelId = @hotelId) AND
		(@tipoHabitacion IS NULL OR habitacion.tipoCodigo = @tipoHabitacion)
END
