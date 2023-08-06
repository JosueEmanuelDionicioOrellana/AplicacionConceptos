public class Tarea : ITarea{

    public void agregar(){
        Console.WriteLine("se agrego una tarea");
    }
    public void modificar(){
        Console.WriteLine("se modifico una tarea");
    }
    public void eliminar(){
        Console.WriteLine("se elimino una tarea");
    }

}