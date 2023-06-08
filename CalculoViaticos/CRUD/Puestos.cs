using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculoViaticos.ConexionSql;

namespace CalculoViaticos.CRUD
{
    public class Puestos:ConnectionToSql
    {

        private SqlDataReader leer;
        private DataTable table = new DataTable();
        private SqlCommand command = new SqlCommand();
        public DataTable ListarPuestos()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "CRUD_PUESTOS";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    leer = command.ExecuteReader();
                    table.Load(leer);
                    connection.Close();
                }
            }
            return table;
        }

        public DataTable ListarEmpleados()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "ListarEmpleados";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    leer = command.ExecuteReader();
                    table.Load(leer);
                    connection.Close();
                }
            }
            return table;
        }
        
        public DataTable ListarTipoTransporte()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "ListarTipoTransporte";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    leer = command.ExecuteReader();
                    table.Load(leer);
                    connection.Close();
                }
            }
            return table;
        }


    }
}
