using System;

class Program {
  public static void Main () {
    Console.WriteLine("Digite o intervalo de tempo no formato \"HH:MM:SS\"");
    string enter = Console.ReadLine();
    string[] v = enter.Split(":");
    long luz = 300000;
    long seg = luz * long.Parse(v[2]);
    long min = luz * 60 * long.Parse(v[1]);
    long hora = luz * 3600 * long.Parse(v[0]);
    long speed = seg + min + hora;
    Console.WriteLine($"A luz percorreu {speed} km nesse intervalo");
  }
}