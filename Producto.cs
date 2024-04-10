using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGruposPoo
{
    internal class Producto
    {
        //atributos de la clase productos tipo_producto, nombre_producto, unidades_producto, precio_unidad_producto, descripcion_producto

        public int tipo_producto { get; set; }

        private string nombre_producto { get; set; }

        private int unidades_producto { get; set; }

        private double precio_unidad_producto { get; set; }

        private string descripcion_producto { get; set; }

        //metodo constructor de la clase producto

        public Producto(int tipo_producto, string nombre_producto, int unidades_producto, double precio_unidad_producto, string descripcion_producto)
        {
            this.tipo_producto = tipo_producto;
            this.nombre_producto = nombre_producto;
            this.unidades_producto = unidades_producto;
            this.precio_unidad_producto = precio_unidad_producto;
            this.descripcion_producto = descripcion_producto;
        }

        //metodos de la clase productos

        //mostrar producto

        public virtual void MostrarProducto()
        {
            Console.WriteLine("Tipo de Producto: " + tipo_producto);
            Console.WriteLine("Nombre del Producto: " + nombre_producto);
            Console.WriteLine("Unidades del Producto: " + unidades_producto);
            Console.WriteLine("Precio por Unidad del Producto: " + precio_unidad_producto);
            Console.WriteLine("Descripcion del Producto: " + descripcion_producto);
        }

        public override string ToString()
        {
            return "Tipo de Producto: " + tipo_producto + "\nNombre del Producto: " + nombre_producto + "\nUnidades del Producto: " + unidades_producto + "\nPrecio por Unidad del Producto: " + precio_unidad_producto + "\nDescripcion del Producto: " + descripcion_producto;
        }

    }
}
