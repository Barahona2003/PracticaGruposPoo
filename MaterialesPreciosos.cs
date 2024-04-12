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

        public Materiales info_material { get; set; }

        private int peso { get; set; }

        //constructor de la clase MaterialesPreciosos

        public MaterialesPreciosos(int id, int tipo_producto, string nombre_producto, int unidades_producto, double precio_unidad_producto, string descripcion_producto, Materiales info_materiales, int peso) : base(id, tipo_producto, nombre_producto, unidades_producto, precio_unidad_producto, descripcion_producto)
        {
            this.tipo_producto = 1;
            this.info_material = info_material;
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
            info_material.MostrarMateriales();
        }

        //metodo que utiliza el de clase padre producto para mostrar tambien los atributos propios de la clase MaterialesPreciosos

        public override void SolicitarDetalles()
        {
            base.MostrarProducto();
            Console.WriteLine("Material: " + info_material);
            Console.WriteLine("Peso: " + peso);
        }
    }
}
