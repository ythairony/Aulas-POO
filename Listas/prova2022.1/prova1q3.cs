using System;

class Program {
  public static void Main() {
    Console.WriteLine();
    Carta c1 = new Carta(1, "ouros");
    Console.WriteLine(c1);

    Carta c2 = new Carta(1, "ouros");
    Console.WriteLine(c2);
    if (Carta.Equals(c1, c2)) {
      Console.WriteLine("São iguais.");
    } else {Console.WriteLine("São diferentes."); }
  }
  
}

class Carta {
  private int numero;
  private string naipe;
  public Carta(int numero, string naipe) {
    this.SetNumero(numero);
    this.SetNaipe(naipe);
  }
  public void SetNumero(int numero) {
    if (numero > 0 && numero <=13) this.numero = numero;
    }
  public void SetNaipe(string naipe) {
    if (naipe == "ouros" || naipe == "copas" || naipe == "espadas" || naipe == "paus") this.naipe = naipe;
    }
  public int GetNumero() {
    return this.numero;
  }
  public string GetNaipe() {
    return this.naipe;
  }
  public static bool Equals(Carta c1, Carta c2) {
    if (c1.GetNumero() == c2.GetNumero() && c1.GetNaipe() == c2.GetNaipe()) {
      return true;
    } else { return false; }
  }
  
  public override string ToString() {
    return $"A carta de número {numero} é do naipe de {naipe}";
  }
}

