USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[GetCountUsuarioByUserName]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[GetCountUsuarioByUserName]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Frutillitas].[GetCountUsuarioByUserName]
@username nvarchar(255)
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT count(id)
		
	FROM [Frutillitas].Usuario
	WHERE 
		username = @username
END
GO