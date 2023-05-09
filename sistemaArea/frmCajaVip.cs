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
    public partial class frmCajaVip : Form
    {
        public frmCajaVip()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            frmSelBarman frmSelBarman = new frmSelBarman();
            frmSelBarman.Show();
            this.Close();
        }
    }
}
