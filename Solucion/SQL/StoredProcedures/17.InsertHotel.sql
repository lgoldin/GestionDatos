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


