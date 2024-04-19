using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGruposPoo
{
    internal class Materiales
    {
        //atributos propios de la clase Materiales

        public string material { get; set; }

        public bool sePuedeReciclar { get; set; }

        public string requisitosEspecificos { get; set; }

        //constructor de la clase Materiales

        public Materiales(string material, bool sePuedeReciclar, string requisitosEspecificos)
        {
            this.material = material;
            this.sePuedeReciclar = sePuedeReciclar;
            this.requisitosEspecificos = requisitosEspecificos;
        }

        public override string ToString()
        {
            return "\nMaterial: " + material + "\n Se puede reciclar: " + 
                sePuedeReciclar + " \nRequisitos Especificos: " + requisitosEspecificos;
        }

        public void MostrarMateriales()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
