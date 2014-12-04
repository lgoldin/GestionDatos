USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertReservaTipoHabitacion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertReservaTipoHabitacion]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Frutillitas].[InsertReservaTipoHabitacion]
@reservaCodigo numeric(18, 0),
@tipoHabitacionCodigo numeric(18, 0)
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [Frutillitas].[ReservaTipoHabitacion](reservaCodigo, tipoHabitacionCodigo)
	VALUES (@reservaCodigo, @tipoHabitacionCodigo)
END 
GO
