using System.Data;
using System.Configuration;
using System.Data.SqlClient;


namespace UtilitiesSolution.ConenctionDataBase.ADO
{
    
   public class ConectionFactory
    {
        static SqlConnection ConnectionDataBase;

        public static SqlConnection BuildConnection()
        {
            if (ConnectionDataBase == null)
            {
                ConnectionDataBase = new SqlConnection();
                ConnectionDataBase.ConnectionString = ConfigurationManager.ConnectionStrings["DataBaseContext"].ConnectionString;
            }
            if (ConnectionDataBase.State == ConnectionState.Closed)
                ConnectionDataBase.Open();
            
            return ConnectionDataBase;
        }
    }

}
