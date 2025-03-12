using System;

namespace InversionElementosDeArreglo
{
    public class Arreglos
    {
        // Método para mostrar el arreglo original
        public void MostrarArreglOrignal(int[] arreglOriginal)
        {
            foreach (int numero in arreglOriginal)
            {
                Console.WriteLine(numero);
            }
        }

        // Método para invertir y mostrar el arreglo
        public void InvertirArreglo(int[] arreglOriginal)
        {
            for (int i = arreglOriginal.Length - 1; i >= 0; i--) // Recorre el arreglo desde el final al inicio
            {
                Console.WriteLine(arreglOriginal[i]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[7]; // Arreglo para almacenar 7 números
            int readNumero = 0;

            // Solicitar al usuario que ingrese los números
            Console.WriteLine("Ingrese un número");
            readNumero = int.Parse(Console.ReadLine());
            numeros[0] = readNumero;

            for (int i = 1; i < 7; i++)
            {
                if (i < 6)
                {
                    Console.WriteLine("Ingrese otro número");
                }
                else
                {
                    Console.WriteLine("Ingrese el último número");
                }
                readNumero = int.Parse(Console.ReadLine());
                numeros[i] = readNumero;
            }

            // Crear una instancia de la clase Arreglos
            Arreglos arreglo = new Arreglos();

            // Mostrar el arreglo original
            Console.WriteLine("Estos son los elementos del arreglo original");
            arreglo.MostrarArreglOrignal(numeros);

            // Mostrar el arreglo invertido
            Console.WriteLine("Estos son los elementos del arreglo ya invertido");
            arreglo.InvertirArreglo(numeros);
        }
    }
}