USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetUsuarios]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetUsuarios]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetUsuarios]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[GetUsuarios]
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
END
' 
END
GO
