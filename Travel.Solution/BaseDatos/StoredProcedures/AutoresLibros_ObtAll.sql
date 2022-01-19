 
 
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AutoresLibrosLibros_ObtAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[AutoresLibrosLibros_ObtAll] AS' 
END
GO 
ALTER PROCEDURE [dbo].[AutoresLibrosLibros_ObtAll]  
AS 
begin
	Select al.AutoresId, al.LibrosISBN 
	from AutoresLibrosLibros al; 
End

GO 

