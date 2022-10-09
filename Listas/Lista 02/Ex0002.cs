using System;

class Program {
  public static void Main () {
    Console.WriteLine("Digite seu nome completo:");
    string nome = Console.ReadLine();
    string[] nome1 = nome.Split();
    Console.WriteLine($"Bem-vindo ao C#, {nome1[0]}");
  }
}