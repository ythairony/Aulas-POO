using System;

class Program {
  public static void Main() {
    Console.WriteLine("Informe um valor real: ");
    //int x = int.Parse(Console.ReadLine());
    int inicio, fim;
    Intervalo(double.Parse(Console.ReadLine()), out inicio, out fim);
    Console.WriteLine($" está entre {inicio} e {fim}");
    
  }
  public static void Intervalo(double x, out int inicio, out int fim) {
    int a = 0; 
    inicio = 0;
    fim = 0;
    while (a < x) {
      a++;
      if (a > x) {
        inicio = a - 1;
        fim = a;
      }
    }
  }
}