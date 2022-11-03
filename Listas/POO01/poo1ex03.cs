using System;

class Program {
  public static void Main() {
    Console.WriteLine("Calcular a velocidade média de viagem");
    Console.WriteLine("Informe a distância (em KM):");
    int d = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o tempo gasto:");
    double t = double.Parse(Console.ReadLine());
    double velomedia = Viagem(d, t);
    Console.WriteLine($"A velocidae média da viagem foi de {velomedia} km/h.");
  }

  public static double Viagem(int distancia, double tempo) {
    double velocidadeMedia = distancia / tempo;
    return velocidadeMedia;
  }
}