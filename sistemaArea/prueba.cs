using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sistemaArea
{
    public partial class prueba : Form
    {
        public prueba()
        {
            InitializeComponent();
        }
        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Determina qué elemento ha sido seleccionado en el ComboBox
            switch (cmbProductos.SelectedIndex)
            {
                case 0: // Vodkas
                    OcultarBotones();
                    // Cambiar contenido del panel                    
                    button16.Visible = true;
                    button16.Text = "ABS. COMUN";

                    button17.Visible = true;
                    button17.Text = "ABS. RASPBERRY";

                    button18.Visible = true;
                    button18.Text = "ABS. MANGO";

                    button19.Visible = true;
                    button19.Text = "SERN. COMUN";

                    button20.Visible = true;
                    button20.Text = "SERN. RASPBERRY";

                    button21.Visible = true;
                    button21.Text = "SERN. MANZANA";

                    button22.Visible = true;
                    button22.Text = "SERN. CITRIC";

                    button23.Visible = true;
                    button23.Text = "SMIR. COMUN";

                    button24.Visible = true;
                    button24.Text = "SMIR. RASPBERRY";

                    button25.Visible = true;
                    button25.Text = "SMIR. TROPICAL";

                    button26.Visible = true;
                    button26.Text = "SMIR. MANZANA";

                    button27.Visible = true;
                    button27.Text = "SMIR. CITRIC";

                    break;
                case 1: // Gin
                    OcultarBotones();
                    // Cambiar contenido del panel
                    button16.Visible = true;
                    button16.Text = "GIN BARATO";

                    button17.Visible = true;
                    button17.Text = "GIN BEEFEATER";

                    button18.Visible = true;
                    button18.Text = "GIN BOMBAY";

                    button19.Visible = true;
                    button19.Text = "GIN BULLDOG";

                    break;
                case 2: // Aperitivos
                    OcultarBotones();
                    // Cambiar contenido del panel
                    button16.Visible = true;
                    button16.Text = "GANCIA";

                    button17.Visible = true;
                    button17.Text = "APEROL";

                    button18.Visible = true;
                    button18.Text = "CAMPARI";

                    button19.Visible = true;
                    button19.Text = "FERNET BRANCA";

                    break;
                case 3: // Importados
                    OcultarBotones();
                    // Cambiar contenido del panel
                    button16.Visible = true;
                    button16.Text = "HOLDMOSER";

                    button17.Visible = true;
                    button17.Text = "JAGGER";

                    break;
                case 4: // Varios
                    OcultarBotones();
                    // Cambiar contenido del panel
                    button16.Visible = true;
                    button16.Text = "RON ORO";

                    button17.Visible = true;
                    button17.Text = "TEQUILA";

                    button18.Visible = true;
                    button18.Text = "COCA COLA";

                    button19.Visible = true;
                    button19.Text = "SPRITE";

                    button20.Visible = true;
                    button20.Text = "POMELO";

                    button21.Visible = true;
                    button21.Text = "TONICA";

                    button22.Visible = true;
                    button22.Text = "AGUA";

                    button23.Visible = true;
                    button23.Text = "JUGO DURAZNO";

                    button24.Visible = true;
                    button24.Text = "JUGO NARANJA";

                    break;
                case 5: // Champagne
                    OcultarBotones();
                    // Cambiar contenido del panel
                    button16.Visible = true;
                    button16.Text = "CHAMP. F. DE ALVEAR";

                    button17.Visible = true;
                    button17.Text = "CHAMP. NORTON";

                    button18.Visible = true;
                    button18.Text = "CHAMP. ECONOMICO";

                    button19.Visible = true;
                    button19.Text = "CHAMP. CHANDON";

                    button20.Visible = true;
                    button20.Text = "CHAMP. CHANDON DELICE";

                    button21.Visible = true;
                    button21.Text = "CHAMP. BARON B";

                    button22.Visible = true;
                    button22.Text = "CHAMP. ANA BLANC";

                    button23.Visible = true;
                    button23.Text = "CHACABUCO";

                    button24.Visible = true;
                    button24.Text = "SPEED";

                    button25.Visible = true;
                    button25.Text = "RED BULL";

                    break;
                case 6: // Cervezas
                    OcultarBotones();
                    // Cambiar contenido del panel                   
                    button16.Visible = true;
                    button16.Text = "BRAHAMA";

                    button17.Visible = true;
                    button17.Text = "CORONA";

                    break;
                case 7: // Whiskys
                    OcultarBotones();
                    // Cambiar contenido del panel
                    button16.Visible = true;
                    button16.Text = "WHIS. CHIVAS";

                    button17.Visible = true;
                    button17.Text = "WHIS. J&B";

                    button18.Visible = true;
                    button18.Text = "WHIS. JW. RED";

                    button19.Visible = true;
                    button19.Text = "WHIS. JW. BLACK";

                    button20.Visible = true;
                    button20.Text = "WHIS. JACK DANIELS";

                    button21.Visible = true;
                    button21.Text = "WHIS. BLENDERS";

                    button22.Visible = true;
                    button22.Text = "WHIS. BALLATAINS";

                    break;
                default:
                    // Si no se selecciona nada, no se agrega nada al Panel
                    break;
            }
            panelProductos.Refresh();
        }

        private void OcultarBotones()
        {
            button16.Visible=false;
            button17.Visible=false;
            button18.Visible=false;
            button19.Visible=false;
            button20.Visible=false;
            button21.Visible=false;
            button22.Visible=false;
            button23.Visible=false;
            button24.Visible=false;
            button25.Visible=false;
            button26.Visible=false;
            button27.Visible=false;
            button28.Visible=false;
            button29.Visible=false;
            button30.Visible=false;
        }
        private void prueba_Load(object sender, EventArgs e)
        {
            
        }
    }
}
