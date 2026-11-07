using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flavors_System.Controlador
{
    internal class Conexion
    {
        public static SqlConnection Conectar() 
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-6FQ7FPV\\MAZA;Initial Catalog=dbFlavors;Integrated Security=True;");
            //SqlConnection cn = new SqlConnection("Data Source=RUTH\\SQLEXPRESS;Initial Catalog=dbFlavors;Integrated Security=True;");
            //SqlConnection cn = new SqlConnection("Data Source=VICTUS;Initial Catalog=dbFlavors;Integrated Security=True");
            //SqlConnection cn = new SqlConnection("Data Source=DELL\\SQLEXPRESS;Initial Catalog=dbFlavors;Integrated Security=True");

            cn.Open();
            return cn;
        }
    }
}
