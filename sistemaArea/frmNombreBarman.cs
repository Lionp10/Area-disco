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
    public partial class frmNombreBarman : Form
    {
        public frmNombreBarman()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            frmMenuCajas frmMenuCajas = new frmMenuCajas();
            frmMenuCajas.Show();
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            frmSelBarman frmSelBarman = new frmSelBarman();

            // Barman 1
            if (txtBarman1.Text == "")
            {
                frmSelBarman.btnBarman1.Enabled = false;
            }
            else
            {
                frmSelBarman.btnBarman1.Text = "1 - " + txtBarman1.Text;                
            }
            // Barman 2
            if (txtBarman2.Text == "")
            {
                frmSelBarman.btnBarman2.Enabled = false;
            }
            else
            {
                frmSelBarman.btnBarman2.Text = "2 - " + txtBarman2.Text;
            }
            // Barman 3
            if (txtBarman3.Text == "")
            {
                frmSelBarman.btnBarman3.Enabled = false;
            }
            else
            {
                frmSelBarman.btnBarman3.Text = "3 - " + txtBarman3.Text;
            }
            // Barman 4
            if (txtBarman4.Text == "")
            {
                frmSelBarman.btnBarman4.Enabled = false;
            }
            else
            {
                frmSelBarman.btnBarman4.Text = "4 - " + txtBarman4.Text;
            }

            frmSelBarman.Show();
            this.Close();

        }
    }
}
