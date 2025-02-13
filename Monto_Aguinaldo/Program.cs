using System;

namespace CalculoAguinaldo
{
    // Clase principal que representa a un Trabajador
    class Trabajador
    {
        // Atributo para almacenar el salario mensual
        public double SalarioMensual { get; set; }

        // Constructor para inicializar el salario mensual
        public Trabajador(double salarioMensual)
        {
            SalarioMensual = salarioMensual;
        }

        // Método para calcular el aguinaldo
        public double CalcularAguinaldo()
        {
            // Calcular el salario diario (asumiendo 30 días al mes)
            double salarioDiario = SalarioMensual / 30;

            // Calcular el aguinaldo (15 días de salario)
            double aguinaldo = salarioDiario * 15;

            return aguinaldo;
        }
    }

    // Clase principal del programa
    class Program
    {
        static void Main(string[] args)
        {
            // Se le pide al usuario que ingrese su salario mensual
            Console.Write("Ingresa tu salario mensual: ");
            double salarioMensual = Convert.ToDouble(Console.ReadLine());

            // Creamos un objeto de la clase Trabajador
            Trabajador trabajador = new Trabajador(salarioMensual);

            // Calcular el aguinaldo usando el método de la clase Trabajador
            double aguinaldo = trabajador.CalcularAguinaldo();

            // Se muestra el resultado el resultado
            Console.WriteLine("El monto de tu aguinaldo es: " + aguinaldo.ToString("C"));
        }
    }
}