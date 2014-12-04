USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[UpdateCliente]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[UpdateCliente]
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


