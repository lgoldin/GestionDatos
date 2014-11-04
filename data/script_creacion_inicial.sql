USE [GD2C2014]
GO
/************ CREATE TABLE AND SCHEMA ***********/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[Ciudad]') AND type in (N'U'))
DROP TABLE [Frutillitas].[Ciudad]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[Cliente]') AND type in (N'U'))
DROP TABLE [Frutillitas].[Cliente]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[Consumible]') AND type in (N'U'))
DROP TABLE [Frutillitas].[Consumible]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[Estadia]') AND type in (N'U'))
DROP TABLE [Frutillitas].[Estadia]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[EstadiaCliente]') AND type in (N'U'))
DROP TABLE [Frutillitas].[EstadiaCliente]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[EstadiaConsumible]') AND type in (N'U'))
DROP TABLE [Frutillitas].[EstadiaConsumible]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[EstadiaDetalle]') AND type in (N'U'))
DROP TABLE [Frutillitas].[EstadiaDetalle]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[Factura]') AND type in (N'U'))
DROP TABLE [Frutillitas].[Factura]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[Funcionalidad]') AND type in (N'U'))
DROP TABLE [Frutillitas].[Funcionalidad]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[Habitacion]') AND type in (N'U'))
DROP TABLE [Frutillitas].[Habitacion]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[Hotel]') AND type in (N'U'))
DROP TABLE [Frutillitas].[Hotel]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[HotelInhabilitacion]') AND type in (N'U'))
DROP TABLE [Frutillitas].[HotelInhabilitacion]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[HotelRegimen]') AND type in (N'U'))
DROP TABLE [Frutillitas].[HotelRegimen]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[Localidad]') AND type in (N'U'))
DROP TABLE [Frutillitas].[Localidad]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[Pais]') AND type in (N'U'))
DROP TABLE [Frutillitas].[Pais]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[Regimen]') AND type in (N'U'))
DROP TABLE [Frutillitas].[Regimen]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[Reserva]') AND type in (N'U'))
DROP TABLE [Frutillitas].[Reserva]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[ReservaCancelacion]') AND type in (N'U'))
DROP TABLE [Frutillitas].[ReservaCancelacion]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[ReservaEstado]') AND type in (N'U'))
DROP TABLE [Frutillitas].[ReservaEstado]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[ReservaHistorial]') AND type in (N'U'))
DROP TABLE [Frutillitas].[ReservaHistorial]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[ReservaHistorialAccion]') AND type in (N'U'))
DROP TABLE [Frutillitas].[ReservaHistorialAccion]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[ReservaTipoHabitacion]') AND type in (N'U'))
DROP TABLE [Frutillitas].[ReservaTipoHabitacion]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[Rol]') AND type in (N'U'))
DROP TABLE [Frutillitas].[Rol]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[RolFuncionalidad]') AND type in (N'U'))
DROP TABLE [Frutillitas].[RolFuncionalidad]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[TipoDocumento]') AND type in (N'U'))
DROP TABLE [Frutillitas].[TipoDocumento]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[TipoHabitacion]') AND type in (N'U'))
DROP TABLE [Frutillitas].[TipoHabitacion]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[Usuario]') AND type in (N'U'))
DROP TABLE [Frutillitas].[Usuario]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[UsuarioLog]') AND type in (N'U'))
DROP TABLE [Frutillitas].[UsuarioLog]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[UsuarioRol]') AND type in (N'U'))
DROP TABLE [Frutillitas].[UsuarioRol]
GO
IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'Frutillitas')
DROP SCHEMA [Frutillitas]
GO
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'Frutillitas')
EXEC sys.sp_executesql N'CREATE SCHEMA [Frutillitas] AUTHORIZATION [dbo]'
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[UsuarioRol]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[UsuarioRol](
	[usuarioId] [int] NULL,
	[rolId] [int] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[UsuarioLog]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[UsuarioLog](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuarioId] [int] NULL,
	[fecha] [datetime] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[Usuario]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[Usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](255) NULL,
	[password] [nvarchar](255) NULL,
	[habilitado] [bit] NULL,
	[apellido] [nvarchar](255) NULL,
	[tipoDocumentoId] [int] NULL,
	[numeroDocumento] [numeric](18, 0) NULL,
	[mail] [nvarchar](255) NULL,
	[telefono] [nvarchar](255) NULL,
	[direccion] [nvarchar](255) NULL,
	[fechaNacimiento] [datetime] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[TipoHabitacion]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[TipoHabitacion](
	[codigo] [numeric](18, 0) NULL,
	[descripcion] [nvarchar](255) NULL,
	[procentual] [numeric](18, 2) NULL,
	[cantHuespedes] [int] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[TipoDocumento]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[TipoDocumento](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](255) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[RolFuncionalidad]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[RolFuncionalidad](
	[rolId] [int] NULL,
	[funcionalidadId] [int] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[Rol]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[Rol](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](255) NULL,
	[activo] [bit] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[ReservaTipoHabitacion]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[ReservaTipoHabitacion](
	[reservaCodigo] [numeric](18, 0) NULL,
	[tipoHabitacionCodigo] [numeric](18, 0) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[ReservaHistorialAccion]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[ReservaHistorialAccion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](255) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[ReservaHistorial]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[ReservaHistorial](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuarioId] [int] NULL,
	[fecha] [datetime] NULL,
	[accionId] [int] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[ReservaEstado]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[ReservaEstado](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](255) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[ReservaCancelacion]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[ReservaCancelacion](
	[reservaCodigo] [numeric](18, 0) NULL,
	[fecha] [datetime] NULL,
	[usuarioId] [int] NULL,
	[motivo] [nvarchar](255) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[Reserva]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[Reserva](
	[codigo] [numeric](18, 0) NULL,
	[fechaDesde] [datetime] NULL,
	[fechaHasta] [datetime] NULL,
	[regimenCodigo] [numeric](18, 0) NULL,
	[hotelId] [int] NULL,
	[estadoId] [int] NULL,
	[clienteId] [int] NULL,
	[fechaCreacion] [datetime] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[Regimen]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[Regimen](
	[codigo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](255) NULL,
	[precio] [numeric](18, 2) NULL,
	[activo] [bit] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[Pais]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[Pais](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](255) NULL,
	[nacionalidad] [nvarchar](255) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[Localidad]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[Localidad](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](255) NULL,
	[paisId] [int] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[HotelRegimen]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[HotelRegimen](
	[hotelId] [int] NULL,
	[regimenCodigo] [numeric](18, 0) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[HotelInhabilitacion]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[HotelInhabilitacion](
	[hotelId] [int] NULL,
	[fechaInicio] [datetime] NULL,
	[fechaFin] [datetime] NULL,
	[descripcion] [nvarchar](255) NULL,
	[fechaCreacion] [datetime] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[Hotel]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[Hotel](
	[id] [int] IDENTITY(1, 1),
	[nombre] [nvarchar](255),
	[ciudadId] [int],
	[direccion] [nvarchar](255),
	[estrellas] [numeric](18, 0),
	[recargaEstrella] [numeric](18, 0),
	[mail] [nvarchar](255),
	[fechaCreacion] [datetime]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[Habitacion]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[Habitacion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[hotelId] [int] NULL,
	[tipoCodigo] [numeric](18, 0) NULL,
	[numero] [numeric](18, 0) NULL,
	[piso] [numeric](18, 0) NULL,
	[frente] [nvarchar](50) NULL,
	[descripcion] [nvarchar](255) NULL,
	[activa] [bit] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[Funcionalidad]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[Funcionalidad](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](255) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[Factura]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[Factura](
	[numero] [numeric](18, 0) NULL,
	[fecha] [datetime] NULL,
	[total] [numeric](18, 2) NULL,
	[estadiaId] [int] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[EstadiaDetalle]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[EstadiaDetalle](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NULL,
	[usuarioId] [int] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[EstadiaConsumible]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[EstadiaConsumible](
	[estadiaId] [int] NULL,
	[consumibleCodigo] [numeric](18, 0) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[EstadiaCliente]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[EstadiaCliente](
	[estadiaId] [int] NULL,
	[clienteId] [int] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[Estadia]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[Estadia](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[reservaCodigo] [numeric](18, 0) NULL,
	[checkinId] [int] NULL,
	[checkoutId] [int] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[Consumible]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[Consumible](
	[codigo] [numeric](18, 0) NULL,
	[descripcion] [nvarchar](255) NULL,
	[precio] [numeric](18, 2) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[Cliente]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[Cliente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tipoDocumentoId] [int] NULL,
	[numeroDocumento] [numeric](18, 0) NULL,
	[nombre] [nvarchar](255) NULL,
	[apellido] [nvarchar](255) NULL,
	[fechaNacimiento] [datetime] NULL,
	[mail] [nvarchar](255) NULL,
	[direccion] [nvarchar](255) NULL,
	[localidadId] [int] NULL,
	[nacionalidadId] [int] NULL,
	[habilitado] [bit] NULL,
	[telefono] [nvarchar](255) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[Ciudad]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[Ciudad](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](255) NULL,
	[paisId] [int] NULL
) ON [PRIMARY]
END
GO

/*****************************************************/


/******************* CONSTRAINS *********************/


/******************* MIGRATION **********************/
INSERT INTO [Frutillitas].[TipoDocumento] ([nombre]) VALUES ('Pasaporte')
GO

INSERT INTO [Frutillitas].[Pais]([nombre], [nacionalidad]) VALUES ('Argentina', 'Argentino')
GO

INSERT INTO [Frutillitas].[Ciudad]([nombre], [paisId])
SELECT DISTINCT [Hotel_Ciudad], 1 /*El único pais que hay*/
FROM [GD2C2014].[gd_esquema].[Maestra]
GO

INSERT INTO [Frutillitas].[Cliente](
	[tipoDocumentoId],
	[numeroDocumento],
	[nombre],
	[apellido],
	[fechaNacimiento],
	[mail],
	[direccion],
	[localidadId],
	[nacionalidadId],
	[habilitado],
	[telefono])
SELECT DISTINCT 
	1, /*El único tipo que hay*/
	[Cliente_Pasaporte_Nro],
	[Cliente_Nombre],
    [Cliente_Apellido],
    [Cliente_Fecha_Nac],
    [Cliente_Mail],
    [Cliente_Dom_Calle] + ' ' + CAST([Cliente_Nro_Calle] as nvarchar(255)) + ' ' + CAST([Cliente_Piso] as nvarchar(255)) + ' ' + [Cliente_Depto],
    NULL,
    1/*[Cliente_Nacionalidad]*/,
    1,
    NULL
FROM [GD2C2014].[gd_esquema].[Maestra]
GO

INSERT INTO [Frutillitas].[Consumible]([codigo], [descripcion], [precio])
SELECT DISTINCT [Consumible_Codigo] ,[Consumible_Descripcion] ,[Consumible_Precio]      
FROM [GD2C2014].[gd_esquema].[Maestra] WHERE [Consumible_Codigo] IS NOT NULL
GO

INSERT INTO [Frutillitas].[Regimen]([descripcion], [precio], [activo])
SELECT DISTINCT [Regimen_Descripcion], [Regimen_Precio], 1
FROM [GD2C2014].[gd_esquema].[Maestra]
GO

INSERT INTO [Frutillitas].[Hotel]([nombre], [ciudadId], [direccion], [estrellas], [recargaEstrella], [mail], [fechaCreacion])
SELECT DISTINCT NULL /*Lo dejo en null pero podría ir la dir*/, (SELECT [id] FROM [Frutillitas].[Ciudad] WHERE [nombre] LIKE [Hotel_Ciudad]), [Hotel_Calle] + ' ' + CAST([Hotel_Nro_Calle] as nvarchar(255)), [Hotel_CantEstrella], [Hotel_Recarga_Estrella], NULL, GETDATE()
FROM [GD2C2014].[gd_esquema].[Maestra]
GO

/*Por ahora dejo un todos contra todos, después hay que preguntar si solo ponemos los minimos*/
INSERT INTO [Frutillitas].[HotelRegimen]([hotelId], [regimenCodigo])
SELECT h.[id], r.[codigo]
FROM [Frutillitas].[Hotel] h, [Frutillitas].[Regimen] r
GO

INSERT INTO [Frutillitas].[TipoHabitacion]([codigo], [descripcion], [procentual], [cantHuespedes])
SELECT DISTINCT [Habitacion_Tipo_Codigo], [Habitacion_Tipo_Descripcion], [Habitacion_Tipo_Porcentual], 1/*Cómo lo sacamos??*/
FROM [GD2C2014].[gd_esquema].[Maestra]
GO

INSERT INTO [Frutillitas].[Habitacion]([hotelId], [tipoCodigo], [numero], [piso], [frente], [descripcion], [activa])
SELECT DISTINCT (SELECT [id] FROM [Frutillitas].[Hotel] WHERE [direccion] = [Hotel_Calle] + ' ' + CAST([Hotel_Nro_Calle] as nvarchar(255))), [Habitacion_Tipo_Codigo], [Habitacion_Numero], [Habitacion_Piso], [Habitacion_Frente], NULL/*Ni idea la descripcion*/, 1
FROM [GD2C2014].[gd_esquema].[Maestra]
GO