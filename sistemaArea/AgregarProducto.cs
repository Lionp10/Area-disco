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
    public partial class AgregarProductos : Form
    {
        public AgregarProductos()
        {
            InitializeComponent();

        }



        private void VerProductos()
        {
            try
            {
                //Conexion con SQL Server
                string consql = "Data Source=LIONP_\\SQLEXPRESS;DataBase=sistemaAreaMASTER_PRUEBA;integrated security=true;";
                SqlConnection objConn = new SqlConnection(consql);
                objConn.Open();

                //Crear comando
                string SQL = "SELECT depID, depNombreProducto FROM depositoData";
                SqlCommand objCmd = new SqlCommand(SQL, objConn);
                objCmd.CommandType = CommandType.Text;

                //CREAR ADAPTADOR
                SqlDataAdapter objAd = new SqlDataAdapter(objCmd);
                DataSet Dg = new DataSet();

                //ADAPTADOR
                objAd.Fill(Dg, "Productos");

                //CERRAR CONEXION BD
                objConn.Close();

                dplProducto.DataSource = Dg.Tables["Productos"];
                dplProducto.ValueMember = "depID";
                dplProducto.DisplayMember = "depNombreProducto";

                //Formatear();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los Tipos de Pago", "Software Taller", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }





        private void VerBarras()
        {
            try
            {
                //Conexion con SQL Server
                string consql = "Data Source=LIONP_\\SQLEXPRESS;DataBase=sistemaAreaMASTER_PRUEBA;integrated security=true;";
                SqlConnection objConn = new SqlConnection(consql);
                objConn.Open();

                //Crear comando
                string SQL = "SELECT barID, barNombre FROM barrasData";
                SqlCommand objCmd = new SqlCommand(SQL, objConn);
                objCmd.CommandType = CommandType.Text;

                //CREAR ADAPTADOR
                SqlDataAdapter objAd = new SqlDataAdapter(objCmd);
                DataSet Dg = new DataSet();

                //ADAPTADOR
                objAd.Fill(Dg, "Barras");

                //CERRAR CONEXION BD
                objConn.Close();

                dplBarra.DataSource = Dg.Tables["Barras"];
                dplBarra.ValueMember = "barID";
                dplBarra.DisplayMember = "barNombre";

                //Formatear();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los Tipos de Pago", "Software Taller", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }



        private void CargarDatos()
        {
            if (dplBarra.SelectedItem != null)
            {
                DataRowView item = (DataRowView)dplBarra.SelectedItem;
                int valorSeleccionado = Convert.ToInt32(item["barID"]);



                string cadenaConexion = "Data Source=LIONP_\\SQLEXPRESS;DataBase=sistemaAreaMASTER_PRUEBA;integrated security=true;";
                string consultaSql = "SELECT prodNombre, prodCantidad FROM productoData WHERE prodCodigo=@Valor";
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    SqlCommand comando = new SqlCommand(consultaSql, conexion);
                    comando.Parameters.AddWithValue("@Valor", valorSeleccionado);

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        DataSet datos = new DataSet();
                        adaptador.Fill(datos, "Barras");
                        DgProductosBarras.Columns.Add("NombreProducto", "Producto");
                        DgProductosBarras.Columns.Add("CantidadProducto", "Cantidad");
                        DgProductosBarras.Columns["NombreProducto"].DataPropertyName = "prodNombre";
                        DgProductosBarras.Columns["CantidadProducto"].DataPropertyName = "prodCantidad";
                        DgProductosBarras.DataSource = datos.Tables["Barras"];
                    }
                }
            }
        }

        private void CargarDG()
        {

            string consultaSql = "SELECT depNombreProducto, depCantidadProducto FROM depositoData";
            string cadenaConexion = "Data Source=LIONP_\\SQLEXPRESS;DataBase=sistemaAreaMASTER_PRUEBA;integrated security=true;";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                using (SqlDataAdapter adaptador = new SqlDataAdapter(consultaSql, conexion))
                {
                    DataSet datos = new DataSet();
                    adaptador.Fill(datos, "DepositoData");

                    //DgDeposito.Columns.Add("NombreProducto", "Producto");
                    //DgDeposito.Columns.Add("CantidadProducto", "Cantidad");
                    //DgDeposito.Columns["NombreProducto"].DataPropertyName = "depNombreProducto";
                    //DgDeposito.Columns["CantidadProducto"].DataPropertyName = "depCantidadProducto";

                    DgDeposito.DataSource = datos.Tables["DepositoData"];
                }
            }
        }



        private void InsertarEnBarra()
        {

            if (Clases.Globales.ventaEstado == true)
            {

                ActualizarStock();

            }

            else
            {
                Insert();
            }
        }


        private void Insert()
        {
            DataRowView itemBarra = (DataRowView)dplBarra.SelectedItem;
            int valorSeleccionadoBarra = Convert.ToInt32(itemBarra["barID"]);
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            string prodNombre = dplProducto.Text;

            string cadenaConexion = "Data Source=LIONP_\\SQLEXPRESS;DataBase=sistemaAreaMASTER_PRUEBA;integrated security=true;";
            string consultaSql = "INSERT INTO productoData (prodNombre, prodCantidad, prodCodigo) VALUES (@prodNombre, @prodCantidad, @prodCodigo)";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(consultaSql, conexion);
                comando.Parameters.AddWithValue("@prodNombre", prodNombre.ToString());
                comando.Parameters.AddWithValue("@prodCantidad", cantidad);
                comando.Parameters.AddWithValue("@prodCodigo", valorSeleccionadoBarra);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

        private void ActualizarStock()
        {
            string prodNombre = dplProducto.Text;
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            DataRowView itemBarra = (DataRowView)dplBarra.SelectedItem;
            int valorSeleccionadoBarra = Convert.ToInt32(itemBarra["barID"]);

            string cadenaConexion = "Data Source=LIONP_\\SQLEXPRESS;DataBase=sistemaAreaMASTER_PRUEBA;integrated security=true;";
            string ActualizarStockDeposito = "UPDATE depositoData SET depcantidadProducto=depcantidadProducto-@prodCantidadDepo where depNombreProducto=@prodNombreDepo";

            //ACTUALIZA STOCK DEPOSITO
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(ActualizarStockDeposito, conexion);
                comando.Parameters.AddWithValue("@prodNombreDepo", prodNombre);
                comando.Parameters.AddWithValue("@prodCantidadDepo", cantidad);

                conexion.Open();
                comando.ExecuteNonQuery();
            }

            //ACTUALIZA STOCK BARRA
            string ActualizarStockBarra = "UPDATE productoData SET prodCantidad=prodCantidad+@prodCantidad where prodNombre=@prodNombre";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(ActualizarStockBarra, conexion);
                comando.Parameters.AddWithValue("@prodNombre", prodNombre);
                comando.Parameters.AddWithValue("@prodCantidad", cantidad);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

        private void dplProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dplProducto.SelectedItem != null)
            {
                DataRowView item = (DataRowView)dplProducto.SelectedItem;
                int valorSeleccionado = Convert.ToInt32(item["depID"]);

                string consultaSql = "SELECT depCantidadProducto FROM depositoData WHERE depID = @Valor";

                using (SqlConnection conexion = new SqlConnection("Server=LIONP_\\SQLEXPRESS;DataBase=sistemaAreaMASTER_PRUEBA;integrated security=true;"))
                {
                    conexion.Open();

                    SqlCommand comando = new SqlCommand(consultaSql, conexion);
                    comando.Parameters.AddWithValue("@Valor", valorSeleccionado);

                    SqlDataReader lector = comando.ExecuteReader();

                    if (lector.Read())
                    {
                        decimal cantidad = lector.GetDecimal(0);
                        lbCantidadMax.Text = cantidad.ToString();
                    }
                }

                string connectionString = "Data Source=LIONP_\\SQLEXPRESS;DataBase=sistemaAreaMASTER_PRUEBA;integrated security=true;";
                string selectQuery = "SELECT prodNombre FROM productoData where prodNombre=@prodNombre";
                string prodNombre = dplProducto.Text;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand comando = new SqlCommand(selectQuery, connection);
                    comando.Parameters.AddWithValue("@prodNombre", prodNombre);
                    connection.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            string productoNombre = reader.GetString(0);


                            if (productoNombre == prodNombre)
                            {
                                Clases.Globales.ventaEstado = true;

                            }
                        }
                    }
                }
                CargarDatos();

            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (dplBarra.SelectedItem != null & dplProducto.SelectedItem != null)
            {

                InsertarEnBarra();

            }

            CargarDatos();
            CargarDG();
        }

        private void dplBarra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dplProducto.SelectedItem != null)
            {
                CargarDatos();


                //string connectionString = "Server=LAPTOP-97L4J3EI\\SQLEXPRESS;DataBase=sistemaAreaMASTER_PRUEBA;integrated security=true;";
                //string selectQuery = "SELECT prodNombre FROM productoData";
                //string prodNombre = dplProducto.Text;
                //using (SqlConnection connection = new SqlConnection(connectionString))
                //{
                //    SqlCommand command = new SqlCommand(selectQuery, connection);
                //    connection.Open();

                //    using (SqlDataReader reader = command.ExecuteReader())
                //    {

                //        while (reader.Read())
                //        {
                //            string productoNombre = reader.GetString(0);


                //            if (productoNombre == prodNombre)
                //            {
                //                Clases.Globales.estado = true;

                //            }
                //        }                        
                //    }
                //}
            }
        }

        private void AgregarProductos_Load(object sender, EventArgs e)
        {
            VerProductos();
            VerBarras();
            //FORMATEAR DG DEPOSITO
            DgDeposito.Columns.Add("NombreProducto", "Producto");
            DgDeposito.Columns.Add("CantidadProducto", "Cantidad");
            DgDeposito.Columns["NombreProducto"].DataPropertyName = "depNombreProducto";
            DgDeposito.Columns["CantidadProducto"].DataPropertyName = "depCantidadProducto";
            CargarDG();
            CargarDatos();
        }
    }
}



//-----------------------------INSERT PRODUCTODATA-------------------------------------------------------------
//DataRowView itemBarra = (DataRowView)dplBarra.SelectedItem;                
//    int valorSeleccionadoBarra = Convert.ToInt32(itemBarra["barID"]);
//    int cantidad = Convert.ToInt32(txtCantidad.Text);


//    string barraNombre = dplBarra.Text;

//    string cadenaConexion = "Server=LAPTOP-97L4J3EI\\SQLEXPRESS;DataBase=sistemaAreaMASTER_PRUEBA;integrated security=true;";
//    string consultaSql = "INSERT INTO productoData (prodNombre, prodCantidad, prodCodigo) VALUES (@prodNombre, @prodCantidad, @prodCodigo)";
//    using (SqlConnection conexion = new SqlConnection(cadenaConexion))
//    {
//        SqlCommand comando = new SqlCommand(consultaSql, conexion);
//        comando.Parameters.AddWithValue("@prodNombre", prodNombre); // reemplaza "Producto nuevo" por el valor ingresado por el usuario
//        comando.Parameters.AddWithValue("@prodCantidad", cantidad);
//        comando.Parameters.AddWithValue("@prodCodigo", valorSeleccionadoBarra);


//        conexion.Open();
//        comando.ExecuteNonQuery();
//    }

//------------------------------ACTUALIZAR STOCK BARRA---------------------------------------------------

//string ActualizarStock = "UPDATE depositoData SET depcantidadProducto= depcantidadProducto-@prodCantidad where depNombreProducto = @prodNombre";
//using (SqlConnection conexion = new SqlConnection(cadenaConexion))
//{
//    SqlCommand comando = new SqlCommand(ActualizarStock, conexion);
//    comando.Parameters.AddWithValue("@prodNombre", prodNombre); // reemplaza "Producto nuevo" por el valor ingresado por el usuario
//    comando.Parameters.AddWithValue("@prodCantidad", cantidad);



//    conexion.Open();
//    comando.ExecuteNonQuery();
//}

//----------------------------SELECT DE BARRAS--------------------------------------------------------

//DataRowView itemBarra = (DataRowView)dplBarra.SelectedItem;
//int valorSeleccionadoBarra = Convert.ToInt32(itemBarra["barID"]);
//string cantidad = txtCantidad.Text;

//string cadenaConexion = "Server=LAPTOP-97L4J3EI\\SQLEXPRESS;DataBase=sistemaAreaMASTER_PRUEBA;integrated security=true;";
//string consultaSql = "SELECT barNombreProducto, barCantidadProducto FROM barrasData WHERE barID = @Valor";
//using (SqlConnection conexion = new SqlConnection(cadenaConexion))
//{
//    SqlCommand comando = new SqlCommand(consultaSql, conexion);
//    comando.Parameters.AddWithValue("@Valor", valorSeleccionadoBarra);

//    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
//    {
//        DataSet datos = new DataSet();
//        adaptador.Fill(datos, "Barras");
//        DgProductosBarras.Columns.Add("NombreProducto", "Producto");
//        DgProductosBarras.Columns.Add("CantidadProducto", "Cantidad");
//        DgProductosBarras.Columns["NombreProducto"].DataPropertyName = "barNombreProducto";
//        DgProductosBarras.Columns["CantidadProducto"].DataPropertyName = "barCantidadProducto";
//        DgProductosBarras.DataSource = datos.Tables["Barras"];
//    }


//}
