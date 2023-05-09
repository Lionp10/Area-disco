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
    public partial class frmMenuCajas : Form
    {
        public frmMenuCajas()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {                      
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            this.Close();
        }

        private void btnDance_Click(object sender, EventArgs e)
        {            
            
            frmCajaDance frmCajaDance = new frmCajaDance();
            frmCajaDance.Show();            
            this.Close();
        }

        private void btnVip_Click(object sender, EventArgs e)
        {
            frmNombreBarman frmNombreBarman = new frmNombreBarman();
            frmNombreBarman.Show();
            this.Close();
        }
    }
}
