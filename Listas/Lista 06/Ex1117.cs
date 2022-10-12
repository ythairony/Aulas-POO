using System;

class Program {
  public static void Main() {
    double nota, soma, mediaFinal;
    soma = 0;
    int testes = 0;
    while (testes != 2) {
      nota = double.Parse(Console.ReadLine());
      if (nota >= 0 && nota <= 10) {
        soma = soma + nota;
        testes += 1;
      } else Console.WriteLine("nota invalida");
    }
    mediaFinal = soma / 2;
    Console.WriteLine($"media = {mediaFinal}");
  }
}