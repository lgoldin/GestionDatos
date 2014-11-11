USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertRolFuncionalidad]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertRolFuncionalidad]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertRolFuncionalidad]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [Frutillitas].[InsertRolFuncionalidad]

@rolId int,
@funcionalidadId int

AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [Frutillitas].[RolFuncionalidad]
           ([rolId]
           ,[funcionalidadId])
     VALUES
           (@rolId
           ,@funcionalidadId)
END
' 
END
GO


