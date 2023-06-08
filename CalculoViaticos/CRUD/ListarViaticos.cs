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
    public class ListarViaticos:ConnectionToSql
    {
        private SqlDataReader leer;
        private DataTable table = new DataTable();
        private SqlCommand command = new SqlCommand();

        public DataTable ListarAlimentacion()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "ListarViaticos";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("accion", "ListarAlimentacion");
                    leer = command.ExecuteReader();
                    table.Load(leer);
                    connection.Close();
                }
            }
            return table;
        }

        public DataTable ListarHospedaje()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "ListarViaticos";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("accion", "ListarHospedaje");
                    leer = command.ExecuteReader();
                    table.Load(leer);
                    connection.Close();
                }
            }
            return table;
        }

        public DataTable ListarTransporte()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "ListarViaticos";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("accion", "ListarTransporte");
                    leer = command.ExecuteReader();
                    table.Load(leer);
                    connection.Close();
                }
            }
            return table;
        }

        public DataTable ListarOtros()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "ListarViaticos";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("accion", "ListarOtros");
                    leer = command.ExecuteReader();
                    table.Load(leer);
                    connection.Close();
                }
            }
            return table;
        }
    }
}
