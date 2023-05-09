using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using sistemaArea.Clases.csUsuarios;

namespace sistemaArea
{
    public class DatosUsuarios : ConexionDB
    { 
        public bool IniciarSesion(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from usuarioData where userUsername = @user and userContrasena = @pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows) 
                    {
                        while (reader.Read())
                        {
                            CacheUsuario.userID = reader.GetInt32(0);
                            CacheUsuario.userNombre = reader.GetString(1);
                            CacheUsuario.userApellido = reader.GetString(2);
                            CacheUsuario.userEmail = reader.GetString(3);
                            CacheUsuario.userUsername = reader.GetString(4);
                            CacheUsuario.userContrasena = reader.GetString(5);
                            CacheUsuario.userCodQR = reader.GetString(6);
                            CacheUsuario.userRolID = reader.GetInt32(7);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

        public bool IniciarSesionQR(string QR)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from usuarioData where userCodQR= @QR";
                    command.Parameters.AddWithValue("@QR", QR);

                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CacheUsuario.userID = reader.GetInt32(0);
                            CacheUsuario.userNombre = reader.GetString(1);
                            CacheUsuario.userApellido = reader.GetString(2);
                            CacheUsuario.userEmail = reader.GetString(3);
                            CacheUsuario.userUsername = reader.GetString(4);
                            CacheUsuario.userContrasena = reader.GetString(5);
                            CacheUsuario.userCodQR = reader.GetString(6);
                            CacheUsuario.userRolID = reader.GetInt32(7);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

        public void EditarPerfil(int userID, string userNombre, string userApellido, string userEmail, string userUsername, string userContrasena, string userCodQR, int userRolID)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update usuarioData set userID=@userID, userNombre=@userNombre, userApellido=@userApellido, userEmail=@userEmail, userUsername=@userUsername, userContrasena=@userContrasena, userCodQR=@userCodQR, userRolID=@userRolID";
                    command.Parameters.AddWithValue("@userNombre", userNombre);
                    command.Parameters.AddWithValue("@userApellido", userApellido);
                    command.Parameters.AddWithValue("@userEmail", userEmail);
                    command.Parameters.AddWithValue("@userUsername", userUsername);
                    command.Parameters.AddWithValue("@userContrasena", userContrasena);
                    command.Parameters.AddWithValue("@userCodQR", userCodQR);
                    command.Parameters.AddWithValue("@userRolID", userRolID);
                    command.Parameters.AddWithValue("@userID", userID);
                    command.CommandType= CommandType.Text;
                    command.ExecuteNonQuery();

                }
            }
        }

        public void AnyMethod()
        {
            if(CacheUsuario.userRolID == CargosUsuario.Administrador)
            {
                //Code
            }
            if(CacheUsuario.userRolID == CargosUsuario.Ecargado)
            {
                // Code
            }
            if (CacheUsuario.userRolID == CargosUsuario.Cajero)
            {
                // Code
            }
        }
    }
}
