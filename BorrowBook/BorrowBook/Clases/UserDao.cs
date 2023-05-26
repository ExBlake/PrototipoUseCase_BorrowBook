using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowBook.Clases
{
    internal class UserDao : ConnectionToSql
    {
        public string recoverPassword(string userRequesting)
        {
            using (var connection = GetConnection())
            {
                //Abrir conexión a la BD
                connection.Open();
                using (var command = new SqlCommand())
                {
                    //Verificar usuario o correo electronico para recuperación de contraseña
                    command.Connection = connection;
                    command.CommandText = "select *from Usuarios where Usuario=@user or Correo=@mail";
                    command.Parameters.AddWithValue("@user", userRequesting);
                    command.Parameters.AddWithValue("@mail", userRequesting);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    //Capturar los datos de las columnas de la base de datos
                    if (reader.Read() == true)
                    {
                        string userName = reader.GetString(0);
                        string userMail = reader.GetString(2);
                        string accountPassword = reader.GetString(1);
                        //Mensaje de envio de recuperación de bd al correo electronico 
                        var mailService = new MailServices.SystemSupportMail();
                        mailService.sendMail(
                          subject: "SISTEMA: Solicitud recuperación contraseña",
                          body: "Hola, " + userName + "\nSolicitaste recuperar tu contraseña.\n" +
                          "tu contraseña actual es: " + accountPassword,
                          recipientMail: new List<string> { userMail }
                          );
                        return "Hola, " + userName + "\nSolicitaste recuperar tu contraseña.\n" +
                          "Por favor revisa tu correo electrónico. " + userMail;
                    }
                    else
                        return "Lo siento, No tienes una cuenta con ese usuario o correo electronico.";
                }
            }
        }
    }
}
