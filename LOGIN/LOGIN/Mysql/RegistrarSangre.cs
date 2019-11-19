using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LOGIN.Mysql
{
    class RegistrarSangre
    {
        public static int agregar(Sangre add)
        {
            int retorno = 0;
            MySqlCommand comando = new MySql
            //MySqlCommand comando = new MySqlCommand(String.Format("INSERT INTO banco(tiposangre_don, cap_ban, tipomlsangre_ban) values('{0}','{1}','{2}')", //, Departamento_id_dept, Estudio_tipo_est1   ,'{3}','{4}'
              //  add.tiposangre_don, add.cap_ban, add.tipomlsangre_ban), conexion.obtainConexion()); //, add.Departamento_id_dept, add.Estudio_tipo_est1
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
