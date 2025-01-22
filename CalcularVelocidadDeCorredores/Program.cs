// Variable para leer la respuesta del usuario
string? leeRespuesta;
// Variable para almacenar la respuesta del usuario sobre continuar o salir
string respuesta = "";

// Variables para los minutos y segundos ingresados
int minutos, segundos;
// Distancia de la carrera en metros
double distancia = 1500.0;

do
{
    // Limpia la consola para una nueva entrada
    Console.Clear();
    // Mensaje al usuario para ingresar el tiempo
    Console.WriteLine("Ingrese el tiempo (minutos, segundos)");
    // Lee la respuesta del usuario
    leeRespuesta = Console.ReadLine();
    // Verifica que la entrada no sea nula
    if (leeRespuesta != null)
    {
        // Divide la entrada en minutos y segundos usando la coma como separador
        string[] partes = leeRespuesta.Split(',');

        // Convierte las partes a enteros
        minutos = int.Parse(partes[0]);
        segundos = int.Parse(partes[1]);

        // Verifica si el tiempo ingresado es (0, 0) para finalizar la entrada
        if (minutos == 0 && segundos == 0)
        {
            Console.WriteLine("Entrada Finalizada");
            break;
        }

        // Calcula el tiempo total en segundos (1 minuto = 60 segundos)
        int tiempoTotalSegundos = (minutos * 60) + segundos;

        // Calcula la velocidad en metros por segundo (m/s)
        double velocidad = distancia / tiempoTotalSegundos;

        // Imprime el tiempo ingresado y la velocidad calculada
        Console.WriteLine($"Tiempo: {minutos} minutos y {segundos} segundos");
        Console.WriteLine($"Velocidad: {velocidad:N4} m/s");
    }

    // Mensaje al usuario para continuar o salir
    Console.WriteLine("Si desea continuar de clic en enter, de lo contrario escriba Exit");
    // Lee la respuesta del usuario sobre continuar o salir
    leeRespuesta = Console.ReadLine();
    if (leeRespuesta != null)
        // Convierte la respuesta a minúsculas para estandarizar la comparación
        respuesta = leeRespuesta.ToLower();

} while (respuesta != "exit"); // Repite mientras la respuesta no sea "exit"