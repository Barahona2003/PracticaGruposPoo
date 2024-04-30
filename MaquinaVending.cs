using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGruposPoo
{
    internal class MaquinaVending
    {
        private static List<Producto> listaProductos; // 12 slots de productos, con x stock por producto

        //Constructor para el instanciamiento en la clase Program recibiendo los datos de la lista que hay en este
        public MaquinaVending()
        {
            listaProductos = new List<Producto>();
        }

        public static void ComprarProducto()
        {
            // Función para comprar un producto me diante un bluce while
            bool seguirComprando = true;
            double precioTotal = 0;
            int udsSeleccionadas = 0;
            bool continuarCompra = true;

            if (listaProductos.Count == 0)
            {
                seguirComprando = false;
                Console.WriteLine("No hay productos en el stock de la máquina. Volviendo al menu principal...");
            }

            while (seguirComprando)
            {
                do      //Entramos dentro del bucle do-while que se seguirá ejecutando mientras la var bool sea true
                {
                    //Se muestra al usuario los diferentes productos de la máquina
                    foreach (Producto p in listaProductos)
                    {
                        p.MostrarProductoDisponible();
                    }

                    // Seleccionar el producto a comprar por parte del usuario
                    Console.WriteLine("Introduce el ID del producto:");
                    int idProducto = int.Parse(Console.ReadLine());
                    Console.WriteLine("Selecciona el número de unidades que desea: ");
                    udsSeleccionadas = int.Parse(Console.ReadLine());
                    for (int i = listaProductos.Count - 1; i >= 0; i--)
                    {
                        Producto p = listaProductos[i];
                        if (p.id == idProducto)
                        {
                            Console.WriteLine("Añadiendo producto a la cesta");
                            precioTotal += p.precioUnidadProducto * udsSeleccionadas;
                        }
                    }

                    // Se pregunta al usuario si desea añadir algun producto adicional
                    Console.WriteLine("¿Quieres añadir otro producto? (1 = sí, 0 = no)");
                    int respuesta = int.Parse(Console.ReadLine());

                    //Finalizamos compra y procedemos al pago
                    if (respuesta == 0)
                    {
                        continuarCompra = false;

                    }
                    

                } while (continuarCompra);

                // Seleccionar el método de pago
                Console.WriteLine("Precio = " + precioTotal + "€");
                Console.WriteLine("Selecciona el método de pago: ");
                Console.WriteLine("1. Tarjeta");
                Console.WriteLine("2. Efectivo");
                int metodoPago =int.Parse(Console.ReadLine());

                if (metodoPago == 1)
                {
                    // Metodo para el pago con tarjeta
                    Console.WriteLine("Introduce el número de tarjeta:");
                    string numeroTarjeta = Console.ReadLine();
                    Console.WriteLine("Introduce el PIN:");
                    string pin = Console.ReadLine();
                    Console.WriteLine("Introduce el nombre del propietario:");
                    string nombrePropietario = Console.ReadLine();
                    Console.WriteLine("Gracias por su compra, su producto esta siendo proporcionado.");
                    // Lógica para procesar el pago con tarjeta
                }
                else if (metodoPago == 2)
                {
                    double efectivoIntroducido = 0;
                    double efectivoRestante = precioTotal;
                    // Metodo de pago en efectivo
                    Console.WriteLine("Introduce las monedas (0.01€ (1cent), 0.02€ (2cent), 0.05€ (5cent), 0.10€ (10cent), 0.20€ (20cent), 0.50€ (50cent), 1€, 2€): ");
                    do
                    {
                        Console.WriteLine("Cantidad total a introducir: " + efectivoRestante + "€");
                        efectivoIntroducido += double.Parse(Console.ReadLine());
                        efectivoRestante -= efectivoIntroducido;
                    } while (efectivoRestante > 0);
                    double cambio = efectivoIntroducido - precioTotal;
                    Console.WriteLine("Cambio devuelto: " + cambio + "€");
                    Console.WriteLine("Gracias por su compra, su producto esta siendo proporcionado.");
                }
                else
                {
                    Console.WriteLine("Opción inválida.");
                }

                seguirComprando = false; // Salir del bucle de compra

            }
        }

        //Funcion para mostrar las caracteristicas del producto
        public static void MostrarProducto()
        {
            if (listaProductos.Count == 0)
            {
                Console.WriteLine("No hay produtos en el stock de la máquina. Volviendo al menu principal...");
            }
            else
            {
                foreach (Producto producto in listaProductos) //Mostramos cada producto en la lista de productos
                {
                    producto.MostrarProductoDisponible();
                }

                // Pedir al usuario el ID del producto
                Console.WriteLine("\nIntroduce el ID del producto:");
                int idProducto = int.Parse(Console.ReadLine());

                //Por cada producto en la lista, si la id que hemos introducido coincide con la de algún producto
                //mostrará su información detallada dependiendo de si es un material precioso, producto alimenticio o producto electrónico

                foreach (Producto producto in listaProductos)
                {
                    if (idProducto == producto.id)
                    {
                        if (producto is ProductosAlimenticios)
                        {
                            ((ProductosAlimenticios)producto).MostrarProducto();
                        }
                        if (producto is ProductosElectronicos)
                        {
                            ((ProductosElectronicos)producto).MostrarProducto();
                        }
                        if (producto is MaterialesPreciosos)
                        {
                            ((MaterialesPreciosos)producto).MostrarProducto();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Producto no encontrado");
                    }
                }
            }

            
        }

        //la clave de Administrador es Admin123
        public static void CargaIndividualProducto()
        {
            Admin admin = new Admin("Admin1234", listaProductos); // Crear una instancia de la clase Admin

            // Llamar al método VerificarContraseña() de la instancia admin y al método CargaIndividualProducto()
            admin.VerificarContraseña();
            admin.CargaIndividualProducto();
        }
           
        public static void CargaCompletaProducto()
        {
            Admin admin = new Admin("Admin1234", listaProductos); // Crear una instancia de la clase Admin

            // Llamar al método VerificarContraseña() de la instancia admin y al método CargaCompletaProducto()
            admin.VerificarContraseña();
            admin.CargaCompletaProducto();

            
        }
    }
}
