using System;
class HelloWorld 
{
  static void Main() 
  {
    Console.WriteLine("Qual o tamanho da senha?");
    if (int.TryParse(Console.ReadLine(), out int caracteres))
    {
     string possivel = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
    Random random = new Random();
    char[] senha = new char[caracteres];
    for (int i = 0; i < caracteres; i++)
    {
        senha[i] = possivel[random.Next(possivel.Length)];
    }
    Console.Write(senha);
    }
    else
    {
        Console.WriteLine("Numero invalido");
    }
  }
}