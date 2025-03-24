using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Paso 1: Solicitar al usuario que ingrese un texto
        Console.WriteLine("Por favor, escribe un texto:");
        string texto = Console.ReadLine();

        // Paso 2: Guardar el texto en un archivo
        string rutaArchivo = "texto.txt";

        try
        {
            using (StreamWriter writer = new StreamWriter(rutaArchivo))
            {
                writer.WriteLine(texto);
            }

            Console.WriteLine("\nEl texto ha sido guardado en 'texto.txt'.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ocurrió un error al guardar el texto: " + ex.Message);
        }

        // Paso 3: Leer el archivo y contar las palabras
        try
        {
            using (StreamReader reader = new StreamReader(rutaArchivo))
            {
                string contenido = reader.ReadToEnd();
                int cantidadPalabras = ContarPalabras(contenido);

                Console.WriteLine($"El texto contiene {cantidadPalabras} palabras.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ocurrió un error al leer el archivo: " + ex.Message);
        }
    }

    // Método para contar palabras en un texto
    static int ContarPalabras(string texto)
    {
        if (string.IsNullOrWhiteSpace(texto))
            return 0;

        // Dividir el texto en palabras usando espacios en blanco como separadores
        string[] palabras = texto.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        return palabras.Length;
    }
}