﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LOGIN.Mysql
{
    class RegistrarCuentaMed
    {
        public static int agregar(CuentaMed add)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(String.Format("insert into médico(nom_med, especialidad_med, contraseña_med, correo_med) values('{0}','{1}','{2}','{3}')",
                add.nom_med, add.especialidad_med, add.contraseña_med, add.correo_med), conexion.obtainConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
