using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaQ10
{
    class Program
    {
        // Método principal, punto de entrada de la aplicación
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la aplicación de gestión de tareas.");

            // Creamos una instancia de la clase Opciones y mostramos el menú
            Opciones opciones = new Opciones();
            opciones.MostrarMenu();
        }
    }
}

