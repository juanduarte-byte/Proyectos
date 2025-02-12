using System;

namespace MostrarNombres
{
    // Clase que contiene el método para mostrar el nombre y apellido
    public class Nombres 
    {
        // Método que muestra el nombre y apellido en dos formatos diferentes
        public void MostrarNombre(string nombre, string apellido)
        {
            // Muestra el nombre y apellido en el orden: Nombre Apellido
            Console.WriteLine($"{nombre} {apellido}");

            // Muestra el apellido y nombre en el orden: Apellido Nombre
            Console.WriteLine($"{apellido} {nombre}");
        }
    }

    // Clase principal del programa
    class Program 
    {
        // Método principal que se ejecuta al iniciar el programa
        static void Main(string[] args)
        {
            // Pide al usuario que ingrese su nombre
            Console.WriteLine("Escriba su nombre:");
            string? leeNombre = Console.ReadLine(); // Lee el nombre ingresado

            string nombre = ""; // Variable para almacenar el nombre
            if (leeNombre != null) // Verifica si se ingresó un nombre
            {
                nombre = leeNombre; // Asigna el nombre ingresado a la variable
            }

            // Pide al usuario que ingrese su apellido
            Console.WriteLine("Escriba su apellido");
            string? leeApellido = Console.ReadLine(); // Lee el apellido ingresado

            string apellido = ""; // Variable para almacenar el apellido
            if (leeApellido != null) // Verifica si se ingresó un apellido
            {
                apellido = leeApellido; // Asigna el apellido ingresado a la variable
            }

            // Mensaje de confirmación de que el proceso fue exitoso
            Console.WriteLine("\nÉxito en el proceso..\n");

            // Crea un objeto de la clase Nombres
            Nombres nombres = new Nombres();

            // Llama al método para mostrar el nombre y apellido en los dos formatos
            nombres.MostrarNombre(nombre, apellido);
        }
    }
}