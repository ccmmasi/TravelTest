using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using Travel.AccessData.AccesoDatos.Implementacion;
using Travel.Core.LogicaNegocio.Interface;
using Travel.DTOS.DTO;

namespace Travel.Core.LogicaNegocio.Implementacion
{
    public class EditorialService : IEditorialService
    {
        public IEditorialDataAccess EditorialDataAccess = new EditorialDataAccess();
        ILog log = LogManager.GetLogger(typeof(EditorialService));

        public DataTable Editorial_ObtAll()
        {
            try
            {
                return EditorialDataAccess.Editorial_ObtAll();
            }
            catch (Exception e)
            {
                log.Error($"Error ocurrido al obtener los registros.", e);
                throw e;
            }
        }

        public DataTable Editorial_ObtUno(int ID)
        {
            try
            {
                return EditorialDataAccess.Editorial_ObtUno(ID);
            }
            catch (Exception e)
            {
                log.Error($"Error ocurrido al obtener el registro.", e);
                throw e;
            }
        }

        public int Editorial_Insertar(int ID, string Nombre, string Sede)
        {
            try
            {
                return EditorialDataAccess.Editorial_Insertar(ID, Nombre, Sede);
            }
            catch (Exception e)
            {
                log.Error($"Error ocurrido al insertar el registro.", e);
                throw e;
            }
        }

        public int Editorial_Actualizar(int ID, string Nombre, string Sede)
        {
            try
            {
                return EditorialDataAccess.Editorial_Actualizar(ID, Nombre, Sede);
            }
            catch (Exception e)
            {
                log.Error($"Error ocurrido al actualizar el registro.", e);
                throw e;
            }
        }

        public List<EditorialDTO> EditorialDTO_ObtAll()
        {
            try
            {
                return EditorialDataAccess.EditorialDTO_ObtAll();
            }
            catch (Exception e)
            {
                log.Error($"Error ocurrido al obtener los registros.", e);
                throw e;
            }
        }

        public EditorialDTO EditorialDTO_ObtUno(int ID)
        {
            try
            {
                return EditorialDataAccess.EditorialDTO_ObtUno(ID);
            }
            catch (Exception e)
            {
                log.Error($"Error ocurrido al obtener el registro.", e);
                throw e;
            }
        }
    }
}
