using System;

namespace TorresDeHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de la clase TorresHanoi
            TorresHanoi hanoi = new TorresHanoi();

            // Pedir al usuario el número de discos
            Console.Write("Ingrese el número de discos: ");
            int discos = int.Parse(Console.ReadLine());

            // Resolver el problema de las Torres de Hanói
            hanoi.ResolverHanoi(discos, 'A', 'C', 'B');
        }
    }

    class TorresHanoi
    {
        // Método recursivo para resolver el problema de las Torres de Hanói
        public void ResolverHanoi(int discos, char origen, char destino, char auxiliar)
        {
            // Caso base: Si solo hay un disco, moverlo directamente
            if (discos == 1)
            {
                Console.WriteLine($"Mover disco 1 de {origen} a {destino}");
                return;
            }

            // Mover n-1 discos de la torre origen a la torre auxiliar
            ResolverHanoi(discos - 1, origen, auxiliar, destino);

            // Mover el disco restante (el más grande) de origen a destino
            Console.WriteLine($"Mover disco {discos} de {origen} a {destino}");

            // Mover los n-1 discos de la torre auxiliar a la torre destino
            ResolverHanoi(discos - 1, auxiliar, destino, origen);
        }
    }
}