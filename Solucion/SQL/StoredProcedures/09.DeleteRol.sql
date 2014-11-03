USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[DeleteRol]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[DeleteRol]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[DeleteRol]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[DeleteRol]

@activo bit,
@id int

AS
	BEGIN
	SET NOCOUNT ON;

	UPDATE [Frutillitas].[Rol]
		  SET[activo] = @activo
	 WHERE [id] = @id
	END
' 
END
GO


