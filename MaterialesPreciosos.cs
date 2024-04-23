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

        public Materiales infoMaterial { get; set; }

        private int peso { get; set; }

        //constructor de la clase MaterialesPreciosos

        public MaterialesPreciosos(int id) : base(id) { }

        public MaterialesPreciosos(int id, int tipoProducto, string nombreProducto, int unidadesProducto, double precioUnidadProducto, string descripcionProducto, Materiales infoMateriales, int peso/*, List<Producto> listaProductos*/) : base(id, tipoProducto, nombreProducto, unidadesProducto, precioUnidadProducto, descripcionProducto/*, listaProductos*/)
        {
            this.tipoProducto = 1;
            this.infoMaterial = infoMaterial;
            this.peso = peso;
            //id = listaProductos.Count;
            
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
            infoMaterial.MostrarMateriales();
        }

        //metodo que utiliza el de clase padre producto para mostrar tambien los atributos propios de la clase MaterialesPreciosos

        public override void SolicitarDetalles()
        {
            base.MostrarProducto();
            Console.WriteLine("Material: " + infoMaterial);
            Console.WriteLine("Peso: " + peso);
        }
    }
}
