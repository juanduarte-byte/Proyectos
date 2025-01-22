// Declaramos las variables
string? leeNumero;
int numero = 0;

Console.WriteLine("Programa que determina si un número es primo");

Console.WriteLine("Ingrese un número");
// Leemos el número que el usuario ingresa
leeNumero = Console.ReadLine();
if (leeNumero != null)
{
    // Convertimos el texto ingresado a un número entero
    numero = int.Parse(leeNumero);
}

// Asumimos que el número es primo hasta que se demuestre lo contrario
bool esPrimo = true;

// Verificamos algunas condiciones básicas
if (numero <= 1)
{
    esPrimo = false; // Los números menores o iguales a 1 no son primos
}
else if (numero == 2)
{
    esPrimo = true; // El 2 es el único número primo par
}
else if (numero % 2 == 0)
{
    esPrimo = false; // Los números pares mayores que 2 no son primos
}
else
{
    // Verificamos si el número es divisible por algún número impar desde 3 hasta la raíz cuadrada del número ingresado
    for (int i = 3; i <= Math.Sqrt(numero); i += 2)
    {
        if (numero % i == 0)
        {
            esPrimo = false; // Si el número se divide exactamente, no es primo
            break; // Salimos del bucle si encontramos un divisor
        }
    }
}

// Imprimimos el resultado
if (esPrimo)
{
    Console.WriteLine($"{numero} es primo.");
}
else
{
    Console.WriteLine($"{numero} no es primo.");
}