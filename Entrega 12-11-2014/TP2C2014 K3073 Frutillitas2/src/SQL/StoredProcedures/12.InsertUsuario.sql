USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertUsuario]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertUsuario]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertUsuario]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[InsertUsuario]
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
@rolId int
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [Frutillitas].[Usuario]
	(
		username,
		password,
		habilitado,
		nombre,
		apellido,
		tipoDocumentoId,
		numeroDocumento,
		mail,
		telefono,
		direccion,
		fechaNacimiento
	)
	VALUES
	(
		@username,
		@password,
		1,
		@nombre,
		@apellido,
		@tipoDocumentoId,
		@numeroDocumento,
		@mail,
		@telefono,
		@direccion,
		@fechaNacimiento
	)
	
	DECLARE @IdUsuario int
	SET @IdUsuario = SCOPE_IDENTITY()
	
	INSERT INTO [Frutillitas].[UsuarioRol] VALUES (@IdUsuario, @rolId)
	
	SELECT @IdUsuario
END
' 
END
GO
