using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace sistemaArea
{
    public class ModeloUsuario
    {
        DatosUsuarios DatosUsuarios = new DatosUsuarios();

        //Atributos de usuario
        private int userID;
        private string userNombre;
        private string userApellido;
        private string userEmail;
        private string userUsername;
        private string userContrasena;
        private string userCodQR;
        private int userRolID;

        public ModeloUsuario(int userID, string userNombre, string userApellido, string userEmail, string userUsername, string userContrasena, string userCodQR, int userRolID)
        {
            this.userID = userID;
            this.userNombre = userNombre;
            this.userApellido = userApellido;
            this.userEmail = userEmail;
            this.userUsername = userUsername;
            this.userContrasena = userContrasena;
            this.userCodQR = userCodQR;
            this.userRolID = userRolID;
        }

        public ModeloUsuario()
        {

        }

        public string EditarPerfilUsuario()
        {
            try
            {
                DatosUsuarios.EditarPerfil(userID, userNombre, userApellido, userEmail, userUsername, userContrasena, userCodQR, userRolID);
                DatosUsuarios.IniciarSesion(userUsername, userContrasena);
                return "Tu perfil se actualizó correctamente.";
            }
            catch (Exception ex)
            {

                return "El nombre de usuario ya existe, intenta de nuevo." + ex;
            }
        }

        public bool LoginUser(string user, string pass)
        {
            return DatosUsuarios.IniciarSesion(user, pass);
        }
        public bool LoginUserQR(string QR)
        {
            return DatosUsuarios.IniciarSesionQR(QR);
        }
    }
}
