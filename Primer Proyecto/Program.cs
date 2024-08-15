
using System;

class Program
{
    static void Main()
    {
        double EdadMeses, Edad;
        string nombre;

        Console.WriteLine("Bienvenidos a nuestro primer programa creado en C#");
        Console.WriteLine("Ingrese su nombre para continuar");
        nombre = Console.ReadLine(); // Para Recibir Valores de Caracter
        Console.WriteLine("Ingrese su edad");
        Edad = Convert.ToDouble(Console.ReadLine()); // Convierte la entrada a double
        EdadMeses = Edad * 12; //Calculos matematicos
        Console.WriteLine("La edad en meses es: " + EdadMeses); //Concatenacion
        if (Edad >= 18)
        {
            Console.WriteLine("Usted es Mayor de Edad");
        }
        else
        {
            Console.WriteLine("Usted es Menor de Edad");
        }
    }
}
