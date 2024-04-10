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

        public bool SePuedeReciclar { get; set; }

        public string RequisitosEspecificos { get; set; }

        //constructor de la clase Materiales

        public Materiales(string material, bool SePuedeReciclar, string RequisitosEspecificos)
        {
            this.material = material;
            this.SePuedeReciclar = SePuedeReciclar;
            this.RequisitosEspecificos = RequisitosEspecificos;
        }

        public override string ToString()
        {
            return "\nMaterial: " + material + "\n Se puede reciclar: " + SePuedeReciclar + " \nRequisitos Especificos: " + RequisitosEspecificos;
        }

        public void MostrarMateriales()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
