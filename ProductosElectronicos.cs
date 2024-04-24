using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGruposPoo
{
    internal class ProductosElectronicos : Producto
    {
        //atributos propios de la clase ProductosElectronicos

        public bool tieneBateria { get; set; }

        public bool precargado { get; set; }

        //constructor de la clase ProductosElectronicos

        public ProductosElectronicos(int id) : base(id)
        {
            this.tipoProducto = 3;
            this.tieneBateria = false;
            this.precargado = false;
        }

        public ProductosElectronicos(int id, int tipoProducto, string nombreProducto, int unidadesProducto, double precioUnidadProducto, string descripcionProducto,
         bool tieneBateria, bool Precargado) : base(id, tipoProducto, nombreProducto, unidadesProducto, precioUnidadProducto, descripcionProducto)
        {
            this.tipoProducto = 3;
            this.tieneBateria = tieneBateria;
            this.precargado = Precargado;
        }

        //metodo que utiliza el de clase padre producto para mostrar tambien los atributos propios de la clase ProductosElectronicos

        public override void MostrarProducto()
        {
            base.MostrarProducto();
            Console.WriteLine("Tiene bateria: " + tieneBateria);
            Console.WriteLine("Precargado: " + precargado);
        }

        //metodo que utiliza el de clase padre producto para solicitar tambien los atributos propios de la clase ProductosElectronicos
        public override void SolicitarDetalles()
        {
            base.SolicitarDetalles();
            Console.WriteLine("Tipo de producto: " + tipoProducto);
            Console.WriteLine("Introduce si el producto tiene bateria: (y/n)");
            tieneBateria = Console.ReadLine().ToLower().Equals("y");
            Console.WriteLine("Introduce si el producto esta precargado: (y/n)");
            precargado = Console.ReadLine().ToLower().Equals("y");
        }
    }
}
