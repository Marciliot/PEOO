using System;

class Program{
  public static void Main(){
    Console.WriteLine("Informe o numéro do mês");
    string mes = Console.ReadLine();
    switch (mes) {
      case "1" : Console.Write("janeiro"); break;
      case "2" : Console.Write("feverio"); break;
      case "3" : Console.Write("março"); break;
      case "4" : Console.Write("abril"); break;
      case "5" : Console.Write("maio"); break;
      case "6" : Console.Write("junho"); break;
      case "7" : Console.Write("julho"); break;
      case "8" : Console.Write("agosto"); break;
      case "9" : Console.Write("outubro"); break;
      case "10" : Console.Write("setembro"); break;
      case "11" : Console.Write("novembro"); break;
      case "12" : Console.Write("dezembro"); break; 
      default : Console.WriteLine("valor inválido"); break;
        
    }
    
    
  }
}