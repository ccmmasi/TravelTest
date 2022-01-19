using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Travel.DTOS.DTO;
using Travel.Generales.General;

namespace Travel.AccessData.AccesoDatos.Implementacion
{
    public class LibroDataAccess : ILibroDataAccess
    {
        private AccesoBaseDatos AccesoBaseDatos = new AccesoBaseDatos();

        public DataTable Libro_ObtAll()
        {
            DataSet ds = new DataSet();

            using (SqlConnection cnn = new SqlConnection(AccesoBaseDatos.GetCnnString()))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "Libros_ObtAll";

                    try
                    {
                        SqlDataAdapter SqlData = new SqlDataAdapter(cmd);
                        SqlData.Fill(ds);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        cnn.Close();
                    }
                }
            }

            return ds.Tables[0];
        }

        public DataTable Libro_ObtUno(double ISBN)
        {
            DataSet ds = new DataSet();

            using (SqlConnection cnn = new SqlConnection(AccesoBaseDatos.GetCnnString()))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "Libros_ObtUno";

                    cmd.Parameters.Add("@ISBN", SqlDbType.BigInt);
                    cmd.Parameters["@ISBN"].Value = ISBN;

                    try
                    {
                        SqlDataAdapter SqlData = new SqlDataAdapter(cmd);
                        SqlData.Fill(ds);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        cnn.Close();
                    }
                }
            }

            return ds.Tables[0];
        }

        public int Libro_Insertar(double ISBN, double Editorial_Id, string Titulo, string Sinopsis, string NPaginas)
        {
            using (SqlConnection cnn = new SqlConnection(AccesoBaseDatos.GetCnnString()))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "Libros_Insertar";

                    cmd.Parameters.Add("@ISBN", SqlDbType.BigInt);
                    cmd.Parameters["@ISBN"].Value = ISBN;

                    cmd.Parameters.Add("@Editorial_Id", SqlDbType.BigInt);
                    cmd.Parameters["@Editorial_Id"].Value = Editorial_Id;

                    cmd.Parameters.Add("@Titulo", SqlDbType.VarChar);
                    cmd.Parameters["@Titulo"].Value = Titulo;

                    cmd.Parameters.Add("@Sinopsis", SqlDbType.VarChar);
                    cmd.Parameters["@Sinopsis"].Value = Sinopsis;

                    cmd.Parameters.Add("@NPaginas", SqlDbType.VarChar);
                    cmd.Parameters["@NPaginas"].Value = NPaginas;

                    try
                    {
                        cmd.ExecuteNonQuery();
                        return 1;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        cnn.Close();
                    }
                }
            }
        }

        public int Libro_Actualizar(double ISBN, double Editorial_Id, string Titulo, string Sinopsis, string NPaginas)
        {
            using (SqlConnection cnn = new SqlConnection(AccesoBaseDatos.GetCnnString()))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "Libros_Actualizar";

                    cmd.Parameters.Add("@ISBN", SqlDbType.BigInt);
                    cmd.Parameters["@ISBN"].Value = ISBN;

                    cmd.Parameters.Add("@Editorial_Id", SqlDbType.BigInt);
                    cmd.Parameters["@Editorial_Id"].Value = Editorial_Id;

                    cmd.Parameters.Add("@Titulo", SqlDbType.VarChar);
                    cmd.Parameters["@Titulo"].Value = Titulo;

                    cmd.Parameters.Add("@Sinopsis", SqlDbType.VarChar);
                    cmd.Parameters["@Sinopsis"].Value = Sinopsis;

                    cmd.Parameters.Add("@NPaginas", SqlDbType.VarChar);
                    cmd.Parameters["@NPaginas"].Value = NPaginas;

                    try
                    {
                        cmd.ExecuteNonQuery();
                        return 1;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        cnn.Close();
                    }
                }
            }
        }

        public List<LibroDTO> LibroDTO_ObtAll()
        {
            IEditorialDataAccess EditorialDataAccess = new EditorialDataAccess();
            List<LibroDTO> LLibros = new List<LibroDTO>();
            LibroDTO LibroObj = new LibroDTO();
            DataSet ds = new DataSet();

            using (SqlConnection cnn = new SqlConnection(AccesoBaseDatos.GetCnnString()))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "Libros_ObtAll";

                    try
                    {
                        SqlDataAdapter SqlData = new SqlDataAdapter(cmd);
                        SqlData.Fill(ds);

                        foreach (DataRow Item in ds.Tables[0].Rows)
                        {
                            LibroObj = new LibroDTO();

                            LibroObj.ISBN = Item.Field<double>("ISBN");
                            LibroObj.Editorial_Id = Item.Field<double>("EditorialId");
                            LibroObj.Titulo = Item.Field<string>("Titulo");
                            LibroObj.Sinopsis = Item.Field<string>("Sinopsis");
                            LibroObj.NPaginas = Item.Field<string>("NPaginas");
                            LibroObj.Editorial = EditorialDataAccess.EditorialDTO_ObtUno(Item.Field<double>("EditorialId"));

                            LLibros.Add(LibroObj);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        cnn.Close();
                    }
                }
            }

            return LLibros;
        }

        public LibroDTO LibroDTO_ObtUno(double ISBN)
        {
            IEditorialDataAccess EditorialDataAccess = new EditorialDataAccess();
            LibroDTO LibroObj = new LibroDTO();
            DataSet ds = new DataSet();

            using (SqlConnection cnn = new SqlConnection(AccesoBaseDatos.GetCnnString()))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "Libros_ObtUno";

                    cmd.Parameters.Add("@ISBN", SqlDbType.BigInt);
                    cmd.Parameters["@ISBN"].Value = ISBN;

                    try
                    {
                        SqlDataAdapter SqlData = new SqlDataAdapter(cmd);
                        SqlData.Fill(ds);

                        foreach (DataRow Item in ds.Tables[0].Rows)
                        {
                            LibroObj = new LibroDTO();

                            LibroObj.ISBN = Item.Field<double>("ISBN");
                            LibroObj.Editorial_Id = Item.Field<double>("EditorialId");
                            LibroObj.Titulo = Item.Field<string>("Titulo");
                            LibroObj.Sinopsis = Item.Field<string>("Sinopsis");
                            LibroObj.NPaginas = Item.Field<string>("NPaginas");
                            LibroObj.Editorial = EditorialDataAccess.EditorialDTO_ObtUno(Item.Field<double>("EditorialId"));
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        cnn.Close();
                    }
                }
            }

            return LibroObj;
        }
    }
}
