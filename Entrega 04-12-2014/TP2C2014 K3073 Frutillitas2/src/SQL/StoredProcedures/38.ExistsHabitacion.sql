USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[ExistsHabitacion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[ExistsHabitacion]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[ExistsHabitacion]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[ExistsHabitacion]
@hotelId int,
@numero numeric(18,0),
@piso numeric(18,0)
AS
BEGIN
	SET NOCOUNT ON;
	
	IF (SELECT 
			COUNT(*)
		FROM [Frutillitas].[Habitacion]
		WHERE
			numero = @numero AND
			piso = @piso AND
			hotelId = @hotelId) = 0
	BEGIN
		SELECT 0
	END
	ELSE
	BEGIN
		SELECT 1
	END
END
' 
END
GO
