USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertTarjetaDeCredito]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertTarjetaDeCredito]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertTarjetaDeCredito]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[InsertTarjetaDeCredito]

@facturaNumero numeric(18,0),
@numero numeric(16,0),
@codigo nvarchar(10),
@fechaVencimiento datetime,
@codigoSeguridad numeric(4,0)

AS
BEGIN

SET NOCOUNT ON;

INSERT INTO [Frutillitas].[TarjetaDeCredito]
           ([facturaNumero]
           ,[numero]
           ,[codigo]
           ,[fechaVencimiento]
           ,[codigoSeguridad])
     VALUES
           (@facturaNumero
           ,@numero
           ,@codigo
           ,@fechaVencimiento
           ,@codigoSeguridad)
		   
END
' 
END
GO


