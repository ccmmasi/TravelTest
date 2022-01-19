 
 
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Editoriales_Insertar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Editoriales_Insertar] AS' 
END
GO 
ALTER PROCEDURE [dbo].[Editoriales_Insertar]   
	@Id numeric(10), 
	@nombre varchar(45),
	@sede varchar(45)
AS  
begin 
	INSERT INTO [dbo].[Editoriales]
	([id]
	,[nombre]
	,[sede] )
	VALUES
	(@id
	,@nombre
	,@sede);
End

GO 

