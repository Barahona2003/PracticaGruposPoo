using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGruposPoo
{
    internal class Informacion_Nutricional
    {
        //atributos propias de la clase Informacion Nutricional

        public int calorias { get; set; }

        public int azucares { get; set; }

        public int grasas { get; set; }

        //metodo constructor de la clase Informacion Nutricional

        public Informacion_Nutricional(int calorias, int azucares, int grasas)
        {
            this.calorias = calorias;
            this.azucares = azucares;
            this.grasas = grasas;
        }

        public override string ToString()
        {
            return "\nCalorias: " + calorias + "\n Azucares: " + azucares + " \nGrasas: " + grasas;
        }

        public void MostrarInformacionNutricional()
        {
            Console.WriteLine(this.ToString());
        }

    }
}
