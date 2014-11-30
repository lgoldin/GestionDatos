use GD2C2014
USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetClientes]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetClientes]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

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
		(@nombre IS NULL OR c.nombre LIKE '%' + @nombre + '%') AND
		(@apellido IS NULL OR c.apellido LIKE '%' + @apellido + '%') AND
		(@mail IS NULL OR c.mail LIKE '%' + @mail + '%') AND
		(@numeroDocumento IS NULL OR c.numeroDocumento LIKE @numeroDocumento + '%') AND
		(@tipoDocumentoId IS NULL OR c.tipoDocumentoId = @tipoDocumentoId)

END
GO
