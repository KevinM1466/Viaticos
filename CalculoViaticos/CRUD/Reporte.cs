using CalculoViaticos.ConexionSql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoViaticos.CRUD
{
    public class Reporte : ConnectionToSql
    {
        private SqlDataReader leer;
        private DataTable table = new DataTable();
        private SqlCommand command = new SqlCommand();

        public DataTable InsertarAlimentacion(int ndiasDesayuno, float asignacionDesayuno, int ndiasAlmuerzo, float asignacionAlmuerzo, int ndiasCena, float asignacionCena, float subTotalDesayuno, float subTotalAlmuerzo,
                float subTotalCena, int empleadoAlimentacion)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "GuardarAlimentacion";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@ndiasDesayuno", ndiasDesayuno);
                    command.Parameters.AddWithValue("@asignacionDesayuno",asignacionDesayuno);
                    command.Parameters.AddWithValue("@ndiasAlmuerzo", ndiasAlmuerzo);
                    command.Parameters.AddWithValue("@asignacionAlmuerzo", asignacionAlmuerzo);
                    command.Parameters.AddWithValue("@ndiasCena", ndiasCena);
                    command.Parameters.AddWithValue("@asignacionCena", asignacionCena);
                    command.Parameters.AddWithValue("@subdesayuno", subTotalDesayuno);
                    command.Parameters.AddWithValue("@subalmuerzo", subTotalAlmuerzo);
                    command.Parameters.AddWithValue("@subcena", subTotalCena);
                    command.Parameters.AddWithValue("@empleadoID", empleadoAlimentacion);
                    leer = command.ExecuteReader();
                    table.Load(leer);
                    connection.Close();
                }
            }
            return table;
        }

        public DataTable InsertarHospedaje(int ndiasHospedaje, float asignacionHospedaje, int empleadoHospedaje)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "GuardarHospedaje";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@ndiasHospedaje", ndiasHospedaje);
                    command.Parameters.AddWithValue("@asignacionHospedaje", asignacionHospedaje);
                    command.Parameters.AddWithValue("@empleadoID", empleadoHospedaje);
                    leer = command.ExecuteReader();
                    table.Load(leer);
                    connection.Close();
                }
            }
            return table;
        }

        public DataTable InsertarTransporte(int idTipoTransporte, float ida, float regreso, int empleadoTransporte)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "GuardarTransporte";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@idTipoTransporte", idTipoTransporte);
                    command.Parameters.AddWithValue("@ida", ida);
                    command.Parameters.AddWithValue("@regreso", regreso);
                    command.Parameters.AddWithValue("@empleadoID", empleadoTransporte);
                    leer = command.ExecuteReader();
                    table.Load(leer);
                    connection.Close();
                }
            }
            return table;
        }

        public DataTable InsertarOtros(int ndiasOtros, float asignacionOtros, string descripcion, int empleadoOtros)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "GuardarOtros";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@ndiasOtros", ndiasOtros);
                    command.Parameters.AddWithValue("@asignacionOtros", asignacionOtros);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@empleadoID", empleadoOtros);
                    leer = command.ExecuteReader();
                    table.Load(leer);
                    connection.Close();
                }
            }
            return table;
        }

        public DataTable InsertarViaticos(DateTime fechaSalida, DateTime fecharegreso, int idTransporte, int idAlimentacion, int idHospedaje, int idOtros, int empleadoID)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "GuardarViaticos";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@fechaSalida", fechaSalida);
                    command.Parameters.AddWithValue("@fecharegreso", fecharegreso);
                    command.Parameters.AddWithValue("@idTransporte", idTransporte);
                    command.Parameters.AddWithValue("@idAlimentacion", idAlimentacion);
                    command.Parameters.AddWithValue("@idHospedaje", idHospedaje);
                    command.Parameters.AddWithValue("@idOtros", idOtros);
                    command.Parameters.AddWithValue("@empleadoID", empleadoID);
                    command.Parameters.AddWithValue("@accion", "Insertar");
                    leer = command.ExecuteReader();
                    table.Load(leer);
                    connection.Close();
                }
            }
            return table;
        }

        public DataTable MostrarViaticos()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "GuardarViaticos";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@fechaSalida", null);
                    command.Parameters.AddWithValue("@fecharegreso", null);
                    command.Parameters.AddWithValue("@idTransporte", 0);
                    command.Parameters.AddWithValue("@idAlimentacion", 0);
                    command.Parameters.AddWithValue("@idHospedaje", 0);
                    command.Parameters.AddWithValue("@idOtros", 0);
                    command.Parameters.AddWithValue("@empleadoID", 0);
                    command.Parameters.AddWithValue("@accion", "Mostrar");
                    leer = command.ExecuteReader();
                    table.Load(leer);
                    connection.Close();
                }
            }
            return table;
        }
    }
}
