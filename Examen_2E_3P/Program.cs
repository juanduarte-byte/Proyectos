using System;
using System.IO;
using System.Collections.Generic;

// Clase que representa un Producto
class Producto
{
    public string Codigo { get; set; }
    public string Nombre { get; set; }
    public int Cantidad { get; set; }
    public decimal Precio { get; set; }
}

// Clase que maneja el inventario
class Inventario
{
    private const string Archivo = "inventario.json";
    private List<Producto> productos = new List<Producto>();

    // Constructor: carga los productos al iniciar
    public Inventario()
    {
        CargarProductos();
    }

    // Carga productos desde archivo
    private void CargarProductos()
    {
        if (File.Exists(Archivo))
        {
            string[] lineas = File.ReadAllLines(Archivo);
            foreach (string linea in lineas)
            {
                string[] datos = linea.Split(',');
                productos.Add(new Producto
                {
                    Codigo = datos[0],
                    Nombre = datos[1],
                    Cantidad = int.Parse(datos[2]),
                    Precio = decimal.Parse(datos[3])
                });
            }
        }
    }

    // Guarda productos en archivo
    private void GuardarProductos()
    {
        List<string> lineas = new List<string>();
        foreach (var p in productos)
        {
            lineas.Add($"{p.Codigo},{p.Nombre},{p.Cantidad},{p.Precio}");
        }
        File.WriteAllLines(Archivo, lineas);
    }

    // Agrega un nuevo producto
    public void AgregarProducto(Producto producto)
    {
        productos.Add(producto); //Añade un producto a la línea y guarda el archivo
        GuardarProductos();
    }

    // Muestra todos los productos
    public void MostrarProductos()
    {
        if (productos.Count == 0)
        {
            Console.WriteLine("No hay productos registrados.");
            return;
        }

        foreach (var p in productos)
        {
            Console.WriteLine($"Código: {p.Codigo}, Nombre: {p.Nombre}, Stock: {p.Cantidad}, Precio: {p.Precio}");
        }
    }

    // Busca productos por código o nombre
    public void BuscarProductos(string termino)
    {
        var resultados = productos.FindAll(p => 
            p.Codigo.Contains(termino) || 
            p.Nombre.Contains(termino));

        if (resultados.Count == 0)
        {
            Console.WriteLine("No se encontraron productos.");
            return;
        }

        foreach (var p in resultados)
        {
            Console.WriteLine($"Código: {p.Codigo}, Nombre: {p.Nombre}, Stock: {p.Cantidad}, Precio: {p.Precio}");
        }
    }

    // Realiza una compra, ó de otra manera, reduce el stock.
    public void ComprarProducto(string codigo, int cantidad)
    {
        var producto = productos.Find(p => p.Codigo == codigo);
        
        if (producto == null)
        {
            Console.WriteLine("Producto no encontrado.");
            return;
        }

        if (producto.Cantidad >= cantidad)
        {
            producto.Cantidad -= cantidad;
            GuardarProductos();
            Console.WriteLine("Compra realizada. Stock actualizado.");
        }
        else
        {
            Console.WriteLine("Stock insuficiente.");
        }
    }
}

class Program
{
    static void Main()
    {
        Inventario inventario = new Inventario();
        bool salir = false;

        while (!salir)
        {
            MostrarMenu();
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarProducto(inventario);
                    break;
                case "2":
                    inventario.MostrarProductos();
                    break;
                case "3":
                    BuscarProducto(inventario);
                    break;
                case "4":
                    ComprarProducto(inventario);
                    break;
                case "5":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }

    // Muestra el menú principal
    static void MostrarMenu()
    {
        Console.WriteLine("\nSISTEMA DE INVENTARIO");
        Console.WriteLine("1. Agregar producto");
        Console.WriteLine("2. Mostrar todos los productos");
        Console.WriteLine("3. Buscar producto");
        Console.WriteLine("4. Comprar producto");
        Console.WriteLine("5. Salir");
        Console.Write("Seleccione una opción: ");
    }

    // Procesa para agregar un producto
    static void AgregarProducto(Inventario inventario)
    {
        Console.WriteLine("\nNUEVO PRODUCTO");
        
        Console.Write("Código: ");
        string codigo = Console.ReadLine();
        
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();
        
        Console.Write("Cantidad: ");
        int cantidad = int.Parse(Console.ReadLine());
        
        Console.Write("Precio: ");
        decimal precio = decimal.Parse(Console.ReadLine());

        inventario.AgregarProducto(new Producto 
        {
            Codigo = codigo,
            Nombre = nombre,
            Cantidad = cantidad,
            Precio = precio
        });

        Console.WriteLine("Producto agregado correctamente.");
    }

    // Procesa para buscar productos
    static void BuscarProducto(Inventario inventario)
    {
        Console.Write("\nIngrese término de búsqueda: ");
        string termino = Console.ReadLine();
        inventario.BuscarProductos(termino);
    }

    // Procesa para comprar productos
    static void ComprarProducto(Inventario inventario)
    {
        Console.Write("\nCódigo del producto a comprar: ");
        string codigo = Console.ReadLine();
        
        Console.Write("Cantidad a comprar: ");
        int cantidad = int.Parse(Console.ReadLine());
        
        inventario.ComprarProducto(codigo, cantidad);
    }
}