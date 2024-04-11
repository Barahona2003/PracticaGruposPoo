using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGruposPoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                            ComprarProducto();
                            break;
                        case 2:
                            MostrarProducto();
                            break;
                        case 3:
                            CargaIndividualProducto();
                            break;
                        case 4:
                            CargaCompletaProducto();
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

        private static void ComprarProducto()
        {
            // Función para comprar un producto me diante un bluce while
            bool seguirComprando = true;

            while (seguirComprando)
            {
                // Seleccionar el producto a comprar por parte del usuario
                Console.WriteLine("Introduce el ID del producto:");
                int idProducto = Convert.ToInt32(Console.ReadLine());

                // Se pregunta al usuario si desea añadir algun producto adicional
                Console.WriteLine("¿Quieres añadir otro producto? (1 = sí, 0 = no)");
                int respuesta = Convert.ToInt32(Console.ReadLine());

                if (respuesta == 1)
                {
                    // Continuar comprando
                    Console.WriteLine("Introduce el ID del producto a añadir:");
                    int idProductoAdicional = Convert.ToInt32(Console.ReadLine());

                }
                else
                {
                    // Seleccionar el método de pago
                    Console.WriteLine("Selecciona el método de pago: ");
                    Console.WriteLine("1. Tarjeta");
                    Console.WriteLine("2. Efectivo");
                    int metodoPago = Convert.ToInt32(Console.ReadLine());

                    if (metodoPago == 1)
                    {
                        // Metodo para el pago con tarjeta
                        Console.WriteLine("Introduce el número de tarjeta:");
                        string numeroTarjeta = Console.ReadLine();
                        Console.WriteLine("Introduce el PIN:");
                        string pin = Console.ReadLine();
                        Console.WriteLine("Introduce el nombre del propietario:");
                        string nombrePropietario = Console.ReadLine();
                        // Lógica para procesar el pago con tarjeta
                    }
                    else if (metodoPago == 2)
                    {

                        // Metodo de pago en efectivo
                        Console.WriteLine("Introduce la cantidad de efectivo:");
                        double cantidadEfectivo = Convert.ToDouble(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Opción inválida.");
                    }

                    seguirComprando = false; // Salir del bucle de compra
                }
            }
        }

        private static void MostrarProducto()
        {
            
        }

        private static void CargaIndividualProducto()
        {

        }

        private static void CargaCompletaProducto()
        {

        }
    }
}
