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
    public partial class frmSelBarman : Form
    {
        public frmSelBarman()
        {
            InitializeComponent();
        }

        private void frmSelBarman_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {           
            frmMenuCajas frmMenuCajas = new frmMenuCajas();
            frmMenuCajas.Show();
            this.Close();
        }

        private void btnBarman1_Click(object sender, EventArgs e)
        {
            frmCajaVip frmCajaVip = new frmCajaVip();
            frmCajaVip.Show();
            this.Close();
        }

        private void btnBarman2_Click(object sender, EventArgs e)
        {
            frmCajaVip frmCajaVip = new frmCajaVip();
            frmCajaVip.Show();
            this.Close();
        }

        private void btnBarman3_Click(object sender, EventArgs e)
        {
            frmCajaVip frmCajaVip = new frmCajaVip();
            frmCajaVip.Show();
            this.Close();
        }

        private void btnBarman4_Click(object sender, EventArgs e)
        {
            frmCajaVip frmCajaVip = new frmCajaVip();
            frmCajaVip.Show();
            this.Close();
        }
    }
}
