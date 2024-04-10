using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGruposPoo
{
    internal class ProductosAlimenticios : Producto
    {
        //atributos propios de la clase Productos Alimenticios

        public Informacion_Nutricional info_nutricional { get; set; }

    //constructor de la clase ProductosAlimenticios

        public ProductosAlimenticios(int tipo_producto, string nombre_producto, int unidades_producto, double precio_unidad_producto, string descripcion_producto, Informacion_Nutricional info_nutricional) : base(tipo_producto, nombre_producto, unidades_producto, precio_unidad_producto, descripcion_producto)
        {
            this.tipo_producto = 2;
            this.info_nutricional = info_nutricional;
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
            info_nutricional.MostrarInformacionNutricional(); 
        }
    }
}
