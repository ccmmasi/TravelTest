using System.Configuration;

namespace Travel.Generales.General
{
    public class AccesoBaseDatos
    {
        protected readonly string CnnString = ConfigurationManager.ConnectionStrings["Travel.SQL"] != null ? ConfigurationManager.ConnectionStrings["Travel.SQL"].ConnectionString : "";

        public string GetCnnString()
        {
            return CnnString;
        }
    }
}
 