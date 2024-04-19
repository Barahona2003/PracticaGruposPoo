using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGruposPoo
{
    internal class Program
    {
        private static List<Producto> listaProductos;
        static MaquinaVending maquinaVending;
        static void Main(string[] args)
        {
            listaProductos = new List<Producto>();
            maquinaVending = new MaquinaVending();

            Console.WriteLine("Hola");
            
            //menu de seleccion de 5 opciones 
            int opcion = 0;
            do
            {
                Console.WriteLine("Bienvenido a la tienda de productos electronicos");
                Console.WriteLine("Seleccione una opcion");
                Console.WriteLine("1. Comprar Producto");
                Console.WriteLine("2. Mostrar Informacion del producto");
                Console.WriteLine("3. Carga individual del producto");
                Console.WriteLine("4. Cargar completa del producto");
                Console.WriteLine("5. Salir");
                Console.Write("Elija opcion");
                try
                {
                    opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            MaquinaVending.ComprarProducto();
                            break;
                        case 2:
                            MaquinaVending.MostrarProducto();
                            break;
                        case 3:
                            MaquinaVending.CargaIndividualProducto();
                            break;
                        case 4:
                            MaquinaVending.CargaCompletaProducto();
                            break;
                        case 5:
                            Console.WriteLine("Saliendo");
                            break;

                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error, la opcion seleccionada no esta disponible, ingrese una opcion valida");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
            while (opcion != 5);

            Console.ReadKey();

        }
    }
}
