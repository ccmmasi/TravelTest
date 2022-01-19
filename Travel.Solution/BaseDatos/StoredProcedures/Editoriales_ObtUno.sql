 
 
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Editoriales_ObtUno]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Editoriales_ObtUno] AS' 
END
GO 
ALTER PROCEDURE [dbo].[Editoriales_ObtUno]  
	@Id numeric(10)
AS 
begin
	Select ed.id, ed.nombre, ed.sede
	from Editoriales ed  
    where ed.id = @Id;
End

GO 

