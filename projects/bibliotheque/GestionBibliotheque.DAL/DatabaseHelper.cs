using Microsoft.Data.SqlClient;
using System.Configuration;

namespace GestionBibliotheque.DAL
{
    public static class DatabaseHelper
    {
        public static SqlConnection GetConnection()
        {
            string cs = ConfigurationManager
                .ConnectionStrings["BibliothequeDb"]
                .ConnectionString;

            return new SqlConnection(cs);
        }
    }
}

