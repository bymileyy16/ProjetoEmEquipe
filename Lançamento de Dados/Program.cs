// See https://aka.ms/new-console-template for more information
using System;
class HelloWorld 
{
  static void Main() 
  {
    Console.Write("Insira o numero de jogadas: ");
    if (int.TryParse(Console.ReadLine(), out int jogadas))
    {
        for (int c = 1; c <= jogadas; c++)
        {
            Random random = new Random();
            int dados = random.Next(1, 6);
            Console.WriteLine($"Dado {c}: {dados}");
        }
    }
    else
    {
        Console.WriteLine("Numero Invalido");
    }
  }
}
