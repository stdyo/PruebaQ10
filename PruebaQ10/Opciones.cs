using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaQ10
{
    public class Opciones
    {
        private Lista lista;

        // Constructor de la clase Opciones
        public Opciones()
        {
            lista = new Lista();
        }

        // Método principal que muestra el menú y maneja las opciones del usuario
        public void MostrarMenu()
        {
            while (true)
            {
                Console.WriteLine("\n--- Menú de Opciones ---");
                Console.WriteLine("1. Agregar tarea");
                Console.WriteLine("2. Listar tareas");
                Console.WriteLine("3. Marcar tarea como completada");
                Console.WriteLine("4. Eliminar tarea");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarTarea();
                        break;
                    case "2":
                        lista.ListarTareas();
                        break;
                    case "3":
                        MarcarComoCompletada();
                        break;
                    case "4":
                        EliminarTarea();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }
            }
        }

        // Método para agregar una nueva tarea
        private void AgregarTarea()
        {
            Console.Write("Ingrese la descripción de la tarea: ");
            string descripcion = Console.ReadLine();

            Console.Write("¿Desea agregar una fecha límite? (S/N): ");
            string respuesta = Console.ReadLine().ToUpper();

            DateTime? fechaLimite = null;
            if (respuesta == "S")
            {
                Console.Write("Ingrese la fecha límite (DD/MM/AAAA): ");
                if (DateTime.TryParse(Console.ReadLine(), out DateTime fecha))
                {
                    fechaLimite = fecha;
                }
                else
                {
                    Console.WriteLine("Fecha invalida. Se agregara la tarea sin fecha límite");
                }
            }

            Tarea nuevaTarea = new Tarea(descripcion, fechaLimite);
            lista.AgregarTarea(nuevaTarea);
            Console.WriteLine("Tarea agregada exitosamente");
        }

        // Método para marcar una tarea como completada
        private void MarcarComoCompletada()
        {
            Console.Write("Ingrese el numero de la tarea a marcar como completada: ");
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                lista.MarcarComoCompletada(index - 1);
            }
            else
            {
                Console.WriteLine("Debe ingresar un numero");
            }
        }

        // Método para eliminar una tarea
        private void EliminarTarea()
        {
            Console.Write("Ingrese el numero de la tarea a eliminar: ");
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                lista.EliminarTarea(index - 1);
            }
            else
            {
                Console.WriteLine("Debe ingresar un numero");
            }
        }
    }
}
