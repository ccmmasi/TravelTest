 
 
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AutoresLibros_Insertar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[AutoresLibros_Insertar] AS' 
END
GO 
ALTER PROCEDURE [dbo].[AutoresLibros_Insertar]   
	@AutoresId numeric(10), 
	@LibrosISBN numeric(10)
AS  
begin 
	INSERT INTO [dbo].[AutoresLibros]
	([AutoresId]
	,[LibrosISBN] )
	VALUES
	(@AutoresId
	,@LibrosISBN );
End

GO 

