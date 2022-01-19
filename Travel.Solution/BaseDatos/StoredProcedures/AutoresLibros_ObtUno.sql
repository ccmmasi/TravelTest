 
 
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AutoresLibros_ObtUno]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[AutoresLibros_ObtUno] AS' 
END
GO 
ALTER PROCEDURE [dbo].[AutoresLibros_ObtUno]  
	@AutoresId numeric(10),
	@LibrosISBN numeric(10)
AS 
begin
	Select al.AutoresId, al.LibrosISBN 
	from AutoresLibrosLibros al 
    where al.AutoresId = @AutoresId or al.LibrosISBN = @LibrosISBN;
End

GO 

