USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetHotelesByIdUsuario]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetHotelesByIdUsuario]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Frutillitas].[GetHotelesByIdUsuario]
@idUsuario int
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT
		h.id AS Id,
		h.nombre AS Nombre,
		c.id AS CiudadId,
		c.nombre AS CiudadNombre,
		p.id AS PaisId,
		p.nombre AS PaisNombre,
		p.nacionalidad AS PaisNacionalidad,
		h.direccion AS Direccion,
		h.estrellas AS Estrellas,
		h.mail AS Mail,
		h.fechaCreacion AS FechaCreacion,
		h.telefono AS Telefono
	FROM [Frutillitas].Hotel h
	LEFT JOIN [Frutillitas].Ciudad c ON c.id = h.ciudadId
	LEFT JOIN [Frutillitas].Pais p ON p.id = c.paisId
	INNER JOIN [Frutillitas].[UsuarioHotel] uh ON uh.hotelId = h.id
	WHERE 
		uh.usuarioId = @idUsuario

END
GO
