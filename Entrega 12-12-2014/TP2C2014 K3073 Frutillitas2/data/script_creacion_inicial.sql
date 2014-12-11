USE [GD2C2014]
GO

/************ DROP SPs **************************/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetCountUsuarioByUserName]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetCountUsuarioByUserName]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetListadoClientePuntos]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetListadoClientePuntos]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertFacturaItem]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertFacturaItem]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertTarjetaDeCredito]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertTarjetaDeCredito]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertEstadiaCliente]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertEstadiaCliente]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertEstadiaConsumible]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertEstadiaConsumible]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertFactura]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertFactura]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetClienteByEstadiaId]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetClienteByEstadiaId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetConsumiblesByIdEstadia]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetConsumiblesByIdEstadia]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetListadoHotelesConsumiblesFacturados]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetListadoHotelesConsumiblesFacturados]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[UpdateEstadia]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[UpdateEstadia]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[CountPosibleReserva]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[CountPosibleReserva]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[DeleteReservaTipoHabitacion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[DeleteReservaTipoHabitacion]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetEstadiaByCodigoReserva]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetEstadiaByCodigoReserva]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetEstadiaById]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetEstadiaById]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetListadoHabitacionCantidad]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetListadoHabitacionCantidad]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetListadoHabitacionDias]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetListadoHabitacionDias]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetTipoHabitacionByReserva]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetTipoHabitacionByReserva]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertEstadia]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertEstadia]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertReservaLog]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertReservaLog]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertReservaTipoHabitacion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertReservaTipoHabitacion]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertHabitacion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertHabitacion]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertUsuarioHotel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertUsuarioHotel]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertHotelInhabilitado]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertHotelInhabilitado]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertHotelRegimen]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertHotelRegimen]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertHotelUsuario]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertHotelUsuario]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertReserva]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertReserva]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[ExistsHabitacion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[ExistsHabitacion]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetActiveReservaBetweenDatesByHotel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetActiveReservaBetweenDatesByHotel]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetActiveReservaRegimenesByHotelId]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetActiveReservaRegimenesByHotelId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetHabitaciones]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetHabitaciones]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetHotelesByIdUsuario]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetHotelesByIdUsuario]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetListadoHotelesFueraDeServicio]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetListadoHotelesFueraDeServicio]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetListadoHotelesReservasCanceladas]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetListadoHotelesReservasCanceladas]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetRegimenesByHotel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetRegimenesByHotel]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetReservaByCodigo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetReservaByCodigo]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetReservaCountByDatesAndHotel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetReservaCountByDatesAndHotel]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetReservasPosteriores]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetReservasPosteriores]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetReservasVencidas]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetReservasVencidas]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[UpdateEstadoReserva]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[UpdateEstadoReserva]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[UpdateHabitacion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[UpdateHabitacion]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[UpdateHotel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[UpdateHotel]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[UpdateReserva]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[UpdateReserva]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[UpdateUsuario]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[UpdateUsuario]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetHoteles]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetHoteles]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertHotel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertHotel]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertRolFuncionalidad]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertRolFuncionalidad]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertUsuario]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertUsuario]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertUsuarioLog]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertUsuarioLog]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertCliente]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertCliente]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetUsuarioByUsernameAndPassword]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetUsuarioByUsernameAndPassword]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetUsuarios]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetUsuarios]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[DeleteUsuarioLog]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[DeleteUsuarioLog]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetFuncionalidadesByRol]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetFuncionalidadesByRol]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetCiudades]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetCiudades]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetCiudadesByPaisId]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetCiudadesByPaisId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetClienteByEmail]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetClienteByEmail]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetClienteById]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetClienteById]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetClienteByTipoYNumeroDocumento]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetClienteByTipoYNumeroDocumento]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetClientes]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetClientes]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[UpdateCliente]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[UpdateCliente]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[UpdateRol]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[UpdateRol]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetConsumibles]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetConsumibles]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetFacturaTipoPago]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetFacturaTipoPago]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetFuncionalidades]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetFuncionalidades]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[DeleteRol]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[DeleteRol]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetHotelCargoEstrella]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetHotelCargoEstrella]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetRoles]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetRoles]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetPaises]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetPaises]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetRegimenes]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetRegimenes]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetTiposDocumento]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetTiposDocumento]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetTiposHabitaciones]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetTiposHabitaciones]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertRol]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertRol]
GO

/************ CREATE TABLE AND SCHEMA ***********/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Frutillitas].[FK_UsuarioRol_Rol]') AND parent_object_id = OBJECT_ID(N'[Frutillitas].[UsuarioRol]'))
ALTER TABLE [Frutillitas].[UsuarioRol] DROP CONSTRAINT [FK_UsuarioRol_Rol]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Frutillitas].[FK_UsuarioRol_Usuario]') AND parent_object_id = OBJECT_ID(N'[Frutillitas].[UsuarioRol]'))
ALTER TABLE [Frutillitas].[UsuarioRol] DROP CONSTRAINT [FK_UsuarioRol_Usuario]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Frutillitas].[FK_UsuarioLog_Usuario]') AND parent_object_id = OBJECT_ID(N'[Frutillitas].[UsuarioLog]'))
ALTER TABLE [Frutillitas].[UsuarioLog] DROP CONSTRAINT [FK_UsuarioLog_Usuario]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Frutillitas].[FK_UsuarioHotel_Hotel]') AND parent_object_id = OBJECT_ID(N'[Frutillitas].[UsuarioHotel]'))
ALTER TABLE [Frutillitas].[UsuarioHotel] DROP CONSTRAINT [FK_UsuarioHotel_Hotel]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Frutillitas].[FK_UsuarioHotel_Usuario]') AND parent_object_id = OBJECT_ID(N'[Frutillitas].[UsuarioHotel]'))
ALTER TABLE [Frutillitas].[UsuarioHotel] DROP CONSTRAINT [FK_UsuarioHotel_Usuario]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Frutillitas].[FK_RolFuncionalidad_Funcionalidad]') AND parent_object_id = OBJECT_ID(N'[Frutillitas].[RolFuncionalidad]'))
ALTER TABLE [Frutillitas].[RolFuncionalidad] DROP CONSTRAINT [FK_RolFuncionalidad_Funcionalidad]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Frutillitas].[FK_RolFuncionalidad_Rol]') AND parent_object_id = OBJECT_ID(N'[Frutillitas].[RolFuncionalidad]'))
ALTER TABLE [Frutillitas].[RolFuncionalidad] DROP CONSTRAINT [FK_RolFuncionalidad_Rol]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Frutillitas].[FK_ReservaTipoHabitacion_Reserva]') AND parent_object_id = OBJECT_ID(N'[Frutillitas].[ReservaTipoHabitacion]'))
ALTER TABLE [Frutillitas].[ReservaTipoHabitacion] DROP CONSTRAINT [FK_ReservaTipoHabitacion_Reserva]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Frutillitas].[FK_ReservaTipoHabitacion_TipoHabitacion]') AND parent_object_id = OBJECT_ID(N'[Frutillitas].[ReservaTipoHabitacion]'))
ALTER TABLE [Frutillitas].[ReservaTipoHabitacion] DROP CONSTRAINT [FK_ReservaTipoHabitacion_TipoHabitacion]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Frutillitas].[FK_ReservaLog_Reserva]') AND parent_object_id = OBJECT_ID(N'[Frutillitas].[ReservaLog]'))
ALTER TABLE [Frutillitas].[ReservaLog] DROP CONSTRAINT [FK_ReservaLog_Reserva]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Frutillitas].[FK_ReservaLog_Usuario]') AND parent_object_id = OBJECT_ID(N'[Frutillitas].[ReservaLog]'))
ALTER TABLE [Frutillitas].[ReservaLog] DROP CONSTRAINT [FK_ReservaLog_Usuario]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Frutillitas].[FK_ReservaLog_Tipo]') AND parent_object_id = OBJECT_ID(N'[Frutillitas].[ReservaLog]'))
ALTER TABLE [Frutillitas].[ReservaLog] DROP CONSTRAINT [FK_ReservaLog_Tipo]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Frutillitas].[FK_Reserva_Cliente]') AND parent_object_id = OBJECT_ID(N'[Frutillitas].[Reserva]'))
ALTER TABLE [Frutillitas].[Reserva] DROP CONSTRAINT [FK_Reserva_Cliente]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Frutillitas].[FK_Reserva_Hotel]') AND parent_object_id = OBJECT_ID(N'[Frutillitas].[Reserva]'))
ALTER TABLE [Frutillitas].[Reserva] DROP CONSTRAINT [FK_Reserva_Hotel]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Frutillitas].[FK_Reserva_Regimen]') AND parent_object_id = OBJECT_ID(N'[Frutillitas].[Reserva]'))
ALTER TABLE [Frutillitas].[Reserva] DROP CONSTRAINT [FK_Reserva_Regimen]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Frutillitas].[FK_Reserva_Estado]') AND parent_object_id = OBJECT_ID(N'[Frutillitas].[Reserva]'))
ALTER TABLE [Frutillitas].[Reserva] DROP CONSTRAINT [FK_Reserva_Estado]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Frutillitas].[FK_HotelRegimen_Hotel]') AND parent_object_id = OBJECT_ID(N'[Frutillitas].[HotelRegimen]'))
ALTER TABLE [Frutillitas].[HotelRegimen] DROP CONSTRAINT [FK_HotelRegimen_Hotel]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Frutillitas].[FK_HotelRegimen_Regimen]') AND parent_object_id = OBJECT_ID(N'[Frutillitas].[HotelRegimen]'))
ALTER TABLE [Frutillitas].[HotelRegimen] DROP CONSTRAINT [FK_HotelRegimen_Regimen]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Frutillitas].[FK_HotelInhabilitacion_Hotel]') AND parent_object_id = OBJECT_ID(N'[Frutillitas].[HotelInhabilitacion]'))
ALTER TABLE [Frutillitas].[HotelInhabilitacion] DROP CONSTRAINT [FK_HotelInhabilitacion_Hotel]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Frutillitas].[FK_Hotel_Ciudad]') AND parent_object_id = OBJECT_ID(N'[Frutillitas].[Hotel]'))
ALTER TABLE [Frutillitas].[Hotel] DROP CONSTRAINT [FK_Hotel_Ciudad]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Frutillitas].[FK_Habitacion_Hotel]') AND parent_object_id = OBJECT_ID(N'[Frutillitas].[Habitacion]'))
ALTER TABLE [Frutillitas].[Habitacion] DROP CONSTRAINT [FK_Habitacion_Hotel]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Frutillitas].[FK_Habitacion_TipoHabitacion]') AND parent_object_id = OBJECT_ID(N'[Frutillitas].[Habitacion]'))
ALTER TABLE [Frutillitas].[Habitacion] DROP CONSTRAINT [FK_Habitacion_TipoHabitacion]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Frutillitas].[UQ_Habitacion_Hotel_Numero]') AND parent_object_id = OBJECT_ID(N'[Frutillitas].[Habitacion]'))
ALTER TABLE [Frutillitas].[Habitacion] DROP CONSTRAINT [UQ_Habitacion_Hotel_Numero]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Frutillitas].[FK_Factura_Estadia]') AND parent_object_id = OBJECT_ID(N'[Frutillitas].[Factura]'))
ALTER TABLE [Frutillitas].[Factura] DROP CONSTRAINT [FK_Factura_Estadia]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Frutillitas].[FK_Factura_TipoPago]') AND parent_object_id = OBJECT_ID(N'[Frutillitas].[Factura]'))
ALTER TABLE [Frutillitas].[Factura] DROP CONSTRAINT [FK_Factura_TipoPago]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Frutillitas].[FK_Factura_Cliente]') AND parent_object_id = OBJECT_ID(N'[Frutillitas].[Factura]'))
ALTER TABLE [Frutillitas].[Factura] DROP CONSTRAINT [FK_Factura_Cliente]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Frutillitas].[FK_FacturaItem_Factura]') AND parent_object_id = OBJECT_ID(N'[Frutillitas].[FacturaItem]'))
ALTER TABLE [Frutillitas].[FacturaItem] DROP CONSTRAINT [FK_FacturaItem_Factura]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Frutillitas].[FK_TarjetaDeCredito_Factura]') AND parent_object_id = OBJECT_ID(N'[Frutillitas].[TarjetaDeCredito]'))
ALTER TABLE [Frutillitas].[TarjetaDeCredito] DROP CONSTRAINT [FK_TarjetaDeCredito_Factura]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Frutillitas].[FK_EstadiaConsumible_Consumible]') AND parent_object_id = OBJECT_ID(N'[Frutillitas].[EstadiaConsumible]'))
ALTER TABLE [Frutillitas].[EstadiaConsumible] DROP CONSTRAINT [FK_EstadiaConsumible_Consumible]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Frutillitas].[FK_EstadiaConsumible_Estadia]') AND parent_object_id = OBJECT_ID(N'[Frutillitas].[EstadiaConsumible]'))
ALTER TABLE [Frutillitas].[EstadiaConsumible] DROP CONSTRAINT [FK_EstadiaConsumible_Estadia]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Frutillitas].[FK_EstadiaCliente_Cliente]') AND parent_object_id = OBJECT_ID(N'[Frutillitas].[EstadiaCliente]'))
ALTER TABLE [Frutillitas].[EstadiaCliente] DROP CONSTRAINT [FK_EstadiaCliente_Cliente]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Frutillitas].[FK_EstadiaCliente_Estadia]') AND parent_object_id = OBJECT_ID(N'[Frutillitas].[EstadiaCliente]'))
ALTER TABLE [Frutillitas].[EstadiaCliente] DROP CONSTRAINT [FK_EstadiaCliente_Estadia]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Frutillitas].[FK_Estadia_Reserva]') AND parent_object_id = OBJECT_ID(N'[Frutillitas].[Estadia]'))
ALTER TABLE [Frutillitas].[Estadia] DROP CONSTRAINT [FK_Estadia_Reserva]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Frutillitas].[FK_Cliente_Pais]') AND parent_object_id = OBJECT_ID(N'[Frutillitas].[Cliente]'))
ALTER TABLE [Frutillitas].[Cliente] DROP CONSTRAINT [FK_Cliente_Pais]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Frutillitas].[FK_Cliente_TipoDocumento]') AND parent_object_id = OBJECT_ID(N'[Frutillitas].[Cliente]'))
ALTER TABLE [Frutillitas].[Cliente] DROP CONSTRAINT [FK_Cliente_TipoDocumento]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Frutillitas].[FK_Ciudad_Pais]') AND parent_object_id = OBJECT_ID(N'[Frutillitas].[Ciudad]'))
ALTER TABLE [Frutillitas].[Ciudad] DROP CONSTRAINT [FK_Ciudad_Pais]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[UsuarioHotel]') AND type in (N'U'))
DROP TABLE [Frutillitas].[UsuarioHotel]
GO
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
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[FacturaItem]') AND type in (N'U'))
DROP TABLE [Frutillitas].[FacturaItem]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[FacturaTipoPago]') AND type in (N'U'))
DROP TABLE [Frutillitas].[FacturaTipoPago]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[TarjetaDeCredito]') AND type in (N'U'))
DROP TABLE [Frutillitas].[TarjetaDeCredito]
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
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[HotelIncrementoEstrella]') AND type in (N'U'))
DROP TABLE [Frutillitas].[HotelIncrementoEstrella]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[HotelInhabilitacion]') AND type in (N'U'))
DROP TABLE [Frutillitas].[HotelInhabilitacion]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[HotelRegimen]') AND type in (N'U'))
DROP TABLE [Frutillitas].[HotelRegimen]
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
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[ReservaLogTipo]') AND type in (N'U'))
DROP TABLE [Frutillitas].[ReservaLogTipo]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[ReservaLog]') AND type in (N'U'))
DROP TABLE [Frutillitas].[ReservaLog]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[ReservaEstado]') AND type in (N'U'))
DROP TABLE [Frutillitas].[ReservaEstado]
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[UsuarioHotel]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[UsuarioHotel](
	[id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[usuarioId] [int] NULL,
	[hotelId] [int] NULL
) ON [PRIMARY]
END
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
	[id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
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
	[id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[username] [nvarchar](255) NULL,
	[password] [varbinary](MAX) NULL,
	[habilitado] [bit] NULL,
	[nombre] [nvarchar](255) NULL,
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
	[codigo] [numeric](18, 0) NOT NULL PRIMARY KEY,
	[descripcion] [nvarchar](255) NULL,
	[porcentual] [numeric](18, 2) NULL
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
	[id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
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
	[id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[ReservaEstado]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[ReservaEstado](
	[id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[descripcion] [nvarchar](255) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[ReservaLogTipo]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[ReservaLogTipo](
	[id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[descripcion] [nvarchar](255) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[ReservaLog]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[ReservaLog](
	[reservaCodigo] [numeric](18, 0) NULL,
	[fecha] [datetime] NULL,
	[usuarioId] [int] NULL,
	[tipoId] [int] NOT NULL,
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
	[codigo] [numeric](18, 0) IDENTITY(1,1) NOT NULL PRIMARY KEY,
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
	[codigo] [numeric](18, 0) IDENTITY(1,1) NOT NULL PRIMARY KEY, /*Como no hay codigo lo dejo como autoincremental*/
	[descripcion] [nvarchar](255) NULL,
	[precio] [numeric](18, 2) NULL,
	[consumiblesGratis] [bit] NULL,
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
	[id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[nombre] [nvarchar](255) NULL,
	[nacionalidad] [nvarchar](255) NULL
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
	[id] [int] IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	[nombre] [nvarchar](255) NULL,
	[ciudadId] [int] NULL,
	[direccion] [nvarchar](255) NULL,
	[estrellas] [numeric](18, 0) NULL,
	[mail] [nvarchar](255) NULL,
	[fechaCreacion] [datetime] NULL,
	[telefono] [nvarchar](255) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[HotelIncrementoEstrella]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[HotelIncrementoEstrella](
	[id] [int] IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	[incremento] [numeric](18, 0) NULL
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
	[id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[hotelId] [int] NULL,
	[tipoCodigo] [numeric](18, 0) NULL,
	[numero] [numeric](18, 0) NULL,
	[piso] [numeric](18, 0) NULL,
	[frente] [nvarchar](50) NULL,/*Hay que cambiar esto, por ahora esta tal como viene (S, N)*/
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
	[id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
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
	[numero] [numeric](18, 0) IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[fecha] [datetime] NULL,
	[total] [numeric](18, 2) NULL,
	[estadiaId] [int] NULL,
	[clienteId] [int] NULL,
	[tipoPagoId] [int] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[FacturaItem]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[FacturaItem](
	[facturaNumero] [numeric](18, 0) NULL,
	[descripcion] [nvarchar](255) NULL,
	[precio] [numeric](18, 2) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[FacturaTipoPago]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[FacturaTipoPago](
	[id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[descripcion] [nvarchar](255) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[TarjetaDeCredito]') AND type in (N'U'))
BEGIN
CREATE TABLE [Frutillitas].[TarjetaDeCredito](
	[id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[facturaNumero] [numeric](18, 0) NULL,
	[numero] [numeric](16, 0) NULL,
	[codigo] [nvarchar](10) NULL,
	[fechaVencimiento] [datetime] NULL,
	[codigoSeguridad] [numeric](4, 0) NULL
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
	[id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[reservaCodigo] [numeric](18, 0) NULL,
	[fechaDesde] [datetime] NULL,
	[fechaHasta] [datetime] NULL,
	[usuarioCheckInId] [int] NULL,
	[usuarioCheckOutId] [int] NULL
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
	[codigo] [numeric](18, 0) NOT NULL PRIMARY KEY,
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
	[id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[tipoDocumentoId] [int] NULL,
	[numeroDocumento] [numeric](18, 0) NULL,
	[nombre] [nvarchar](255) NULL,
	[apellido] [nvarchar](255) NULL,
	[fechaNacimiento] [datetime] NULL,
	[mail] [nvarchar](255) NULL,
	[direccion] [nvarchar](255) NULL,
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
	[id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[nombre] [nvarchar](255) NULL,
	[paisId] [int] NULL
) ON [PRIMARY]
END
GO

/*****************************************************/


/******************* CONSTRAINS *********************/
ALTER TABLE [Frutillitas].[UsuarioHotel] ADD CONSTRAINT FK_UsuarioHotel_Hotel FOREIGN KEY (hotelId) REFERENCES [Frutillitas].[Hotel](id)
GO
ALTER TABLE [Frutillitas].[UsuarioHotel] ADD CONSTRAINT FK_UsuarioHotel_Usuario FOREIGN KEY (usuarioId) REFERENCES [Frutillitas].[Usuario](id)
GO
ALTER TABLE [Frutillitas].[UsuarioRol] ADD CONSTRAINT FK_UsuarioRol_Usuario FOREIGN KEY (usuarioId) REFERENCES [Frutillitas].[Usuario](id)
GO
ALTER TABLE [Frutillitas].[UsuarioRol] ADD CONSTRAINT FK_UsuarioRol_Rol FOREIGN KEY (rolId) REFERENCES [Frutillitas].[Rol](id)
GO
ALTER TABLE [Frutillitas].[UsuarioLog] ADD CONSTRAINT FK_UsuarioLog_Usuario FOREIGN KEY (usuarioId) REFERENCES [Frutillitas].[Usuario](id)
GO
ALTER TABLE [Frutillitas].[RolFuncionalidad] ADD CONSTRAINT FK_RolFuncionalidad_Funcionalidad FOREIGN KEY (funcionalidadId) REFERENCES [Frutillitas].[Funcionalidad](id)
GO
ALTER TABLE [Frutillitas].[RolFuncionalidad] ADD CONSTRAINT FK_RolFuncionalidad_Rol FOREIGN KEY (rolId) REFERENCES [Frutillitas].[Rol](id)
GO
ALTER TABLE [Frutillitas].[ReservaTipoHabitacion] ADD CONSTRAINT FK_ReservaTipoHabitacion_Reserva FOREIGN KEY (reservaCodigo) REFERENCES [Frutillitas].[Reserva](codigo)
GO
ALTER TABLE [Frutillitas].[ReservaTipoHabitacion] ADD CONSTRAINT FK_ReservaTipoHabitacion_TipoHabitacion FOREIGN KEY (tipoHabitacionCodigo) REFERENCES [Frutillitas].[TipoHabitacion](codigo)
GO
ALTER TABLE [Frutillitas].[ReservaLog] ADD CONSTRAINT FK_ReservaLog_Reserva FOREIGN KEY (reservaCodigo) REFERENCES [Frutillitas].[Reserva](codigo)
GO
ALTER TABLE [Frutillitas].[ReservaLog] ADD CONSTRAINT FK_ReservaLog_Usuario FOREIGN KEY (usuarioId) REFERENCES [Frutillitas].[Usuario](id)
GO
ALTER TABLE [Frutillitas].[ReservaLog] ADD CONSTRAINT FK_ReservaLog_Tipo FOREIGN KEY (tipoId) REFERENCES [Frutillitas].[ReservaLogTipo](id)
GO
ALTER TABLE [Frutillitas].[Reserva] ADD CONSTRAINT FK_Reserva_Regimen FOREIGN KEY (regimenCodigo) REFERENCES [Frutillitas].[Regimen](codigo)
GO
ALTER TABLE [Frutillitas].[Reserva] ADD CONSTRAINT FK_Reserva_Hotel FOREIGN KEY (hotelId) REFERENCES [Frutillitas].[Hotel](id)
GO
ALTER TABLE [Frutillitas].[Reserva] ADD CONSTRAINT FK_Reserva_Estado FOREIGN KEY (estadoId) REFERENCES [Frutillitas].[ReservaEstado](id)
GO
ALTER TABLE [Frutillitas].[Reserva] ADD CONSTRAINT FK_Reserva_Cliente FOREIGN KEY (clienteId) REFERENCES [Frutillitas].[Cliente](id)
GO
ALTER TABLE [Frutillitas].[HotelRegimen] ADD CONSTRAINT FK_HotelRegimen_Hotel FOREIGN KEY (hotelId) REFERENCES [Frutillitas].[Hotel](id)
GO
ALTER TABLE [Frutillitas].[HotelRegimen] ADD CONSTRAINT FK_HotelRegimen_Regimen FOREIGN KEY (regimenCodigo) REFERENCES [Frutillitas].[Regimen](codigo)
GO
ALTER TABLE [Frutillitas].[HotelInhabilitacion] ADD CONSTRAINT FK_HotelInhabilitacion_Hotel FOREIGN KEY (hotelId) REFERENCES [Frutillitas].[Hotel](id)
GO
ALTER TABLE [Frutillitas].[Hotel] ADD CONSTRAINT FK_Hotel_Ciudad FOREIGN KEY (ciudadId) REFERENCES [Frutillitas].[Ciudad](id)
GO
ALTER TABLE [Frutillitas].[Habitacion] ADD CONSTRAINT FK_Habitacion_Hotel FOREIGN KEY (hotelId) REFERENCES [Frutillitas].[Hotel](id)
GO
ALTER TABLE [Frutillitas].[Habitacion] ADD CONSTRAINT FK_Habitacion_TipoHabitacion FOREIGN KEY (tipoCodigo) REFERENCES [Frutillitas].[TipoHabitacion](codigo)
GO
ALTER TABLE [Frutillitas].[Habitacion] ADD CONSTRAINT UQ_Habitacion_Hotel_Numero UNIQUE (hotelId, numero)
GO
ALTER TABLE [Frutillitas].[Factura] ADD CONSTRAINT FK_Factura_Estadia FOREIGN KEY (estadiaId) REFERENCES [Frutillitas].[Estadia](id)
GO
ALTER TABLE [Frutillitas].[Factura] ADD CONSTRAINT FK_Factura_TipoPago FOREIGN KEY (tipoPagoId) REFERENCES [Frutillitas].[FacturaTipoPago](id)
GO
ALTER TABLE [Frutillitas].[Factura] ADD CONSTRAINT FK_Factura_Cliente FOREIGN KEY (clienteId) REFERENCES [Frutillitas].[Cliente](id)
GO
ALTER TABLE [Frutillitas].[FacturaItem] ADD CONSTRAINT FK_FacturaItem_Factura FOREIGN KEY (facturaNumero) REFERENCES [Frutillitas].[Factura](numero)
GO
ALTER TABLE [Frutillitas].[TarjetaDeCredito] ADD CONSTRAINT FK_TarjetaDeCredito_Factura FOREIGN KEY (facturaNumero) REFERENCES [Frutillitas].[Factura](numero)
GO
ALTER TABLE [Frutillitas].[EstadiaConsumible] ADD CONSTRAINT FK_EstadiaConsumible_Estadia FOREIGN KEY (estadiaId) REFERENCES [Frutillitas].[Estadia](id)
GO
ALTER TABLE [Frutillitas].[EstadiaConsumible] ADD CONSTRAINT FK_EstadiaConsumible_Consumible FOREIGN KEY (consumibleCodigo) REFERENCES [Frutillitas].[Consumible](codigo)
GO
ALTER TABLE [Frutillitas].[EstadiaCliente] ADD CONSTRAINT FK_EstadiaCliente_Estadia FOREIGN KEY (estadiaId) REFERENCES [Frutillitas].[Estadia](id)
GO
ALTER TABLE [Frutillitas].[EstadiaCliente] ADD CONSTRAINT FK_EstadiaCliente_Cliente FOREIGN KEY (clienteId) REFERENCES [Frutillitas].[Cliente](id)
GO
ALTER TABLE [Frutillitas].[Estadia] ADD CONSTRAINT FK_Estadia_Reserva FOREIGN KEY (reservaCodigo) REFERENCES [Frutillitas].[Reserva](codigo)
GO
ALTER TABLE [Frutillitas].[Cliente] ADD CONSTRAINT FK_Cliente_TipoDocumento FOREIGN KEY (tipoDocumentoId) REFERENCES [Frutillitas].[TipoDocumento](id)
GO
ALTER TABLE [Frutillitas].[Cliente] ADD CONSTRAINT FK_Cliente_Pais FOREIGN KEY (nacionalidadId) REFERENCES [Frutillitas].[Pais](id)
GO
ALTER TABLE [Frutillitas].[Ciudad] ADD CONSTRAINT FK_Ciudad_Pais FOREIGN KEY (paisId) REFERENCES [Frutillitas].[Pais](id)
GO
ALTER TABLE [Frutillitas].[Estadia] ADD CONSTRAINT FK_Estadia_UsuarioCheckIn FOREIGN KEY (usuarioCheckInId) REFERENCES [Frutillitas].[Usuario](id)
GO
ALTER TABLE [Frutillitas].[Estadia] ADD CONSTRAINT FK_Estadia_UsuarioCheckOut FOREIGN KEY (usuarioCheckOutId) REFERENCES [Frutillitas].[Usuario](id)
GO

/******************* CREATE SPs **********************/


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetCountUsuarioByUserName]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[GetCountUsuarioByUserName]

@username nvarchar(255)
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT count(id)
		
	FROM [Frutillitas].Usuario
	WHERE 
		username = @username
END
'
END

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
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetTiposHabitaciones]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[GetTiposHabitaciones]
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT
		*
	FROM [Frutillitas].TipoHabitacion
END
' 
END
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
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetHotelCargoEstrella]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[GetHotelCargoEstrella]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT TOP 1 [incremento]
	FROM [GD2C2014].[Frutillitas].[HotelIncrementoEstrella]
END
' 
END
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
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetFacturaTipoPago]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[GetFacturaTipoPago]
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT 
	   [id]
      ,[descripcion]
  FROM [GD2C2014].[Frutillitas].[FacturaTipoPago]
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetConsumibles]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[GetConsumibles]
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT
		*
	FROM [Frutillitas].[Consumible]
END
' 
END
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
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[UpdateCliente]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[UpdateCliente]


@tipoDocumentoId int
,@numeroDocumento numeric(18,0)
,@nombre nvarchar(255)
,@apellido nvarchar(255)
,@fechaNacimiento datetime
,@mail nvarchar(255)
,@direccion nvarchar(255)
,@nacionalidadId int
,@telefono nvarchar(255)
,@id int
,@habilitado bit

AS
BEGIN

SET NOCOUNT ON;
UPDATE [Frutillitas].[Cliente]
   SET [tipoDocumentoId] = @tipoDocumentoId
      ,[numeroDocumento] = @numeroDocumento
	  ,[nombre] = @nombre
      ,[apellido] = @apellido
      ,[fechaNacimiento] = @fechaNacimiento
      ,[mail] = @mail
      ,[direccion] = @direccion
      ,[nacionalidadId] = @nacionalidadId
      ,[habilitado] = @habilitado
      ,[telefono] = @telefono
 WHERE [id] = @id
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetClientes]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[GetClientes]

@nombre nvarchar(255) = null,
@apellido nvarchar(255) = null,
@tipoDocumentoId int = null,
@numeroDocumento nvarchar(255) = null,
@mail nvarchar(255) = null

AS
BEGIN
	SET NOCOUNT ON;
	
	
SELECT c.[id]
      ,c.[tipoDocumentoId]
      ,c.[numeroDocumento]
      ,c.[nombre]
      ,c.[apellido]
      ,c.[fechaNacimiento]
      ,c.[mail]
      ,c.[direccion]
      ,c.[nacionalidadId]
      ,c.[habilitado]
      ,c.[telefono]
	  ,t.[nombre] as tipoDocumentoNombre
  FROM [Frutillitas].[Cliente] c
  INNER JOIN [Frutillitas].[TipoDocumento] t on c.tipoDocumentoId = t.id
	WHERE 
		(@nombre IS NULL OR c.nombre LIKE ''%'' + @nombre + ''%'') AND
		(@apellido IS NULL OR c.apellido LIKE ''%'' + @apellido + ''%'') AND
		(@mail IS NULL OR c.mail LIKE ''%'' + @mail + ''%'') AND
		(@numeroDocumento IS NULL OR c.numeroDocumento LIKE @numeroDocumento + ''%'') AND
		(@tipoDocumentoId IS NULL OR c.tipoDocumentoId = @tipoDocumentoId)

END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetClienteByTipoYNumeroDocumento]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[GetClienteByTipoYNumeroDocumento]

@tipoDocoumentoId int
,@numeroDocumento numeric(18, 0)

AS
BEGIN
	SET NOCOUNT ON;
	
SELECT c.[id]
      ,c.[tipoDocumentoId]
      ,c.[numeroDocumento]
      ,c.[nombre]
      ,c.[apellido]
      ,c.[fechaNacimiento]
      ,c.[mail]
      ,c.[direccion]
      ,c.[nacionalidadId]
      ,c.[habilitado]
      ,c.[telefono]
	  ,t.[nombre] as tipoDocumentoNombre
  FROM [Frutillitas].[Cliente] c
  INNER JOIN [Frutillitas].[TipoDocumento] t on c.tipoDocumentoId = t.id
  WHERE c.[tipoDocumentoId] = @tipoDocoumentoId and c.[numeroDocumento] = @numeroDocumento
  END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetClienteById]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[GetClienteById]

@id int

AS
BEGIN
	SET NOCOUNT ON;
	
SELECT c.[id]
      ,c.[tipoDocumentoId]
      ,c.[numeroDocumento]
      ,c.[nombre]
      ,c.[apellido]
      ,c.[fechaNacimiento]
      ,c.[mail]
      ,c.[direccion]
      ,c.[nacionalidadId]
      ,c.[habilitado]
      ,c.[telefono]
	  ,t.[nombre] as tipoDocumentoNombre
  FROM [Frutillitas].[Cliente] c
  INNER JOIN [Frutillitas].[TipoDocumento] t on c.tipoDocumentoId = t.id
  WHERE c.[id] = @id
  END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetClienteByEmail]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[GetClienteByEmail]

@email nvarchar(255)

AS
BEGIN
	SET NOCOUNT ON;
	
SELECT c.[id]
      ,c.[tipoDocumentoId]
      ,c.[numeroDocumento]
      ,c.[nombre]
      ,c.[apellido]
      ,c.[fechaNacimiento]
      ,c.[mail]
      ,c.[direccion]
      ,c.[nacionalidadId]
      ,c.[habilitado]
      ,c.[telefono]
	  ,t.[nombre] as tipoDocumentoNombre
  FROM [Frutillitas].[Cliente] c
  INNER JOIN [Frutillitas].[TipoDocumento] t on c.tipoDocumentoId = t.id
  WHERE c.[mail] = @email
  END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetCiudadesByPaisId]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[GetCiudadesByPaisId]

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
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetCiudades]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[GetCiudades]

AS
BEGIN
	SET NOCOUNT ON;
	
SELECT [id]
      ,[nombre]
	  ,[paisId]
  FROM [GD2C2014].[Frutillitas].[Ciudad]
END
' 
END
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
      rf.[funcionalidadId] AS [funcionalidadId],
      f.[nombre] AS [nombre]
  FROM [GD2C2014].[Frutillitas].[RolFuncionalidad] rf
  INNER JOIN [Frutillitas].[Funcionalidad] f ON rf.funcionalidadId = f.id
  WHERE [rolId] = @rolId
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[DeleteUsuarioLog]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[DeleteUsuarioLog]
@username nvarchar(255)
AS
BEGIN
	SET NOCOUNT ON;
	
	DECLARE @usuarioId int
	SELECT @usuarioId = id FROM [Frutillitas].[Usuario] WHERE username = @username
	
	DELETE FROM [Frutillitas].[UsuarioLog] WHERE usuarioId = @usuarioId
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetUsuarios]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
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
	LEFT JOIN [Frutillitas].TipoDocumento td ON td.id = u.tipoDocumentoId
	INNER JOIN [Frutillitas].UsuarioRol ur ON ur.usuarioId = u.id
	INNER JOIN [Frutillitas].Rol r ON r.id = ur.rolId
	WHERE 
		(@username IS NULL OR u.username LIKE ''%'' + @username + ''%'') AND
		(@nombre IS NULL OR u.nombre LIKE ''%'' + @nombre + ''%'') AND
		(@apellido IS NULL OR u.apellido LIKE ''%'' + @apellido + ''%'') AND
		(@tipoDocumentoId IS NULL OR u.tipoDocumentoId = @tipoDocumentoId) AND
		(@numeroDocumento IS NULL OR u.numeroDocumento = @numeroDocumento) AND
		(@mail IS NULL OR u.mail LIKE ''%'' + @mail + ''%'') AND
		(@telefono IS NULL OR u.telefono LIKE ''%'' + @telefono + ''%'') AND
		(@direccion IS NULL OR u.direccion LIKE ''%'' + @direccion + ''%'') AND
		(@fechaNacimiento IS NULL OR u.fechaNacimiento = @fechaNacimiento) AND
		(@rolId IS NULL OR r.id = @rolId)
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetUsuarioByUsernameAndPassword]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
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
		u.password = @password AND
		u.habilitado = 1
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertCliente]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[InsertCliente]


@tipoDocumentoId int
,@numeroDocumento numeric(18,0)
,@nombre nvarchar(255)
,@apellido nvarchar(255)
,@fechaNacimiento datetime
,@mail nvarchar(255)
,@direccion nvarchar(255)
,@nacionalidadId int
,@telefono nvarchar(255)

AS
BEGIN

SET NOCOUNT ON;
declare @id int

INSERT INTO [Frutillitas].[Cliente]
           ([tipoDocumentoId]
           ,[numeroDocumento]
           ,[nombre]
           ,[apellido]
           ,[fechaNacimiento]
           ,[mail]
           ,[direccion]
           ,[nacionalidadId]
           ,[habilitado]
           ,[telefono])
     VALUES
           (@tipoDocumentoId
			,@numeroDocumento 
			,@nombre 
			,@apellido
			,@fechaNacimiento
			,@mail 
			,@direccion
			,@nacionalidadId
			,1
			,@telefono)

		   set @id = SCOPE_IDENTITY()
		   select @id
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertUsuarioLog]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[InsertUsuarioLog]
@username nvarchar(255)
AS
BEGIN
	SET NOCOUNT ON;
	
	DECLARE @usuarioId int
	SELECT @usuarioId = id FROM [Frutillitas].[Usuario] WHERE username = @username
	
	INSERT INTO [Frutillitas].[UsuarioLog]
	(
		usuarioId,
		fecha
	)
	VALUES
	(
		@usuarioId,
		GETDATE()
	)
	
	IF (SELECT COUNT(*) FROM [Frutillitas].[UsuarioLog] WHERE usuarioId = @usuarioId) >= 3
	BEGIN
		UPDATE [Frutillitas].[Usuario] SET habilitado = 0 WHERE id = @usuarioId
	END
END
' 
END
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
@rolId int,
@habilitado bit
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
		@habilitado,
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
@mail nvarchar(255),
@telefono nvarchar(255)

AS
BEGIN

SET NOCOUNT ON;
declare @id int

INSERT INTO [Frutillitas].[Hotel]
           ([nombre]
           ,[ciudadId]
           ,[direccion]
           ,[estrellas]
           ,[mail]
           ,[fechaCreacion]
		   ,[telefono])
     VALUES
           (@nombre
		   ,@ciudadId
           ,@direccion
           ,@estrellas
           ,@mail
           ,@fechaCreacion
		   ,@telefono)

		   set @id = SCOPE_IDENTITY()
		   select @id
		   
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetHoteles]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
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
		(@nombre IS NULL OR h.nombre LIKE ''%'' + @nombre + ''%'') AND
		(@estrellas IS NULL OR h.estrellas = @estrellas) AND
		(@ciudadId IS NULL OR c.id = @ciudadId) AND
		(@paisId IS NULL OR p.id = @paisId)

END
' 
END
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
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[UpdateReserva]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[UpdateReserva]	
@codigo numeric(18, 0),
@fechaDesde datetime,
@fechaHasta datetime,
@regimenCodigo numeric(18, 0),
@hotelId int
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [Frutillitas].[Reserva]
	SET fechaDesde = @fechaDesde,
		fechaHasta = @fechaHasta,
		regimenCodigo = @regimenCodigo,
		hotelId = @hotelId,
		estadoId = 2
	WHERE codigo = @codigo
END 
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[UpdateHotel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[UpdateHotel]
@id int,
@nombre nvarchar(255),
@ciudadId int,
@estrellas int,
@mail nvarchar(255),
@telefono nvarchar(255),
@direccion nvarchar(255)
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [Frutillitas].[Hotel]
   SET [nombre] = @nombre
      ,[ciudadId] = @ciudadId
      ,[direccion] = @direccion
      ,[estrellas] = @estrellas
      ,[mail] = @mail
      ,[telefono] = @telefono
 WHERE id = @id
	
	DELETE FROM [Frutillitas].[HotelRegimen]  WHERE hotelId = @id
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[UpdateHabitacion]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[UpdateHabitacion]
@id int,
@frente bit = null,
@activa bit = null,
@numero numeric(18,0) = null,
@piso numeric(18,0) = null,
@descripcion nvarchar(255) = null,
@tipoHabitacionCodigo int,
@hotelId int
AS
BEGIN
	SET NOCOUNT ON;
	
	DECLARE @EsFrente nvarchar(1)
	IF @frente IS NULL
	BEGIN
		SET @EsFrente = null
	END
	ELSE
	BEGIN
		IF @frente = 1
		BEGIN
			SET @EsFrente = ''S''
		END
		ELSE
		BEGIN
			SET @EsFrente = ''N''
		END
	END
	
	UPDATE [Frutillitas].[Habitacion]
	SET
		frente = @EsFrente,
		activa = @activa,
		numero = @numero,
		piso = @piso,
		descripcion = @descripcion,
		tipoCodigo = @tipoHabitacionCodigo,
		hotelId = @hotelId
	WHERE
		id = @id
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[UpdateEstadoReserva]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[UpdateEstadoReserva]
@codigo numeric(18, 0),
@estadoId int
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [Frutillitas].[Reserva] SET [estadoId] = @estadoId
	WHERE [codigo] = @codigo
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetReservasVencidas]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[GetReservasVencidas]
@fecha smalldatetime
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT
		r.codigo
	FROM [Frutillitas].[Reserva] r
	WHERE 
		r.fechaDesde < @fecha AND
		r.estadoId IN (1, 2)
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetReservasPosteriores]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[GetReservasPosteriores]
@codigo numeric(18,0),
@clienteId int
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT
		r.codigo
	FROM [Frutillitas].[Reserva] r
	WHERE 
		r.fechaDesde > (SELECT fechaDesde FROM [Frutillitas].[Reserva] WHERE codigo = @codigo) AND
		r.clienteId = @clienteId
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetReservaCountByDatesAndHotel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[GetReservaCountByDatesAndHotel]

@fechaDesde datetime,
@fechaHasta datetime,
@hotelId int

AS
BEGIN
	SET NOCOUNT ON;
	
SELECT COUNT([codigo])
  FROM [Frutillitas].[Reserva]
  WHERE
   [hotelId] = @hotelId AND
  (([fechaDesde] >= @fechaDesde AND [fechaDesde] <= @fechaHasta) OR
  ([fechaHasta] >= @fechaDesde AND [fechaHasta] <= @fechaHasta))
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetReservaByCodigo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[GetReservaByCodigo]
@codigo [numeric](18, 0),
@hotelId int = null
AS
BEGIN
	SET NOCOUNT ON;
	SELECT res.[codigo], res.[fechaDesde], res.[fechaHasta], res.[regimenCodigo], res.[hotelId], res.[clienteId]
	FROM [Frutillitas].[Reserva] res
	WHERE 
		res.[codigo] = @codigo AND 
		(@hotelId IS NULL OR res.hotelId = @hotelId) AND
		res.estadoId IN (1,2)
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetRegimenesByHotel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[GetRegimenesByHotel]

@hotelId int

AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT [hotelId]
      ,[regimenCodigo]
  FROM [Frutillitas].[HotelRegimen]
  WHERE [hotelId] = @hotelId
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetListadoHotelesReservasCanceladas]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[GetListadoHotelesReservasCanceladas]
@fechaDesde datetime,
@fechaHasta datetime
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT TOP 5 (SELECT [nombre] FROM [Frutillitas].[Hotel] WHERE [id] = r.[hotelId]) as [Hotel], COUNT(1) as [CantReservasCanceladas]
	FROM [Frutillitas].[Reserva] r
	WHERE ([estadoId] = 3 OR r.[estadoId] = 4 OR r.[estadoId] = 5) AND r.[fechaDesde] BETWEEN @fechaDesde AND @fechaHasta
	GROUP BY r.[hotelId]
	ORDER BY COUNT(1) DESC
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetListadoHotelesFueraDeServicio]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[GetListadoHotelesFueraDeServicio]
@fechaDesde datetime,
@fechaHasta datetime
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT TOP 5 (SELECT [nombre] FROM [Frutillitas].[Hotel] WHERE [id] = hi.[hotelId]) as [Hotel], SUM(DATEDIFF(DAY, hi.[fechaInicio], hi.[fechaFin])) as [CantFueraDeServicio]
	FROM [Frutillitas].[HotelInhabilitacion] hi
	WHERE hi.[fechaInicio] BETWEEN @fechaDesde AND @fechaHasta
	GROUP BY hi.[hotelId]
	ORDER BY SUM(DATEDIFF(DAY, [fechaInicio], [fechaFin])) DESC
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetHotelesByIdUsuario]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[GetHotelesByIdUsuario]
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
		h.mail AS Mail,
		h.fechaCreacion AS FechaCreacion,
		h.telefono AS Telefono
	FROM [Frutillitas].UsuarioHotel uh
	INNER JOIN [Frutillitas].Hotel h ON h.id = uh.hotelId
	LEFT JOIN [Frutillitas].Ciudad c ON c.id = h.ciudadId
	LEFT JOIN [Frutillitas].Pais p ON p.id = c.paisId
	WHERE uh.usuarioId = @usuarioId
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetHabitaciones]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[GetHabitaciones]
@frente bit = null,
@numero numeric(18,0) = null,
@piso numeric(18,0) = null,
@descripcion nvarchar(255) = null,
@hotelId int = null,
@tipoHabitacion int = null,
@activa bit = null
AS
BEGIN
	
	DECLARE @EsFrente nvarchar(1)
	IF @frente IS NULL
	BEGIN
		SET @EsFrente = null
	END
	ELSE
	BEGIN
		IF @frente = 1
		BEGIN
			SET @EsFrente = ''S''
		END
		ELSE
		BEGIN
			SET @EsFrente = ''N''
		END
	END
		
	SET NOCOUNT ON;
	
	SELECT
		habitacion.*,
		tipo.codigo AS CodigoTipoHabitacion,
		tipo.descripcion AS DescripcionTipoHabitacion,
		tipo.porcentual AS Porcentual,
		hotel.id AS IdHotel,
		hotel.nombre AS Nombre,
		hotel.direccion AS Direccion,
		hotel.estrellas AS Estrellas,
		hotel.mail AS Mail,
		hotel.fechaCreacion AS FechaCreacion,
		hotel.telefono AS Telefono,
		c.id AS CiudadId,
		c.nombre AS CiudadNombre,
		p.id AS PaisId,
		p.nombre AS PaisNombre,
		p.nacionalidad AS PaisNacionalidad
	FROM [Frutillitas].Habitacion habitacion
	INNER JOIN [Frutillitas].TipoHabitacion tipo ON tipo.codigo = habitacion.tipoCodigo
	INNER JOIN [Frutillitas].Hotel hotel ON hotel.id = habitacion.hotelId
	LEFT JOIN [Frutillitas].Ciudad c ON c.id = hotel.ciudadId
	LEFT JOIN [Frutillitas].Pais p ON p.id = c.paisId
	WHERE
		(@EsFrente IS NULL OR habitacion.frente = @EsFrente) AND
		(@activa IS NULL OR habitacion.activa = @activa) AND
		(@numero IS NULL OR habitacion.numero = @numero) AND
		(@piso IS NULL OR habitacion.piso = @piso) AND
		(@descripcion IS NULL OR habitacion.descripcion LIKE ''%'' + @descripcion + ''%'') AND
		(@hotelId IS NULL OR habitacion.hotelId = @hotelId) AND
		(@tipoHabitacion IS NULL OR habitacion.tipoCodigo = @tipoHabitacion)
	ORDER BY hotel.id
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetActiveReservaRegimenesByHotelId]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[GetActiveReservaRegimenesByHotelId]
@hotelId int,
@fecha datetime
AS
BEGIN
	SET NOCOUNT ON;
	SELECT DISTINCT reg.descripcion AS descripcion, reg.codigo AS codigo	
	FROM [Frutillitas].Reserva res
	INNER JOIN [Frutillitas].Regimen reg
	ON res.regimenCodigo = reg.codigo
	WHERE
	res.hotelId = @hotelId AND
	res.estadoId <> 3 AND
	res.estadoId <> 4 AND
	res.estadoId <> 5 AND
	(res.fechaDesde > @fecha OR
	(res.fechaDesde < @fecha AND res.fechaHasta > @fecha))

END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetActiveReservaBetweenDatesByHotel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[GetActiveReservaBetweenDatesByHotel]
@hotelId int,
@fechaDesde smalldatetime,
@fechaHasta smalldatetime
AS
BEGIN
	SET NOCOUNT ON;
	SELECT res.codigo
	FROM [Frutillitas].Reserva res
	WHERE
	res.hotelId = @hotelId AND
	res.estadoId <> 3 AND
	res.estadoId <> 4 AND
	res.estadoId <> 5 AND
	((res.fechaDesde between @fechaDesde and @fechaHasta) or 
	(res.fechaHasta between @fechaDesde and @fechaHasta))

END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[ExistsHabitacion]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[ExistsHabitacion]
@hotelId int,
@numero numeric(18,0),
@piso numeric(18,0)
AS
BEGIN
	SET NOCOUNT ON;
	
	IF (SELECT 
			COUNT(*)
		FROM [Frutillitas].[Habitacion]
		WHERE
			numero = @numero AND
			piso = @piso AND
			hotelId = @hotelId) = 0
	BEGIN
		SELECT 0
	END
	ELSE
	BEGIN
		SELECT 1
	END
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertReserva]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[InsertReserva]	
@fechaDesde datetime,
@fechaHasta datetime,
@regimenCodigo numeric(18, 0),
@hotelId int,
@estadoId int,
@clienteId int,
@fechaCreacion datetime
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @id int
	
	INSERT INTO [Frutillitas].[Reserva](fechaDesde, fechaHasta, regimenCodigo, hotelId, estadoId, clienteId, fechaCreacion)
	VALUES (@fechaDesde, @fechaHasta, @regimenCodigo, @hotelId, @estadoId, @clienteId, @fechaCreacion)
		
	SET @id = SCOPE_IDENTITY()
	SELECT @id
END 
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertHotelUsuario]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[InsertHotelUsuario]


@usuarioId int,
@hotelId int

AS
BEGIN

SET NOCOUNT ON;

INSERT INTO [Frutillitas].[UsuarioHotel]
           ([usuarioId]
           ,[hotelId])
     VALUES
           (@usuarioId
           ,@hotelId)
		   
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertHotelRegimen]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[InsertHotelRegimen]

@hotelId int,
@regimenCodigo int

AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [Frutillitas].[HotelRegimen]
           ([hotelId]
           ,[regimenCodigo])
     VALUES
           (@hotelId
           ,@regimenCodigo)
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertHotelInhabilitado]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[InsertHotelInhabilitado]
@hotelId int,
@fechaInicio datetime,
@fechaFin datetime,
@descripcion nvarchar(255),
@fechaCreacion datetime
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [Frutillitas].[HotelInhabilitacion]
           ([hotelId]
           ,[fechaInicio]
           ,[fechaFin]
           ,[descripcion]
           ,[fechaCreacion])
     VALUES
           (@hotelId
           ,@fechaInicio
           ,@fechaFin
           ,@descripcion
           ,@fechaCreacion)

END
' 
END
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
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertHabitacion]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[InsertHabitacion]
@frente bit = null,
@activa bit = null,
@numero numeric(18,0) = null,
@piso numeric(18,0) = null,
@descripcion nvarchar(255) = null,
@tipoHabitacionCodigo int,
@hotelId int
AS
BEGIN
	SET NOCOUNT ON;
	
	DECLARE @EsFrente nvarchar(1)
	IF @frente IS NULL
	BEGIN
		SET @EsFrente = null
	END
	ELSE
	BEGIN
		IF @frente = 1
		BEGIN
			SET @EsFrente = ''S''
		END
		ELSE
		BEGIN
			SET @EsFrente = ''N''
		END
	END
	
	INSERT INTO [Frutillitas].[Habitacion]
	(
		frente,
		activa,
		numero,
		piso,
		descripcion,
		tipoCodigo,
		hotelId
	)
	VALUES
	(
		@EsFrente,
		@activa,
		@numero,
		@piso,
		@descripcion,
		@tipoHabitacionCodigo,
		@hotelId
	)
	
	DECLARE @IdHabitacion int
	SET @IdHabitacion = SCOPE_IDENTITY()
	
	SELECT @IdHabitacion
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertReservaTipoHabitacion]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[InsertReservaTipoHabitacion]
@reservaCodigo numeric(18, 0),
@tipoHabitacionCodigo numeric(18, 0)
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [Frutillitas].[ReservaTipoHabitacion](reservaCodigo, tipoHabitacionCodigo)
	VALUES (@reservaCodigo, @tipoHabitacionCodigo)
END 
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertReservaLog]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[InsertReservaLog]
@reservaCodigo [numeric](18, 0),
@fecha datetime,
@usuarioId int,
@tipoId int,
@motivo nvarchar(255)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [Frutillitas].[ReservaLog] ([reservaCodigo], [fecha], [usuarioId], [tipoId], [motivo])
	VALUES (@reservaCodigo, @fecha, @usuarioId, @tipoId, @motivo)
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertEstadia]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[InsertEstadia]
@codigoReserva numeric(18,0),
@usuarioId int
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [Frutillitas].[Estadia]
	(
		reservaCodigo,
		fechaDesde,
		fechaHasta,
		usuarioCheckInId,
		usuarioCheckOutId	
	)
	VALUES
	(
		@codigoReserva,
		GETDATE(),
		null,
		@usuarioId,
		null
	)
	
	DECLARE @id int
	set @id = SCOPE_IDENTITY()
	select @id
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetTipoHabitacionByReserva]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[GetTipoHabitacionByReserva]
@reservaCodigo [numeric](18, 0)
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT [tipoHabitacionCodigo]
	FROM [Frutillitas].[ReservaTipoHabitacion]
	WHERE [reservaCodigo] = @reservaCodigo
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetListadoHabitacionDias]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[GetListadoHabitacionDias]
@fechaDesde datetime,
@fechaHasta datetime
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT TOP 5 (SELECT [descripcion] FROM [Frutillitas].[TipoHabitacion] WHERE [codigo] = tph.[tipoHabitacionCodigo]) as [Habitacion], (SELECT [nombre] FROM [Frutillitas].[Hotel] WHERE [id] = r.[hotelId]) as [Hotel], SUM(DATEDIFF(DAY, r.[fechaDesde], r.[fechaHasta])) as [CantDiasOcupadas]
	FROM [Frutillitas].[ReservaTipoHabitacion] tph
	INNER JOIN [Frutillitas].[Reserva] r ON r.[codigo] = tph.[reservaCodigo]
	WHERE [estadoId] = 6 AND r.[fechaDesde] BETWEEN @fechaDesde AND @fechaHasta
	GROUP BY tph.[tipoHabitacionCodigo], r.[hotelId]
	ORDER BY SUM(DATEDIFF(DAY, r.[fechaDesde], r.[fechaHasta])) DESC
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetListadoHabitacionCantidad]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[GetListadoHabitacionCantidad]
@fechaDesde datetime,
@fechaHasta datetime
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT TOP 5 (SELECT [descripcion] FROM [Frutillitas].[TipoHabitacion] WHERE [codigo] = tph.[tipoHabitacionCodigo]) as [Habitacion], (SELECT [nombre] FROM [Frutillitas].[Hotel] WHERE [id] = r.[hotelId]) as [Hotel], COUNT(1) as [CantVecesOcupadas]
	FROM [Frutillitas].[ReservaTipoHabitacion] tph
	INNER JOIN [Frutillitas].[Reserva] r ON r.[codigo] = tph.[reservaCodigo]
	WHERE [estadoId] = 6 AND r.[fechaDesde] BETWEEN @fechaDesde AND @fechaHasta
	GROUP BY tph.[tipoHabitacionCodigo], r.[hotelId]
	ORDER BY COUNT(1) DESC
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetEstadiaById]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[GetEstadiaById]
@id int
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT
		*
	FROM [Frutillitas].[Estadia]
	WHERE
		id = @id
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetEstadiaByCodigoReserva]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[GetEstadiaByCodigoReserva]
@codigoReserva numeric(18,0),
@hotelId numeric(18,0)
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT
		e.*
	FROM [Frutillitas].[Estadia] e
	INNER JOIN [Frutillitas].[Reserva] r ON e.reservaCodigo = r.codigo
	WHERE
		e.reservaCodigo = @codigoReserva AND
		r.hotelId = @hotelId
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[DeleteReservaTipoHabitacion]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[DeleteReservaTipoHabitacion]
@reservaCodigo numeric(18, 0)
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [Frutillitas].[ReservaTipoHabitacion]
	WHERE reservaCodigo = @reservaCodigo
END 
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[CountPosibleReserva]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[CountPosibleReserva]
@hotelId int,
@fechaDesde datetime,
@fechaHasta datetime,
@tipoHabitacionCodigo numeric(18, 0)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT COUNT(DISTINCT hab.id)
	FROM [Frutillitas].[Habitacion] hab	
	WHERE hab.hotelId = @hotelId
		AND NOT EXISTS (SELECT 1 FROM [Frutillitas].[HotelInhabilitacion] WHERE [hotelId] = hab.hotelId AND (@fechaDesde BETWEEN [fechaInicio] AND [fechaFin] OR @fechaHasta BETWEEN [fechaInicio] AND [fechaFin]))
		AND hab.tipoCodigo = @tipoHabitacionCodigo
		AND hab.id NOT IN (
			SELECT DISTINCT hab2.id
			FROM [Frutillitas].[Habitacion] hab2
			JOIN [Frutillitas].[Reserva] res ON res.hotelId = hab2.hotelId
			JOIN [Frutillitas].[ReservaTipoHabitacion] resTipo ON resTipo.tipoHabitacionCodigo = hab2.tipoCodigo AND resTipo.reservaCodigo = res.codigo
			WHERE hab2.hotelId = @hotelId
				AND hab2.tipoCodigo = @tipoHabitacionCodigo 
				AND ((res.fechaDesde BETWEEN @fechaDesde AND @fechaHasta) OR 
					(res.fechaDesde BETWEEN @fechaDesde AND @fechaHasta))
				AND res.estadoId = 1 OR res.estadoId = 2)
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[UpdateEstadia]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[UpdateEstadia]
@estadiaId int,
@codigoReserva numeric(18,0),
@usuarioId int
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [Frutillitas].[Estadia]
	SET
		fechaHasta = GETDATE(),
		usuarioCheckOutId = @usuarioId
	WHERE
		reservaCodigo = @codigoReserva AND
		id = @estadiaId
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetListadoHotelesConsumiblesFacturados]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[GetListadoHotelesConsumiblesFacturados]
@fechaDesde datetime,
@fechaHasta datetime
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT TOP 5 (SELECT [nombre] FROM [Frutillitas].[Hotel] WHERE [id] = r.[hotelId]) as [Hotel], COUNT(1) as [CantConsumiblesFacturados]
	FROM [Frutillitas].[Estadia] e
	INNER JOIN [Frutillitas].[Reserva] r ON r.[codigo] = e.[reservaCodigo]
	INNER JOIN [Frutillitas].[Factura] f ON f.[estadiaId] = e.[id]
	INNER JOIN [Frutillitas].[EstadiaConsumible] ec ON ec.[estadiaId] = e.[id]
	WHERE r.[fechaDesde] BETWEEN @fechaDesde AND @fechaHasta
	GROUP BY r.[hotelId]
	ORDER BY COUNT(1) DESC
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetConsumiblesByIdEstadia]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[GetConsumiblesByIdEstadia]
@idEstadia int
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT
		c.*
	FROM [Frutillitas].[EstadiaConsumible] e
	LEFT JOIN [Frutillitas].[Consumible] c ON c.codigo = e.consumibleCodigo
	WHERE
		e.estadiaId = @idEstadia
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetClienteByEstadiaId]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[GetClienteByEstadiaId]

@estadiaId int

AS
BEGIN
	SET NOCOUNT ON;
	
SELECT c.[id]
      ,c.[tipoDocumentoId]
      ,c.[numeroDocumento]
      ,c.[nombre]
      ,c.[apellido]
      ,c.[fechaNacimiento]
      ,c.[mail]
      ,c.[direccion]
      ,c.[nacionalidadId]
      ,c.[habilitado]
      ,c.[telefono]
	  ,t.[nombre] as tipoDocumentoNombre
  FROM [Frutillitas].[EstadiaCliente] e
  INNER JOIN [Frutillitas].[Cliente] c on e.clienteId = c.id
  INNER JOIN [Frutillitas].[TipoDocumento] t on c.tipoDocumentoId = t.id
  WHERE e.[estadiaId] = @estadiaId
  END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertFactura]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[InsertFactura]


@fecha datetime,
@total numeric(18,2),
@estadiaId int,
@tipoPagoId int,
@clienteId int

AS
BEGIN

SET NOCOUNT ON;
declare @numero int

INSERT INTO [Frutillitas].[Factura]
           (
           [fecha]
           ,[total]
           ,[estadiaId]
           ,[tipoPagoId]
		   ,[clienteId])
     VALUES
           (
           @fecha
           ,@total
           ,@estadiaId
           ,@tipoPagoId
		   ,@clienteId)

		   set @numero = SCOPE_IDENTITY()
		   select @numero
		   
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertEstadiaConsumible]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[InsertEstadiaConsumible]
@consumibleCodigo numeric(18,0),
@idEstadia int
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [Frutillitas].[EstadiaConsumible]
	(
		estadiaId,
		consumibleCodigo
	)
	VALUES
	(
		@idEstadia,
		@consumibleCodigo
	)
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertEstadiaCliente]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[InsertEstadiaCliente]
@estadiaId int,
@clienteId int
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [Frutillitas].[EstadiaCliente]
           ([estadiaId]
           ,[clienteId])
     VALUES
           (@estadiaId
           ,@clienteId)

END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertTarjetaDeCredito]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[InsertTarjetaDeCredito]

@facturaNumero numeric(18,0),
@numero numeric(16,0),
@codigo nvarchar(10),
@fechaVencimiento datetime,
@codigoSeguridad numeric(4,0)

AS
BEGIN

SET NOCOUNT ON;

INSERT INTO [Frutillitas].[TarjetaDeCredito]
           ([facturaNumero]
           ,[numero]
           ,[codigo]
           ,[fechaVencimiento]
           ,[codigoSeguridad])
     VALUES
           (@facturaNumero
           ,@numero
           ,@codigo
           ,@fechaVencimiento
           ,@codigoSeguridad)
		   
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertFacturaItem]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[InsertFacturaItem]

@facturaNumero numeric(18,0)
,@descripcion nvarchar(255)
,@precio numeric(18,2)

AS
BEGIN

SET NOCOUNT ON;

INSERT INTO [Frutillitas].[FacturaItem]
           ([facturaNumero]
           ,[descripcion]
           ,[precio])
     VALUES
           (@facturaNumero
           ,@descripcion
           ,@precio)		   
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetListadoClientePuntos]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[GetListadoClientePuntos]
@fechaDesde datetime,
@fechaHasta datetime
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT TOP 5 (SELECT [nombre] + '' '' + [apellido] FROM [Frutillitas].[Cliente] WHERE [id] = f.[clienteId]) as [Cliente], SUM(fi.[precio] / (CASE WHEN LEFT(fi.[descripcion], 11) = ''Consumible:'' THEN 5 WHEN LEFT(fi.[descripcion], 9) = ''Descuento'' THEN 5 WHEN LEFT(fi.[descripcion], 8) = ''Estadia:'' THEN 10 END)) as [Puntos]
	FROM [Frutillitas].[Factura] f
	INNER JOIN [Frutillitas].[FacturaItem] fi ON fi.[facturaNumero] = f.[numero]
	WHERE f.[fecha] BETWEEN @fechaDesde AND @fechaHasta
	GROUP BY f.[clienteId]
	ORDER BY SUM(fi.[precio] / (CASE WHEN LEFT(fi.[descripcion], 11) = ''Consumible:'' THEN 5 WHEN LEFT(fi.[descripcion], 9) = ''Descuento'' THEN 5 WHEN LEFT(fi.[descripcion], 8) = ''Estadia:'' THEN 10 END)) DESC
END
' 
END
GO

/******************* MIGRATION **********************/
INSERT INTO [Frutillitas].[TipoDocumento] ([nombre]) VALUES ('Pasaporte')
GO

INSERT INTO [Frutillitas].[Pais]([nombre], [nacionalidad]) VALUES ('Argentina', 'Argentino')
GO

INSERT INTO [Frutillitas].[Funcionalidad]([nombre]) VALUES ('Usuario')
GO
INSERT INTO [Frutillitas].[Funcionalidad]([nombre]) VALUES ('Hotel')
GO
INSERT INTO [Frutillitas].[Funcionalidad]([nombre]) VALUES ('Habitacion')
GO
INSERT INTO [Frutillitas].[Funcionalidad]([nombre]) VALUES ('Regimen')
GO
INSERT INTO [Frutillitas].[Funcionalidad]([nombre]) VALUES ('Cliente')
GO
INSERT INTO [Frutillitas].[Funcionalidad]([nombre]) VALUES ('Reserva')
GO
INSERT INTO [Frutillitas].[Funcionalidad]([nombre]) VALUES ('Estadia')
GO
INSERT INTO [Frutillitas].[Funcionalidad]([nombre]) VALUES ('EstadiaConsumible')
GO
INSERT INTO [Frutillitas].[Funcionalidad]([nombre]) VALUES ('Factura')
GO
INSERT INTO [Frutillitas].[Funcionalidad]([nombre]) VALUES ('Listado')
GO

INSERT INTO [Frutillitas].[Rol]([nombre], [activo]) VALUES ('Administrador', 1)
GO
INSERT INTO [Frutillitas].[Rol]([nombre], [activo]) VALUES ('Recepcionista', 1)
GO
INSERT INTO [Frutillitas].[Rol]([nombre], [activo]) VALUES ('Guest', 1)
GO

INSERT INTO [Frutillitas].[RolFuncionalidad]([rolId], [funcionalidadId])
SELECT r.[id], f.[id]
FROM [Frutillitas].[Rol] r, [Frutillitas].[Funcionalidad] f
WHERE r.[nombre] = 'Administrador'
GO

INSERT INTO [Frutillitas].[RolFuncionalidad]([rolId], [funcionalidadId])
SELECT r.[id], f.[id]
FROM [Frutillitas].[Rol] r, [Frutillitas].[Funcionalidad] f
WHERE r.[nombre] = 'Recepcionista' AND f.[nombre] IN ('Cliente', 'Reserva', 'Estadia', 'EstadiaConsumible', 'Factura')
GO

INSERT INTO [Frutillitas].[RolFuncionalidad]([rolId], [funcionalidadId])
SELECT r.[id], f.[id]
FROM [Frutillitas].[Rol] r, [Frutillitas].[Funcionalidad] f
WHERE r.[nombre] = 'Guest' AND f.[nombre] = 'Reserva'
GO

INSERT INTO [Frutillitas].[Usuario]([username], [password], [habilitado]) VALUES ('admin', 0xE6B87050BFCB8143FCB8DB0170A4DC9ED00D904DDD3E2A4AD1B1E8DC0FDC9BE7, 1)
GO

INSERT INTO [Frutillitas].[UsuarioRol]([usuarioId], [rolId])
SELECT u.[id], r.[id]
FROM [Frutillitas].[Usuario] u, [Frutillitas].[Rol] r
WHERE u.[username] = 'admin' AND r.[nombre] = 'Administrador'
GO

INSERT INTO [Frutillitas].[Usuario]([username], [password], [habilitado]) VALUES ('guest', 0x84983c60f7daadc1cb8698621f802c0d9f9a3c3c295c810748fb048115c186ec, 1)
GO
INSERT INTO [Frutillitas].[UsuarioRol]([usuarioId], [rolId])
SELECT u.[id], r.[id]
FROM [Frutillitas].[Usuario] u, [Frutillitas].[Rol] r
WHERE u.[username] = 'guest' AND r.[nombre] = 'Guest'
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
    1/*[Cliente_Nacionalidad]*/,
    1,
    NULL
FROM [GD2C2014].[gd_esquema].[Maestra]
GO

INSERT INTO [Frutillitas].[Consumible]([codigo], [descripcion], [precio])
SELECT DISTINCT [Consumible_Codigo] ,[Consumible_Descripcion] ,[Consumible_Precio]      
FROM [GD2C2014].[gd_esquema].[Maestra] WHERE [Consumible_Codigo] IS NOT NULL
GO

INSERT INTO [Frutillitas].[Regimen]([descripcion], [precio], [consumiblesGratis], [activo])
SELECT DISTINCT [Regimen_Descripcion], [Regimen_Precio], 1, 1
FROM [GD2C2014].[gd_esquema].[Maestra]
WHERE [Regimen_Descripcion] LIKE 'all inclusive%'
GO

INSERT INTO [Frutillitas].[Regimen]([descripcion], [precio], [consumiblesGratis], [activo])
SELECT DISTINCT [Regimen_Descripcion], [Regimen_Precio], 0, 1
FROM [GD2C2014].[gd_esquema].[Maestra]
WHERE [Regimen_Descripcion] NOT LIKE 'all inclusive%'
GO

INSERT INTO [Frutillitas].[Hotel]([ciudadId], [direccion], [estrellas], [mail], [fechaCreacion])
SELECT DISTINCT (SELECT [id] FROM [Frutillitas].[Ciudad] WHERE [nombre] LIKE [Hotel_Ciudad]), [Hotel_Calle] + ' ' + CAST([Hotel_Nro_Calle] as nvarchar(255)), [Hotel_CantEstrella], NULL, GETDATE()
FROM [GD2C2014].[gd_esquema].[Maestra]
GO

UPDATE [Frutillitas].[Hotel] SET [nombre] = ('Hotel ' + [direccion])
GO

INSERT INTO [Frutillitas].[UsuarioHotel]([usuarioId], [hotelId])
SELECT (SELECT [id] FROM [Frutillitas].[Usuario] WHERE [username] = 'admin'), [id]
FROM [Frutillitas].[Hotel]
GO

INSERT INTO [Frutillitas].[HotelIncrementoEstrella]([incremento])
SELECT TOP 1 [Hotel_Recarga_Estrella] FROM [GD2C2014].[gd_esquema].[Maestra]
GO

/*Por ahora dejo un todos contra todos, después hay que preguntar si solo ponemos los minimos*/
INSERT INTO [Frutillitas].[HotelRegimen]([hotelId], [regimenCodigo])
SELECT h.[id], r.[codigo]
FROM [Frutillitas].[Hotel] h, [Frutillitas].[Regimen] r
GO

INSERT INTO [Frutillitas].[TipoHabitacion]([codigo], [descripcion], [porcentual])
SELECT DISTINCT [Habitacion_Tipo_Codigo], [Habitacion_Tipo_Descripcion], [Habitacion_Tipo_Porcentual]
FROM [GD2C2014].[gd_esquema].[Maestra]
GO

INSERT INTO [Frutillitas].[Habitacion]([hotelId], [tipoCodigo], [numero], [piso], [frente], [descripcion], [activa])
SELECT DISTINCT (SELECT [id] FROM [Frutillitas].[Hotel] WHERE [direccion] = [Hotel_Calle] + ' ' + CAST([Hotel_Nro_Calle] as nvarchar(255))), [Habitacion_Tipo_Codigo], [Habitacion_Numero], [Habitacion_Piso], [Habitacion_Frente], NULL/*Ni idea la descripcion*/, 1
FROM [GD2C2014].[gd_esquema].[Maestra]
GO

INSERT INTO [Frutillitas].[ReservaEstado]([descripcion]) VALUES ('Correcta')
GO
INSERT INTO [Frutillitas].[ReservaEstado]([descripcion]) VALUES ('Modificada')
GO
INSERT INTO [Frutillitas].[ReservaEstado]([descripcion]) VALUES ('Cancelada-Recepcion')
GO
INSERT INTO [Frutillitas].[ReservaEstado]([descripcion]) VALUES ('Cancelada-Cliente')
GO
INSERT INTO [Frutillitas].[ReservaEstado]([descripcion]) VALUES ('Cancelada-No-Show')
GO
INSERT INTO [Frutillitas].[ReservaEstado]([descripcion]) VALUES ('Efectivizada')
GO

INSERT INTO [Frutillitas].[ReservaLogTipo]([descripcion]) VALUES ('Creacion')
GO
INSERT INTO [Frutillitas].[ReservaLogTipo]([descripcion]) VALUES ('Modificacion')
GO
INSERT INTO [Frutillitas].[ReservaLogTipo]([descripcion]) VALUES ('Cancelacion')
GO

SET IDENTITY_INSERT [Frutillitas].[Reserva] ON
GO
INSERT INTO [Frutillitas].[Reserva]([codigo], [fechaDesde], [fechaHasta], [regimenCodigo], [hotelId], [estadoId], [clienteId], [fechaCreacion])
SELECT DISTINCT [Reserva_Codigo], [Reserva_Fecha_Inicio], DATEADD(day, [Reserva_Cant_Noches], [Reserva_Fecha_Inicio]),	
	(SELECT [codigo] FROM [Frutillitas].[Regimen] WHERE [descripcion] = [Regimen_Descripcion]),
	(SELECT [id] FROM [Frutillitas].[Hotel] WHERE [direccion] = [Hotel_Calle] + ' ' + CAST([Hotel_Nro_Calle] as nvarchar(255))),	
    (SELECT [id] FROM [Frutillitas].[ReservaEstado] WHERE [descripcion] = 'Correcta'),
    c.[id],
	DATEADD(day, -1, [Reserva_Fecha_Inicio])
FROM [GD2C2014].[gd_esquema].[Maestra]
INNER JOIN [Frutillitas].[Cliente] c ON [numeroDocumento] = [Cliente_Pasaporte_Nro] AND [nombre] = [Cliente_Nombre] AND [apellido] = [Cliente_Apellido]
GO
SET IDENTITY_INSERT [Frutillitas].[Reserva] OFF
GO

INSERT INTO [Frutillitas].[ReservaTipoHabitacion]([reservaCodigo], [tipoHabitacionCodigo])
SELECT DISTINCT r.[codigo], [Habitacion_Tipo_Codigo]
FROM [Frutillitas].[Reserva] r
INNER JOIN [GD2C2014].[gd_esquema].[Maestra] ON r.[codigo] = [Reserva_Codigo]
GO

INSERT INTO [Frutillitas].[Estadia]([reservaCodigo], [fechaDesde], [fechaHasta])
SELECT DISTINCT [Reserva_Codigo], [Estadia_Fecha_Inicio], DATEADD(day, [Estadia_Cant_Noches], [Estadia_Fecha_Inicio])
FROM [GD2C2014].[gd_esquema].[Maestra]
WHERE [Estadia_Fecha_Inicio] IS NOT NULL AND [Estadia_Cant_Noches] IS NOT NULL
GO

UPDATE [Frutillitas].[Reserva] SET [estadoId] = (SELECT [id] FROM [Frutillitas].[ReservaEstado] WHERE [descripcion] = 'Efectivizada')
WHERE [codigo] IN (SELECT DISTINCT [reservaCodigo] FROM [Frutillitas].[Estadia])

UPDATE [Frutillitas].[Reserva] SET [estadoId] = (SELECT [id] FROM [Frutillitas].[ReservaEstado] WHERE [descripcion] = 'Cancelada-No-Show')
WHERE [fechaDesde] < GETDATE()

INSERT INTO [Frutillitas].[EstadiaConsumible]([estadiaId], [consumibleCodigo])
SELECT [id], [Consumible_Codigo] FROM [Frutillitas].[Estadia]
INNER JOIN [GD2C2014].[gd_esquema].[Maestra] ON [reservaCodigo] = [Reserva_Codigo]
WHERE [Consumible_Codigo] IS NOT NULL
GO

INSERT INTO [Frutillitas].[FacturaTipoPago]([descripcion]) VALUES ('Efectivo')
GO
INSERT INTO [Frutillitas].[FacturaTipoPago]([descripcion]) VALUES ('Tarjeta')
GO

SET IDENTITY_INSERT [Frutillitas].[Factura] ON
GO
INSERT INTO [Frutillitas].[Factura]([numero], [fecha], [total], [estadiaId], [tipoPagoId], [clienteId])
SELECT DISTINCT [Factura_Nro], [Factura_Fecha], [Factura_Total] + ([Item_Factura_Monto] * [Estadia_Cant_Noches]), e.[id], (SELECT [id] FROM [Frutillitas].[FacturaTipoPago] WHERE [descripcion] = 'Efectivo'), r.[clienteId]
FROM [Frutillitas].[Estadia] e
INNER JOIN [Frutillitas].[Reserva] r ON r.[codigo] = e.[reservaCodigo]
INNER JOIN [GD2C2014].[gd_esquema].[Maestra] ON e.[reservaCodigo] = [Reserva_Codigo]
WHERE [Factura_Nro] IS NOT NULL AND [Consumible_Precio] IS NULL AND [Item_Factura_Monto] IS NOT NULL
GO
SET IDENTITY_INSERT [Frutillitas].[Factura] OFF
GO

INSERT INTO [Frutillitas].[FacturaItem]([facturaNumero], [descripcion], [precio])
SELECT f.[numero], 'Consumible: ' + c.[descripcion], c.[precio]
FROM [Frutillitas].[Factura] f
INNER JOIN [Frutillitas].[Estadia] e ON f.[estadiaId] = e.[id]
INNER JOIN [Frutillitas].[EstadiaConsumible] ec ON ec.[estadiaId] = e.[id]
INNER JOIN [Frutillitas].[Consumible] c ON c.[codigo] = ec.[consumibleCodigo]
GO

INSERT INTO [Frutillitas].[FacturaItem]([facturaNumero], [descripcion], [precio])
SELECT f.[numero], 'Estadia: ' + STR([Estadia_Cant_Noches]) + ' noches', [Item_Factura_Monto] * [Estadia_Cant_Noches]
FROM [Frutillitas].[Factura] f
INNER JOIN [GD2C2014].[gd_esquema].[Maestra] ON [Factura_Nro] = f.[numero]
WHERE [Consumible_Precio] IS NULL AND [Item_Factura_Monto] IS NOT NULL
GO

INSERT INTO [Frutillitas].[EstadiaCliente]([estadiaId], [clienteId])
SELECT e.[id], r.[clienteId]
FROM [Frutillitas].[Estadia] e
INNER JOIN [Frutillitas].[Reserva] r ON e.[reservaCodigo] = r.[codigo]
GO