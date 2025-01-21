string? leeRespuesta;

//Variable donde se guardarán lo ingresado por el usuario
string respuesta = "";

double primerNumero = 0.0;
double segundoNumero = 0.0;
double sumaNumeros = 0.0;
double restaNumeros = 0.0;
double multiplicacionNumeros = 0.0;
double divisionNumeros = 0.0;

do
{
    Console.Clear();

    Console.WriteLine("Calculadora Básica\n");

    /*Se dan dos instrucciones y para ingresar el primer número después valída su respuesta para pasarlo a una variable 
    declarado como entero: primerNumero. TENIENDO EN CUENTA QUE SOLO INGRESA NUMEROS*/
    Console.WriteLine("Ingrese dos números");
    Console.WriteLine("Ingrese el primero:");
    leeRespuesta = Console.ReadLine();
    if (leeRespuesta != null)
    {
        primerNumero = double.Parse(leeRespuesta);
    }

    /*Segunda instrucción para ingresar el segundo número y validar lo ingresado*/
    Console.WriteLine("Ingrese el segundo:");
    leeRespuesta = Console.ReadLine();
    if (leeRespuesta != null)
    {
        segundoNumero = double.Parse(leeRespuesta);
    }

    /*Después de ingresar los dos números se imprimen las operaciones a realizar y valida lo ingresado por el usuario*/
    Console.WriteLine("Elige la operación de desee que realice ingresando el número de la operación, si desea cambiar el número de clic en enter\n");
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Resta");
    Console.WriteLine("3. Multiplicación");
    Console.WriteLine("4. División");

    leeRespuesta = Console.ReadLine();
    if (leeRespuesta != null)
    {
        respuesta = leeRespuesta;
    }

    /*Teniendo en cuenta el menú, con el switch case se evalúa lo ingresado contemplando las opciones posibles para la 
    realización de las operaciones*/
    switch (respuesta)
    {
        case "1":
            Console.WriteLine();
            sumaNumeros = primerNumero + segundoNumero;
            Console.WriteLine($"{primerNumero} + {segundoNumero} = {sumaNumeros}\n");

            //Este código considera si desea continuar o salir del programa. Se utiliza en los cuatro casos
            Console.WriteLine("Si desea continuar de clic en Enter, de lo contrario escriba Exit");
            leeRespuesta = Console.ReadLine();
            if (leeRespuesta != null)
            {
                respuesta = leeRespuesta.ToLower();
            }
            break;
        case "2":
            Console.WriteLine();
            restaNumeros = primerNumero - segundoNumero;
            Console.WriteLine($"{primerNumero} - {segundoNumero} = {restaNumeros}\n");

            Console.WriteLine("Si desea continuar de clic en Enter, de lo contrario escriba Exit");
            leeRespuesta = Console.ReadLine();
            if (leeRespuesta != null)
            {
                respuesta = leeRespuesta.ToLower();
            }
            break;
        case "3":
            Console.WriteLine();
            multiplicacionNumeros = primerNumero * segundoNumero;
            Console.WriteLine($"{primerNumero} * {segundoNumero} = {multiplicacionNumeros}\n");

            Console.WriteLine("Si desea continuar de clic en Enter, de lo contrario escriba Exit");
            leeRespuesta = Console.ReadLine();
            if (leeRespuesta != null)
            {
                respuesta = leeRespuesta.ToLower();
            }
            break;
        case "4":
            Console.WriteLine();

            //Antes de continuar la división se evaluán los casos de división por cero para evitar errores
            if (primerNumero == 0 && segundoNumero == 0)
            {
                Console.WriteLine("Resultado indefinido");
            }
            else if (primerNumero > 0 && segundoNumero == 0)
            {
                Console.WriteLine("No se puede dividir entre cero");
            }
            else
            {
                divisionNumeros = primerNumero / segundoNumero;
                Console.WriteLine($"{primerNumero} / {segundoNumero} = {divisionNumeros}\n");
            }

            Console.WriteLine("Si desea continuar de clic en Enter, de lo contrario escriba Exit");
            leeRespuesta = Console.ReadLine();
            if (leeRespuesta != null)
            {
                respuesta = leeRespuesta.ToLower();
            }
            break;
    }

} while (respuesta != "exit");