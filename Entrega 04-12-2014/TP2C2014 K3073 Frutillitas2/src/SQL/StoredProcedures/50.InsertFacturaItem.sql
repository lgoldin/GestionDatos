USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertFacturaItem]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertFacturaItem]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertFacturaItem]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[InsertFacturaItem]

@facturaNumero numeric(18,0)
,@descripcion nvarchar(255)
,@precio numeric(18,2)

AS
BEGIN

SET NOCOUNT ON;

INSERT INTO [Frutillitas].[FacturaItem]
           ([facturaNumero]
           ,[descripcion]
           ,[precio])
     VALUES
           (@facturaNumero
           ,@descripcion
           ,@precio)		   
END
' 
END
GO


