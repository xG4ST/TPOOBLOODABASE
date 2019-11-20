using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LOGIN.Mysql
{
    class RegistroDepartamento
    {
        public static int agregar(Departamentos add)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(String.Format("insert into Departamento(nom_dep) values('{0}')", add.nom_dep), conexion.obtainConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}