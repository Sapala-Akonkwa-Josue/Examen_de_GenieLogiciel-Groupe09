using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_GL_Groupe01._4._Connexion
{
    internal class DataAccess
    {
        public SqlConnection connection = null;
        string connectionString = "Data Source=KING-SAP-PC;Initial Catalog=gestion_personne;User ID=sa;Password=1234;Encrypt=false";
        public bool OpenConnection()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();

            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void CloseConnection()
        {
            if (connection != null)
            {
                connection.Close();
            }
        }
    }
}
