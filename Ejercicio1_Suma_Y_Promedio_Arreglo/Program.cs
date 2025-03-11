using System;

namespace EjercicioUno
{
    public class Operaciones //Creo una clase que tiene un método que saca el promedio de los números ingresados
    {
        public double SumaTotal { get; set; }

        public Operaciones (double sumaTotal) //Constructor para la suma total ingresado
        {
            this.SumaTotal = sumaTotal;
        }

        public double SacarPromedio() //Método que saca el promedio con base a la suma total ingresado
        {
            return SumaTotal/10;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de un arreglo que limita el número, y variables que contendran números
            int[] numeros = new int [10];
            int readNum = 0;
            int sumaDeNumeros = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un número");
                readNum = int.Parse(Console.ReadLine());

                numeros[i] = readNum;
            }

            foreach (int num in numeros)
            {
                sumaDeNumeros += num;
            }

            Operaciones operaciones = new Operaciones(sumaDeNumeros);
            double promedio = operaciones.SacarPromedio();

            Console.WriteLine($"La suma total es de: {sumaDeNumeros}");
            Console.WriteLine($"El promedio es de: {promedio}");
        }
    }
}