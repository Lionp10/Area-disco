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
    public partial class frmLoginQR : Form
    {
        public frmLoginQR()
        {
            InitializeComponent();
        }

        private void frmAccesoQR_Load(object sender, EventArgs e)
        {
            txtQR.Focus();
        }

        private void msgError(string msg)
        {
            lbMsgError.Text = "   " + msg;
            lbMsgError.Visible = true;
        }

        private void txtQR_TextChanged(object sender, EventArgs e)
        {
            if (txtQR.Text != "")
            {
                if (txtQR.Text != "")
                {
                    ModeloUsuario user = new ModeloUsuario();
                    var validLogin = user.LoginUserQR(txtQR.Text);
                    if (validLogin == true)
                    {
                        frmBienvenida frmBienvenida = new frmBienvenida();
                        frmBienvenida.ShowDialog();
                        frmPrincipal frmPrincipal = new frmPrincipal();
                        frmPrincipal.Show();
                    }
                    else
                    {
                        msgError("Tarjeta no valida");
                    }
                }
            }
            else
            {
                msgError("Tarjeta no valida");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAcceso frmAcceso = new frmAcceso();
            frmAcceso.Show();
        }
    }
}
