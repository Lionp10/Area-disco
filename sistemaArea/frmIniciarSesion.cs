using sistemaArea.Clases.csUsuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaArea
{
    public partial class frmIniciarSesion : Form
    {
        public frmIniciarSesion()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "")
            {
                if (txtContrasena.Text != "")
                {
                    ModeloUsuario user = new ModeloUsuario();
                    var validLogin = user.LoginUser(txtUsername.Text, txtContrasena.Text);
                    if (validLogin == true)
                    {
                        frmLogin frmLogin = new frmLogin();
                        frmLogin.Hide();
                        if (CacheUsuario.userRolID == CargosUsuario.Cajero)
                        {
                            frmUserCajero frmUserCajero = new frmUserCajero();
                            frmUserCajero.ShowDialog();                            
                            frmPrincipal frmPrincipal = new frmPrincipal();
                            frmPrincipal.Show();
                            frmPrincipal.FormClosed += CerrarSesion;
                        }
                        else
                        {
                            frmBienvenida frmBienvenida = new frmBienvenida();
                            frmBienvenida.ShowDialog();
                            frmPrincipal frmPrincipal = new frmPrincipal();
                            frmPrincipal.Show();
                            frmPrincipal.FormClosed += CerrarSesion;
                        }
                    }
                    else
                    {
                        msgError("Usuario o contraseña incorrecto.");
                        txtUsername.Clear();
                        txtContrasena.Clear();
                        txtUsername.Focus();
                    }
                }
                else
                {
                    msgError("Ingrese su contraseña.");
                    txtContrasena.Focus();
                }
            }
            else
            {
                msgError("Ingrese su usuario.");
                txtUsername.Focus();
            }
        }

        private void msgError(string msg)
        {
            lbMsgError.Text = "   " + msg;
            lbMsgError.Visible = true;
        }

        private void CerrarSesion(object sender, FormClosedEventArgs e)
        {
            txtUsername.Clear();
            txtContrasena.Clear();
            this.Show();
            lbMsgError.Visible = false;
            txtUsername.Focus();
        }

        private void frmIniciarSesion_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }
    }
}
