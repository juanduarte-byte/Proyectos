using System;

namespace CalculadoraPOO
{
    public class Operaciones
    {
        public double primerNumero { get; set;}
        public double segundoNumero { get; set;}

        //Constructor
        public Operaciones(double numero1, double numero2)
        {
            primerNumero = numero1;
            segundoNumero = numero2;
        }

        public double Sumar()
        {
            return primerNumero + segundoNumero;
        }

        public double Restar()
        {
            return primerNumero - segundoNumero;
        }

        public double Multiplicar()
        {
            return primerNumero * segundoNumero;
        }

        public double Dividir()
        {
            return primerNumero / segundoNumero;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            Operaciones operaciones = new Operaciones(numero1, numero2);

            Console.WriteLine("¿Qué operación quiere realizar? Ingrese el número de la opción elegida");
            Console.WriteLine("1.Sumar, 2.Restar, 3.Múltiplicar, 4.Dividir");
            string leeRespuesta = Console.ReadLine();

            switch (leeRespuesta)
            {
                case "1":
                    Console.WriteLine($"{numero1} + {numero2} = {operaciones.Sumar()}");
                    break;
                case "2":
                    Console.WriteLine($"{numero1} - {numero2} = {operaciones.Restar()}");
                    break;
                case "3":
                    Console.WriteLine($"{numero1} * {numero2} = {operaciones.Multiplicar()}");
                    break;
                case "4":
                    Console.WriteLine($"{numero1} / {numero2} = {operaciones.Dividir()}");
                    break;
                default:
                    Console.WriteLine("Error, no existe lo ingresado");
                    break;
            }
        }
    }
}