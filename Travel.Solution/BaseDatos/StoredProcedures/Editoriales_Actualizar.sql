 
 
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Editoriales_Actualizar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Editoriales_Actualizar] AS' 
END
GO 
ALTER PROCEDURE [dbo].[Editoriales_Actualizar]  
	@Id numeric(10), 
	@nombre varchar(45),
	@sede varchar(45)
AS  
begin
	Update Editoriales
	set nombre = @nombre,
	sede = @sede
	where id = @id;  
End	

GO 

