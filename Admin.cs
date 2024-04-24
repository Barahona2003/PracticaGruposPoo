using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGruposPoo
{
    internal class Admin
    {
        //atributos de la clase padre admin
        public string claveAcceso { get; set; }
        protected List<Producto> listaProductos;

        //constructor de la clase Admin

        public Admin(string claveAcceso, List<Producto> listaProductos)
        {
            this.claveAcceso = claveAcceso;
            this.listaProductos = listaProductos;
        }

        //metodo para verificar la contraseña del admin si la contrseña es igual a Admin1234 podra continuar si no se le dara un mensaje de error
        //de contraseña invalida y se le pedira que vuelva a intentarlo
        public void VerificarContraseña()
        {
            string claveAcceso;
            do
            {
                Console.WriteLine("Introduce la contraseña: ");
                claveAcceso = Console.ReadLine();
                if (claveAcceso == "Admin1234")
                {
                    Console.Clear();
                    Console.WriteLine("Bienvenido Admin");
                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Contraseña incorrecta, vuelve a intentarlo");
                }
            } while (claveAcceso != "Admin1234");
        }

        public void CargaIndividualProducto()
        {
            int opcion = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("1. Nuevo Material Precioso");
                Console.WriteLine("2. Nuevo Producto Alimenticio");
                Console.WriteLine("3. Nuevo Producto Electronico");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Elija opcion:");
                try
                {
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
                            GuardarProductos("Productos.txt");
                            Console.WriteLine("Se han guardado los productos, saliendo...");
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

            } while (opcion != 4);

            Console.ReadKey();
        }

        // Funcion para guardar los productos de la lista de productos en un archivo de texto llamado Productos.txt
        public void GuardarProductos(string nombre_archivo)
        {
            try
            {
                StreamWriter escritor_archivos = new StreamWriter(nombre_archivo);
                // Avanzamos hasta el final del archivo
                // escritor_archivos.BaseStream.Seek(0, SeekOrigin.End);
                foreach (Producto p in listaProductos)
                {
                    escritor_archivos.WriteLine(p.ToFile());
                }
                escritor_archivos.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("No se encuentra el archivo de productos: " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error de E/S" + ex.Message);
            }
        }        

        public void CargaCompletaProducto()
        {
            Console.Clear();
            try
            {
                StreamReader lector_archivos = new StreamReader("Productos.txt");
                string linea;
                while ((linea = lector_archivos.ReadLine()) != null)
                {
                    string[] datos = linea.Split(';');
                    switch (datos[1])
                    {
                        case "1":
                            MaterialesPreciosos m = new MaterialesPreciosos(listaProductos.Count);
                            m.FromFile(datos);
                            listaProductos.Add(m);
                            break;
                        case "2":
                            ProductosAlimenticios p = new ProductosAlimenticios(listaProductos.Count);
                            p.FromFile(datos);
                            listaProductos.Add(p);
                            break;
                        case "3":
                            ProductosElectronicos e = new ProductosElectronicos(listaProductos.Count);
                            e.FromFile(datos);
                            listaProductos.Add(e);
                            break;
                    }
                }
                lector_archivos.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("No se encuentra el archivo de productos: " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error de E/S" + ex.Message);
            }

            Console.WriteLine("Productos cargados correctamente");
            // Mostramos la lista que se ha cargado
            foreach (Producto p in listaProductos)
            {
                p.MostrarProducto();
            }
        }
    }
}
