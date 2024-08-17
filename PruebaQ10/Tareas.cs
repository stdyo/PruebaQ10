using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaQ10
{
    public class Tarea
    {
        // Propiedades de la tarea
        public string Descripcion { get; set; }
        public DateTime? FechaLimite { get; set; }
        public bool Completada { get; set; }

        // Constructor de la clase Tarea
        public Tarea(string descripcion, DateTime? fechaLimite = null)
        {
            Descripcion = descripcion;
            FechaLimite = fechaLimite;
            Completada = false; // Por defecto, una nueva tarea no está completada
        }

        // Método para convertir la tarea a una cadena de texto para mostrarla
        public override string ToString()
        {
            // Creamos una marca visual para indicar si la tarea está completada o no
            string estado = Completada ? "[X]" : "[ ]";

            // Formateamos la fecha límite o usamos un texto por defecto si no hay fecha
            string fecha = FechaLimite.HasValue ? FechaLimite.Value.ToShortDateString() : "Sin fecha límite";

            // Devolvemos la tarea formateada como texto
            return $"{estado} {Descripcion} - {fecha}";
        }
    }
}
