use GD2C2014
USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetUsuarioByUsernameAndPassword]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetUsuarioByUsernameAndPassword]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Frutillitas].[GetUsuarioByUsernameAndPassword]
@username nvarchar(255),
@password varbinary(max)
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
	LEFT JOIN [Frutillitas].TipoDocumento td ON td.id = u.tipoDocumentoId
	INNER JOIN [Frutillitas].UsuarioRol ur ON ur.usuarioId = u.id
	INNER JOIN [Frutillitas].Rol r ON r.id = ur.rolId
	WHERE 
		u.username = @username AND
		u.password = @password
END
GO
