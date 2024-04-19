using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGruposPoo
{
    internal class Admin
    {
        //atributos de la clase padre admin

        public string nombre { get; set; }

        public string clave_acceso { get; set; }

        //constructor de la clase Admin

        public Admin(string nombre, string clave_acceso)
        {
            this.nombre = nombre;
            this.clave_acceso = clave_acceso;
        }

        //metodo para verificar la contraseña del admin si la contrseña es igual a Admin1234 podra continuar si no se le dara un mensaje de error de contraseña invalida y se le pedira que vuelva a intentarlo

        public void VerificarContraseña()
        {
            string contraseña;
            do
            {
                Console.WriteLine("Introduce la contraseña: ");
                contraseña = Console.ReadLine();
                if (contraseña == "Admin1234")
                {
                    Console.WriteLine("Contraseña correcta");
                }
                else
                {
                    Console.WriteLine("Contraseña incorrecta, vuelve a intentarlo");
                }
            } while (contraseña != "Admin1234");
        }

        /*public void VerificarContraseña()
        {
            string contraseña;
            Console.WriteLine("Introduce la contraseña: ");
            contraseña = Console.ReadLine();
            if (contraseña == "Admin1234")
            {
                Console.WriteLine("Contraseña correcta");
            }
            else
            {
                Console.WriteLine("Contraseña incorrecta, vuelve a intentarlo");
                VerificarContraseña();
            }
        }*/




    }
}
