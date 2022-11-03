using System;
using System.Globalization;
using System.Threading;


class Program {
  public static void Main() {
    Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
    Console.WriteLine("POO Bank");
    Console.WriteLine("Informe seu nome:");
    string nome = Console.ReadLine();
    Console.WriteLine("Informe o número da conta:");
    int numConta = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe seu saldo da conta:");
    double saldo = double.Parse(Console.ReadLine());
    Console.WriteLine();
    int op = 1;
    while (op != 0) {
      Console.WriteLine("Deseja a opção que deseja fazer:");
      Console.WriteLine("1 - Depositar");
      Console.WriteLine("2 - Sacar");
      Console.WriteLine("0 - Encerrar");
      Console.WriteLine();
      op = int.Parse(Console.ReadLine());
      if (op == 1) {
        Console.WriteLine("Quanto deseja depositar");
        double deposito = double.Parse(Console.ReadLine());
        saldo += deposito;
        Console.WriteLine($"Novo saldo {saldo:c2}");
        Console.WriteLine();
      }
      if (op == 2) {
        Console.WriteLine("Quanto deseja sacar");
        double saque = double.Parse(Console.ReadLine());
        saldo -= saque;
        Console.WriteLine($"Novo saldo {saldo:c2}");
        Console.WriteLine();
      }
    }
  Console.WriteLine("Operação encerrada");
  Console.WriteLine($"Nome do titular da conta = {nome}");
  Console.WriteLine($"Número da conta = {numConta}");
  Console.WriteLine($"Saldo da conta = {saldo:c2}");
  }
  
}