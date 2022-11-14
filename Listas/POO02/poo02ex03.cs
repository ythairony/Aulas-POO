using System;

class Program {
  Viagem v1 = new Viagem();
  v1.SetDistancia(350);
  v1.SetTempo(4);
  Console.WriteLine($"{v1.VelocidadeMedia()} km/h");

  Viagem v2 = new Viagem();
  v2.SetDistancia(80);
  v2.SetTempo(1.5);
  Console.WriteLine($"{v2.VelocidadeMedia()} km/h");

}

class Viagem {
  private double distancia;
  private double tempo = 1;
  public void SetDistancia(double d) {
    if (d >= 0) distancia = d;
  }
  public void SetTempo(double t) {
    if (t > 0) tempo = t;
  }
  public double GetDistancia() {
    return distancia;
  }
  public double GetTempo() => tempo;
  public double VelocidadeMedia() => distancia/tempo;
}