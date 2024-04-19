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

        public Informacion_Nutricional infoNutricional { get; set; }

    //constructor de la clase ProductosAlimenticios

        public ProductosAlimenticios(int id, int tipoProducto, string nombreProducto, int unidadesProducto, double precioUnidadProducto, string descripcionProducto, Informacion_Nutricional infoNutricional) : base( id, tipoProducto, nombreProducto, unidadesProducto, precioUnidadProducto, descripcionProducto)
        {
            this.tipoProducto = 2;
            this.infoNutricional = infoNutricional;
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
            infoNutricional.MostrarInformacionNutricional(); 
        }

        //metodo para solicitar los detalles del producto por pantalla
        public override void SolicitarDetalles()
        {
            base.SolicitarDetalles();
            infoNutricional.MostrarInformacionNutricional();
        }
    }
}
