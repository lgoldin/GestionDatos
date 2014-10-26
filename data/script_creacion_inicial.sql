USE GD2C2014
GO

CREATE SCHEMA Frutillitas

/**************************** CREATE TABLES ******************************/
CREATE TABLE [Frutillitas].[Pais](
	[id] [int] IDENTITY(1, 1),
	[nombre] [nvarchar](255),
	[nacionalidad] [nvarchar](255))

CREATE TABLE [Frutillitas].[Ciudad](
	[id] [int] IDENTITY(1, 1),
	[nombre] [nvarchar](255),
	[paisId] [int])
	
CREATE TABLE [Frutillitas].[Localidad](
	[id] [int] IDENTITY(1, 1),
	[nombre] [nvarchar](255),
	[paisId] [int])
	
CREATE TABLE [Frutillitas].[TipoDocumento](
	[id] [int] IDENTITY(1, 1),
	[nombre] [nvarchar](255))
	
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
	[telefono])
	
CREATE TABLE [Frutillitas].[Usuario](
	[id] [int] IDENTITY(1, 1),
	[userName] [nvarchar](255),
	[password],
	[habilitado] [bit],
	[apellido] [nvarchar](255),
	[tipoDocumentoId] [int],
	[numeroDocumento] [numeric](18, 0),
	[mail] [nvarchar](255),
	[telefono],
	[direccion] [nvarchar](255),
	[fechaNacimiento] [datetime])
	
CREATE TABLE [Frutillitas].[Hotel](
	[id] [int] IDENTITY(1, 1),
	[nombre] [nvarchar](255),
	[ciudadId] [int],
	[estrellas] [numeric](18, 0),
	[recargaEstrella] [numeric](18, 0),
	[mail] [nvarchar](255),
	[fechaCreacion] [datetime])
	
CREATE TABLE [Frutillitas].[TipoHabitacion](
	[codigo] [numeric](18, 0),
	[descripcion] [nvarchar](255),
	[procentual] [numeric](18, 2),
	[cantHuespedes])
	
CREATE TABLE [Frutillitas].[Habitacion](
	[id] [int] IDENTITY(1, 1),
	[hotelId] [int],
	[tipoCodigo] [numeric](18, 0),
	[numero] [numeric](18, 0),
	[piso] [numeric](18, 0),
	[frente] [nvarchar](50),
	[descripcion] [nvarchar](255),
	[activa] [bit])
	
CREATE TABLE [Frutillitas].[HotelInhabilitacion](
	[hotelId] [int],
	[fechaInicio] [datetime],
	[fechaFin] [datetime],
	[descripcion] [nvarchar](255),
	[fechaCreacion] [datetime])
	
CREATE TABLE [Frutillitas].[Regimen](
	[codigo] [numeric](18, 0),
	[descripcion] [nvarchar](255),
	[precio][numeric](18, 2),
	[activo] [bit])
	
CREATE TABLE [Frutillitas].[HotelRegimen](
	[hotelId] [int],
	[regimenCodigo] [numeric](18, 0))
	
CREATE TABLE [Frutillitas].[Consumible](
	[codigo] [numeric](18, 0),
	[descripcion] [nvarchar](255),
	[precio] [numeric](18, 2))
	
CREATE TABLE [Frutillitas].[Reserva](
	[codigo] [numeric](18, 0),
	[fechaDesde] [datetime],
	[fechaHasta] [datetime],
	[regimenCodigo] [numeric](18, 0),
	[hotelId] [int],
	[estadoId] [int],
	[clienteId] [int],
	[fechaCreacion] [datetime])
	
CREATE TABLE [Frutillitas].[ReservaTipoHabitacion](
	[reservaCodigo] [numeric](18, 0),
	[tipoHabitacionCodigo] [numeric](18, 0))
	
CREATE TABLE [Frutillitas].[ReservaCancelacion](
	[reservaCodigo] [numeric](18, 0),
	[fecha] [datetime],
	[usuarioId] [int],
	[motivo] [nvarchar](255))
	
CREATE TABLE [Frutillitas].[EstadiaDetalle](
	[id] [int] IDENTITY(1, 1),
	[fecha] [datetime],
	[usuarioId] [int])

CREATE TABLE [Frutillitas].[Estadia](
	[id] [int] IDENTITY(1, 1),
	[reservaCodigo] [numeric](18, 0),
	[checkinId] [int],
	[checkoutId] [int])
	
CREATE TABLE [Frutillitas].[Factura](
	[numero] [numeric](18, 0),
	[fecha] [datetime],
	[total] [numeric](18, 2),
	[estadiaId] [int])