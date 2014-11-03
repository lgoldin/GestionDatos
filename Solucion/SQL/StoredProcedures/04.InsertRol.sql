USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertRol]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertRol]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertRol]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[InsertRol]

@nombre varchar(255),
@activo bit

AS
BEGIN
	SET NOCOUNT ON;
	

	INSERT INTO [Frutillitas].[Rol]
           ([nombre]
           ,[activo])
	OUTPUT INSERTED.Id
    VALUES
           (@nombre
           ,@activo)
END
' 
END
GO


