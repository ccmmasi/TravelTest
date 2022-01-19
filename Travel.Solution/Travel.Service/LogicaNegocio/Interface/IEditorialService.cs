using System.Collections.Generic;
using System.Data;
using Travel.DTOS.DTO;

namespace Travel.Core.LogicaNegocio.Interface
{
    public interface IEditorialService
    {
        DataTable Editorial_ObtAll();
        DataTable Editorial_ObtUno(double ID);
        int Editorial_Insertar(double ID, string Nombre, string Sede);
        int Editorial_Actualizar(double ID, string Nombre, string Sede);
        List<EditorialDTO> EditorialDTO_ObtAll();
        EditorialDTO EditorialDTO_ObtUno(double ID);
    }
}
