USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertCliente]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertCliente]
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


