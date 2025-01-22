// Variable para leer el resultado ingresado por el usuario
string? leeResultado;

// Inicialización del contador de números leídos
int contador = 0;
// Inicialización de la variable para almacenar el número ingresado
int numero = 0;

// Mensaje inicial que describe el propósito del programa
Console.WriteLine("Programa que lee e imprime una serie de números distintos de cero y muestra cuantos valores fueron ingresados");

do
{
    // Solicita al usuario ingresar un número distinto de cero o finalizar con cero
    Console.Write("Ingrese un número distinto de cero, si desea finalizar ingrese el cero: ");
    // Lee la entrada del usuario
    leeResultado = Console.ReadLine();
    // Verifica que la entrada no sea nula
    if (leeResultado != null)
    {
        // Convierte la entrada a un número entero
        numero = int.Parse(leeResultado);
        // Verifica si el número ingresado es distinto de cero
        if (numero != 0)
        {
            // Imprime el número ingresado
            Console.WriteLine($"\n{numero}");
            // Incrementa el contador de números leídos
            contador++;
        }
        else
        {
            // Mensaje indicando que se ha finalizado la entrada de números
            Console.WriteLine("\n Finalizó \n");
        }
    }
} while (numero != 0); // El bucle continúa mientras el número ingresado no sea cero

// Muestra el número total de valores leídos
Console.WriteLine($"El número de valores leídos son: {contador}\n");