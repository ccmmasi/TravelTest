using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using Travel.AccessData.AccesoDatos.Implementacion;
using Travel.Core.LogicaNegocio.Interface;
using Travel.DTOS.DTO;

namespace Travel.Core.LogicaNegocio.Implementacion
{
    public class AutorLibroService : IAutorLibroService
    {
        public IAutorLibroDataAccess AutorLibroDataAccess = new AutorLibroDataAccess();
        ILog log = LogManager.GetLogger(typeof(AutorLibroService));

        public DataTable AutorLibro_ObtAll()
        {
            try
            {
                return AutorLibroDataAccess.AutorLibro_ObtAll();
            }
            catch (Exception e)
            {
                log.Error($"Error ocurrido al obtener los registros.", e);
                throw e;
            }
        }

        public DataTable AutorLibro_ObtUno(double Autor_Id, double Libro_ISBN)
        {
            try
            {
                return AutorLibroDataAccess.AutorLibro_ObtUno(Autor_Id,  Libro_ISBN);
            }
            catch (Exception e)
            {
                log.Error($"Error ocurrido al obtener el registro.", e);
                throw e;
            }
        }

        public int AutorLibro_Insertar(double Autor_Id, double Libro_ISBN)
        {
            try
            {
                return AutorLibroDataAccess.AutorLibro_Insertar(Autor_Id, Libro_ISBN);
            }
            catch (Exception e)
            {
                log.Error($"Error ocurrido al insertar el registro.", e);
                throw e;
            }
        }

        public List<AutorLibroDTO> AutorLibroDTO_ObtAll()
        {
            try
            {
                return AutorLibroDataAccess.AutorLibroDTO_ObtAll();
            }
            catch (Exception e)
            {
                log.Error($"Error ocurrido al obtener los registros.", e);
                throw e;
            }
        }

        public AutorLibroDTO AutorLibroDTO_ObtUno(double Autor_Id, double Libro_ISBN)
        {
            try
            {
                return AutorLibroDataAccess.AutorLibroDTO_ObtUno(Autor_Id, Libro_ISBN);
            }
            catch (Exception e)
            {
                log.Error($"Error ocurrido al obtener el registro.", e);
                throw e;
            }
        }
    }
}
