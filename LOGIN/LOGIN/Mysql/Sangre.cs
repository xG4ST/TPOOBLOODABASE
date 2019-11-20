using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIN.Mysql
{
    class Sangre
    {
        public string tiposangre_don { get; set; }
        public string tipomlsangre_ban { get; set; }
        public int cap_ban { get; set; }
        //public int Departamento_id_dept { get; set; }
        //public string Estudio_tipo_est1 { get; set; }

        public Sangre () { }
        public Sangre (string TipoSangre_Don, string TipoMlSangre_Ban, int Capacidad_Ban, int Departamento_Id, string Estudio_Tipo) 
        {
            this.tiposangre_don = TipoSangre_Don;
            this.tipomlsangre_ban = TipoMlSangre_Ban;
            this.cap_ban = Capacidad_Ban;
            //this.Departamento_id_dept = Departamento_Id;
            //this.Estudio_tipo_est1 = Estudio_Tipo;
        }
    }
}
