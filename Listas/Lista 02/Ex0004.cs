using System;

class Program {
  public static void Main () {
    Console.WriteLine("Digite a base e a altura do retângulo");
    double baser = double.Parse(Console.ReadLine());
    double altura = double.Parse(Console.ReadLine());
    double area = baser * altura;
    double perimetro = 2 * (baser + altura);
    double diagonal = Math.Sqrt(Math.Pow(baser, 2) + Math.Pow(altura, 2));
    Console.WriteLine($"Área = {area:f2} - Perímetro = {perimetro:f2} - Diagonal = {diagonal:f2}");
  }
}