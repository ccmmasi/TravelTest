using System.Collections.Generic;
using System.Data;
using Travel.DTOS.DTO;

namespace Travel.AccessData.AccesoDatos.Implementacion
{
    public interface ILibroDataAccess
    {
        DataTable Libro_ObtAll();
        DataTable Libro_ObtUno(int ISBN);
        int Libro_Insertar(double ISBN, double Editorial_Id, string Titulo, string Sinopsis, string NPaginas);
        int Libro_Actualizar(double ISBN, double Editorial_Id, string Titulo, string Sinopsis, string NPaginas);
        List<LibroDTO> LibroDTO_ObtAll();
        LibroDTO LibroDTO_ObtUno(int ISBN);
    }
}
