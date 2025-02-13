using System;

namespace AlimentosParaPerro
{
    public class Alimentos
    {
        //Método que obtiene la cantidad total de gramos respecto a los días de viaje y los convierte en kilogramos
        public double CalcularEnKilogramos(double numeroDias, double cantidadDeGramos = 0.00)
        {
            cantidadDeGramos = numeroDias * 750;
            return cantidadDeGramos / 1000;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Pedimos que ingrese los días de ausencia del usuario y le mostramos cuanto debe de dejarle de alimento a su perro
            Console.WriteLine("Ingrese los días que se va de viaje");
            int numeroDias = Convert.ToInt32(Console.ReadLine());

            //Creamos una instancia de la clase Alimentos con el fin de usar su método CalcularEnKilogramos()
            Alimentos alimentos = new Alimentos();

            Console.WriteLine($"La cantidad de alimento que se le debe de dejar a su pero es de {alimentos.CalcularEnKilogramos(numeroDias)} Kg");
        }
    }
}