using System;
using System.Linq;

class Program
{
    static void Main()
    {
        //Solicitarle al usuario que ingrese 10 números
        int[] numeros = new int[10];

        Console.WriteLine("Por favor, ingresa 10 números:");

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        //Solicitarle al usuario el número que quiere eliminar
        Console.Write("Ingresa el número que deseas eliminar: ");
        int numeroEliminar = Convert.ToInt32(Console.ReadLine());

        //Eliminar el número del arreglo
        int[] nuevoArreglo = numeros.Where(n => n != numeroEliminar).ToArray();

        //Mostrar el nuevo arreglo
        Console.WriteLine("\nEl nuevo arreglo sin el número eliminado es:");
        foreach (int numero in nuevoArreglo)
        {
            Console.Write(numero + " ");
        }
    }
}