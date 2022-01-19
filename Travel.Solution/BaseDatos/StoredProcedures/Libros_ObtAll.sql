 
 
IF NOT EXISTS (SELECT * FROM sys.objects WHERE OBJECT_ID = OBJECT_ID(N'[dbo].[Libros_ObtAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Libros_ObtAll] AS' 
END
GO 
ALTER PROCEDURE [dbo].[Libros_ObtAll]  
AS 
begin
	Select li.ISBN, li.EditorialId, li.Titulo, li.Sinopsis, li.NPaginas 
	from Libros li; 
End

GO 

