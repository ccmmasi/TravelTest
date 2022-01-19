using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using Travel.AccessData.AccesoDatos.Implementacion;
using Travel.Core.LogicaNegocio.Interface;
using Travel.DTOS.DTO;

namespace Travel.Core.LogicaNegocio.Implementacion
{
    public class AutorService : IAutorService
    {
        public IAutorDataAccess AutorDataAccess = new AutorDataAccess();
        ILog log = LogManager.GetLogger(typeof(AutorService));

        public DataTable Autor_ObtAll()
        {
            try
            {
                return AutorDataAccess.Autor_ObtAll();
            }
            catch (Exception e)
            {
                log.Error($"Error ocurrido al obtener los registros.", e);
                throw e;
            }
        }

        public DataTable Autor_ObtUno(int ID)
        {
            try
            {
                return AutorDataAccess.Autor_ObtUno(ID);
            }
            catch (Exception e)
            {
                log.Error($"Error ocurrido al obtener el registro.", e);
                throw e;
            }
        }

        public int Autor_Insertar(int ID, string Nombres, string Apellidos)
        {
            try
            {
                return AutorDataAccess.Autor_Insertar(ID, Nombres, Apellidos);
            }
            catch (Exception e)
            {
                log.Error($"Error ocurrido al insertar el registro.", e);
                throw e;
            }
        }

        public int Autor_Actualizar(int ID, string Nombres, string Apellidos)
        {
            try
            {
                return AutorDataAccess.Autor_Actualizar(ID, Nombres, Apellidos);
            }
            catch (Exception e)
            {
                log.Error($"Error ocurrido al actualizar el registro.", e);
                throw e;
            }
        }

        public List<AutorDTO> AutorDTO_ObtAll()
        {
            try
            {
                return AutorDataAccess.AutorDTO_ObtAll();
            }
            catch (Exception e)
            {
                log.Error($"Error ocurrido al obtener los registros.", e);
                throw e;
            }
        }

        public AutorDTO AutorDTO_ObtUno(int ID)
        {
            try
            {
                return AutorDataAccess.AutorDTO_ObtUno(ID);
            }
            catch (Exception e)
            {
                log.Error($"Error ocurrido al obtener el registro.", e);
                throw e;
            }
        }
    }
}
