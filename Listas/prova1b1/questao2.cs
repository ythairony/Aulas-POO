using System;

class Program {
  public static void Main() {
    Console.WriteLine();
    
    Console.WriteLine("Informe o número do lado esquerdo da 1º peça:");
    int ladoesquerdo1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o número do lado direito da 1º peça:");
    int ladodireito1 = int.Parse(Console.ReadLine()); 
    PeçaDomino p1 = new PeçaDomino(ladoesquerdo1, ladodireito1);
    Console.WriteLine();
    
    Console.WriteLine("Informe o número do lado esquerdo da 2º peça:");
    int ladoesquerdo2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o número do lado direito da 2º peça:");
    int ladodireito2 = int.Parse(Console.ReadLine()); 
    PeçaDomino p2 = new PeçaDomino(ladoesquerdo2, ladodireito2);
    Console.WriteLine();

    if (PeçaDomino.Equals(p1, p2)) {
      Console.WriteLine("As peças combinam, em pelo menos um de seus lados são iguais.");
    } else {Console.WriteLine("as peças não combinam, todos os lados de cada peça são diferentes."); }
  }
}

class PeçaDomino {
  private int numeroesquerdo;
  private int numerodireito;
  public PeçaDomino(int numeroesquerdo, int numerodireito) {
    this.SetNumeroesquerdo(numeroesquerdo);
    this.SetNumerodireito(numerodireito);
  }
  public void SetNumeroesquerdo(int numeroesquerdo) {
    if (numeroesquerdo >= 1 && numeroesquerdo <= 6) {this.numeroesquerdo = numeroesquerdo; }
  }
  public void SetNumerodireito(int numerodireito) {
    if (numerodireito >= 1 && numerodireito <= 6) {this.numerodireito = numerodireito; }
  }
  public int GetNumeroesquerdo() {
    return this.numeroesquerdo;
  }
  public int GetNumerodireito() {
    return this.numerodireito;
  }
  public static bool Equals(PeçaDomino p1, PeçaDomino p2) {
    if (p1.GetNumeroesquerdo() == p2.GetNumeroesquerdo() || p1.GetNumeroesquerdo() == p2.GetNumerodireito() || p1.GetNumerodireito() == p2.GetNumeroesquerdo() || p1.GetNumerodireito() == p2.GetNumerodireito()) {
      return true;
    } else { return false; }
  }
}