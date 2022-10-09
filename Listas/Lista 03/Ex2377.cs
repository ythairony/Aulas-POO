using System;

class Program {
  public static void Main() {
    string[] distancia = Console.ReadLine().Split();
    string[] preco = Console.ReadLine().Split();
    int custo = int.Parse(distancia[0]) * int.Parse(preco[0]);
    int dist = int.Parse(distancia[0]) / int.Parse(distancia[1]);
    int ped = dist * int.Parse(preco[1]);
    Console.WriteLine($"{ped + custo}");
  }
}