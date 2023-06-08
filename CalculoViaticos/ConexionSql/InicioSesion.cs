using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Xaml;

namespace CalculoViaticos.ConexionSql
{
    public class InicioSesion : ConnectionToSql
    {
        private SqlDataReader leer;
        private DataTable table = new DataTable();

        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Login1";
                    command.Parameters.AddWithValue("@codigo", 0);
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            //
                        }
                        return true;
                    }
                    else return false;
                }
            }
        }

        public string recoverPassword(string userRequesting)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "RecuperarContraseña";
                    command.Parameters.AddWithValue("@correo", userRequesting);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        string userName = reader.GetString(3) + " " + reader.GetString(4);
                        string userMail = reader.GetString(1);
                        string password = reader.GetString(2);
                        string accountPassword = reader.GetString(2);
                        var mailService = new ServidorCorreo.SistemaSoporteCorreo();
                        mailService.sendMail(
                          subject: "SISTEMA: Solicitud de recuperacion de contraseña",
                          body: "Hola " + userName + "\nsolicitaste recuperar tu contraseña.\n" +
                          "Por favor, revise su correo electrónico" +
                          "\nSu contraseña es: " + password,
                          recipientMail: new List<string> { userMail }
                          );
                        return "Hola " + userName + "\nsolicitaste recuperar tu contraseña.\n" +
                                "Por favor, revise su correo electrónico";
                    }
                    else
                        return "Lo sentimos, el correo ingresado no está registrado";
                }
            }
        }

        public string MensajeViaticos(string userRequesting)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT a.IdUsuario, b.correo, [dbo].[Desencriptar](A.Contrasenia) AS Contraseña, B.nombre, B.apellido FROM Usuarios A INNER JOIN empleados B ON a.IdEmpleado = b.IdEmpleado WHERE b.correo = @correo";
                    command.Parameters.AddWithValue("@correo", userRequesting);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        string userName = reader.GetString(3) + " " + reader.GetString(4);
                        string userMail = reader.GetString(1);
                        var mailService = new ServidorCorreo.SistemaSoporteCorreo();
                        mailService.sendMail(
                          subject: "SISTEMA: Mensaje de Asignacion de viaticos",
                          body: "Hola " + userName + "\nTe informamos que tus viaticos han sido asigandos.\n" +
                          "Por favor, comuniquese con su jefe inmediato para proseguir con el proceso\n" +
                          "Gracias por trabajar con nosotros sigue esforzandote",
                          recipientMail: new List<string> { userMail }
                          );
                        return "Mensaje de confirmacion!";
                    }
                    else
                        return "Lo siento error en el sistema";
                }
            }
        }
    }
}
