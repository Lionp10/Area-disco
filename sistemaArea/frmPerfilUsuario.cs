using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sistemaArea
{
    public partial class frmPerfilUsuario : Form
    {
        public frmPerfilUsuario()
        {
            InitializeComponent();
        }

        private void frmPerfilUsuario_Load(object sender, EventArgs e)
        {            
            loadUserData();
            initializePassEditControls();
        }

        private void btnEditPeril_Click(object sender, EventArgs e)
        {
            panelEditPerfil.Visible = true;
            loadUserData();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadUserData()
        {
            //View
            lbNombreCompleto.Text = CacheUsuario.userApellido + ", " + CacheUsuario.userNombre;
            lbEmail.Text = CacheUsuario.userEmail;
            lbUsername.Text = CacheUsuario.userUsername;
            if (CacheUsuario.userRolID == 1)
            {
                lbRol.Text = "Administrador/a";
            }
            if (CacheUsuario.userRolID == 2)
            {
                lbRol.Text = "Encargado/a";
            }
            if (CacheUsuario.userRolID == 3)
            {
                lbRol.Text = "Cajero/a";
            }

            //Edit panel
            txtEditNombre.Text = CacheUsuario.userNombre;
            txtEditApellido.Text = CacheUsuario.userApellido;
            txtEditEmail.Text = CacheUsuario.userEmail;
            txtEditUsername.Text = CacheUsuario.userUsername;
            txtEditContrasena.Text = CacheUsuario.userContrasena;
            txtEditContrasena.PasswordChar = '*';
            txtEditRepContrasena.Text = CacheUsuario.userContrasena;
            txtEditRepContrasena.PasswordChar = '*';
            txtEditQR.Text = CacheUsuario.userCodQR;
            txtEditQR.PasswordChar = '*';
            txtContrasenaActual.Text = "";
        }
        
        private void initializePassEditControls()
        {            
            txtEditContrasena.Enabled = false;
            txtEditRepContrasena.Enabled = false;
            picOjos.Enabled = false;
            picOjos2.Enabled = false;
            linkEditPass.Text = "Edit";

            txtEditQR.Enabled = false;
            linkEditQR.Text = "Edit";
            picOjos3.Enabled = false;

        }

        private void reset()
        {
            loadUserData();
            initializePassEditControls();
        }

        private void linkEditPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkEditPass.Text == "Edit")
            {
                linkEditPass.Text = "Cancel";
                txtEditContrasena.Enabled = true;
                txtEditRepContrasena.Enabled = true;
                picOjos.Enabled = true;
                picOjos2.Enabled = true;
            }
            else if (linkEditPass.Text == "Cancel")
            {
                initializePassEditControls();
                txtEditContrasena.Text = CacheUsuario.userContrasena;
                txtEditRepContrasena.Text = CacheUsuario.userContrasena;
                txtEditContrasena.PasswordChar = '*';
                txtEditRepContrasena.PasswordChar = '*';
            }
        }

        private void linkEditQR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkEditQR.Text == "Edit")
            {
                linkEditQR.Text = "Cancel";
                txtEditQR.Enabled = true;
                picOjos3.Enabled = true;
            }
            else if (linkEditQR.Text == "Cancel")
            {
                initializePassEditControls();                
                txtEditQR.Text = CacheUsuario.userCodQR;
                txtEditQR.PasswordChar = '*';
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelEditPerfil.Visible = false;
            reset();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtEditContrasena.Text.Length >= 5)
            {
                if (txtEditContrasena.Text == txtEditRepContrasena.Text)
                {
                    if (txtContrasenaActual.Text == CacheUsuario.userContrasena)
                    {
                        var ModeloUsario = new ModeloUsuario(
                            userID: CacheUsuario.userID,
                            userNombre: txtEditNombre.Text,
                            userApellido: txtEditApellido.Text,
                            userEmail: txtEditEmail.Text,
                            userUsername: txtEditUsername.Text,
                            userContrasena: txtEditContrasena.Text,
                            userCodQR: txtEditQR.Text,
                            userRolID: CacheUsuario.userRolID);
                        var result = ModeloUsario.EditarPerfilUsuario();
                        MessageBox.Show(result);
                        reset();
                        panelEditPerfil.Visible = false;
                    }
                    else
                        MessageBox.Show("Contraseña actual incorrecta.");


                }
                else
                    MessageBox.Show("Las contraseñas no coinciden.");
            }
            else
                MessageBox.Show("La contraseña debe tener al menos 5 caracteres.");
        }

        #region Ver / Ocultas password / QR
        private void picOjos_Click(object sender, EventArgs e)
        {
            if (txtEditContrasena.PasswordChar == '\0')
            {
                // Si el PasswordChar actual es un carácter normal, cámbielo a un carácter de contraseña.
                txtEditContrasena.PasswordChar = '*';
                picOjos.Image = Properties.Resources.ojoOpen;
            }
            else
            {
                // Si el PasswordChar actual es un carácter de contraseña, cámbielo a un carácter normal.
                txtEditContrasena.PasswordChar = '\0';
                picOjos.Image = Properties.Resources.ojoClose;
            }
        }
        private void picOjos2_Click(object sender, EventArgs e)
        {
            if (txtEditRepContrasena.PasswordChar == '\0')
            {
                // Si el PasswordChar actual es un carácter normal, cámbielo a un carácter de contraseña.
                txtEditRepContrasena.PasswordChar = '*';
                picOjos2.Image = Properties.Resources.ojoOpen;
            }
            else
            {
                // Si el PasswordChar actual es un carácter de contraseña, cámbielo a un carácter normal.
                txtEditRepContrasena.PasswordChar = '\0';
                picOjos2.Image = Properties.Resources.ojoClose;
            }
        }

        private void picOjos3_Click(object sender, EventArgs e)
        {
            if (txtEditQR.PasswordChar == '\0')
            {
                // Si el PasswordChar actual es un carácter normal, cámbielo a un carácter de contraseña.
                txtEditQR.PasswordChar = '*';
                picOjos3.Image = Properties.Resources.ojoOpen;
            }
            else
            {
                // Si el PasswordChar actual es un carácter de contraseña, cámbielo a un carácter normal.
                txtEditQR.PasswordChar = '\0';
                picOjos3.Image = Properties.Resources.ojoClose;
            }
        }

        private void picOjos4_Click(object sender, EventArgs e)
        {
            if (txtContrasenaActual.PasswordChar == '\0')
            {
                // Si el PasswordChar actual es un carácter normal, cámbielo a un carácter de contraseña.
                txtContrasenaActual.PasswordChar = '*';
                picOjos4.Image = Properties.Resources.ojoOpen;
            }
            else
            {
                // Si el PasswordChar actual es un carácter de contraseña, cámbielo a un carácter normal.
                txtContrasenaActual.PasswordChar = '\0';
                picOjos4.Image = Properties.Resources.ojoClose;
            }
        }

        #endregion
        
    }
}
