string? leeResultado;

int numeroEntero = 0;
int resultado = 0;

bool validaNumero = false;

Console.WriteLine("Programa que multiplica un número entero por 2");
do
{
    Console.Write("Ingresa un número entero: ");
    leeResultado = Console.ReadLine();
    if (leeResultado != null)
    {
        validaNumero = int.TryParse(leeResultado, out numeroEntero);
    }
} while (validaNumero != true);

resultado = 2 * numeroEntero;
Console.WriteLine($"\n2 * {numeroEntero} = {resultado}");