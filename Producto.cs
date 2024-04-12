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

        public int Id { get; set; }
        public int tipo_producto { get; set; }

        private string nombre_producto { get; set; }

        private int unidades_producto { get; set; }

        private double precio_unidad_producto { get; set; }

        private string descripcion_producto { get; set; }

        //metodo constructor de la clase producto

        public Producto(int id, int tipo_producto, string nombre_producto, int unidades_producto, double precio_unidad_producto, string descripcion_producto)
        {
            this.Id = id;
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
            return "Id del producto: "+ Id + "\nTipo de Producto: " + tipo_producto + "\nNombre del Producto: " + nombre_producto + "\nUnidades del Producto: " + unidades_producto + "\nPrecio por Unidad del Producto: " + precio_unidad_producto + "\nDescripcion del Producto: " + descripcion_producto;
        }

        //metodo que solicite los detalles del producto a la hora de añadirlo a la maquina expendedora
        
        public virtual void SolicitarDetalles()
        {
            Console.WriteLine("Introduce el tipo de producto: ");
            tipo_producto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el nombre del producto: ");
            nombre_producto = Console.ReadLine();
            Console.WriteLine("Introduce las unidades del producto: ");
            unidades_producto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el precio por unidad del producto: ");
            precio_unidad_producto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce la descripcion del producto: ");
            descripcion_producto = Console.ReadLine();
        }

    }
}
