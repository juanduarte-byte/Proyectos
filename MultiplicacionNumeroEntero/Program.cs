// Declaración de una cadena de texto que puede ser nula para leer el resultado del usuario
string? leeResultado;

// Declaración de variables enteras para almacenar el número ingresado y el resultado de la multiplicación
int numeroEntero = 0;
int resultado = 0;

// Declaración de una variable booleana para validar si el número ingresado es correcto
bool validaNumero = false;

// Mensaje que indica el propósito del programa
Console.WriteLine("Programa que multiplica un número entero por 2");

do
{
    // Solicita al usuario ingresar un número entero
    Console.Write("Ingresa un número entero: ");
    
    // Lee la entrada del usuario
    leeResultado = Console.ReadLine();
    
    // Verifica si la entrada no es nula
    if (leeResultado != null)
    {
        // Intenta convertir la entrada a un número entero y valida si la conversión fue exitosa
        validaNumero = int.TryParse(leeResultado, out numeroEntero);
    }
// Repite el ciclo mientras la entrada no sea un número entero válido
} while (validaNumero != true);

// Calcula el resultado de multiplicar el número entero por 2
resultado = 2 * numeroEntero;

// Muestra el resultado de la multiplicación
Console.WriteLine($"\n2 * {numeroEntero} = {resultado}");
