 
 
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Editoriales_ObtAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Editoriales_ObtAll] AS' 
END
GO 
ALTER PROCEDURE [dbo].[Editoriales_ObtAll]  
AS 
begin
	Select ed.id, ed.nombre, ed.Sede
	from Editoriales ed; 
End

GO 
