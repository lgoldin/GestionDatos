USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertHotelInhabilitado]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertHotelInhabilitado]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

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
GO
