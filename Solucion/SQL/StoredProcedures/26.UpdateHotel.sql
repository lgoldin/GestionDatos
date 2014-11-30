USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[UpdateHotel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[UpdateHotel]
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
