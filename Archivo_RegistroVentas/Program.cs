using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        //Solicitar al usuario que ingrese las ventas del día
        Console.WriteLine("Registro de Ventas del Día");
        Console.WriteLine("Ingresa los datos de las ventas (nombre del producto, cantidad vendida, precio unitario).");
        Console.WriteLine("Escribe 'fin' para terminar.");

        string rutaArchivo = "ventas.csv";

        using (StreamWriter writer = new StreamWriter(rutaArchivo))
        {
            while (true)
            {
                Console.Write("Nombre del producto: ");
                string nombre = Console.ReadLine();

                if (nombre.ToLower() == "fin")
                    break;

                Console.Write("Cantidad vendida: ");
                int cantidad = Convert.ToInt32(Console.ReadLine());

                Console.Write("Precio unitario: ");
                double precio = Convert.ToDouble(Console.ReadLine());

                // Guardar la venta en el archivo CSV
                writer.WriteLine($"{nombre},{cantidad},{precio}");
            }
        }

        Console.WriteLine("Las ventas han sido guardadas en 'ventas.csv'.");

        //Leer el archivo y calcular el total de ventas del día
        double totalVentas = 0;

        try
        {
            using (StreamReader reader = new StreamReader(rutaArchivo))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    string[] datos = linea.Split(',');
                    string nombre = datos[0];
                    int cantidad = Convert.ToInt32(datos[1]);
                    double precio = Convert.ToDouble(datos[2]);

                    double totalVenta = cantidad * precio;
                    totalVentas += totalVenta;

                    Console.WriteLine($"{nombre}: {cantidad} x {precio:C} = {totalVenta:C}");
                }
            }

            Console.WriteLine($"\nTotal de ventas del día: {totalVentas:C}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ocurrió un error al leer el archivo: " + ex.Message);
        }
    }
}
