USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[DeleteUsuarioLog]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[DeleteUsuarioLog]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[DeleteUsuarioLog]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[DeleteUsuarioLog]
@username nvarchar(255)
AS
BEGIN
	SET NOCOUNT ON;
	
	DECLARE @usuarioId int
	SELECT @usuarioId = id FROM [Frutillitas].[Usuario] WHERE username = @username
	
	DELETE FROM [Frutillitas].[UsuarioLog] WHERE usuarioId = @usuarioId
END
' 
END
GO
