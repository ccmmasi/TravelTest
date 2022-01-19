 
 
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Autores_ObtAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Autores_ObtAll] AS' 
END
GO 
ALTER PROCEDURE [dbo].[Autores_ObtAll]  
AS 
begin
	Select au.id, au.nombres, au.apellidos
	from autores au; 
End

GO 

