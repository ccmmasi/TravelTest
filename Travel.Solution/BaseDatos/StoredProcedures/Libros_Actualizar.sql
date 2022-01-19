 
 
IF NOT EXISTS (SELECT * FROM sys.objects WHERE OBJECT_ID = OBJECT_ID(N'[dbo].[Libros_Actualizar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Libros_Actualizar] AS' 
END
GO 
ALTER PROCEDURE [dbo].[Libros_Actualizar]  
	@ISBN numeric(10), 
	@EditorialId numeric(10), 
	@Titulo varchar(45),
	@Sinopsis varchar(45),
	@NPaginas varchar(45)
AS 
begin 
	Update Libros
	set Titulo = @Titulo,
	Sinopsis = @Sinopsis,
	NPaginas = @NPaginas
	where ISBN = @ISBN and EditorialId = @EditorialId;  
End	

GO 

