using System;

namespace AguaEnLitros
{
    public class Agua
    {
        //Realiza la conversión de metros cúbicos a litros
        public double ConverirEnLitros(double aguaMetrosCubic)
        {
            return aguaMetrosCubic * 1000;
        }
    }

    class Program
    {
        //En esta clase pedimos que ingrese la cantidad que consume la familia durante el mes en metros cúbicos
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingresa la cantidad de agua que está en metros cúbicos durante el mes");
            double aguaMetrosCubic = Convert.ToDouble(Console.ReadLine());

            //Creamos una instancia de la clase Agua y utilizamos su método para hacer la conversión
            Agua agua = new Agua();
            double cantidadDeAgua = agua.ConverirEnLitros(aguaMetrosCubic);

            //Se muestra el resultado en litros
            Console.WriteLine($"La cantidad de agua que consume durante el mes en litros es de: {cantidadDeAgua} L");
        }
    }
}