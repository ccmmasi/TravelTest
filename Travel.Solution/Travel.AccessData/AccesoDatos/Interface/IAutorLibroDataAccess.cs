using System.Collections.Generic;
using System.Data;
using Travel.DTOS.DTO;

namespace Travel.AccessData.AccesoDatos.Implementacion
{
    public interface IAutorLibroDataAccess
    {
        DataTable AutorLibro_ObtAll();
        DataTable AutorLibro_ObtUno(double Autor_Id, double Libro_ISBN);
        int AutorLibro_Insertar(double Autor_Id, double Libro_ISBN);
        List<AutorLibroDTO> AutorLibroDTO_ObtAll();
        AutorLibroDTO AutorLibroDTO_ObtUno(double Autor_Id, double Libro_ISBN);
    }
}
