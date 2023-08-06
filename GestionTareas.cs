public class GestionTareas{

    private Tarea tarea1;
    public void gestionCrearTareas(Tarea tarea){
        this.tarea1 = tarea;
    }

    public void tareaCrear(){
        tarea1.agregar();
    }

    public void tareaModificar(){
        tarea1.modificar();
    }
    public void tareaEliminar(){
        tarea1.eliminar();
    }
}