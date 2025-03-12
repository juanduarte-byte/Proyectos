using System;

namespace OrdenamientoDeNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de un arreglo para almacenar 7 números
            int[] numeros = new int[7];
            int readNum = 0;

            // Solicitar al usuario que ingrese 7 números
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Ingrese un número");
                readNum = int.Parse(Console.ReadLine());
                numeros[i] = readNum;
            }

            // Algoritmo de ordenamiento de burbuja
            int numeroElementos = numeros.Length;
            for (int i = 0; i < numeroElementos - 1; i++) // Recorrer el arreglo
            {
                for (int j = 0; j < numeroElementos - 1 - i; j++) // Comparar elementos adyacentes
                {
                    if (numeros[j] > numeros[j + 1]) // Intercambiar si están en el orden incorrecto
                    {
                        int numeroTemporal = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = numeroTemporal;
                    }
                }
            }

            // Mostrar el arreglo ordenado
            Console.WriteLine("\n  El orden correcto del arreglo es: \n");
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }
        }
    }
}