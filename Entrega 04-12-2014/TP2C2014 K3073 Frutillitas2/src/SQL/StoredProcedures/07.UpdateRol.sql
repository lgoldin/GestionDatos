USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[UpdateRol]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[UpdateRol]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[UpdateRol]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[UpdateRol]

@nombre varchar(255),
@activo bit,
@id int

AS
	BEGIN
	SET NOCOUNT ON;

	UPDATE [Frutillitas].[Rol]
	   SET [nombre] = @nombre
		  ,[activo] = @activo
	 WHERE [id] = @id
	END

	DELETE FROM [Frutillitas].[RolFuncionalidad]
      WHERE [RolId] = @id

' 
END
GO


