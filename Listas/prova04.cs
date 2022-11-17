using System;

class Program {
  public static void Main() {
    Console.WriteLine();
    Console.WriteLine("Informe o número da 1º carta:");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o naipe da 1º carta:");
    string naipe1 = Console.ReadLine();   
    Carta c1 = new Carta(num1, naipe1);
    Console.WriteLine();
    
    Console.WriteLine("Informe o número da 2º carta:");
    int num2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o naipe da 2º carta:");
    string naipe2 = Console.ReadLine();   
    Carta c2 = new Carta(num2, naipe2);
    Console.WriteLine();
    
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
