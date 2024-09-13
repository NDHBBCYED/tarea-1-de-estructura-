// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // Declaración de un array de tuplas para almacenar nombres y calificaciones de los estudiantes
        var estudiantes = new (string nombre, double calificacion)[]
        {
            ("Ana", 85.5),
            ("Carlos", 92.0),
            ("Pedro", 76.8),
            ("Lucía", 89.4),
            ("María", 91.2)
        };

        // Mostrar los estudiantes y sus calificaciones
        Console.WriteLine("Lista de estudiantes y sus calificaciones:");
        foreach (var estudiante in estudiantes)
        {
            Console.WriteLine($"Nombre: {estudiante.nombre}, Calificación: {estudiante.calificacion}");
        }

        // Calcular el promedio de las calificaciones
        double sumaCalificaciones = 0;
        foreach (var estudiante in estudiantes)
        {
            sumaCalificaciones += estudiante.calificacion;
        }
        double promedio = sumaCalificaciones / estudiantes.Length;

        // Mostrar el promedio
        Console.WriteLine($"\nEl promedio de las calificaciones es: {promedio:F2}");

        // Encontrar la calificación más alta
        var mejorEstudiante = estudiantes[0];
        foreach (var estudiante in estudiantes)
        {
            if (estudiante.calificacion > mejorEstudiante.calificacion)
            {
                mejorEstudiante = estudiante;
            }
        }

        // Mostrar al estudiante con la mejor calificación
        Console.WriteLine($"\nEl estudiante con la mejor calificación es: {mejorEstudiante.nombre} con {mejorEstudiante.calificacion:F2}");
    }
}

