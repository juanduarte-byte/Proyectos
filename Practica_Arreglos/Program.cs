using System; 

public class Estudiante
{
    //Atributo que es un arreglo de calificaiones
    private int[] calificaciones;

    //Constructor para inicializar el arreglo
    public Estudiante(int[] calificaciones)
    {
        this.calificaciones = calificaciones;
    }

    //Método para mostrar las calificaciones
    public void MostrarCalificaciones()
    {
        Console.WriteLine("Calificaciones:");
        foreach (int calificacion in calificaciones)
        {
            Console.WriteLine(calificacion);
        }
    }
}

//Uso de la clase
class Program
{
    static void Main(string[] args)
    {
        int[] calificaciones = { 85, 90, 78, 92, 88 };
        Estudiante estudiante = new Estudiante(calificaciones);
        estudiante.MostrarCalificaciones();
    }
}