using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoViaticos.ConexionSql
{
    public abstract class ConnectionToSql
    {

        private readonly string connectionString;
        public ConnectionToSql()
        {
            connectionString = "Data Source=THEDARKSARCO;Initial Catalog=ViaticosTEH;Integrated Security=True";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

    }
}
