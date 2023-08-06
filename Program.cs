namespace Concurrencia;
class Program
{
    static void Main(string[] args)
    {
        Tarea tarea = new Tarea();
        GestionTareas tareas = new GestionTareas();

        tareas.gestionCrearTareas(tarea);

        Thread thread1 = new Thread(tareas.tareaCrear());

        thread1.Start();
        thread1.Join();

        Console.WriteLine("Exiting...");


    }
}
