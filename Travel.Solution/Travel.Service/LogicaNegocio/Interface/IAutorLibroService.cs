using System.Collections.Generic;
using System.Data;
using Travel.DTOS.DTO;

namespace Travel.Core.LogicaNegocio.Interface
{
    public interface IAutorLibroService
    {
        DataTable AutorLibro_ObtAll();
        DataTable AutorLibro_ObtUno(double Autor_Id, double Libro_ISBN);
        int AutorLibro_Insertar(double Autor_Id, double Libro_ISBN);
        int AutorLibro_Actualizar(double Autor_Id, double Libro_ISBN);
        List<AutorLibroDTO> AutorLibroDTO_ObtAll();
        AutorLibroDTO AutorLibroDTO_ObtUno(double Autor_Id, double Libro_ISBN);
    }
}
