﻿using System;
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
            string contraseña;
            do
            {
                Console.WriteLine("Introduce la contraseña: ");
                contraseña = Console.ReadLine();
                if (contraseña == claveAcceso)
                {
                    Console.WriteLine("Contraseña correcta");
                }
                else
                {
                    Console.WriteLine("Contraseña incorrecta, vuelve a intentarlo");
                }
            } while (contraseña != claveAcceso);
        }

        public void CargaIndividualProducto()
        {
            int opcion = 0;

            do
            {
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
            } while (opcion != 4);
        }

        public bool CargaCompletaProducto()
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
                            MaterialesPreciosos m = new MaterialesPreciosos(listaProductos.Count,int.Parse(datos[1]), datos[2], int.Parse(datos[3]), double.Parse(datos[4]), datos[5], datos[6], datos[7], datos[8], int.Parse(datos[9]));
                            listaProductos.Add(m);
                        }
                        else if (datos[0] == "1")
                        {
                            ProductosAlimenticios p = new ProductosAlimenticios(listaProductos.Count,int.Parse(datos[1]), datos[2], int.Parse(datos[3]), double.Parse(datos[4]), datos[5], int.Parse(datos[6]), int.Parse(datos[7]), int.Parse(datos[8]));
                            listaProductos.Add(p);
                        }
                        else
                        {
                            ProductosElectronicos e = new ProductosElectronicos(listaProductos.Count,int.Parse(datos[1]), datos[2], int.Parse(datos[3]), double.Parse(datos[4]), datos[5], bool.Parse(datos[6]), bool.Parse(datos[7]));
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
