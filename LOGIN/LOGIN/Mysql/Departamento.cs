using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIN.Mysql
{
    class Departamento
    {
        public int id_dep{ get; set; }
        public string nom_dep { get; set; }

        public Departamento() { }

        public Departamento(int Id, string NomDep)
        {
            this.id_dep = Id;
            this.nom_dep = NomDep;
        }
    }
}
