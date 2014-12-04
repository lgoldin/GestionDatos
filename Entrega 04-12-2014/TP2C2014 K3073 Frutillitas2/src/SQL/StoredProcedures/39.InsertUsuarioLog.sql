USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertUsuarioLog]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertUsuarioLog]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertUsuarioLog]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[InsertUsuarioLog]
@username nvarchar(255)
AS
BEGIN
	SET NOCOUNT ON;
	
	DECLARE @usuarioId int
	SELECT @usuarioId = id FROM [Frutillitas].[Usuario] WHERE username = @username
	
	INSERT INTO [Frutillitas].[UsuarioLog]
	(
		usuarioId,
		fecha
	)
	VALUES
	(
		@usuarioId,
		GETDATE()
	)
	
	IF (SELECT COUNT(*) FROM [Frutillitas].[UsuarioLog] WHERE usuarioId = @usuarioId) >= 3
	BEGIN
		UPDATE [Frutillitas].[Usuario] SET habilitado = 0 WHERE id = @usuarioId
	END
END
' 
END
GO
