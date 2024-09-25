// See https://aka.ms/new-console-template for more information
using System;
using System.Threading;
class HelloWorld 
{
  static void Main() 
  {
    Console.Write("Insira quantos segundos o cronometro deve rodar: ");
    if (int.TryParse(Console.ReadLine(), out int segundos) && segundos > 0)
    {
        for (int c = segundos; c > 0; c--)
        {
            Console.WriteLine($"Tempo restante: {c} segundos");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Tempo esgotado!");
    }
    else
    {
        Console.WriteLine("Insira um tempo válido!");
    }
  }
}
