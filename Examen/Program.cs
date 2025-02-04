using System;

namespace CalculadorDeVentas
{
    public class CochinitaFeliz
    {
        public double CantidadDeTortas { get; set; }
        public double CantidadDeTacos { get; set; }

        public CochinitaFeliz(double cantidadDeTortas, double cantidadDeTacos)
        {
            CantidadDeTortas = cantidadDeTortas;
            CantidadDeTacos = cantidadDeTacos;
        }

        public double CalcularTotalUnidades()
        {
            return CantidadDeTortas + CantidadDeTacos;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double totalTortas = 0.00;
            double totalTacos = 0.00;

            string respuesta;

            do
            {
                Console.WriteLine("Ingrese la cantidad de tortas:");
                double tortas = Convert.ToDouble(Console.ReadLine());
                totalTortas += tortas;

                Console.WriteLine("Ingrese la cantidad de tacos:");
                double tacos = Convert.ToDouble(Console.ReadLine());
                totalTacos += tacos;

                Console.WriteLine("Si desea continuar ingrese ENTER, si no escriba EXIT:");
                respuesta = Console.ReadLine()?.ToLower() ?? "";

            } while (respuesta != "exit");

            CochinitaFeliz cochinitaFeliz = new CochinitaFeliz(totalTortas, totalTacos);

            double totalUnidades = cochinitaFeliz.CalcularTotalUnidades();

            Console.WriteLine($"La cantidad de tortas vendidas es: {totalTortas}");
            Console.WriteLine($"La cantidad de tacos vendidos es: {totalTacos}");
            Console.WriteLine($"El total de unidades vendidas es: {totalUnidades}");
        }
    }
}