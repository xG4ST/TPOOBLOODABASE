using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIN.Mysql
{
    class Donador_has_Estudio1
    {
        public int Donador_iddon1 { get; set; }
        public string Estudio_tipo_est1 { get; set; }
        public int id_dcita { get; set; }
        public int fecha_dcita { get; set; }
        public int hora_dcita { get; set; }
        public string nom_don { get; set; }
        public int tel_don { get; set; }
        public int correo_don { get; set; }
        //

        public Donador_has_Estudio1() { }
        public Donador_has_Estudio1(int Donador_iddon1, string Estudio_tipo_est1, int id_dcita,
            int fecha_dcita, int hora_dcita, string nom_don, int tel_don, int correo_don) //string Estudio_Tipo
        {
            this.Donador_iddon1 = Donador_iddon1;
            this.Estudio_tipo_est1 = Estudio_tipo_est1;
            this.id_dcita = id_dcita;
            this.fecha_dcita = fecha_dcita;
            this.hora_dcita = hora_dcita;
            this.nom_don = nom_don;
            this.tel_don = tel_don;
            this.correo_don = correo_don;

        }
    }
}
