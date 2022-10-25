using System;

class Program {
  public static void Main(){
    Console.WriteLine("Informe um valor: ");
    double x = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe outro valor: ");
    double y = double.Parse(Console.ReadLine());
    double maior = Maior(x, y);
    Console.WriteLine($"O maior valor informado foi {maior}");
  }

  public static double Maior(double a, double b) {
    double maior;
    if (a >= b) maior = a;
    else maior = b;
    return maior;
  }
}