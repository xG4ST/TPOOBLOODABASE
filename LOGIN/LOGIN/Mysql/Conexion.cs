using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LOGIN.Mysql
{
    class Conexion
    {
        public static MySqlConnection obtainConexion()
        {
            MySqlConnection conexion = new MySqlConnection("server = 127.0.0.1; database = sistemabloodabase; Uid = root; pwd = 2000;");
            conexion.Open();
            return conexion;
        }
    }
}
