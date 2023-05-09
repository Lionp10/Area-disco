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
    public partial class frmUserCajero : Form
    {
        public frmUserCajero()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            CacheUsuario.cajNombre = txtNombreCajero.Text;
            CacheUsuario.cajApellido = txtApellidoCajero.Text;

            frmPrincipal frmPrincipal = new frmPrincipal();
            frmBienvenida frmBienvenida = new frmBienvenida();
            if (txtNombreCajero.Text != "")
            {
                if (txtApellidoCajero.Text != "")
                {
                    this.Hide();
                    frmPrincipal.lbNombreCajero.Text = txtApellidoCajero.Text + ", " + txtNombreCajero.Text;
                    frmBienvenida.lbNombreCaj.Text = txtApellidoCajero.Text + ", " + txtNombreCajero.Text;
                    frmBienvenida.ShowDialog();
                    frmPrincipal.Show();                    
                }
                else
                {
                    msgError("Ingrese su apellido.");
                    txtApellidoCajero.Focus();
                }
            }
            else
            {
                msgError("Ingrese su nombre.");
                txtNombreCajero.Focus();
            }
        }
        private void msgError(string msg)
        {
            lbErrorMsg.Text = "   " + msg;
            lbErrorMsg.Visible = true;
        }

        public void DatosCajero()
        {
            CacheUsuario.cajNombre = txtNombreCajero.Text;
            CacheUsuario.cajApellido = txtApellidoCajero.Text;
        }
    }
}
