using CalculoViaticos.ConexionSql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace CalculoViaticos.CRUD
{
    public class Empleados : ConnectionToSql
    {
        private SqlDataReader leer;
        private DataTable table = new DataTable();
        private SqlCommand command = new SqlCommand();

        public DataTable Mostrar()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "crud_empleados";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@codigo", 0);
                    command.Parameters.AddWithValue("@nombre", "");
                    command.Parameters.AddWithValue("@apellido", "");
                    command.Parameters.AddWithValue("@IdPuesto", 0);
                    command.Parameters.AddWithValue("@dni", "");
                    command.Parameters.AddWithValue("@correo", "");
                    command.Parameters.AddWithValue("@direccion", "");
                    command.Parameters.AddWithValue("@accion", "mostrar");
                    leer = command.ExecuteReader();
                    table.Load(leer);
                    connection.Close();
                }
            }
            return table;
        }

        public DataTable guardar(string nombre, string apellido, int IdPuesto, string dni, string correo, string direccion)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "crud_empleados";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@codigo", 0);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@IdPuesto", IdPuesto);
                    command.Parameters.AddWithValue("@dni", dni);
                    command.Parameters.AddWithValue("@correo", correo);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@accion", "guardar");
                    leer = command.ExecuteReader();
                    table.Load(leer);
                    connection.Close();
                }
            }
            return table;
        }

        public DataTable actualizar(int codigo, string nombre, string apellido, int IdPuesto, string dni, string correo, string direccion)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "crud_empleados";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@codigo", codigo);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@IdPuesto", IdPuesto);
                    command.Parameters.AddWithValue("@dni", dni);
                    command.Parameters.AddWithValue("@correo", correo);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@accion", "actualizar");
                    leer = command.ExecuteReader();
                    table.Load(leer);
                    connection.Close();
                }
            }
            return table;
        }

        public DataTable borrar(int codigo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "crud_empleados";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@codigo", codigo);
                    command.Parameters.AddWithValue("@nombre", "");
                    command.Parameters.AddWithValue("@apellido", "");
                    command.Parameters.AddWithValue("@IdPuesto", 0);
                    command.Parameters.AddWithValue("@dni", "");
                    command.Parameters.AddWithValue("@correo", "");
                    command.Parameters.AddWithValue("@direccion", "");
                    command.Parameters.AddWithValue("@accion", "borrar");
                    leer = command.ExecuteReader();
                    table.Load(leer);
                    connection.Close();
                }
            }
            return table;
        }
    }
}
