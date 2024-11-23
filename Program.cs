//Joel De Jesús Oseliz Reynoso
//Matrícula: 2023-1132

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculadora Básica");
        Console.WriteLine("Elige una operación:");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");
        int opcion = int.Parse(Console.ReadLine());

        Console.Write("Introduce el primer número: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Introduce el segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        double resultado = 0;

        switch (opcion)
        {
            case 1:
                resultado = num1 + num2;
                break;
            case 2:
                resultado = num1 - num2;
                break;
            case 3:
                resultado = num1 * num2;
                break;
            case 4:
                resultado = num1 / num2;
                break;
            default:
                Contole.WriteLine("Ha ocurrido algún error, revise y vuelva a intentarlo nuevamente.");
                break;
        }

        Console.WriteLine($"El resultado es: {resultado}");
    }
}
