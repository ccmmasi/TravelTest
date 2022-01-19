using System.Collections.Generic;
using System.Data;
using Travel.DTOS.DTO;

namespace Travel.AccessData.AccesoDatos.Implementacion
{
    public interface IEditorialDataAccess
    {
        DataTable Editorial_ObtAll();
        DataTable Editorial_ObtUno(double ID);
        int Editorial_Insertar(double ID, string Nombre, string Sede);
        int Editorial_Actualizar(double ID, string Nombre, string Sede);
        List<EditorialDTO> EditorialDTO_ObtAll();
        EditorialDTO EditorialDTO_ObtUno(double ID);
    }
}
