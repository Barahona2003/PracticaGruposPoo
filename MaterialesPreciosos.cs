using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGruposPoo
{
    internal class MaterialesPreciosos : Producto
    {
        //atributos propios de la clase Materiales Preciosos

        public string material { get; set; }

        public bool sePuedeReciclar { get; set; }
        
        public string requisitosEspecificos { get; set; }

        private int peso { get; set; }

        //constructor de la clase MaterialesPreciosos

        public MaterialesPreciosos(int id) : base(id)
        {
            this.tipoProducto = 1;
            this.material = "";
            this.sePuedeReciclar = false;
            this.requisitosEspecificos = "";
            this.peso = -1;
        }

        public MaterialesPreciosos(int id, int tipoProducto, string nombreProducto, int unidadesProducto, double precioUnidadProducto, string descripcionProducto, string material, bool sePuedeReciclar, string requisitosEspecificos, int peso) : 
            base(id, tipoProducto, nombreProducto, unidadesProducto, precioUnidadProducto, descripcionProducto)
        {
            this.tipoProducto = 1;
            this.material = material;
            this.sePuedeReciclar = sePuedeReciclar;
            this.requisitosEspecificos = requisitosEspecificos;
            this.peso = peso;
        }

        //metodos de la clase MaterialesPreciosos

        //metodo para mostrar los materiales

        public override string ToString()
        {
            return base.ToString();
        }

        public override void MostrarProducto()
        {
            base.MostrarProducto();
            Console.WriteLine("Material: " + material);
            Console.WriteLine("Reciclable o no reciclable: " + sePuedeReciclar);
            Console.WriteLine("Requisitos especificos: " + requisitosEspecificos);
            Console.WriteLine("Peso: " + peso);
        }

        //metodo que utiliza el de clase padre producto para mostrar tambien los atributos propios de la clase MaterialesPreciosos

        public override void SolicitarDetalles()
        {
            base.SolicitarDetalles();
            Console.WriteLine("Tipo de producto: " + tipoProducto);
            Console.WriteLine("Introduce el material del producto: ");
            material = Console.ReadLine();
            Console.WriteLine("Introduce si el producto se puede reciclar: (y/n)");
            sePuedeReciclar = Console.ReadLine().ToLower().Equals("y");
            Console.WriteLine("Introduce los requisitos especificos del producto: ");
            requisitosEspecificos = Console.ReadLine();
            Console.WriteLine("Introduce el peso del producto: ");
            peso = Convert.ToInt32(Console.ReadLine());
        }
    }
}
