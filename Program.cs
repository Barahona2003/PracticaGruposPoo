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
        static MaquinaVending maquinaVending;
        static void Main(string[] args)
        {
            maquinaVending = new MaquinaVending();

            //menu de seleccion de 5 opciones con las funciones de la maquina de vending
            
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
                Console.WriteLine("Elija opcion");
                try
                {
                    opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            MaquinaVending.ComprarProducto();   //Llamamiento al método ComprarProducto de la clase MaquinaVending
                            break;
                        case 2:
                            MaquinaVending.MostrarProducto();   //Llamamiento al método MostrarProducto de la clase MaquinaVending
                            break;
                        case 3:
                            MaquinaVending.CargaIndividualProducto();   //Llamamiento al método CargaIndividualProducto de la clase MaquinaVending
                            break;
                        case 4:
                            MaquinaVending.CargaCompletaProducto(); //Llamamiento al método CargaCompletaProducto de la clase MaquinaVending
                            break;
                        case 5:
                            Console.WriteLine("Saliendo");
                            Console.WriteLine("Presione para continuar");
                            break;

                    }
                }
                catch (FormatException)     //Excepciones en caso de fallo
                {
                    Console.WriteLine("Error, la opcion seleccionada no esta disponible, ingrese una opcion valida");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                
            }
            while (opcion != 5);

            Console.ReadKey();

        }
    }
}
