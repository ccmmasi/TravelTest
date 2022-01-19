 
 
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Autores_Actualizar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Autores_Actualizar] AS' 
END
GO 
ALTER PROCEDURE [dbo].[Autores_Actualizar]  
	@Id numeric(10), 
	@nombres varchar(45),
	@apellidos varchar(45)
AS  
begin
	Update autores
	set nombres = @nombres,
	apellidos = @apellidos
	where id = @id;  
End		

GO 

