 
 
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

 
 
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Autores_Insertar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Autores_Insertar] AS' 
END
GO 
ALTER PROCEDURE [dbo].[Autores_Insertar]   
	@Id numeric(10), 
	@nombres varchar(45),
	@apellidos varchar(45)
AS   
begin
	INSERT INTO [dbo].[autores]
	([id]
	,[nombres]
	,[apellidos] )
	VALUES
	(@id
	,@nombres
	,@apellidos);
End

GO 

 
 
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

 
 
IF NOT EXISTS (SELECT * FROM sys.objects WHERE OBJECT_ID = OBJECT_ID(N'[dbo].[Libros_Actualizar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Libros_Actualizar] AS' 
END
GO 
ALTER PROCEDURE [dbo].[Libros_Actualizar]  
	@ISBN numeric(10), 
	@EditorialId numeric(10), 
	@Titulo varchar(45),
	@Sinopsis varchar(45),
	@NPaginas varchar(45)
AS 
begin 
	Update Libros
	set Titulo = @Titulo,
	Sinopsis = @Sinopsis,
	NPaginas = @NPaginas
	where ISBN = @ISBN and EditorialId = @EditorialId;  
End	

GO 

 
 
IF NOT EXISTS (SELECT * FROM sys.objects WHERE OBJECT_ID = OBJECT_ID(N'[dbo].[Libros_Insertar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Libros_Insertar] AS' 
END
GO 
ALTER PROCEDURE [dbo].[Libros_Insertar]   
	@ISBN numeric(10), 
	@EditorialId numeric(10), 
	@Titulo varchar(45),
	@Sinopsis varchar(45),
	@NPaginas varchar(45)
AS   
begin
	INSERT INTO [dbo].[Libros]
	([ISBN]
	,[EditorialId]
	,[Titulo]
	,[Sinopsis]
	,[NPaginas] )
	VALUES
	(@ISBN
	,@EditorialId
	,@Titulo
	,@Sinopsis
	,@NPaginas);
End

GO 

 
 
IF NOT EXISTS (SELECT * FROM sys.objects WHERE OBJECT_ID = OBJECT_ID(N'[dbo].[Libros_ObtAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Libros_ObtAll] AS' 
END
GO 
ALTER PROCEDURE [dbo].[Libros_ObtAll]  
AS 
begin
	Select li.ISBN, li.EditorialId, li.Titulo, li.Sinopsis, li.NPaginas 
	from Libros li; 
End

GO 

 
 
IF NOT EXISTS (SELECT * FROM sys.objects WHERE OBJECT_ID = OBJECT_ID(N'[dbo].[Libros_ObtUno]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Libros_ObtUno] AS' 
END
GO 
ALTER PROCEDURE [dbo].[Libros_ObtUno]  
	@ISBN numeric(10)
AS 
begin
	Select li.ISBN, li.EditorialId, li.Titulo, li.Sinopsis, li.NPaginas 
	from Libros li
    where li.ISBN = @ISBN;
End

GO 

