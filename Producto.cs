using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGruposPoo
{
    internal abstract class Producto
    {
        //atributos de la clase productos tipo_producto, nombre_producto, unidades_producto, precio_unidad_producto, descripcion_producto

        public int id { get; set; }
        public int tipoProducto { get; set; }

        public string nombreProducto { get; set; }

        public int unidadesProducto { get; set; }

        public double precioUnidadProducto { get; private set; }

        public string descripcionProducto { get; set; }

        //metodo constructor de la clase producto

        public Producto(int id)
        {
            this.id = id;
        }
        
        public Producto(int id, int tipoProducto, string nombreProducto, int unidadesProducto, double precioUnidadProducto, string descripcionProducto)
        {
            this.id = id;
            this.tipoProducto = tipoProducto;
            this.nombreProducto = nombreProducto;
            this.unidadesProducto = unidadesProducto;
            this.precioUnidadProducto = precioUnidadProducto;
            this.descripcionProducto = descripcionProducto;
        }

        //metodos de la clase productos

        //mostrar producto

        public void MostrarProductoDisponible()
        {
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Nombre: " + nombreProducto);
            Console.WriteLine("Unidades disponibles: " + unidadesProducto);
            Console.WriteLine("Precio: " + precioUnidadProducto);
        }

        public virtual void MostrarProducto()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Tipo de Producto: " + tipoProducto);
            Console.WriteLine("Nombre del Producto: " + nombreProducto);
            Console.WriteLine("Unidades del Producto: " + unidadesProducto);
            Console.WriteLine("Precio por Unidad del Producto: " + precioUnidadProducto);
            Console.WriteLine("Descripcion del Producto: " + descripcionProducto);
        }

        public override string ToString()
        {
            return "Id del producto: "+ id + "\nTipo de Producto: " + 
                tipoProducto + "\nNombre del Producto: " + nombreProducto + 
                "\nUnidades del Producto: " + unidadesProducto + "\nPrecio por Unidad del Producto: " + 
                precioUnidadProducto + "\nDescripcion del Producto: " + descripcionProducto;
        }

        //metodo que solicite los detalles del producto a la hora de añadirlo a la maquina expendedora
        
        public virtual void SolicitarDetalles()
        {
            Console.WriteLine("Introduce el nombre del producto: ");
            nombreProducto = Console.ReadLine();
            Console.WriteLine("Introduce las unidades del producto: ");
            unidadesProducto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el precio por unidad del producto: ");
            precioUnidadProducto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce la descripcion del producto: ");
            descripcionProducto = Console.ReadLine();
        }

        // Metodo para tranformar el producto en un string para guardarlo en un archivo

        public virtual string ToFile()
        {
            string separator = ";";

            return id + separator + tipoProducto + separator + nombreProducto + separator +
                unidadesProducto + separator + precioUnidadProducto + separator + descripcionProducto;
        }

        //public abstract void FromFile();

        public virtual void FromFile(string[] data)
        {
            id = Convert.ToInt32(data[0]);
            tipoProducto = Convert.ToInt32(data[1]);
            nombreProducto = data[2];
            unidadesProducto = Convert.ToInt32(data[3]);
            precioUnidadProducto = Convert.ToDouble(data[4]);
            descripcionProducto = data[5];
        }

    }
}
