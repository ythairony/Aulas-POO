using System;

class Program {
  public static void Main() {
    Console.WriteLine("Informe um valor real: ");
    int x = int.Parse(Console.ReadLine());
    int inicio, fim;
    Intervalo(x, out inicio, out fim);
    Console.WriteLine($"{x} está entre {inicio} e {fim}");
    
  }
  public static void Intervalo(double x, out int inicio, out int fim) {
    int a = 0;
    while (a < x) {
      a++;
      if (a > x) {
        inicio = a - 1;
        fim = a;
      }
    }
  }
}