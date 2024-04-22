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
                    double efectivoIntroducido = 0;
                    double efectivoRestante = precioTotal;
                    // Metodo de pago en efectivo
                    Console.WriteLine("Introduce las monedas (0.01€ (1cent), 0.02€ (2cent), 0.05€ (5cent), 0.10€ (10cent), 0.20€ (20cent), 0.50€ (50cent), 1€, 2€): ");
                    do
                    {
                        Console.WriteLine("Cantidad total a introducir: " + efectivoRestante + "€");
                        efectivoIntroducido += int.Parse(Console.ReadLine());
                        efectivoRestante -= efectivoIntroducido;
                    } while (efectivoRestante > 0);
                    double cambio = efectivoIntroducido - precioTotal;
                    Console.WriteLine("Cambio devuelto: " + cambio + "€");
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
            // Mostrar los productos disponibles
            foreach (Producto producto in listaProductos)
            {
                Console.WriteLine("ID: " + producto.id);
                Console.WriteLine("Tipo: " + producto.tipoProducto);
                Console.WriteLine("Nombre: " + producto.nombreProducto);
                Console.WriteLine("Unidades: " + producto.unidadesProducto);
                Console.WriteLine("Precio: " + producto.precioUnidadProducto);
                Console.WriteLine("Descripcion: " + producto.descripcionProducto);
            }

            // Pedir al usuario el ID del producto
            Console.WriteLine("Introduce el ID del producto:");
            int idProducto = Convert.ToInt32(Console.ReadLine());

            // Buscar el producto en la lista de productos
            Producto productoSeleccionado = listaProductos.FirstOrDefault(p => p.id == idProducto);

            if (productoSeleccionado != null)
            {
                // Mostrar la información del producto
                Console.WriteLine("Información del producto:");
                Console.WriteLine("ID: " + productoSeleccionado.id);
                Console.WriteLine("Tipo de producto: " + productoSeleccionado.tipoProducto);
                Console.WriteLine("Nombre: " + productoSeleccionado.nombreProducto);
                Console.WriteLine("Precio: " + productoSeleccionado.Precio);
                Console.WriteLine("Descripción: " + productoSeleccionado.descripcionProducto);
                Console.WriteLine("Cantidad disponible: " + productoSeleccionado.unidadesProducto);
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }


        }

        //la clave de Administrador es Admin123
        public static void CargaIndividualProducto()
        {
            Admin admin = new Admin("nombreAdmin", "claveAdmin"); // Crear una instancia de la clase Admin

            // Llamar al método VerificarContraseña() de la instancia admin
            admin.VerificarContraseña();

            // Si la contraseña es correcta, se permite la carga de productos

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

        //Clave de Administrador == Admin1234
       /* public static void CargaCompletaProducto()
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
            
            
        }*/

        public static bool CargaCompletaProducto()
        {
            Admin admin = new Admin("nombreAdmin", "claveAdmin"); // Crear una instancia de la clase Admin

            // Llamar al método VerificarContraseña() de la instancia admin
            admin.VerificarContraseña();

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
                            MaterialesPreciosos m = new MaterialesPreciosos(int.Parse(datos[1]), int.Parse(datos[2]), datos[3], int.Parse(datos[4]), double.Parse(datos[5]), datos[6], datos[7], int.Parse(datos[8]));
                            listaProductos.Add(m);
                        }
                        else if (datos[0] == "1")
                        {
                            ProductosAlimenticios p = new ProductosAlimenticios(int.Parse(datos[1]), int.Parse(datos[2]), datos[3], int.Parse(datos[4]), double.Parse(datos[5]), datos[6], datos[7]);
                            listaProductos.Add(p);
                        }
                        else
                        {
                            ProductosElectronicos e = new ProductosElectronicos(int.Parse(datos[1]), (datos[2]), int.Parse(datos[3]), double.Parse(datos[4]), (datos[5]), bool.Parse(datos[6]), bool.Parse(datos[7]));
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
    }
}
