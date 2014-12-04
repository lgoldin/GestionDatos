USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetClienteByEstadiaId]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetClienteByEstadiaId]
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
