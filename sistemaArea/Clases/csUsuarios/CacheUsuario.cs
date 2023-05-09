using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaArea
{
    public static class CacheUsuario
    {
        public static int userID { get; set; }
        public static string userNombre { get; set; }
        public static string userApellido { get; set; }
        public static string userEmail { get; set; }
        public static string userUsername { get; set; }
        public static string userContrasena { get; set; }
        public static string userCodQR { get; set; }
        public static int userRolID { get; set; }
        public static string cajNombre { get; set; }
        public static string cajApellido { get; set; }
    }
}
