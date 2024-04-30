using System;
using System.Collections;
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

        //Método para verificar la contraseña del admin si la contraseña es igual a claveAcceso (Admin1234) podra continuar si no se le dara un mensaje de error
        //de contraseña invalida y se le pedira que vuelva a intentarlo
        public void VerificarContraseña()
        {
            string contraseña;
            do
            {
                Console.WriteLine("Introduce la contraseña: ");
                contraseña = Console.ReadLine();
                if (this.claveAcceso == contraseña)
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
            } while (contraseña != claveAcceso);
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
                    escritor_archivos.WriteLine(p.ToFile());    //Escribimos en el fichero lo que hay almacenado en la lista de productos llamando al método ToFile
                }
                escritor_archivos.Close();  //Cerramos el lector de ficheros
            }
            catch (FileNotFoundException ex)    //Excepciones
            {
                Console.WriteLine("No se encuentra el archivo de productos: " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error de E/S" + ex.Message);
            }
        }

        public void CargaIndividualProducto()
        {
            int opcion = 0;

            //El bucle se seguirá ejecutando mientras no elijamos la opción 4
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
                    opcion = int.Parse(Console.ReadLine()); //Según a opción llamamos a un caso
                    switch (opcion)
                    {
                        case 1:
                            MaterialesPreciosos m = new MaterialesPreciosos(listaProductos.Count);  //Llamamos al constructor para almacenar el count de la lista como el id
                            m.SolicitarDetalles();  //Llamamos al método SolicitarDetalles de la clase 
                            listaProductos.Add(m);  //Añadimos el producto ya con todas sus características en la lista de productos
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
                catch (FormatException) //Excepciones
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

        }       

        public void CargaCompletaProducto()
        {
            Console.Clear();
            try
            {
                StreamReader lector_archivos = new StreamReader("Productos.txt"); //Llamamos a la clase StreamReader para poder leer el fichero
                string linea;
                while ((linea = lector_archivos.ReadLine()) != null)    //Mientras no haya una línea en blanco se seguirá leyendo el fichero
                {
                    string[] datos = linea.Split(';');  //Almacenamos el separador del fichero de texto en una variable
                    switch (datos[1])   //Dependiendo de si el roducto es un material precioso, un producto alimenticio o electrónico se llamará a uno de los tres casos
                    {
                        case "1":
                            MaterialesPreciosos m = new MaterialesPreciosos(listaProductos.Count);  //Llamamos al constructor para almacenar el count de la lista como el id
                            m.FromFile(datos);  //Llamamos al método FromFile de la clase 
                            listaProductos.Add(m);  //Añadimos el producto ya con todas sus características en la lista de productos
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
                lector_archivos.Close();    //Cerramos el lector de ficheros
            }
            catch (FileNotFoundException ex)    //Excepciones en caso de que no encontremos el fichero
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
