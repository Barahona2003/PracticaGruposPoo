﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGruposPoo
{
    internal class ProductosAlimenticios : Producto
    {
        //atributos propios de la clase Productos Alimenticios

        public int calorias { get; set; }

        public int azucares { get; set; }

        public int grasas { get; set; }


        //constructor de la clase ProductosAlimenticios

        public ProductosAlimenticios(int id) : base(id)
        {
            this.tipoProducto = 2;
            this.calorias = -1;
            this.azucares = -1;
            this.grasas = -1;
        }

        public ProductosAlimenticios(int id, int tipoProducto, string nombreProducto, int unidadesProducto, double precioUnidadProducto, string descripcionProducto,
         int calorias, int azucares, int grasas) : base(id, tipoProducto, nombreProducto, unidadesProducto, precioUnidadProducto, descripcionProducto)
        {
            this.tipoProducto = 2;
            this.calorias = calorias;
            this.azucares = azucares;
            this.grasas = grasas;
        }

        //metodos de la clase ProductosAlimenticios

        //metodo que coge los atributos de la clase prodcutos en un tostring para poder utilizarla en esta clase y mostrarla
        public override string ToString()
        {
            return base.ToString();
        }

        //metodo para mostrar el producto
        public override void MostrarProducto()
        {
            base.MostrarProducto();
            Console.WriteLine("Calorias: " + calorias + "kcal");
            Console.WriteLine("Azúcares: " + azucares + "g");
            Console.WriteLine("Grasas: " + grasas + "g");
        }

        //metodo para solicitar los detalles del producto por pantalla
        public override void SolicitarDetalles()
        {
            base.SolicitarDetalles();
            //Console.WriteLine("Tipo de producto: " + tipoProducto);
            Console.WriteLine("Introduce las calorias del producto: ");
            calorias = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce los azucares del producto: ");
            azucares = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce las grasas del producto: ");
            grasas = Convert.ToInt32(Console.ReadLine());
        }

        // Convertir el producto a una string para poder guardarla en un fichero
        public override string ToFile(){
            string separator = ";";
            return base.ToFile() + separator + calorias + separator + azucares + separator + grasas;
        }

        //Método que toma los atributos del método de la clase producto y añade también los atributos de esta clase
        public override void FromFile(string[] data){   
            base.FromFile(data);
            calorias = Convert.ToInt32(data[6]);
            azucares = Convert.ToInt32(data[7]);
            grasas = Convert.ToInt32(data[8]);
        }

    }
}
