using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIN.Mysql
{
    class Donante
    {
        public int id_don { get; set; }
        public string nom_don { get; set; }
        public string sexo_don { get; set; }
        public int edad_don { get; set; }
        public DateTime fechanac_don { get; set; }
        public string tel_don { get; set; }
        public string tiposangre_don { get; set; }
        public string dir_don { get; set; }
        public string correo_don { get; set; }

        public Donante() { }
        public Donante(int IdDon, string NombreDon, string SexoDon, int EdadDon, DateTime FechaNacDon, string TelDon, string TipoSangreDon, string DirDon, string CorreoDon)
        {
            this.id_don = IdDon;
            this.nom_don = NombreDon;
            this.sexo_don = SexoDon;
            this.edad_don = EdadDon;
            this.fechanac_don = FechaNacDon;
            this.tel_don = TelDon;
            this.tiposangre_don = TipoSangreDon;
            this.dir_don = DirDon;
            this.correo_don = CorreoDon;
        }
    }
}
