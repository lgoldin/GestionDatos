USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[UpdateUsuario]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[UpdateUsuario]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[UpdateUsuario]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[UpdateUsuario]
@id int,
@username nvarchar(255),
@password varbinary(max),
@nombre nvarchar(255),
@apellido nvarchar(255),
@tipoDocumentoId int,
@numeroDocumento numeric(18,0),
@mail nvarchar(255),
@telefono nvarchar(255),
@direccion nvarchar(255),
@fechaNacimiento smalldatetime,
@rolId int,
@habilitado bit
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [Frutillitas].[Usuario]
	SET
		username = @username,
		password = @password,
		nombre = @nombre,
		apellido = @apellido,
		tipoDocumentoId = @tipoDocumentoId,
		numeroDocumento = @numeroDocumento,
		mail = @mail,
		telefono = @telefono,
		direccion = @direccion,
		fechaNacimiento = @fechaNacimiento,
		habilitado = @habilitado
	WHERE id = @id
	
	UPDATE [Frutillitas].[UsuarioRol] SET rolId = @rolId WHERE usuarioId = @id
	
	DELETE FROM [Frutillitas].[UsuarioHotel]  WHERE usuarioId = @id
END
' 
END
GO
