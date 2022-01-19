 
 
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Autores_ObtUno]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Autores_ObtUno] AS' 
END
GO 
ALTER PROCEDURE [dbo].[Autores_ObtUno]  
	@Id numeric(10)
AS 
begin
	Select au.id, au.nombres, au.apellidos
	from autores au  
    where au.id = @Id;
End

GO 

