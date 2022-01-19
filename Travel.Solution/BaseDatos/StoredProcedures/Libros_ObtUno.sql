 
 
IF NOT EXISTS (SELECT * FROM sys.objects WHERE OBJECT_ID = OBJECT_ID(N'[dbo].[Libros_ObtUno]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Libros_ObtUno] AS' 
END
GO 
ALTER PROCEDURE [dbo].[Libros_ObtUno]  
	@ISBN numeric(10)
AS 
begin
	Select li.ISBN, li.EditorialId, li.Titulo, li.Sinopsis, li.NPaginas 
	from Libros li
    where li.ISBN = @ISBN;
End

GO 

