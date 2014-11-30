USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetClienteByTipoYNumeroDocumento]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetClienteByTipoYNumeroDocumento]
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
