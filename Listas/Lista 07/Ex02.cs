using System;

class Program {
  public static void Main() {
    int x, y, z;
    Console.WriteLine("Informe o primeiro valor: ");
    x = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o segundo valor: ");
    y = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o terceiro valor: ");
    z = int.Parse(Console.ReadLine());
    Ordenar(ref x, ref y, ref z);
    Console.WriteLine($"A ordem crescente dos valores são {x}, {y} e {z}.");
  }
  
  public static void Ordenar(ref int x, ref int y, ref int z) {
    int a;
    if (x > y) {
      a = x;
      x = y;
      y = a;
    }

    if (x > z) {
      a = x;
      x = z;
      z = a;
    }

    if (y > z) {
      a = y;
      y = z;
      z = a;
    }

  }
}