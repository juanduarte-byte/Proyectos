using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Paso 1: Solicitar al usuario ingresar 5 nombres
        string[] nombres = new string[5];
        Console.WriteLine("Por favor, ingresa 5 nombres:");

        for (int i = 0; i < nombres.Length; i++)
        {
            Console.Write($"Nombre {i + 1}: ");
            nombres[i] = Console.ReadLine();
        }

        // Paso 2: Guardar los nombres en un archivo de texto
        string rutaArchivo = "nombres.txt";

        try
        {
            // Escribir los nombres en el archivo
            using (StreamWriter writer = new StreamWriter(rutaArchivo))
            {
                foreach (string nombre in nombres)
                {
                    writer.WriteLine(nombre);
                }
            }

            Console.WriteLine("Los nombres han sido guardados en el archivo 'nombres.txt'.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ocurrió un error al guardar los nombres: " + ex.Message);
        }

        // Paso 3: Leer los nombres desde el archivo y mostrarlos en pantalla
        Console.WriteLine("\nLeyendo los nombres desde el archivo 'nombres.txt':");

        try
        {
            using (StreamReader reader = new StreamReader(rutaArchivo))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ocurrió un error al leer los nombres: " + ex.Message);
        }
    }
}
