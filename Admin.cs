using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGruposPoo
{
    internal class Admin
    {
        //atributos de la clase padre admin

        public string nombre { get; set; }

        public string clave_acceso { get; set; }

        //constructor de la clase Admin

        public Admin(string nombre, string clave_acceso)
        {
            this.nombre = nombre;
            this.clave_acceso = clave_acceso;
        }


    }
}
