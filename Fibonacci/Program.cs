using System;

namespace Fibonacci
{
    class Program // Se crea la clase Program para pedir al usuario que ingrese el número de la posicón que desee
    {
        static void Main(string[] args)
        {
            //Se crea una instancia de la clase FormulaFibonacci
            FormulaFibonacci formulaFibonacci = new FormulaFibonacci();

            //Se le pide al usuario que ingrese la posición en la secuancia de Fibonacci
            Console.WriteLine("Ingrese la posición para calcular en la secuencia de Fibonacci");
            int numero = int.Parse(Console.ReadLine());

            int resultado = formulaFibonacci.Fibonacci(numero);

            //Se imprime el resultado de la posición dada
            Console.WriteLine($"El valor de Fibonacci en la posición ingresada es de: {resultado}");
        }
    }

    class FormulaFibonacci
    {
        //Se hace la recursividad para realizar con base a la posición dada el calculo en la secuancia de Fibonacci
        public int Fibonacci(int numero)
        {
            if (numero == 0) // Base, siempre empieza con el término 0
            {
                return 0;
            }
            else if (numero == 1) // Base, siempre empieza con el término 1
            {
                return 1;
            }
            else
            {
                //Se hace la función recursiva
                return Fibonacci (numero -1) + Fibonacci (numero - 2);
            }
        }
    }
}