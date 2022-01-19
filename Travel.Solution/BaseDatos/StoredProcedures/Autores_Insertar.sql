 
 
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Autores_Insertar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Autores_Insertar] AS' 
END
GO 
ALTER PROCEDURE [dbo].[Autores_Insertar]   
	@Id numeric(10), 
	@nombres varchar(45),
	@apellidos varchar(45)
AS   
begin
	INSERT INTO [dbo].[autores]
	([id]
	,[nombres]
	,[apellidos] )
	VALUES
	(@id
	,@nombres
	,@apellidos);
End

GO 

