using System.Collections.Generic;
using System.Data;
using Travel.DTOS.DTO;

namespace Travel.Core.LogicaNegocio.Interface
{
    public interface IAutorService
    {
        DataTable Autor_ObtAll();
        DataTable Autor_ObtUno(double ID);
        int Autor_Insertar(double ID, string Nombres, string Apellidos);
        int Autor_Actualizar(double ID, string Nombres, string Apellidos);
        List<AutorDTO> AutorDTO_ObtAll();
        AutorDTO AutorDTO_ObtUno(double ID);
    }
}
