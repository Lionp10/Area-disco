using sistemaArea.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaArea
{
    public partial class frmCajaDance : Form
    {
        public frmCajaDance()
        {
            InitializeComponent();
            panelBebidas.Visible = true;
        }

        private void frmCajaDance_Load(object sender, EventArgs e)
        {
            lbPuesto.Text = "PUESTO: " + CacheUsuario.userUsername;
            lbResponsable.Text = "RESPONSABLE: " + CacheUsuario.cajApellido + ", " + CacheUsuario.cajNombre;
            Globales.ventaCodVenta = Properties.Settings.Default.UltimoCodigoVenta;
        }

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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void timerFechaHora_Tick(object sender, EventArgs e)
        {
            lbFechaHora.Text = DateTime.Now.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de cerrar la aplicación?", "Advertencia",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
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

        private void panelTop_DoubleClick(object sender, EventArgs e)
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

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #region botonera familias
        private void btnFliaVodkas_Click(object sender, EventArgs e)
        {
            panelBebidas.Visible = false;
            panelGin.Visible = false;
            panelAperitivos.Visible = false;
            panelImportados.Visible = false;
            panelVarios.Visible = false;
            panelChampagne.Visible = false;
            panelCervezas.Visible = false;
            panelWhiskys.Visible = false;
            panelVodkas.Visible = true;
        }

        private void btnFliaGin_Click(object sender, EventArgs e)
        {
            panelBebidas.Visible = false;
            panelVodkas.Visible = false;
            panelAperitivos.Visible = false;
            panelImportados.Visible = false;
            panelVarios.Visible = false;
            panelChampagne.Visible = false;
            panelCervezas.Visible = false;
            panelWhiskys.Visible = false;
            panelGin.Visible = true;
        }

        private void btnFliaAperitivos_Click(object sender, EventArgs e)
        {
            panelBebidas.Visible = false;
            panelVodkas.Visible = false;
            panelGin.Visible = false;
            panelImportados.Visible = false;
            panelVarios.Visible = false;
            panelChampagne.Visible = false;
            panelCervezas.Visible = false;
            panelWhiskys.Visible = false;
            panelAperitivos.Visible = true;
        }

        private void btnFliaImportados_Click(object sender, EventArgs e)
        {
            panelBebidas.Visible = false;
            panelVodkas.Visible = false;
            panelGin.Visible = false;
            panelAperitivos.Visible = false;
            panelVarios.Visible = false;
            panelChampagne.Visible = false;
            panelCervezas.Visible = false;
            panelWhiskys.Visible = false;
            panelImportados.Visible = true;
        }

        private void btnFliaVarios_Click(object sender, EventArgs e)
        {
            panelBebidas.Visible = false;
            panelVodkas.Visible = false;
            panelGin.Visible = false;
            panelAperitivos.Visible = false;
            panelImportados.Visible = false;
            panelChampagne.Visible = false;
            panelCervezas.Visible = false;
            panelWhiskys.Visible = false;
            panelVarios.Visible = true;
        }

        private void btnFliaChampagne_Click(object sender, EventArgs e)
        {
            panelBebidas.Visible = false;
            panelVodkas.Visible = false;
            panelGin.Visible = false;
            panelAperitivos.Visible = false;
            panelImportados.Visible = false;
            panelVarios.Visible = false;
            panelCervezas.Visible = false;
            panelWhiskys.Visible = false;
            panelChampagne.Visible = true;
        }

        private void btnFliaCervezas_Click(object sender, EventArgs e)
        {
            panelBebidas.Visible = false;
            panelChampagne.Visible = false;
            panelVodkas.Visible = false;
            panelGin.Visible = false;
            panelAperitivos.Visible = false;
            panelImportados.Visible = false;
            panelVarios.Visible = false;
            panelWhiskys.Visible = false;
            panelCervezas.Visible = true;
        }

        private void btnFliaWhiskys_Click(object sender, EventArgs e)
        {
            panelBebidas.Visible = false;
            panelCervezas.Visible = false;
            panelChampagne.Visible = false;
            panelVodkas.Visible = false;
            panelGin.Visible = false;
            panelAperitivos.Visible = false;
            panelImportados.Visible = false;
            panelVarios.Visible = false;
            panelWhiskys.Visible = true;
        }
        #endregion

        #region botonera bebidas

        #region Vodkas
        private void btnSmirCitric_Click(object sender, EventArgs e)
        {
            Clases.Globales.ventaCantidad = 1;
            Clases.Globales.ventaNombreProducto = "Smirnoff citric";
            Clases.Globales.ventaFamiliaProducto = "Vodka";
            Clases.Globales.ventaDescuento = false;
            Clases.Globales.venta2x1 = false;
            Clases.Globales.ventaPrecioProducto = 105;
            int ventaCodVenta = Clases.Globales.ventaCodVenta;
            string respVentas = Clases.Globales.ventaResponsable;
            Clases.Globales.ventaDatetime = DateTime.Now;

            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = Clases.Globales.ventaCantidad;
            fila.Cells[1].Value = Clases.Globales.ventaNombreProducto;
            fila.Cells[2].Value = Clases.Globales.ventaDescuento;
            fila.Cells[3].Value = Clases.Globales.venta2x1;
            fila.Cells[4].Value = Clases.Globales.ventaPrecioProducto;
            fila.Cells[5].Value = Clases.Globales.ventaFamiliaProducto;
            fila.Cells[6].Value = Clases.Globales.ventaCodVenta;
            fila.Cells[7].Value = Clases.Globales.ventaResponsable;
            fila.Cells[8].Value = Clases.Globales.ventaDatetime;
            dgVentasDance.Rows.Add(fila);
            LimpiarVariables();
        }

        private void btnSmirManzana_Click(object sender, EventArgs e)
        {
            Clases.Globales.ventaCantidad = 1;
            Clases.Globales.ventaNombreProducto = "Smirnoff manzana";
            Clases.Globales.ventaFamiliaProducto = "Vodka";
            Clases.Globales.ventaDescuento = false;
            Clases.Globales.venta2x1 = false;
            Clases.Globales.ventaPrecioProducto = 100;
            int ventaCodVenta = Clases.Globales.ventaCodVenta;
            string respVentas = Clases.Globales.ventaResponsable;
            Clases.Globales.ventaDatetime = DateTime.Now;

            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = Clases.Globales.ventaCantidad;
            fila.Cells[1].Value = Clases.Globales.ventaNombreProducto;
            fila.Cells[2].Value = Clases.Globales.ventaDescuento;
            fila.Cells[3].Value = Clases.Globales.venta2x1;
            fila.Cells[4].Value = Clases.Globales.ventaPrecioProducto;
            fila.Cells[5].Value = Clases.Globales.ventaFamiliaProducto;
            fila.Cells[6].Value = Clases.Globales.ventaCodVenta;
            fila.Cells[7].Value = Clases.Globales.ventaResponsable;
            fila.Cells[8].Value = Clases.Globales.ventaDatetime;
            dgVentasDance.Rows.Add(fila);
            LimpiarVariables();
        }

        private void btnSmirTropical_Click(object sender, EventArgs e)
        {
            Clases.Globales.ventaCantidad = 1;
            Clases.Globales.ventaNombreProducto = "Smirnoff tropical";
            Clases.Globales.ventaFamiliaProducto = "Vodka";
            Clases.Globales.ventaDescuento = false;
            Clases.Globales.venta2x1 = false;
            Clases.Globales.ventaPrecioProducto = 110;
            int ventaCodVenta = Clases.Globales.ventaCodVenta;
            string respVentas = Clases.Globales.ventaResponsable;
            Clases.Globales.ventaDatetime = DateTime.Now;

            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = Clases.Globales.ventaCantidad;
            fila.Cells[1].Value = Clases.Globales.ventaNombreProducto;
            fila.Cells[2].Value = Clases.Globales.ventaDescuento;
            fila.Cells[3].Value = Clases.Globales.venta2x1;
            fila.Cells[4].Value = Clases.Globales.ventaPrecioProducto;
            fila.Cells[5].Value = Clases.Globales.ventaFamiliaProducto;
            fila.Cells[6].Value = Clases.Globales.ventaCodVenta;
            fila.Cells[7].Value = Clases.Globales.ventaResponsable;
            fila.Cells[8].Value = Clases.Globales.ventaDatetime;
            dgVentasDance.Rows.Add(fila);
            LimpiarVariables();
        }

        private void btnSmirRaspberry_Click(object sender, EventArgs e)
        {
            Clases.Globales.ventaCantidad = 1;
            Clases.Globales.ventaNombreProducto = "Smirnoff raspberry";
            Clases.Globales.ventaFamiliaProducto = "Vodka";
            Clases.Globales.ventaDescuento = false;
            Clases.Globales.venta2x1 = false;
            Clases.Globales.ventaPrecioProducto = 115;
            int ventaCodVenta = Clases.Globales.ventaCodVenta;
            string respVentas = Clases.Globales.ventaResponsable;
            Clases.Globales.ventaDatetime = DateTime.Now;

            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = Clases.Globales.ventaCantidad;
            fila.Cells[1].Value = Clases.Globales.ventaNombreProducto;
            fila.Cells[2].Value = Clases.Globales.ventaDescuento;
            fila.Cells[3].Value = Clases.Globales.venta2x1;
            fila.Cells[4].Value = Clases.Globales.ventaPrecioProducto;
            fila.Cells[5].Value = Clases.Globales.ventaFamiliaProducto;
            fila.Cells[6].Value = Clases.Globales.ventaCodVenta;
            fila.Cells[7].Value = Clases.Globales.ventaResponsable;
            fila.Cells[8].Value = Clases.Globales.ventaDatetime;
            dgVentasDance.Rows.Add(fila);
            LimpiarVariables();
        }

        private void btnSmirComun_Click(object sender, EventArgs e)
        {
            Clases.Globales.ventaCantidad = 1;
            Clases.Globales.ventaNombreProducto = "Smirnoff común";
            Clases.Globales.ventaFamiliaProducto = "Vodka";
            Clases.Globales.ventaDescuento = false;
            Clases.Globales.venta2x1 = false;
            Clases.Globales.ventaPrecioProducto = 120;
            int ventaCodVenta = Clases.Globales.ventaCodVenta;
            string respVentas = Clases.Globales.ventaResponsable;
            Clases.Globales.ventaDatetime = DateTime.Now;

            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = Clases.Globales.ventaCantidad;
            fila.Cells[1].Value = Clases.Globales.ventaNombreProducto;
            fila.Cells[2].Value = Clases.Globales.ventaDescuento;
            fila.Cells[3].Value = Clases.Globales.venta2x1;
            fila.Cells[4].Value = Clases.Globales.ventaPrecioProducto;
            fila.Cells[5].Value = Clases.Globales.ventaFamiliaProducto;
            fila.Cells[6].Value = Clases.Globales.ventaCodVenta;
            fila.Cells[7].Value = Clases.Globales.ventaResponsable;
            fila.Cells[8].Value = Clases.Globales.ventaDatetime;
            dgVentasDance.Rows.Add(fila);
            LimpiarVariables();
        }

        private void btnSernCitric_Click(object sender, EventArgs e)
        {
            Clases.Globales.ventaCantidad = 1;
            Clases.Globales.ventaNombreProducto = "Sernova citric";
            Clases.Globales.ventaFamiliaProducto = "Vodka";
            Clases.Globales.ventaDescuento = false;
            Clases.Globales.venta2x1 = false;
            Clases.Globales.ventaPrecioProducto = 105;
            int ventaCodVenta = Clases.Globales.ventaCodVenta;
            string respVentas = Clases.Globales.ventaResponsable;
            Clases.Globales.ventaDatetime = DateTime.Now;

            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = Clases.Globales.ventaCantidad;
            fila.Cells[1].Value = Clases.Globales.ventaNombreProducto;
            fila.Cells[2].Value = Clases.Globales.ventaDescuento;
            fila.Cells[3].Value = Clases.Globales.venta2x1;
            fila.Cells[4].Value = Clases.Globales.ventaPrecioProducto;
            fila.Cells[5].Value = Clases.Globales.ventaFamiliaProducto;
            fila.Cells[6].Value = Clases.Globales.ventaCodVenta;
            fila.Cells[7].Value = Clases.Globales.ventaResponsable;
            fila.Cells[8].Value = Clases.Globales.ventaDatetime;
            dgVentasDance.Rows.Add(fila);
            LimpiarVariables();
        }

        private void btnSernManzana_Click(object sender, EventArgs e)
        {
            Clases.Globales.ventaCantidad = 1;
            Clases.Globales.ventaNombreProducto = "Sernova manzana";
            Clases.Globales.ventaFamiliaProducto = "Vodka";
            Clases.Globales.ventaDescuento = false;
            Clases.Globales.venta2x1 = false;
            Clases.Globales.ventaPrecioProducto = 80;
            int ventaCodVenta = Clases.Globales.ventaCodVenta;
            string respVentas = Clases.Globales.ventaResponsable;
            Clases.Globales.ventaDatetime = DateTime.Now;

            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = Clases.Globales.ventaCantidad;
            fila.Cells[1].Value = Clases.Globales.ventaNombreProducto;
            fila.Cells[2].Value = Clases.Globales.ventaDescuento;
            fila.Cells[3].Value = Clases.Globales.venta2x1;
            fila.Cells[4].Value = Clases.Globales.ventaPrecioProducto;
            fila.Cells[5].Value = Clases.Globales.ventaFamiliaProducto;
            fila.Cells[6].Value = Clases.Globales.ventaCodVenta;
            fila.Cells[7].Value = Clases.Globales.ventaResponsable;
            fila.Cells[8].Value = Clases.Globales.ventaDatetime;
            dgVentasDance.Rows.Add(fila);
            LimpiarVariables();
        }

        private void btnSernRaspberry_Click(object sender, EventArgs e)
        {
            Clases.Globales.ventaCantidad = 1;
            Clases.Globales.ventaNombreProducto = "Sernova raspberry";
            Clases.Globales.ventaFamiliaProducto = "Vodka";
            Clases.Globales.ventaDescuento = false;
            Clases.Globales.venta2x1 = false;
            Clases.Globales.ventaPrecioProducto = 100;
            int ventaCodVenta = Clases.Globales.ventaCodVenta;
            string respVentas = Clases.Globales.ventaResponsable;
            Clases.Globales.ventaDatetime = DateTime.Now;

            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = Clases.Globales.ventaCantidad;
            fila.Cells[1].Value = Clases.Globales.ventaNombreProducto;
            fila.Cells[2].Value = Clases.Globales.ventaDescuento;
            fila.Cells[3].Value = Clases.Globales.venta2x1;
            fila.Cells[4].Value = Clases.Globales.ventaPrecioProducto;
            fila.Cells[5].Value = Clases.Globales.ventaFamiliaProducto;
            fila.Cells[6].Value = Clases.Globales.ventaCodVenta;
            fila.Cells[7].Value = Clases.Globales.ventaResponsable;
            fila.Cells[8].Value = Clases.Globales.ventaDatetime;            
            dgVentasDance.Rows.Add(fila);
            LimpiarVariables();
        }

        private void btnSernComun_Click(object sender, EventArgs e)
        {
            Clases.Globales.ventaCantidad = 1;
            Clases.Globales.ventaNombreProducto = "Sernova común";
            Clases.Globales.ventaFamiliaProducto = "Vodka";
            Clases.Globales.ventaDescuento = false;
            Clases.Globales.venta2x1 = false;
            Clases.Globales.ventaPrecioProducto = 90;
            int ventaCodVenta = Clases.Globales.ventaCodVenta;
            string respVentas = Clases.Globales.ventaResponsable;
            Clases.Globales.ventaDatetime = DateTime.Now;

            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = Clases.Globales.ventaCantidad;
            fila.Cells[1].Value = Clases.Globales.ventaNombreProducto;
            fila.Cells[2].Value = Clases.Globales.ventaDescuento;
            fila.Cells[3].Value = Clases.Globales.venta2x1;
            fila.Cells[4].Value = Clases.Globales.ventaPrecioProducto;
            fila.Cells[5].Value = Clases.Globales.ventaFamiliaProducto;
            fila.Cells[6].Value = Clases.Globales.ventaCodVenta;            
            fila.Cells[7].Value = Clases.Globales.ventaResponsable;
            fila.Cells[8].Value = Clases.Globales.ventaDatetime;
            dgVentasDance.Rows.Add(fila);
            LimpiarVariables();
        }

        private void btnAbsMango_Click(object sender, EventArgs e)
        {
            Clases.Globales.ventaCantidad = 1;
            Clases.Globales.ventaNombreProducto = "Absolut mango";
            Clases.Globales.ventaFamiliaProducto = "Vodka";
            Clases.Globales.ventaDescuento = false;
            Clases.Globales.venta2x1 = false;
            Clases.Globales.ventaPrecioProducto = 95;
            int ventaCodVenta = Clases.Globales.ventaCodVenta;
            string respVentas = Clases.Globales.ventaResponsable;
            Clases.Globales.ventaDatetime = DateTime.Now;

            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = Clases.Globales.ventaCantidad;
            fila.Cells[1].Value = Clases.Globales.ventaNombreProducto;
            fila.Cells[2].Value = Clases.Globales.ventaDescuento;
            fila.Cells[3].Value = Clases.Globales.venta2x1;
            fila.Cells[4].Value = Clases.Globales.ventaPrecioProducto;
            fila.Cells[5].Value = Clases.Globales.ventaFamiliaProducto;
            fila.Cells[6].Value = Clases.Globales.ventaCodVenta;
            fila.Cells[7].Value = Clases.Globales.ventaResponsable;
            fila.Cells[8].Value = Clases.Globales.ventaDatetime;
            dgVentasDance.Rows.Add(fila);
            LimpiarVariables();
        }

        private void btnAbsRaspberry_Click(object sender, EventArgs e)
        {
            Clases.Globales.ventaCantidad = 1;
            Clases.Globales.ventaNombreProducto = "Absolut raspberry";
            Clases.Globales.ventaFamiliaProducto = "Vodka";
            Clases.Globales.ventaDescuento = false;
            Clases.Globales.venta2x1 = false;
            Clases.Globales.ventaPrecioProducto = 100;
            int ventaCodVenta = Clases.Globales.ventaCodVenta;
            string respVentas = Clases.Globales.ventaResponsable;
            Clases.Globales.ventaDatetime = DateTime.Now;

            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = Clases.Globales.ventaCantidad;
            fila.Cells[1].Value = Clases.Globales.ventaNombreProducto;
            fila.Cells[2].Value = Clases.Globales.ventaDescuento;
            fila.Cells[3].Value = Clases.Globales.venta2x1;
            fila.Cells[4].Value = Clases.Globales.ventaPrecioProducto;
            fila.Cells[5].Value = Clases.Globales.ventaFamiliaProducto;
            fila.Cells[6].Value = Clases.Globales.ventaCodVenta;
            fila.Cells[7].Value = Clases.Globales.ventaResponsable;
            fila.Cells[8].Value = Clases.Globales.ventaDatetime;
            dgVentasDance.Rows.Add(fila);
            LimpiarVariables();
        }

        private void btnAbsComun_Click(object sender, EventArgs e)
        {
            Clases.Globales.ventaCantidad = 1;
            Clases.Globales.ventaNombreProducto = "Absolut Común";
            Clases.Globales.ventaFamiliaProducto = "Vodka";
            Clases.Globales.ventaDescuento = false;
            Clases.Globales.venta2x1 = false;
            Clases.Globales.ventaPrecioProducto = 105;
            int ventaCodVenta = Clases.Globales.ventaCodVenta;
            string respVentas = Clases.Globales.ventaResponsable;
            Clases.Globales.ventaDatetime = DateTime.Now;

            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = Clases.Globales.ventaCantidad;
            fila.Cells[1].Value = Clases.Globales.ventaNombreProducto;
            fila.Cells[2].Value = Clases.Globales.ventaDescuento;
            fila.Cells[3].Value = Clases.Globales.venta2x1;
            fila.Cells[4].Value = Clases.Globales.ventaPrecioProducto;
            fila.Cells[5].Value = Clases.Globales.ventaFamiliaProducto;
            fila.Cells[6].Value = Clases.Globales.ventaCodVenta;
            fila.Cells[7].Value = Clases.Globales.ventaResponsable;
            fila.Cells[8].Value = Clases.Globales.ventaDatetime;
            dgVentasDance.Rows.Add(fila);
            LimpiarVariables();
        }

        #endregion

        #region Gin

        private void btnGinBulldog_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Gin bulldog";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 50;
            string respVentas = "Maria";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }

        private void btnGinBombay_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Gin Bombay";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 60;
            string respVentas = "Maria";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }

        private void btnAGinBeefeater_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Gin beefeater";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 35;
            string respVentas = "Maria";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }

        private void btnGinBarato_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Gin barato";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 20;
            string respVentas = "Maria";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }

        #endregion

        #region Aperitivos

        private void btnFerBranca_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Fernet branca";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 200;
            string respVentas = "Samuel";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }

        private void btnCampari_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Campari";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 150;
            string respVentas = "Samuel";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }

        private void btnAperol_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Aperol";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 100;
            string respVentas = "Samuel";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }

        private void btnGancia_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Gancia";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 170;
            string respVentas = "Samuel";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }

        #endregion

        #region Importados

        private void btnJagger_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Jagger";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 500;
            string respVentas = "Samuel";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }

        private void btnHoldmoser_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Holdmoser";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 470;
            string respVentas = "Samuel";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }

        #endregion

        #region Varios

        private void btnRedbull_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Red bull";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 300;
            string respVentas = "Sara";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }

        private void btnSpeed_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Speed";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 250;
            string respVentas = "Sara";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }

        private void btnJNaranja_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Jugo de naranja";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 50;
            string respVentas = "Sara";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }

        private void btnJDurazno_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Jugo de durazno";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 50;
            string respVentas = "Sara";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }

        private void btnAgua_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Agua";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 30;
            string respVentas = "Sara";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }

        private void btnTonica_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Tónica";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 100;
            string respVentas = "Sara";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }

        private void btnPomelo_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Pomelo";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 80;
            string respVentas = "Sara";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }

        private void btnSprite_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Sprite";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 120;
            string respVentas = "Sara";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }

        private void btnCocacola_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Coca cola";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 120;
            string respVentas = "Sara";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }

        private void btnTequila_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Tequila";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 175;
            string respVentas = "Sara";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }
        private void btnRonoro_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Ron oro";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 150;
            string respVentas = "Sara";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }

        #endregion

        #region Champagne

        private void btnChamChacabuco_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Champ. Chacabuco";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 500;
            string respVentas = "Fátima";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }

        private void btnChamAnaBlanc_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Champ. Ana blanc";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 550;
            string respVentas = "Fátima";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }

        private void btnChamBaronB_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Champ. Baron B";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 650;
            string respVentas = "Fátima";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }

        private void btnChamChandonD_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Champ. Chandon delice";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 650;
            string respVentas = "Fátima";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }

        private void btnChamChandon_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Champ. Chandon";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 600;
            string respVentas = "Fátima";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }

        private void btnChamEconomico_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Champ. Económico";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 350;
            string respVentas = "Fátima";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }

        private void btnChamNorton_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Champ. Norton";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 700;
            string respVentas = "Fátima";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }

        private void btnChamFdAlvear_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Champ. F. de alvear";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 700;
            string respVentas = "Fátima";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }
        #endregion

        #region Cervezas

        private void btnCorona_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Corona";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 300;
            string respVentas = "Luz";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }

        private void btnBrahama_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Brahama";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 200;
            string respVentas = "Luz";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }

        #endregion

        #region Whiskys

        private void btnWisBallantains_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Wis. Ballantains";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 300;
            string respVentas = "Agustin";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }

        private void btnWisBlenders_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Wis. Blenders";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 400;
            string respVentas = "Agustin";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }

        private void btnWisJackDaniels_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Wis. Jack Daniels";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 500;
            string respVentas = "Agustin";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }

        private void btnJWBlack_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Wis. JW Black";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 600;
            string respVentas = "Agustin";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }

        private void btnWisJWRed_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Wis. JW Red";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 600;
            string respVentas = "Agustin";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }

        private void btnWisJB_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Wis. J & B";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 400;
            string respVentas = "Agustin";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }

        private void btnWisChivas_Click(object sender, EventArgs e)
        {
            int cantidad = 1;
            string nombreProducto = "Wis. Chivas";
            bool descuento = false;
            bool dosxuno = false;
            int precio = 350;
            string respVentas = "Agustin";


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgVentasDance);
            fila.Cells[0].Value = cantidad;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = descuento;
            fila.Cells[3].Value = dosxuno;
            fila.Cells[4].Value = precio;
            fila.Cells[5].Value = respVentas;
            dgVentasDance.Rows.Add(fila);
        }

        #endregion

        #endregion botonera bebidas


        private void InsertarDetalle()
        {
            if (Clases.Globales.Boton == true)
            {
                string cadenaConexion = "Data Source=LIONP_\\SQLEXPRESS;DataBase=sistemaArea;integrated security=true;";
                string consultaSql = "INSERT INTO Ventas (Fecha, userIDdetalle) VALUES (@Fecha, @userIDdetalle)";
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    SqlCommand comando = new SqlCommand(consultaSql, conexion);
                    comando.Parameters.AddWithValue("@Fecha", Clases.Globales.ventaDatetime);
                    comando.Parameters.AddWithValue("@userIDdetalle", CacheUsuario.userID);



                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
                string insertsql = "INSERT INTO DataVentas (ventaCantidad, ventaNombreProducto, VentaDescuento, VentaDosxUno, ventaRespVentas, VentaCodDetalle) VALUES (@ventaCantidad, @ventaNombreProducto, @VentaDescuento, @VentaDosxUno, @ventaRespVentas, @VentaCodDetalle)";
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    SqlCommand comando = new SqlCommand(insertsql, conexion);
                    comando.Parameters.AddWithValue("@ventaCantidad", Clases.Globales.ventaCantidad);
                    comando.Parameters.AddWithValue("@ventaNombreProducto", Clases.Globales.ventaNombreProducto);
                    comando.Parameters.AddWithValue("@VentaDescuento", Clases.Globales.ventaDescuento);
                    comando.Parameters.AddWithValue("@VentaDosxUno", Clases.Globales.venta2x1);
                    comando.Parameters.AddWithValue("@VentaCodDetalle", Clases.Globales.ventaCodVenta);
                    comando.Parameters.AddWithValue("@ventaRespVentas", Clases.Globales.ventaResponsable);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }

            }
            Clases.Globales.Boton = false;
        }


        private void btnCobrar_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=LIONEL\\SQLEXPRESS;DataBase=sistemaArea;integrated security=true;");
            connection.Open();

            string query = "INSERT INTO ventasData (ventaCantidad, ventaNombreProducto, ventaDescuento, venta2x1, ventaPrecioProducto, ventaFamiliaProducto, ventaCodVenta, ventaResponsable, ventaDatetime) VALUES ";

            for (int i = 0; i < dgVentasDance.Rows.Count; i++)
            {
                query += "('" + dgVentasDance.Rows[i].Cells[0].Value + "', '" + dgVentasDance.Rows[i].Cells[1].Value + "', '" + dgVentasDance.Rows[i].Cells[2].Value + "', '" + dgVentasDance.Rows[i].Cells[3].Value + "', '" + dgVentasDance.Rows[i].Cells[4].Value + "', '" + dgVentasDance.Rows[i].Cells[5].Value + "', '" + dgVentasDance.Rows[i].Cells[6].Value + "', '" + dgVentasDance.Rows[i].Cells[7].Value + "', '" + dgVentasDance.Rows[i].Cells[8].Value + "')";

                if (i != dgVentasDance.Rows.Count - 1)
                {
                    query += ",";
                }
            }

            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();


            Clases.Globales.ventaCodVenta = Clases.Globales.ventaCodVenta + 1;
            LimpiarDG();            
        }

        private void frmCajaDance_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.UltimoCodigoVenta = Globales.ventaCodVenta;
            Properties.Settings.Default.Save();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuCajas frmMenuCajas = new frmMenuCajas();
            frmMenuCajas.Show();
        }

        //private void btnCobrar_Click(object sender, EventArgs e)
        //{
        //    InsertarDetalle();
        //    Clases.Globales.ventaCodDetalle = Clases.Globales.ventaCodDetalle + 1;
        //    LimpiarDG();
        //}
        private void LimpiarVariables()
        {
            Clases.Globales.ventaCantidad = 1;
            Clases.Globales.ventaNombreProducto = "";
            Clases.Globales.ventaFamiliaProducto = "";
            Clases.Globales.ventaDescuento = false;
            Clases.Globales.venta2x1 = false;
            Clases.Globales.ventaPrecioProducto = 0;          
        }
        private void LimpiarDG()
        {
            dgVentasDance.Rows.Clear();
        }
    }
}
