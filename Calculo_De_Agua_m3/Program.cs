using System;

namespace AguaEnLitros
{
    public class Agua
    {
        public double ConverirEnLitros(double aguaMetrosCubic)
        {
            return aguaMetrosCubic * 1000;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingresa la cantidad de agua que está en metros cúbicos durante el mes");
            double aguaMetrosCubic = Convert.ToDouble(Console.ReadLine());

            Agua agua = new Agua();
            double cantidadDeAgua = agua.ConverirEnLitros(aguaMetrosCubic);

            Console.WriteLine($"La cantidad de agua que consume durante el mes en litros es de: {cantidadDeAgua} L");
        }
    }
}