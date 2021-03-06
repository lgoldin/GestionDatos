USE [GD2C2014]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertHabitacion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [Frutillitas].[InsertHabitacion]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Frutillitas].[InsertHabitacion]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [Frutillitas].[InsertHabitacion]
@frente bit = null,
@activa bit = null,
@numero numeric(18,0) = null,
@piso numeric(18,0) = null,
@descripcion nvarchar(255) = null,
@tipoHabitacionCodigo int,
@hotelId int
AS
BEGIN
	SET NOCOUNT ON;
	
	DECLARE @EsFrente nvarchar(1)
	IF @frente IS NULL
	BEGIN
		SET @EsFrente = null
	END
	ELSE
	BEGIN
		IF @frente = 1
		BEGIN
			SET @EsFrente = ''S''
		END
		ELSE
		BEGIN
			SET @EsFrente = ''N''
		END
	END
	
	INSERT INTO [Frutillitas].[Habitacion]
	(
		frente,
		activa,
		numero,
		piso,
		descripcion,
		tipoCodigo,
		hotelId
	)
	VALUES
	(
		@EsFrente,
		@activa,
		@numero,
		@piso,
		@descripcion,
		@tipoHabitacionCodigo,
		@hotelId
	)
	
	DECLARE @IdHabitacion int
	SET @IdHabitacion = SCOPE_IDENTITY()
	
	SELECT @IdHabitacion
END
' 
END
GO
