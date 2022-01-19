using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using Travel.AccessData.AccesoDatos.Implementacion;
using Travel.Core.LogicaNegocio.Interface;
using Travel.DTOS.DTO;

namespace Travel.Core.LogicaNegocio.Implementacion
{
    public class LibroService : ILibroService
    {
        public ILibroDataAccess LibroDataAccess = new LibroDataAccess();
        ILog log = LogManager.GetLogger(typeof(LibroService));

        public DataTable Libro_ObtAll()
        {
            try
            {
                return LibroDataAccess.Libro_ObtAll();
            }
            catch (Exception e)
            {
                log.Error($"Error ocurrido al obtener los registros.", e);
                throw e;
            }
        }

        public DataTable Libro_ObtUno(double ISBN)
        {
            try
            {
                return LibroDataAccess.Libro_ObtUno(ISBN);
            }
            catch (Exception e)
            {
                log.Error($"Error ocurrido al obtener el registro.", e);
                throw e;
            }
        }

        public int Libro_Insertar(double ISBN, double Editorial_Id, string Titulo, string Sinopsis, string NPaginas)
        {
            try
            {
                return LibroDataAccess.Libro_Insertar(ISBN, Editorial_Id, Titulo, Sinopsis, NPaginas);
            }
            catch (Exception e)
            {
                log.Error($"Error ocurrido al insertar el registro.", e);
                throw e;
            }
        }

        public int Libro_Actualizar(double ISBN, double Editorial_Id, string Titulo, string Sinopsis, string NPaginas)
        {
            try
            {
                return LibroDataAccess.Libro_Actualizar(ISBN, Editorial_Id, Titulo, Sinopsis, NPaginas);
            }
            catch (Exception e)
            {
                log.Error($"Error ocurrido al actualizar el registro.", e);
                throw e;
            }
        }

        public List<LibroDTO> LibroDTO_ObtAll()
        {
            try
            {
                return LibroDataAccess.LibroDTO_ObtAll();
            }
            catch (Exception e)
            {
                log.Error($"Error ocurrido al obtener los registros.", e);
                throw e;
            }
        }

        public LibroDTO LibroDTO_ObtUno(double ISBN)
        {
            try
            {
                return LibroDataAccess.LibroDTO_ObtUno(ISBN);
            }
            catch (Exception e)
            {
                log.Error($"Error ocurrido al obtener el registro.", e);
                throw e;
            }
        }
    }
}
