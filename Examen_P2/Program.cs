using System;

// Definición de la clase
public class Producto // clase Producto
{
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public string Codigo { get; set; }

    public Producto (string nombre, double precio, string codigo) //clase Producto
    {
        Nombre = nombre;
        Precio = precio;
        Codigo = codigo;
    }

    public void MostrarInformacion() //Muestra la información de cada producto
    {
        Console.WriteLine($"Nombre: {Nombre}, Código: {Codigo}, Precio: {Precio}");
    }
}

// Clase Tienda
public class Tienda
{
    private Producto[] productos;
    private int contadorProductos;

    public Tienda (int capacidadInicial)
    {
        productos = new Producto[capacidadInicial]; // uso la variable productos
        contadorProductos = 0;
    }

    public void AgregarProducto() 
    {
        if (contadorProductos < productos.Length)
        {
            Console.Write("Ingrese el nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el precio: ");
            double precio = double.Parse(Console.ReadLine());

            string codigo;
            do
            {
                Console.Write("Ingrese el código (8 dígitos): ");
                codigo = Console.ReadLine();
            } while (codigo.Length != 8 || !EsNumeroValido(codigo)); //Aqí le agrego más especifícaciones que tiene que cumplir lo ingresado

            Producto nuevoProducto = new Producto(nombre, precio, codigo);
            productos[contadorProductos] = nuevoProducto;
            contadorProductos++;
        }
        else
        {
            Console.WriteLine("Ha alcanzado su capacidad máxima de productos.");
        }
    }

    private bool EsNumeroValido(string numero) //Utilizo este método para que me valide si lo que pone el usuario son digitos
    {
        foreach (char c in numero)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }
        return true;
    }

    public void MostrarProductos()
    {
        for (int i = 0; i < contadorProductos; i++)
        {
            productos[i].MostrarInformacion();
        }
    }

    public double CalcularPrecio()
    {
        return CalcularPrecioRecursivo(0);
    }

    private double CalcularPrecioRecursivo(int indice)
    {
        if (indice >= contadorProductos)
        {
            return 0;
        }
        return productos[indice].Precio + CalcularPrecioRecursivo(indice + 1);
    }
}

// Clase principal para probar el programa
public class Program
{
    public static void Main()
    {
        Tienda tienda = new Tienda (10); // Capacidad inicial para 10 productos

        string opcion = "";
        do
        {
            Console.Clear();

            Console.WriteLine("\n Menú:");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Mostrar productos");
            Console.WriteLine("3. Calcular precio total");
            Console.Write("Seleccione una opción: ");
            opcion = Console.ReadLine();

            //Utilizamos un switch para cada caso que elija el usuario
            switch (opcion)
            {
                case "1":
                    tienda.AgregarProducto();

                    Console.WriteLine("Si desea continuar de clic en Enter, de lo contrario escriba Exit");
                    opcion = Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("\n Información de todos los productos: \n");
                    tienda.MostrarProductos();

                    Console.WriteLine("Si desea continuar de clic en Enter, de lo contrario escriba Exit");
                    opcion = Console.ReadLine();
                    break;
                case "3":
                    double precioTotal = tienda.CalcularPrecio();
                    Console.WriteLine($"Precio total de todos los productos: {precioTotal}");

                    Console.WriteLine("Si desea continuar de clic en Enter, de lo contrario escriba Exit");
                    opcion = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    Console.WriteLine("Si desea continuar de clic en Enter, de lo contrario escriba Exit");
                    opcion = Console.ReadLine();
                    break;
            }
        } while (opcion != "exit");
    }
}