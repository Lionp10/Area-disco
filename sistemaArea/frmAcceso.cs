using sistemaArea.Clases.csUsuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaArea
{
    public partial class frmAcceso : Form
    {
        public frmAcceso()
        {
            InitializeComponent();
        }

        private void frmAcceso_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                if (txtContrasena.Text != "")
                {
                    ModeloUsuario user = new ModeloUsuario();
                    var validLogin = user.LoginUser(txtUsuario.Text, txtContrasena.Text);
                    if (validLogin == true)
                    {                        
                        if (CacheUsuario.userRolID == CargosUsuario.Cajero)
                        {                            
                            frmUserCajero frmUserCajero = new frmUserCajero();
                            frmUserCajero.ShowDialog();
                            this.Hide();
                            frmPrincipal frmPrincipal = new frmPrincipal();
                            frmPrincipal.FormClosed += CerrarSesion;                            
                        }
                        else
                        {
                            frmBienvenida frmBienvenida = new frmBienvenida();
                            frmBienvenida.ShowDialog();
                            this.Hide();
                            frmPrincipal frmPrincipal = new frmPrincipal();
                            frmPrincipal.Show();
                            frmPrincipal.FormClosed += CerrarSesion;
                        }                        
                    }
                    else
                    {
                        msgError("Usuario o contraseña incorrecto.");
                        txtUsuario.Clear();
                        txtContrasena.Clear();
                        txtUsuario.Focus();
                    }
                }
                else
                {
                    msgError("Ingrese su contraseña.");
                    txtContrasena.Focus();
                }

            }
            else {
                msgError("Ingrese su usuario.");
                txtUsuario.Focus ();
            }           
        }
        private void msgError(string msg)
        {
            lbErrorMsg.Text = "   " + msg;
            lbErrorMsg.Visible = true;
        }

        private void CerrarSesion(object sender, FormClosedEventArgs e)
        {
            txtUsuario.Clear(); 
            txtContrasena.Clear();
            lbErrorMsg.Visible = false;
            this.Show();
            txtUsuario.Focus();
        }

        private void btnQR_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginQR frmAccesoQR = new frmLoginQR();
            frmAccesoQR.Show();
        }
    }
}
