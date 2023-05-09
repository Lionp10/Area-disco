using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaArea.Clases
{
    public static class Globales
    {
        public static bool Boton = false;
        public static int ventaCantidad = 1;
        public static string ventaNombreProducto = "";
        public static string ventaFamiliaProducto = "";
        public static bool ventaDescuento = false;
        public static bool venta2x1 = false;
        public static int ventaPrecioProducto = 0;
        public static string ventaResponsable = CacheUsuario.cajApellido + ", " + CacheUsuario.cajNombre;
        public static int ventaCodVenta = 1;
        public static DateTime ventaDatetime;
        public static bool ventaEstado = false;
    }
}
