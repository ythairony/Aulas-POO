using System;

class MainClass {
  public static double Circuferencia(int raio) {
    double pi = 3.14159;
    double circ = 2 * pi * raio;
    return circ;
  }

  public static void Main() {
    Console.WriteLine("Informe o valor do raio do círculo");
    int r = int.Parse(Console.ReadLine());
    double c = Circuferencia(r);
    Console.WriteLine($"A circunferência do círculo de raio {r} é {c}");
  }
}