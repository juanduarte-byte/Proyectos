// Variable para leer el resultado de entrada
string? leeResultado;

// Declaración de variables para almacenar los puntajes de las actividades y la calificación final
double puntajePracticas = 0.00;
double puntajeExamen = 0.00;
double puntajeTareas = 0.00;
double calificacionFinal = 0.00;

// Solicita al usuario ingresar las calificaciones de las tres actividades del alumno: Prácticas, Examen y Tareas
Console.WriteLine("Ingrese las tres actividades del alumno (Prácticas) (Examen) (Tareas)");

// Lee el puntaje de las prácticas, lo convierte a doble y aplica el porcentaje correspondiente
Console.Write("Prácticas: ");
leeResultado = Console.ReadLine();
if (leeResultado != null)
{
    puntajePracticas = double.Parse(leeResultado);
    puntajePracticas *= 0.55; // El puntaje de prácticas representa el 55% de la calificación final
}

// Lee el puntaje del examen, lo convierte a double y aplica el porcentaje correspondiente
Console.Write("Examen: ");
leeResultado = Console.ReadLine();
if (leeResultado != null)
{
    puntajeExamen = double.Parse(leeResultado);
    puntajeExamen *= 0.30; // El puntaje de examen representa el 30% de la calificación final
}

// Lee el puntaje de las tareas, lo convierte a doble y aplica el porcentaje correspondiente
Console.Write("Tareas: ");
leeResultado = Console.ReadLine();
if (leeResultado != null)
{
    puntajeTareas = double.Parse(leeResultado);
    puntajeTareas *= 0.15; // El puntaje de tareas representa el 15% de la calificación final
}

// Calcula la calificación final sumando los puntajes ponderados de las tres actividades
calificacionFinal = puntajePracticas + puntajeExamen + puntajeTareas;

// Muestra la calificación final del alumno
Console.Write($"La calificación final del alumno es de: {calificacionFinal}");
Console.WriteLine();