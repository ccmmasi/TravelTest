using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Travel.DTOS.DTO;
using Travel.Generales.General;

namespace Travel.AccessData.AccesoDatos.Implementacion
{
    public class AutorDataAccess : IAutorDataAccess
    {
        private AccesoBaseDatos AccesoBaseDatos = new AccesoBaseDatos();

        public DataTable Autor_ObtAll()
        {
            DataSet ds = new DataSet();

            using (SqlConnection cnn = new SqlConnection(AccesoBaseDatos.GetCnnString()))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "Autores_ObtAll";

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

        public DataTable Autor_ObtUno(double ID)
        {
            DataSet ds = new DataSet();

            using (SqlConnection cnn = new SqlConnection(AccesoBaseDatos.GetCnnString()))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "Autores_ObtUno";

                    cmd.Parameters.Add("@ID", SqlDbType.BigInt);
                    cmd.Parameters["@ID"].Value = ID;

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

        public int Autor_Insertar(double ID, string Nombres, string Apellidos)
        {
            using (SqlConnection cnn = new SqlConnection(AccesoBaseDatos.GetCnnString()))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "Autores_Insertar";

                    cmd.Parameters.Add("@ID", SqlDbType.BigInt);
                    cmd.Parameters["@ID"].Value = ID;

                    cmd.Parameters.Add("@Nombres", SqlDbType.VarChar);
                    cmd.Parameters["@Nombres"].Value = Nombres;

                    cmd.Parameters.Add("@Apellidos", SqlDbType.VarChar);
                    cmd.Parameters["@Apellidos"].Value = Apellidos;

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

        public int Autor_Actualizar(double ID, string Nombres, string Apellidos)
        {
            using (SqlConnection cnn = new SqlConnection(AccesoBaseDatos.GetCnnString()))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "Autores_Actualizar";

                    cmd.Parameters.Add("@ID", SqlDbType.BigInt);
                    cmd.Parameters["@ID"].Value = ID;

                    cmd.Parameters.Add("@Nombres", SqlDbType.VarChar);
                    cmd.Parameters["@Nombres"].Value = Nombres;

                    cmd.Parameters.Add("@Apellidos", SqlDbType.VarChar);
                    cmd.Parameters["@Apellidos"].Value = Apellidos;

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

        public List<AutorDTO> AutorDTO_ObtAll()
        {
            List<AutorDTO> LAutores = new List<AutorDTO>();
            AutorDTO AutorObj = new AutorDTO();
            DataSet ds = new DataSet();

            using (SqlConnection cnn = new SqlConnection(AccesoBaseDatos.GetCnnString()))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "Autores_ObtAll";

                    try
                    {
                        SqlDataAdapter SqlData = new SqlDataAdapter(cmd);
                        SqlData.Fill(ds);

                        foreach (DataRow Item in ds.Tables[0].Rows)
                        {
                            AutorObj = new AutorDTO();

                            AutorObj.ID = Item.Field<double>("ID");
                            AutorObj.Nombres = Item.Field<string>("Nombres");
                            AutorObj.Apellidos = Item.Field<string>("Apellidos");

                            LAutores.Add(AutorObj);
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

            return LAutores;
        }

        public AutorDTO AutorDTO_ObtUno(double ID)
        {
            AutorDTO AutorObj = new AutorDTO();
            DataSet ds = new DataSet();

            using (SqlConnection cnn = new SqlConnection(AccesoBaseDatos.GetCnnString()))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "Autores_ObtUno";

                    cmd.Parameters.Add("@ID", SqlDbType.BigInt);
                    cmd.Parameters["@ID"].Value = ID;

                    try
                    {
                        SqlDataAdapter SqlData = new SqlDataAdapter(cmd);
                        SqlData.Fill(ds);

                        foreach (DataRow Item in ds.Tables[0].Rows)
                        {
                            AutorObj = new AutorDTO();

                            AutorObj.ID = Item.Field<double>("ID");
                            AutorObj.Nombres = Item.Field<string>("Nombres");
                            AutorObj.Apellidos = Item.Field<string>("Apellidos");
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

            return AutorObj;
        }
    }
}
