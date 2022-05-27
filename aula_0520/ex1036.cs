using System;

class Program{
  public static void Main() {
    string s = Console.ReadLine();
    string[] v = s.Split();
    double a = double.Parse(v[0]);
    double b = double.Parse(v[1]);
    double c = double.Parse(v[2]);
    double dela =  b * b - 4 * a * c;
    double r1 = (-b + Math.Sqrt(dela)) / (2 * a);
    double r2 = (-b + Math.Sqrt(dela)) / (2 * a);

    if ( dela < 0 || a == 0)
     Console.WriteLine("Impossivel calcular");
  else{
     Console.WriteLine($"R1 ={r1:f5}");
     Console.WriteLine($"R1 ={r1:f5}");
    }
  }
}
