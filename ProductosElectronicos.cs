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

        public bool tiene_bateria { get; set; }

        public bool Precargado { get; set; }

        //constructor de la clase ProductosElectronicos

        public ProductosElectronicos(int tipo_producto, string nombre_producto, int unidades_producto, double precio_unidad_producto, string descripcion_producto, bool tiene_bateria, bool Precargado) : base(tipo_producto, nombre_producto, unidades_producto, precio_unidad_producto, descripcion_producto)
        {
            this.tipo_producto = 3;
            this.tiene_bateria = tiene_bateria;
            this.Precargado = Precargado;
        }

    }
}
