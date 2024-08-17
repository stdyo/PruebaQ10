using PruebaQ10;

public class Lista
{
    // Lista para almacenar las tareas
    private List<Tarea> tareas;

    // Constructor de la clase Lista
    public Lista()
    {
        tareas = new List<Tarea>();
    }

    // Método para agregar una nueva tarea a la lista
    public void AgregarTarea(Tarea tarea)
    {
        tareas.Add(tarea);
    }

    // Método para mostrar todas las tareas en la lista
    public void ListarTareas()
    {
        if (tareas.Count == 0)
        {
            Console.WriteLine("No hay tareas en la lista");
            return;
        }

        for (int i = 0; i < tareas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tareas[i]}");
        }
    }

    // Método para marcar una tarea como completada
    public void MarcarComoCompletada(int index)
    {
        if (index >= 0 && index < tareas.Count)
        {
            tareas[index].Completada = true;
            Console.WriteLine("Tarea marcada como completada");
        }
        else
        {
            Console.WriteLine("Indice de tarea invalido");
        }
    }

    // Método para eliminar una tarea de la lista
    public void EliminarTarea(int index)
    {
        if (index >= 0 && index < tareas.Count)
        {
            tareas.RemoveAt(index);
            Console.WriteLine("Tarea eliminada.");
        }
        else
        {
            Console.WriteLine("Indice de tarea invalido");
        }
    }
}