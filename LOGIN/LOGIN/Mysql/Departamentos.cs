using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIN.Mysql
{
    class Departamentos
    {
        public int id_dep { get; set; }
        public string nom_dep { get; set; }

        public Departamentos() { }

        public Departamentos(int IdDepartamento, string NombreDepartamento)
        {
            this.id_dep = IdDepartamento;
            this.nom_dep = NombreDepartamento;
        }
    }
}
