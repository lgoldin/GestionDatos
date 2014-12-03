USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertFactura]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertFactura]
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
@tipoPagoId int

AS
BEGIN

SET NOCOUNT ON;
declare @numero int

INSERT INTO [Frutillitas].[Factura]
           (
           [fecha]
           ,[total]
           ,[estadiaId]
           ,[tipoPagoId])
     VALUES
           (
           @fecha
           ,@total
           ,@estadiaId
           ,@tipoPagoId)

		   set @numero = SCOPE_IDENTITY()
		   select @numero
		   
END
' 
END
GO


