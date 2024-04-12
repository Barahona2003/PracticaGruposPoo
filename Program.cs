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
        static void Main(string[] args)
        {
            listaProductos = new List<Producto>();
            
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

        //Funcion para mostrar las caracteristicas del producto
        private static void MostrarProducto()
        {
            // Mostrar los productos disponibles
            foreach (Producto producto in listaProductos)
            {
                Console.WriteLine("ID: " + producto.Id);
                Console.WriteLine("Nombre: " + producto.nombre_producto);
                Console.WriteLine("Unidades: " + producto.Unidades);
                Console.WriteLine("Precio: " + producto.Precio);
                Console.WriteLine("Descripcion: " + producto.Descripcion);
            }

            // Pedir al usuario el ID del producto
            Console.WriteLine("Introduce el ID del producto:");
            int idProducto = Convert.ToInt32(Console.ReadLine());

            // Buscar el producto en la lista de productos
            Producto productoSeleccionado = listaProductos.FirstOrDefault(p => p.Id == idProducto);

            if (productoSeleccionado != null)
            {
                // Mostrar la información del producto
                Console.WriteLine("Nombre: " + productoSeleccionado.Nombre);
                Console.WriteLine("Precio: " + productoSeleccionado.Precio);
                Console.WriteLine("Descripción: " + productoSeleccionado.Descripcion);
                Console.WriteLine("Cantidad disponible: " + productoSeleccionado.Unidades);
                Console.WriteLine("Tipo de producto: " + productoSeleccionado.TipoProducto);
                Console.WriteLine("Categoría: " + productoSeleccionado.Categoria);
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }


        }

        //la clave de Administrador es Admin123
        private static void CargaIndividualProducto()
        {
            Console.WriteLine("Introduce la clave de administrador:");
            string clave = Console.ReadLine();

            if (clave == "Admin123")
            {
                Console.WriteLine("Clave correcta.");
                int opcion = 0;
                Console.WriteLine("1.Nuevo Material Precioso");
                Console.WriteLine("2.Nuevo Producto Alimenticio");
                Console.WriteLine("3.Nuevo Producto Electronico");
                Console.WriteLine("4.Salir");
                Console.Write("Elija opcion");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        MaterialesPreciosos m = new MaterialesPreciosos(listaProductos.Count);
                        m.SolicitarDetalles();
                        listaProductos.Add(m);
                        break;
                    case 2:
                        ProductosAlimenticios p = new ProductosAlimenticios(listaProductos.Count);
                        p.SolicitarDetalles();
                        listaProductos.Add(p);
                        break;
                    case 3:
                        ProductosElectronicos e = new ProductosElectronicos(listaProductos.Count);
                        e.SolicitarDetalles();
                        listaProductos.Add(e);
                        break;
                    case 4:
                        Console.WriteLine("Saliendo");
                        break;
                        
                }


            }
            else
            {
                Console.WriteLine("Clave de administradorincorrecta.");
            }

        }

        //Clave de Administrador == Admin1234
        private static void CargaCompletaProducto()
        {
            Console.WriteLine("Introduce la clave de administrador:");
            string clave = Console.ReadLine();

            if (clave == "Admin1234")
            {

                bool ProductosCargados = false;
                try
                {
                    if (File.Exists("Productos.txt"))
                    {
                        StreamReader sr = new StreamReader("Productos.txt");
                        string linea;
                        while ((linea = sr.ReadLine()) != null)
                        {
                            ProductosCargados = true;
                            string[] datos = linea.Split('/');
                            if (datos[0] == "0")
                            {
                                MaterialesPreciosos m = new MaterialesPreciosos(int.Parse(datos[1]), int.Parse(datos[2]), datos[3], int.Parse(datos[4]), double.Parse(datos[5]), datos[6], datos[7], int.Parse(datos[8]);
                                listaProductos.Add(m);
                            }
                            else if (datos[0] == "1")
                            {
                                ProductosAlimenticios p = new ProductosAlimenticios(int.Parse(datos[1]), int.Parse(datos[2]), datos[3], int.Parse(datos[4]), double.Parse(datos[5]), datos[6], datos[7]);
                                listaProductos.Add(p);
                            }
                            else
                            {
                                ProductosElectronicos e = new ProductosElectronicos(int.Parse(datos[1]), int.Parse(datos[2]), datos[3], int.Parse(datos[4]), double.Parse(datos[5]), datos[6], bool.Parse(datos[7]), bool.Parse(datos[8]));
                            }
                            sr.Close();




                        }
                    }
                    else
                    {
                        File.Create("Productos.txt").Close();
                    }
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine("No se encuentra el archivo de productos: " + ex.Message);
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Error de E/S" + ex.Message);
                }
                return ProductosCargados;
            }
            else
            {
                Console.WriteLine("Clave de administrador incorrecta");
            }
        }
    }
}
