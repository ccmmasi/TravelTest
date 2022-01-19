IF OBJECT_ID('Autores') IS NULL
BEGIN
	CREATE TABLE [dbo].[Autores]
	(
		[Id] NUMERIC(10) NOT NULL PRIMARY KEY,
		[Nombres] Varchar(45) NOT NULL,
		[Apellidos] Varchar(45) NOT NULL 
	)
END



IF OBJECT_ID('Editoriales') IS NULL
BEGIN
	CREATE TABLE [dbo].[Editoriales]
	(
		[Id] NUMERIC(10) NOT NULL PRIMARY KEY,
		[Nombre] Varchar(45) NOT NULL,
		[Sede] Varchar(45) NOT NULL 
	)
END



IF OBJECT_ID('Libros') IS NULL
BEGIN
	CREATE TABLE [dbo].[Libros]
	(
		[ISBN] NUMERIC(10) NOT NULL PRIMARY KEY,
		[EditorialId] NUMERIC(10) NOT NULL  ,
		[Titulo] varchar(45) NOT NULL  ,
		[Sinopsis] varchar(45) NOT NULL  ,
		[NPaginas] varchar(45) NOT NULL  
	)
END



IF OBJECT_ID('AutoresLibros') IS NULL
BEGIN
	CREATE TABLE [dbo].[AutoresLibros]
	(
		[AutoresId] NUMERIC(10) NOT NULL , 
		[LibrosISBN] NUMERIC(10) NOT NULL, 
		PRIMARY KEY ([LibrosISBN], [AutoresId])
	)
END

