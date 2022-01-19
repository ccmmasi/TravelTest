@ECHO OFF

echo ---------------------------------------------------
del ArchivosCompilados.sql
echo ---------------------------------------------------
echo Compilando SQL Files ...
echo ---------------------------------------------------
copy *.sql ArchivosCompilados.sql
echo ---------------------------------------------------
pause
echo Done.