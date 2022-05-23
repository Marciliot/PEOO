using System;

class Program{
  public static void Main() {
    Console.WriteLine("digite dois valores interios");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    if(a == b)
      Console.WriteLine("numeros iguais");
    if (a > b)
      Console.WriteLine($"Maior = {a}");
    if (b > a)
      Console.WriteLine($"Maior = {b}");
   
  
  }
}