using System;

class MainClass {
  public static void Main() {
    Console.WriteLine("Informe o raio:");
    double a, c;
    Raio r = new Raio();
    r.SetRaio(double.Parse(Console.ReadLine()));
    a = r.CalcArea();
    c = r.CalcCircunferencia();
    Console.WriteLine($"Área do círculo = {a}");
    Console.WriteLine($"Circunferência do círculo = {c}");
    
  }
}

class Raio {
  private double r;
  public void SetRaio(double v) {
    if (v > 0) r = v;
  }
  
  public double GetRaio() {
    return r;
  }
  
  public double CalcArea() {
    double pi = 3.14159;
    return pi * Math.Pow(r, 2);
  }

  public double CalcCircunferencia() {
    double pi = 3.14159;
    return 2 * pi * r;
  }
}
