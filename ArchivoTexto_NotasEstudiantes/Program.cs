using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Paso 1: Solicitar datos de los estudiantes y guardarlos en un archivo
        string rutaArchivo = "notas.txt";

        Console.WriteLine("Ingrese los datos de los estudiantes (nombre y 3 calificaciones).");
        Console.WriteLine("Escriba 'fin' para terminar.");

        using (StreamWriter writer = new StreamWriter(rutaArchivo))
        {
            while (true)
            {
                Console.Write("Nombre del estudiante: ");
                string nombre = Console.ReadLine();

                if (nombre.ToLower() == "fin")
                    break;

                Console.Write("Calificación 1: ");
                double calif1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Calificación 2: ");
                double calif2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Calificación 3: ");
                double calif3 = Convert.ToDouble(Console.ReadLine());

                // Guardar los datos en el archivo
                writer.WriteLine($"{nombre},{calif1},{calif2},{calif3}");
            }
        }

        Console.WriteLine("Datos de los estudiantes guardados en 'notas.txt'.");

        // Paso 2: Leer el archivo y calcular el promedio de cada estudiante
        Console.WriteLine("\nPromedios de los estudiantes:");

        using (StreamReader reader = new StreamReader(rutaArchivo))
        {
            string linea;
            while ((linea = reader.ReadLine()) != null)
            {
                string[] datos = linea.Split(',');
                string nombre = datos[0];
                double calif1 = Convert.ToDouble(datos[1]);
                double calif2 = Convert.ToDouble(datos[2]);
                double calif3 = Convert.ToDouble(datos[3]);

                double promedio = (calif1 + calif2 + calif3) / 3;

                Console.WriteLine($"{nombre}: {promedio:F2}");
            }
        }
    }
}