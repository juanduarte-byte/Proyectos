using System;

// Definición de la clase CuentaBancaria
public class CuentaBancaria
{
    public string Titular { get; set; }
    public double Saldo { get; set; }
    public string NumeroCuenta { get; set; }

    public CuentaBancaria(string titular, double saldoInicial, string numeroCuenta)
    {
        Titular = titular;
        Saldo = saldoInicial;
        NumeroCuenta = numeroCuenta;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Titular: {Titular}, Número de Cuenta: {NumeroCuenta}, Saldo: {Saldo}");
    }
}

// Definición de la clase Banco
public class Banco
{
    private CuentaBancaria[] cuentas;
    private int contadorCuentas;

    public Banco(int capacidadInicial)
    {
        cuentas = new CuentaBancaria[capacidadInicial];
        contadorCuentas = 0;
    }

    public void AgregarCuenta()
    {
        if (contadorCuentas < cuentas.Length)
        {
            Console.Write("Ingrese el nombre del titular: ");
            string titular = Console.ReadLine();

            Console.Write("Ingrese el saldo inicial: ");
            double saldoInicial = double.Parse(Console.ReadLine());

            string numeroCuenta;
            do
            {
                Console.Write("Ingrese el número de cuenta (8 dígitos): ");
                numeroCuenta = Console.ReadLine();
            } while (numeroCuenta.Length != 8 || !EsNumeroValido(numeroCuenta));

            CuentaBancaria nuevaCuenta = new CuentaBancaria(titular, saldoInicial, numeroCuenta);
            cuentas[contadorCuentas] = nuevaCuenta;
            contadorCuentas++;
        }
        else
        {
            Console.WriteLine("El banco ha alcanzado su capacidad máxima de cuentas.");
        }
    }

    private bool EsNumeroValido(string numero)
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

    public void MostrarCuentas()
    {
        for (int i = 0; i < contadorCuentas; i++)
        {
            cuentas[i].MostrarInformacion();
        }
    }

    public double CalcularSaldoTotal()
    {
        return CalcularSaldoTotalRecursivo(0);
    }

    private double CalcularSaldoTotalRecursivo(int indice)
    {
        if (indice >= contadorCuentas)
        {
            return 0;
        }
        return cuentas[indice].Saldo + CalcularSaldoTotalRecursivo(indice + 1);
    }
}

// Clase principal para probar el programa
public class Program
{
    public static void Main()
    {
        Banco banco = new Banco(10); // Capacidad inicial para 10 cuentas

        string opcion = "";
        do
        {
            Console.Clear();

            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Agregar cuenta");
            Console.WriteLine("2. Mostrar cuentas");
            Console.WriteLine("3. Calcular saldo total");
            Console.Write("Seleccione una opción: ");
            opcion = Console.ReadLine();

            //Poner que lea al usuario para que se vea la información de cada opción
            switch (opcion)
            {
                case "1":
                    banco.AgregarCuenta();

                    Console.WriteLine("Si desea continuar de clic en Enter, de lo contrario escriba Exit");
                    opcion = Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("\n Información de todas las cuentas:\n");
                    banco.MostrarCuentas();

                    Console.WriteLine("Si desea continuar de clic en Enter, de lo contrario escriba Exit");
                    opcion = Console.ReadLine();
                    break;
                case "3":
                    double saldoTotal = banco.CalcularSaldoTotal();
                    Console.WriteLine($"Saldo total de todas las cuentas: {saldoTotal}");

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