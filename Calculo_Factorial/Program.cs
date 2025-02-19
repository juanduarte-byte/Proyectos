using System;

namespace FactoarialRecursivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial factorial = new Factorial();

            Console.WriteLine("Ingrese el número para calcular el factorial");
            int numero = int.Parse(Console.ReadLine());

            int resultado = factorial.CalcularFactorial(numero);

            Console.WriteLine($"El factorial de {numero} es: {resultado}");
        }
    }

    class Factorial
    {
        //Método recursivo para calcular el factorial
        public int CalcularFactorial(int numero)
        {
            //El caso base: el factorial de 0 o 1 es 1
            if (numero == 0 || numero == 1)
            {
                return 1;
            }
            else 
            {
                //LLamada recursiva
                return numero * CalcularFactorial(numero - 1);
            }
        }
    }
}