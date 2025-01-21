string? leerRespuesta;
string respuesta = "";
string tipoDeTriangulo = "";

do
{
    double ladoA = 0.00;
    double ladoB = 0.00;
    double ladoC = 0.00;

    Console.Clear();

    Console.WriteLine("Ingrese la longitud del lado a");
    leerRespuesta = Console.ReadLine();
    if (leerRespuesta != null)
    {
        ladoA = double.Parse(leerRespuesta);
    }

    Console.WriteLine("Ingrese la longitud del lado b");
    leerRespuesta = Console.ReadLine();
    if (leerRespuesta != null)
    {
        ladoB = double.Parse(leerRespuesta);
    }

    Console.WriteLine("Ingrese la longitud del lado c");
    leerRespuesta = Console.ReadLine();
    if (leerRespuesta != null)
    {
        ladoC = double.Parse(leerRespuesta);
    }

    //Validamos cada uno de los valores dados para determinar qué tipo de triángulo es
    if (ladoA == ladoB && ladoB == ladoC)
    {
        tipoDeTriangulo = "Equilátero";
    }
    else if (ladoA == ladoB || ladoB == ladoC || ladoC == ladoA)
    {
        tipoDeTriangulo = "Isósceles";
    }
    else
    {
        tipoDeTriangulo = "Escaleno";
    }

    Console.WriteLine();
    Console.WriteLine($"El triángulo es un {tipoDeTriangulo}");
    Console.WriteLine($"El área del triángulo {tipoDeTriangulo} es: {CalcularArea(ladoA, ladoB, ladoC)}\n");

    Console.WriteLine("Si desea continuar de clic en enter, de lo contrario escriba Exit");
    leerRespuesta = Console.ReadLine();
    if (leerRespuesta != null)
    {
        respuesta = leerRespuesta.ToLower();
    }

} while (respuesta != "exit");

double CalcularArea(double ladoA, double ladoB, double ladoC)
{
    double semiPerimetro = 0.00;
    double calculoParaArea = 0.00;
    double areaDelTriangulo = 0.00;

    semiPerimetro = (ladoA + ladoB + ladoC) / 2;
    calculoParaArea = (semiPerimetro) * (semiPerimetro - ladoA) * (semiPerimetro - ladoB) * (semiPerimetro - ladoC);
    return areaDelTriangulo = Math.Sqrt(calculoParaArea);
}