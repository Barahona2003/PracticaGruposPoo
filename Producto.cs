﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGruposPoo
{
    internal class Producto
    {
        //atributos de la clase productos tipo_producto, nombre_producto, unidades_producto, precio_unidad_producto, descripcion_producto

        public int id { get; set; }
        public int tipoProducto { get; set; }

        private string nombreProducto { get; set; }

        private int unidadesProducto { get; set; }

        public double precioUnidadProducto { get; private set; }

        private string descripcionProducto { get; set; }

        //List<Producto> listaProductos = new List<Producto>();

        //metodo constructor de la clase producto

        public Producto(int id, int tipoProducto, string nombreProducto, int unidadesProducto, double precioUnidadProducto, string descripcionProducto/*, List<Producto> listaProductos*/)
        {
            this.id = id;
            this.tipoProducto = tipoProducto;
            this.nombreProducto = nombreProducto;
            this.unidadesProducto = unidadesProducto;
            this.precioUnidadProducto = precioUnidadProducto;
            this.descripcionProducto = descripcionProducto;
            //this.listaProductos = listaProductos;
        }

        //metodos de la clase productos

        //mostrar producto

        public virtual void MostrarProductoDisponible()
        {
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Nombre: " + nombreProducto);
            Console.WriteLine("Unidades disponibles: " + unidadesProducto);
            Console.WriteLine("Precio: " + precioUnidadProducto);
        }

        public virtual void MostrarProducto()
        {
            
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
            Console.WriteLine("Introduce el tipo de producto: ");
            tipoProducto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el nombre del producto: ");
            nombreProducto = Console.ReadLine();
            Console.WriteLine("Introduce las unidades del producto: ");
            unidadesProducto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el precio por unidad del producto: ");
            precioUnidadProducto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce la descripcion del producto: ");
            descripcionProducto = Console.ReadLine();
        }

    }
}
