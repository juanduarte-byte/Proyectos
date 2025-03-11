using System;

namespace OrdenamientoDeNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de un arreglo que limita el número, y variables que contendran números
            int[] numeros = new int [7];
            int readNum = 0;

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Ingrese un número");
                readNum = int.Parse(Console.ReadLine());

                numeros[i] = readNum;
            }

            Array.Sort(numeros);

            foreach (int num in numeros)
            {
                Console.WriteLine($"Aquí está el ordenamiento correcto: {num}");
            }
        }
    }
}