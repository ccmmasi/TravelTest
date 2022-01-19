using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Travel.DTOS.DTO;
using Travel.Generales.General;

namespace Travel.AccessData.AccesoDatos.Implementacion
{
    public class AutorLibroDataAccess : IAutorLibroDataAccess
    {
        private AccesoBaseDatos AccesoBaseDatos = new AccesoBaseDatos();

        public DataTable AutorLibro_ObtAll()
        {
            DataSet ds = new DataSet();

            using (SqlConnection cnn = new SqlConnection(AccesoBaseDatos.GetCnnString()))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "AutorLibros_ObtAll";

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

        public DataTable AutorLibro_ObtUno(double Autor_Id, double Libro_ISBN)
        {
            DataSet ds = new DataSet();

            using (SqlConnection cnn = new SqlConnection(AccesoBaseDatos.GetCnnString()))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "AutorLibros_ObtUno";

                    cmd.Parameters.Add("@AutoresId", SqlDbType.BigInt);
                    cmd.Parameters["@AutoresId"].Value = Autor_Id;

                    cmd.Parameters.Add("@LibrosISBN", SqlDbType.BigInt);
                    cmd.Parameters["@LibrosISBN"].Value = Libro_ISBN;

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

        public int AutorLibro_Insertar(double Autor_Id, double Libro_ISBN)
        {
            using (SqlConnection cnn = new SqlConnection(AccesoBaseDatos.GetCnnString()))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "AutorLibros_Insertar";

                    cmd.Parameters.Add("@AutoresId", SqlDbType.BigInt);
                    cmd.Parameters["@AutoresId"].Value = Autor_Id;

                    cmd.Parameters.Add("@LibrosISBN", SqlDbType.BigInt);
                    cmd.Parameters["@LibrosISBN"].Value = Libro_ISBN;

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

        public List<AutorLibroDTO> AutorLibroDTO_ObtAll()
        {
            IAutorDataAccess AutorDataAccess = new AutorDataAccess();
            ILibroDataAccess LibroDataAccess = new LibroDataAccess();
            List<AutorLibroDTO> LAutorLibroes = new List<AutorLibroDTO>();
            AutorLibroDTO AutorLibroObj = new AutorLibroDTO();
            DataSet ds = new DataSet();

            using (SqlConnection cnn = new SqlConnection(AccesoBaseDatos.GetCnnString()))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "AutorLibroes_ObtAll";

                    try
                    {
                        SqlDataAdapter SqlData = new SqlDataAdapter(cmd);
                        SqlData.Fill(ds);

                        foreach (DataRow Item in ds.Tables[0].Rows)
                        {
                            AutorLibroObj = new AutorLibroDTO();

                            AutorLibroObj.Autor_Id = Item.Field<double>("AutoresId");
                            AutorLibroObj.Libro_ISBN = Item.Field<double>("LibrosISBN");
                            AutorLibroObj.Autor = AutorDataAccess.AutorDTO_ObtUno(Item.Field<double>("AutoresId"));
                            AutorLibroObj.Libro = LibroDataAccess.LibroDTO_ObtUno(Item.Field<double>("LibrosISBN"));

                            LAutorLibroes.Add(AutorLibroObj);
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

            return LAutorLibroes;
        }

        public AutorLibroDTO AutorLibroDTO_ObtUno(double Autor_Id, double Libro_ISBN)
        {
            IAutorDataAccess AutorDataAccess = new AutorDataAccess();
            ILibroDataAccess LibroDataAccess = new LibroDataAccess();
            AutorLibroDTO AutorLibroObj = new AutorLibroDTO();
            DataSet ds = new DataSet();

            using (SqlConnection cnn = new SqlConnection(AccesoBaseDatos.GetCnnString()))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "AutorLibroes_ObtUno";

                    cmd.Parameters.Add("@AutoresId", SqlDbType.BigInt);
                    cmd.Parameters["@AutoresId"].Value = Autor_Id;

                    cmd.Parameters.Add("@LibrosISBN", SqlDbType.BigInt);
                    cmd.Parameters["@LibrosISBN"].Value = Libro_ISBN;

                    try
                    {
                        SqlDataAdapter SqlData = new SqlDataAdapter(cmd);
                        SqlData.Fill(ds);

                        foreach (DataRow Item in ds.Tables[0].Rows)
                        {
                            AutorLibroObj = new AutorLibroDTO();

                            AutorLibroObj.Autor_Id = Item.Field<double>("AutoresId");
                            AutorLibroObj.Libro_ISBN = Item.Field<double>("LibrosISBN");
                            AutorLibroObj.Autor = AutorDataAccess.AutorDTO_ObtUno(Item.Field<double>("AutoresId"));
                            AutorLibroObj.Libro = LibroDataAccess.LibroDTO_ObtUno(Item.Field<double>("LibrosISBN"));
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

            return AutorLibroObj;
        }
    }
}
