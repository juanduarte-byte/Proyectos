using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Paso 1: Ingresar datos de productos
        Console.WriteLine("Ingrese los datos del producto:");
        
        Console.Write("Código del producto: ");
        string codigo = Console.ReadLine();
        
        Console.Write("Nombre del producto: ");
        string nombre = Console.ReadLine();
        
        Console.Write("Cantidad en stock: ");
        int cantidad = int.Parse(Console.ReadLine());
        
        Console.Write("Precio unitario: ");
        decimal precio = decimal.Parse(Console.ReadLine());

        // Paso 2: Guardar en archivo
        string linea = $"{codigo},{nombre},{cantidad},{precio}";
        File.AppendAllText("inventario.json", linea + Environment.NewLine);

        // Paso 3: Leer y mostrar archivo
        Console.WriteLine("\nProductos registrados:");
        if (File.Exists("inventario.json"))
        {
            string[] productos = File.ReadAllLines("inventario.json");
            foreach (string producto in productos)
            {
                //Lo hago para que cada palabra de la línea sea dividida y guardada en el arreglo datos para luego imprimirse de manera independiente
                string[] datos = producto.Split(',');
                Console.WriteLine($"Código: {datos[0]}, Nombre: {datos[1]}, Stock: {datos[2]}, Precio: {datos[3]}");
            }
        }
        else
        {
            Console.WriteLine("Se ha revisado y No hay productos registrados aún.");
        }
    }
}