using sistemaArea.Clases.csUsuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaArea
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            timerFechaHora.Enabled = true;
            lbNombreCajero.Visible = false;
            DatosUsuarios();

            //Permisos de usuarios
            if (CacheUsuario.userRolID == CargosUsuario.Cajero || CacheUsuario.userRolID == CargosUsuario.Ecargado) // Encargado & Cajero
            {
                btnAdmUsers.Enabled = false;
                btnReportes.Enabled = false;
                btnDeposito.Enabled = false;
                btnSincronizar.Enabled = false;
            }
            if (CacheUsuario.userRolID == CargosUsuario.Cajero) // Cajero
            {
                lbNombreCompleto.Visible = false;
                lbUsuario.Visible = true;
                lbNombreCajero.Visible = true;
                linkLbMiPerfil.Enabled = false;
            }
            if (CacheUsuario.userRolID == CargosUsuario.Administrador || CacheUsuario.userRolID == CargosUsuario.Ecargado) // Administrador & Encargado
            {
                lbNombreCajero.Visible = false;
            }
        }

        private void DatosUsuarios()
        {
            lbUsuario.Text = CacheUsuario.userUsername;
            lbNombreCompleto.Text = CacheUsuario.userApellido + ", " + CacheUsuario.userNombre;
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
        }

        #region Botones

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de cerrar sesión?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                if (CacheUsuario.userRolID == 3)
                {
                    Application.Exit();
                }
                else
                {
                    this.Close();
                    Application.Exit();
                }
        }

        private void linkLbMiPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirFormulario<frmPerfilUsuario>();
        }

        private void btnCajas_Click(object sender, EventArgs e)
        {
            frmMenuCajas frmMenuCajas = new frmMenuCajas();
            frmMenuCajas.Show();
            this.Hide();
        }



        #endregion

        #region Funcionalidades del formulario

        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(32, 26, 21));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        // Capturar posición y tamaño del formulario
        int lx, ly;
        int sw, sh;

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de cerrar la aplicación?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelBarraTitulo_DoubleClick(object sender, EventArgs e)
        {
            if (btnMaximizar.Visible == true)
            {
                lx = this.Location.X;
                ly = this.Location.Y;
                sw = this.Size.Width;
                sh = this.Size.Height;
                btnMaximizar.Visible = false;
                btnRestaurar.Visible = true;
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            }
            else
            {
                btnMaximizar.Visible = true;
                btnRestaurar.Visible = false;
                this.Size = new Size(sw, sh);
                this.Location = new Point(lx, ly);
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();        

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void timerFechaHora_Tick(object sender, EventArgs e)
        {
            lbFechaHora.Text = DateTime.Now.ToString();
        }

        // MÉTODOS PARA ABRIR FORMULARIOS DENTRO DE UN PANEL
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                     //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForm);
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }
        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            //if (Application.OpenForms["frmPerfilUsuario"] == null)
            //{
            //    btnMiPerfil.BackColor = Color.FromArgb(120,91,59);
            //}

            //Así con todos los forms
            //if (Application.OpenForms["frmReportes"] == null)
            //{
            //    btnMiPerfil.BackColor = Color.FromArgb(120, 91, 59);
            //}
        }

        #endregion
    }
}
