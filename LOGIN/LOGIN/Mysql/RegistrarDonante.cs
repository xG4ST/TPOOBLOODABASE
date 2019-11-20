using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LOGIN.Mysql
{
    class RegistrarDonante
    {
        public static int agregar(Donante add)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(String.Format("insert into Donador(nom_don, sexo_don, edad_don, tel_don, tiposangre_don, fechanac_don, dir_don, correo_don,) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                add.nom_don, add.sexo_don, add.edad_don, add.tel_don, add.tiposangre_don, add.fechanac_don, add.dir_don, add.correo_don), conexion.obtainConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
