 
 
IF NOT EXISTS (SELECT * FROM sys.objects WHERE OBJECT_ID = OBJECT_ID(N'[dbo].[Libros_Insertar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Libros_Insertar] AS' 
END
GO 
ALTER PROCEDURE [dbo].[Libros_Insertar]   
	@ISBN numeric(10), 
	@EditorialId numeric(10), 
	@Titulo varchar(45),
	@Sinopsis varchar(45),
	@NPaginas varchar(45)
AS   
begin
	INSERT INTO [dbo].[Libros]
	([ISBN]
	,[EditorialId]
	,[Titulo]
	,[Sinopsis]
	,[NPaginas] )
	VALUES
	(@ISBN
	,@EditorialId
	,@Titulo
	,@Sinopsis
	,@NPaginas);
End

GO 

