using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Conversor de Temperatura");
        Console.WriteLine("Escolha a conversão:");
        Console.WriteLine("a) Celsius para Fahrenheit");
        Console.WriteLine("b) Celsius para Kelvin");
        Console.WriteLine("c) Fahrenheit para Celsius");
        Console.WriteLine("d) Fahrenheit para Kelvin");
        Console.WriteLine("e) Kelvin para Celsius");
        Console.WriteLine("f) Kelvin para Fahrenheit");
        
        char escolha = Console.ReadKey().KeyChar;
        Console.WriteLine("\nDigite a temperatura:");

        double temperatura = Convert.ToDouble(Console.ReadLine());
        double resultado;

        switch (escolha)
        {
            case 'a':
                resultado = (temperatura * 9 / 5) + 32;
                Console.WriteLine($"{temperatura}°C = {resultado}°F");
                break;
            case 'b':
                resultado = temperatura + 273.15;
                Console.WriteLine($"{temperatura}°C = {resultado}K");
                break;
            case 'c':
                resultado = (temperatura - 32) * 5 / 9;
                Console.WriteLine($"{temperatura}°F = {resultado}°C");
                break;
            case 'd':
                resultado = (temperatura - 32) * 5 / 9 + 273.15;
                Console.WriteLine($"{temperatura}°F = {resultado}K");
                break;
            case 'e':
                resultado = temperatura - 273.15;
                Console.WriteLine($"{temperatura}K = {resultado}°C");
                break;
            case 'f':
                resultado = (temperatura - 273.15) * 9 / 5 + 32;
                Console.WriteLine($"{temperatura}K = {resultado}°F");
                break;
            default:
                Console.WriteLine("Escolha inválida.");
                break;
        }
    }
}

