use GD2C2014
USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetUsuarios]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetUsuarios]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Frutillitas].[GetUsuarios]
@username nvarchar(255) = null,
@nombre nvarchar(255) = null,
@apellido nvarchar(255) = null,
@tipoDocumentoId int = null,
@numeroDocumento numeric(18,0) = null,
@mail nvarchar(255) = null,
@telefono nvarchar(255) = null,
@direccion nvarchar(255) = null,
@fechaNacimiento smalldatetime = null,
@rolId int = null
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT 
		u.*,
		td.id AS TipoDocumentoId,
		td.nombre AS TipoDocumentoNombre,
		r.id AS rolId,
		r.nombre AS rol
	FROM [Frutillitas].Usuario u
	INNER JOIN [Frutillitas].TipoDocumento td ON td.id = u.tipoDocumentoId
	INNER JOIN [Frutillitas].UsuarioRol ur ON ur.usuarioId = u.id
	INNER JOIN [Frutillitas].Rol r ON r.id = ur.rolId
	WHERE 
		(@username IS NULL OR u.username LIKE '%' + @username + '%') AND
		(@nombre IS NULL OR u.nombre LIKE '%' + @nombre + '%') AND
		(@apellido IS NULL OR u.apellido LIKE '%' + @apellido + '%') AND
		(@tipoDocumentoId IS NULL OR u.tipoDocumentoId = @tipoDocumentoId) AND
		(@numeroDocumento IS NULL OR u.numeroDocumento = @numeroDocumento) AND
		(@mail IS NULL OR u.mail LIKE '%' + @mail + '%') AND
		(@telefono IS NULL OR u.telefono LIKE '%' + @telefono + '%') AND
		(@direccion IS NULL OR u.direccion LIKE '%' + @direccion + '%') AND
		(@fechaNacimiento IS NULL OR u.fechaNacimiento = @fechaNacimiento) AND
		(@rolId IS NULL OR r.id = @rolId)
END
GO
