using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIN.Mysql
{
    class CuentaMed
    {
        public int id_med { get; set; }
        public string nom_med { get; set; }
        public string especialidad_med { get; set; }
        public string contraseña_med { get; set; }
        public string correo_med { get; set; }

        public CuentaMed() { }
        public CuentaMed(int Id, string Nombre, string Especialidad, string Contraseña, string Correo)
        {
            this.id_med = Id;
            this.nom_med = Nombre;
            this.especialidad_med = Especialidad;
            this.contraseña_med = Contraseña;
            this.correo_med = Correo;
        }
    }
}
