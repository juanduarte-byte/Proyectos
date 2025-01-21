//PromedioDeNumeros
//Se declaran variables para leer las respuestas del usuario y pasarla a otra variable.
string? leerRespuesta;
string respuesta = "";

//Variable que valida el número ingresado
bool validarNumero = false;

// Se usa este bucle con el fin de que todo se valide y si quiere salir del programa
do
{
    Console.Clear();

    //Se declaran e inicializan variables para la realización de la suma y también el promedio
    int numero = 0;
    int sumaNumeros = 0;
    int cantidadDeNumeros = 0;

    double promedio = 0.00;

    Console.WriteLine("Ingrese la cantidad de números a sumar y promediar:");
    leerRespuesta = Console.ReadLine();

    /* Si cumple que es diferente de null entonces procede a tratar de convertirlo a un entero, validarlo y realizar la suma con
    el bucle for*/
    if (leerRespuesta != null)
    {
        /*Se trata de convertir la variable leerRespuesta en un número y arroja true o false en validarNumero*/
        validarNumero = int.TryParse(leerRespuesta, out cantidadDeNumeros);
        
        //Si es un entero entonces procede a realizar la suma con números enteros, luego promediar para imprimir
        if (validarNumero)
        {
            Console.WriteLine("Ingrese los números: ");

            for (int i = 0; i < cantidadDeNumeros; i++)
            {
                do
                {
                    leerRespuesta = Console.ReadLine();
                    if (leerRespuesta != null)
                    {
                        validarNumero = int.TryParse(leerRespuesta, out numero);
                    }

                } while (validarNumero == false);

                sumaNumeros += numero;
            }

            promedio = sumaNumeros / cantidadDeNumeros;
            Console.WriteLine($"\nEl resultado de la suma es: {sumaNumeros}");
            Console.WriteLine($"El promedio es: {promedio}");
        }
        // Este código es una opción si no se pudo convertir cantidadNumero como un entero y vuelva a iniciar y poner todo bien de nuevo.
        else
        {
            Console.WriteLine("Ocurrió un error, lo ingresado no es un número entero");
        }
    }

    Console.WriteLine("De clic en enter para ir al inicio o escriba Exit si desea salir del programa");
    leerRespuesta = Console.ReadLine();
    if (leerRespuesta != null)
    {
        respuesta = leerRespuesta.ToLower();
    }

} while (respuesta != "exit");
