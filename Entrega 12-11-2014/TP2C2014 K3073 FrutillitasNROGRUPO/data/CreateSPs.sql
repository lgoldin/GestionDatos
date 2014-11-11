USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetRoles]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetRoles]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetRoles]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[GetRoles]
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT
		id AS Id,
		nombre AS Nombre,
		activo AS Activo
	FROM [Frutillitas].Rol
END
' 
END
GO
USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetTiposDocumento]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetTiposDocumento]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetTiposDocumento]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[GetTiposDocumento]
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT
		id AS Id,
		nombre AS Nombre
	FROM [Frutillitas].TipoDocumento
END
' 
END
GO
USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetHoteles]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetHoteles]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetHoteles]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[GetHoteles]
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
		h.recargaEstrella AS RecargaEstrella,
		h.mail AS Mail,
		h.fechaCreacion AS FechaCreacion
	FROM [Frutillitas].Hotel h
	LEFT JOIN [Frutillitas].Ciudad c ON c.id = h.ciudadId
	LEFT JOIN [Frutillitas].Pais p ON p.id = c.paisId
END
' 
END
GO
USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertRol]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertRol]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertRol]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[InsertRol]

@nombre varchar(255),
@activo bit

AS
BEGIN

	SET NOCOUNT ON;
	declare @id int	

	INSERT INTO [Frutillitas].[Rol]
           ([nombre]
           ,[activo])
	OUTPUT INSERTED.Id
    VALUES
           (@nombre
           ,@activo)

		   
		   set @id = SCOPE_IDENTITY()
		   select @id
END
' 
END
GO
USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertRolFuncionalidad]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertRolFuncionalidad]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertRolFuncionalidad]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[InsertRolFuncionalidad]

@rolId int,
@funcionalidadId int

AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [Frutillitas].[RolFuncionalidad]
           ([rolId]
           ,[funcionalidadId])
     VALUES
           (@rolId
           ,@funcionalidadId)
END
' 
END
GO
USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetFuncionalidades]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetFuncionalidades]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetFuncionalidades]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[GetFuncionalidades]
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT [id] 
      ,[nombre]
  FROM [Frutillitas].[Funcionalidad]
END
' 
END
GO
USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[UpdateRol]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[UpdateRol]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[UpdateRol]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[UpdateRol]

@nombre varchar(255),
@activo bit,
@id int

AS
	BEGIN
	SET NOCOUNT ON;

	UPDATE [Frutillitas].[Rol]
	   SET [nombre] = @nombre
		  ,[activo] = @activo
	 WHERE [id] = @id
	END

	DELETE FROM [Frutillitas].[RolFuncionalidad]
      WHERE [RolId] = @id

' 
END
GO
USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetFuncionalidadesByRol]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetFuncionalidadesByRol]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetFuncionalidadesByRol]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[GetFuncionalidadesByRol]

@rolId int

AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT
      [funcionalidadId]
  FROM [GD2C2014].[Frutillitas].[RolFuncionalidad]
  WHERE [rolId] = @rolId
END
' 
END
GO
USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[DeleteRol]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[DeleteRol]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[DeleteRol]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[DeleteRol]

@activo bit,
@id int

AS
	BEGIN
	SET NOCOUNT ON;

	UPDATE [Frutillitas].[Rol]
		  SET[activo] = @activo
	 WHERE [id] = @id
	END
' 
END
GO
USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetPaises]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetPaises]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetPaises]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[GetPaises]
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT [id]
      ,[nombre]
      ,[nacionalidad]
  FROM [GD2C2014].[Frutillitas].[Pais]
END
' 
END
GO
USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetCiudades]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetCiudades]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetCiudades]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[GetCiudades]

@paisId int

AS
BEGIN
	SET NOCOUNT ON;
	
SELECT [id]
      ,[nombre]
  FROM [GD2C2014].[Frutillitas].[Ciudad]
  WHERE [paisId] = @paisId
END
' 
END
GO
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
USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertUsuarioHotel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertUsuarioHotel]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertUsuarioHotel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[InsertUsuarioHotel]
@usuarioId int,
@hotelId int
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [Frutillitas].[UsuarioHotel]
	(
		usuarioId,
		hotelId
	)
	VALUES
	(
		@usuarioId,
		@hotelId
	)
	
END
' 
END
GO
USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetHotelesByIdUsuario]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetHotelesByIdUsuario]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetHotelesByIdUsuario]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[GetHotelesByIdUsuario]
@usuarioId int
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
		h.recargaEstrella AS RecargaEstrella,
		h.mail AS Mail,
		h.fechaCreacion AS FechaCreacion
	FROM [Frutillitas].UsuarioHotel uh
	INNER JOIN [Frutillitas].Hotel h ON h.id = uh.hotelId
	LEFT JOIN [Frutillitas].Ciudad c ON c.id = h.ciudadId
	LEFT JOIN [Frutillitas].Pais p ON p.id = c.paisId
	WHERE uh.usuarioId = @usuarioId
END
' 
END
GO
USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetRegimenes]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetRegimenes]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetRegimenes]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[GetRegimenes]
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT
		codigo,
		descripcion,
		activo,
		precio
	FROM [Frutillitas].[Regimen]
END
' 
END
GO
USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertHotel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertHotel]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertHotel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[InsertHotel]


@ciudadId int,
@direccion nvarchar(255),
@estrellas numeric(18, 0),
@fechaCreacion datetime,
@nombre nvarchar(255),
@recargaEstrella numeric(18, 0),
@mail nvarchar(255)

AS
BEGIN

SET NOCOUNT ON;
declare @id int

INSERT INTO [Frutillitas].[Hotel]
           ([nombre]
           ,[ciudadId]
           ,[direccion]
           ,[estrellas]
           ,[recargaEstrella]
           ,[mail]
           ,[fechaCreacion])
     VALUES
           (@nombre
		   ,@ciudadId
           ,@direccion
           ,@estrellas
           ,@recargaEstrella
           ,@mail
           ,@fechaCreacion)

		   set @id = SCOPE_IDENTITY()
		   select @id
		   
END
' 
END
GO
USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertRolFuncionalidad]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertRolFuncionalidad]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertRolFuncionalidad]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[InsertRolFuncionalidad]

@rolId int,
@funcionalidadId int

AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [Frutillitas].[RolFuncionalidad]
           ([rolId]
           ,[funcionalidadId])
     VALUES
           (@rolId
           ,@funcionalidadId)
END
' 
END
GO
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
@rolId int
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
		fechaNacimiento = @fechaNacimiento
	WHERE id = @id
	
	UPDATE [Frutillitas].[UsuarioRol] SET rolId = @rolId WHERE usuarioId = @id
	
	DELETE FROM [Frutillitas].[UsuarioHotel]  WHERE usuarioId = @id
END
' 
END
GO
USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertUsuarioHotel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertUsuarioHotel]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertUsuarioHotel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[InsertUsuarioHotel]
@usuarioId int,
@hotelId int
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [Frutillitas].[UsuarioHotel]
	(
		usuarioId,
		hotelId
	)
	VALUES
	(
		@usuarioId,
		@hotelId
	)
	
END
' 
END
GO
