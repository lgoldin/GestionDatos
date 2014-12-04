USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetHoteles]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetHoteles]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Frutillitas].[GetHoteles]

@nombre nvarchar(255) = null,
@estrellas int = null,
@paisId int = null,
@ciudadId int = null

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
	WHERE 
		(@nombre IS NULL OR h.nombre LIKE '%' + @nombre + '%') AND
		(@estrellas IS NULL OR h.estrellas = @estrellas) AND
		(@ciudadId IS NULL OR c.id = @ciudadId) AND
		(@paisId IS NULL OR p.id = @paisId)

END
GO
