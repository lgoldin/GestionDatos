USE GD2C2014
GO

CREATE SCHEMA Frutillitas
GO

/**************************** CREATE TABLES ******************************/
CREATE TABLE [Frutillitas].[Pais](
	[id] [int] IDENTITY(1, 1),
	[nombre] [nvarchar](255),
	[nacionalidad] [nvarchar](255))
GO

CREATE TABLE [Frutillitas].[Ciudad](
	[id] [int] IDENTITY(1, 1),
	[nombre] [nvarchar](255),
	[paisId] [int])
GO
	
CREATE TABLE [Frutillitas].[Localidad](
	[id] [int] IDENTITY(1, 1),
	[nombre] [nvarchar](255),
	[paisId] [int])
GO
	
CREATE TABLE [Frutillitas].[TipoDocumento](
	[id] [int] IDENTITY(1, 1),
	[nombre] [nvarchar](255))
GO
	
CREATE TABLE [Frutillitas].[Cliente](
	[id] [int] IDENTITY(1, 1),
	[tipoDocumentoId] [int],
	[numeroDocumento] [numeric](18, 0),
	[nombre] [nvarchar](255),
	[apellido] [nvarchar](255),
	[fechaNacimiento] [datetime],
	[mail] [nvarchar](255),
	[direccion] [nvarchar](255),
	[localidadId] [int],
	[nacionalidadId] [int],
	[habilitado] [bit],
	[telefono] [nvarchar](255))
GO
	
CREATE TABLE [Frutillitas].[Usuario](
	[id] [int] IDENTITY(1, 1),
	[userName] [nvarchar](255),
	[password] [nvarchar](255), /*Change the type*/
	[habilitado] [bit],
	[apellido] [nvarchar](255),
	[tipoDocumentoId] [int],
	[numeroDocumento] [numeric](18, 0),
	[mail] [nvarchar](255),
	[telefono] [nvarchar](255),
	[direccion] [nvarchar](255),
	[fechaNacimiento] [datetime])
GO
	
CREATE TABLE [Frutillitas].[Rol](
	[id] [int] IDENTITY(1, 1),
	[nombre] [nvarchar](255),
	[activo] [bit])
GO
	
CREATE TABLE [Frutillitas].[Funcionalidad](
	[id] [int] IDENTITY(1, 1),
	[nombre] [nvarchar](255))
GO
	
CREATE TABLE [Frutillitas].[RolFuncionalidad](
	[rolId] [int],
	[funcionalidadId] [int])
GO
	
CREATE TABLE [Frutillitas].[UsuarioRol](
	[usuarioId] [int],
	[rolId] [int])
GO
	
CREATE TABLE [Frutillitas].[UsuarioLog](
	[id] [int] IDENTITY(1, 1),
	[usuarioId] [int],
	[fecha] [datetime])
GO
	
CREATE TABLE [Frutillitas].[Hotel](
	[id] [int] IDENTITY(1, 1),
	[nombre] [nvarchar](255),
	[ciudadId] [int],
	[estrellas] [numeric](18, 0),
	[recargaEstrella] [numeric](18, 0),
	[mail] [nvarchar](255),
	[fechaCreacion] [datetime])
GO
	
CREATE TABLE [Frutillitas].[TipoHabitacion](
	[codigo] [numeric](18, 0),
	[descripcion] [nvarchar](255),
	[procentual] [numeric](18, 2),
	[cantHuespedes] [int])
GO
	
CREATE TABLE [Frutillitas].[Habitacion](
	[id] [int] IDENTITY(1, 1),
	[hotelId] [int],
	[tipoCodigo] [numeric](18, 0),
	[numero] [numeric](18, 0),
	[piso] [numeric](18, 0),
	[frente] [nvarchar](50),
	[descripcion] [nvarchar](255),
	[activa] [bit])
GO
	
CREATE TABLE [Frutillitas].[HotelInhabilitacion](
	[hotelId] [int],
	[fechaInicio] [datetime],
	[fechaFin] [datetime],
	[descripcion] [nvarchar](255),
	[fechaCreacion] [datetime])
GO
	
CREATE TABLE [Frutillitas].[Regimen](
	[codigo] [numeric](18, 0),
	[descripcion] [nvarchar](255),
	[precio][numeric](18, 2),
	[activo] [bit])
GO
	
CREATE TABLE [Frutillitas].[HotelRegimen](
	[hotelId] [int],
	[regimenCodigo] [numeric](18, 0))
GO
	
CREATE TABLE [Frutillitas].[Consumible](
	[codigo] [numeric](18, 0),
	[descripcion] [nvarchar](255),
	[precio] [numeric](18, 2))
GO
	
CREATE TABLE [Frutillitas].[Reserva](
	[codigo] [numeric](18, 0),
	[fechaDesde] [datetime],
	[fechaHasta] [datetime],
	[regimenCodigo] [numeric](18, 0),
	[hotelId] [int],
	[estadoId] [int],
	[clienteId] [int],
	[fechaCreacion] [datetime])
GO
	
CREATE TABLE [Frutillitas].[ReservaTipoHabitacion](
	[reservaCodigo] [numeric](18, 0),
	[tipoHabitacionCodigo] [numeric](18, 0))
GO
	
CREATE TABLE [Frutillitas].[ReservaEstado](
	[id] [int] IDENTITY(1, 1),
	[descripcion] [nvarchar](255))
GO
	
CREATE TABLE [Frutillitas].[ReservaCancelacion](
	[reservaCodigo] [numeric](18, 0),
	[fecha] [datetime],
	[usuarioId] [int],
	[motivo] [nvarchar](255))
GO
	
CREATE TABLE [Frutillitas].[ReservaHistorial](
	[id] [int] IDENTITY(1, 1),
	[usuarioId] [int],
	[fecha] [datetime],
	[accionId] [int])
GO
	
CREATE TABLE [Frutillitas].[ReservaHistorialAccion](
	[id] [int] IDENTITY(1, 1),
	[nombre] [nvarchar](255))
GO

CREATE TABLE [Frutillitas].[Estadia](
	[id] [int] IDENTITY(1, 1),
	[reservaCodigo] [numeric](18, 0),
	[checkinId] [int],
	[checkoutId] [int])
GO
	
CREATE TABLE [Frutillitas].[EstadiaDetalle](
	[id] [int] IDENTITY(1, 1),
	[fecha] [datetime],
	[usuarioId] [int])
GO

CREATE TABLE [Frutillitas].[EstadiaCliente](
	[estadiaId] [int],
	[clienteId] [int])
GO
	
CREATE TABLE [Frutillitas].[EstadiaConsumible](
	[estadiaId] [int],
	[consumibleCodigo] [numeric](18, 0))
GO
	
CREATE TABLE [Frutillitas].[Factura](
	[numero] [numeric](18, 0),
	[fecha] [datetime],
	[total] [numeric](18, 2),
	[estadiaId] [int])
GO


/******************* CONSTRAINS *********************/


/******************* MIGRATION **********************/
INSERT INTO [Frutillitas].[TipoDocumento] ([nombre]) VALUES ('Pasaporte')
GO

INSERT INTO [Frutillitas].[Pais]([nombre], [nacionalidad]) VALUES ('Argentina', 'Argentino')
GO

INSERT INTO [Frutillitas].[Ciudad]([nombre], [paisId])
SELECT DISTINCT [Hotel_Ciudad], 1
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

INSERT INTO [Frutillitas].[Regimen](/*[codigo], */[descripcion], [precio], [activo])
SELECT DISTINCT [Regimen_Descripcion], [Regimen_Precio], 1
FROM [GD2C2014].[gd_esquema].[Maestra]
GO