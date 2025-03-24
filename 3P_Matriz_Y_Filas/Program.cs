using System;
class Program
{
    static void Main()
    {
        // Crear una matriz de 3x3
        int[,] matriz = new int[3, 3];

        Console.WriteLine("Ingresa los valores para la matriz de 3x3:");

        // Solicitar al usuario que ingrese los valores de la matriz, el motivo de las dos iteraciones es para que recorra la matriz de 3x3
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Fila {i + 1}, Columna {j + 1}: ");
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        //Solicitar al usuario un número para multiplicar cada fila
        Console.Write("Ingresa un número para multiplicar cada fila: ");
        int multiplicador = Convert.ToInt32(Console.ReadLine());

        // Multiplicar cada fila por el número ingresado
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matriz[i, j] *= multiplicador;
            }
        }

        // Mostrar la nueva matriz con los valores actualizados
        Console.WriteLine("\nLa nueva matriz es:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}