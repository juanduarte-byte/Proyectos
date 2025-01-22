string? leeResultado;

double puntajePracticas = 0.00;
double puntajeExamen = 0.00;
double puntajeTareas = 0.00;
double calificacionFinal = 0.00;

Console.WriteLine("Ingrese las tres actividades del alumno (Prácticas) (Examen) (Tareas)");

Console.Write("Prácticas: ");
leeResultado = Console.ReadLine();
if (leeResultado != null)
{
    puntajePracticas = double.Parse(leeResultado);
    puntajePracticas *= 0.55;
}

Console.Write("Examen: ");
leeResultado = Console.ReadLine();
if (leeResultado != null)
{
    puntajeExamen = double.Parse(leeResultado);
    puntajeExamen *= 0.30;
}

Console.Write("Tareas: ");
leeResultado = Console.ReadLine();
if (leeResultado != null)
{
    puntajeTareas = double.Parse(leeResultado);
    puntajeTareas *= 0.15;
}

calificacionFinal = puntajePracticas + puntajeExamen + puntajeTareas;

Console.Write($"La calificación final del alumno es de: {calificacionFinal}");
Console.WriteLine();