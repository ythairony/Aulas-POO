using System;

class Program {
  public static void Main() {
    Console.WriteLine("Horários do Cinema");
    
  }

  public static void Dia() {
    int op = 1;
    while (op != 0) {
      Console.WriteLine("Digite a opção que deseja fazer:");
      Console.WriteLine("[ 1 ] Segunda-feira");
      Console.WriteLine("[ 2 ] Terça-feira");
      Console.WriteLine("[ 3 ] Quarta-feira");
      Console.WriteLine("[ 4 ] Quinta-feira");
      Console.WriteLine("[ 5 ] Sexta-feira");
      Console.WriteLine("[ 6 ] Sábado");
      Console.WriteLine("[ 7 ] Domingo");
      Console.WriteLine("[ 0 ] Encerrar");
    }
  }
}