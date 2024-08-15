using System;

class Program
{
    static void Main()
    {
        double nota1, nota2, nota3, nota4, promedio;

        // Ingresar las 4 notas
        Console.WriteLine("Ingrese la primera nota:");
        nota1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la segunda nota:");
        nota2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la tercera nota:");
        nota3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la cuarta nota:");
        nota4 = Convert.ToDouble(Console.ReadLine());

        // Calcular el promedio
        promedio = (nota1 + nota2 + nota3 + nota4) / 4;

        // Mostrar el promedio
        Console.WriteLine("El promedio es: " + promedio);

        // Determinar y mostrar la observación según el promedio
        if (promedio < 70)
        {
            Console.WriteLine("Observación: Reprobado");
        }
        else if (promedio >= 70 && promedio <= 80)
        {
            Console.WriteLine("Observación: Bueno");
        }
        else if (promedio >= 81 && promedio <= 90)
        {
            Console.WriteLine("Observación: Muy Bueno");
        }
        else if (promedio >= 91 && promedio <= 100)
        {
            Console.WriteLine("Observación: Excelente");
        }
        else
        {
            Console.WriteLine("Observación: Nota fuera de rango válido.");
        }
    }
}

