using System.Collections.Generic;
using System.Data;
using Travel.DTOS.DTO;

namespace Travel.AccessData.AccesoDatos.Implementacion
{
    public interface IAutorDataAccess
    {
        DataTable Autor_ObtAll();
        DataTable Autor_ObtUno(int ID);
        int Autor_Insertar(int ID, string Nombres, string Apellidos);
        int Autor_Actualizar(int ID, string Nombres, string Apellidos);
        List<AutorDTO> AutorDTO_ObtAll();
        AutorDTO AutorDTO_ObtUno(int ID);
    }
}
