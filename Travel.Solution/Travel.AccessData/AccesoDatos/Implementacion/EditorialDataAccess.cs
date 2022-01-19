using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Travel.DTOS.DTO;
using Travel.Generales.General;

namespace Travel.AccessData.AccesoDatos.Implementacion
{
    public class EditorialDataAccess : IEditorialDataAccess
    {
        private AccesoBaseDatos AccesoBaseDatos = new AccesoBaseDatos();

        public DataTable Editorial_ObtAll()
        {
            DataSet ds = new DataSet();

            using (SqlConnection cnn = new SqlConnection(AccesoBaseDatos.GetCnnString()))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "Editoriales_ObtAll";

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

        public DataTable Editorial_ObtUno(int ID)
        {
            DataSet ds = new DataSet();

            using (SqlConnection cnn = new SqlConnection(AccesoBaseDatos.GetCnnString()))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "Editoriales_ObtUno";

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

        public int Editorial_Insertar(int ID, string Nombre, string Sede)
        {
            using (SqlConnection cnn = new SqlConnection(AccesoBaseDatos.GetCnnString()))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "Editoriales_Insertar";

                    cmd.Parameters.Add("@ID", SqlDbType.BigInt);
                    cmd.Parameters["@ID"].Value = ID;

                    cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
                    cmd.Parameters["@Nombre"].Value = Nombre;

                    cmd.Parameters.Add("@Sede", SqlDbType.VarChar);
                    cmd.Parameters["@Sede"].Value = Sede;

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

        public int Editorial_Actualizar(int ID, string Nombre, string Sede)
        {
            using (SqlConnection cnn = new SqlConnection(AccesoBaseDatos.GetCnnString()))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "Editoriales_Actualizar";

                    cmd.Parameters.Add("@ID", SqlDbType.BigInt);
                    cmd.Parameters["@ID"].Value = ID;

                    cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
                    cmd.Parameters["@Nombre"].Value = Nombre;

                    cmd.Parameters.Add("@Sede", SqlDbType.VarChar);
                    cmd.Parameters["@Sede"].Value = Sede;

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

        public List<EditorialDTO> EditorialDTO_ObtAll()
        {
            List<EditorialDTO> LEditoriales = new List<EditorialDTO>();
            EditorialDTO EditorialObj = new EditorialDTO();
            DataSet ds = new DataSet();

            using (SqlConnection cnn = new SqlConnection(AccesoBaseDatos.GetCnnString()))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "Editoriales_ObtAll";

                    try
                    {
                        SqlDataAdapter SqlData = new SqlDataAdapter(cmd);
                        SqlData.Fill(ds);

                        foreach (DataRow Item in ds.Tables[0].Rows)
                        {
                            EditorialObj = new EditorialDTO();

                            EditorialObj.ID = Item.Field<double>("ID");
                            EditorialObj.Nombre = Item.Field<string>("Nombre");
                            EditorialObj.Sede = Item.Field<string>("Sede");

                            LEditoriales.Add(EditorialObj);
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

            return LEditoriales;
        }

        public EditorialDTO EditorialDTO_ObtUno(int ID)
        {
            EditorialDTO EditorialObj = new EditorialDTO();
            DataSet ds = new DataSet();

            using (SqlConnection cnn = new SqlConnection(AccesoBaseDatos.GetCnnString()))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "Editoriales_ObtUno";

                    cmd.Parameters.Add("@ID", SqlDbType.BigInt);
                    cmd.Parameters["@ID"].Value = ID;

                    try
                    {
                        SqlDataAdapter SqlData = new SqlDataAdapter(cmd);
                        SqlData.Fill(ds);

                        foreach (DataRow Item in ds.Tables[0].Rows)
                        {
                            EditorialObj = new EditorialDTO();

                            EditorialObj.ID = Item.Field<double>("ID");
                            EditorialObj.Nombre = Item.Field<string>("Nombre");
                            EditorialObj.Sede = Item.Field<string>("Sede");
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

            return EditorialObj;
        }
    }
}
