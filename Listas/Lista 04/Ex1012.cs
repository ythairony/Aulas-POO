using System;

class Program {
  public static void Main() {
    string[] v = Console.ReadLine().Split();
    double pi = 3.14159;
    double triangulo = (double.Parse(v[0]) * double.Parse(v[2])) / 2;
    double circulo = Math.Pow(double.Parse(v[2]), 2) * pi;
    double trapezio = (double.Parse(v[0]) + double.Parse(v[1])) * double.Parse(v[2]) / 2;
    double quadrado = Math.Pow(double.Parse(v[1]), 2);
    double retangulo = double.Parse(v[0]) * double.Parse(v[1]);
    Console.WriteLine($"TRIANGULO: {triangulo:f3}");
    Console.WriteLine($"CIRCULO: {circulo:f3}");
    Console.WriteLine($"TRAPEZIO: {trapezio:f3}");
    Console.WriteLine($"QUADRADO: {quadrado:f3}");
    Console.WriteLine($"RETANGULO: {retangulo:f3}");
  }
}