using System;

class Program {
  public static void Main() {
    Pais x = null;
    for (int i = 0; i < 10; i++) {
      Console.WriteLine();
      Console.WriteLine($"Informe o {i+1}º país:");
      string nome = Console.ReadLine();
      Console.WriteLine("Informe o população (em milhões):");
      int populacao = int.Parse(Console.ReadLine());
      if (x == null) {
        x = new Pais(nome, populacao);
      }
      else if (x.GetPopulacao() < populacao) {
        x = new Pais(nome, populacao);
      }
    }
    Console.WriteLine(x);
  }
}

class Pais {
  private string nome;
  private int populacao;
  public Pais(string nome, int populacao) {
    this.SetNome(nome);
    this.SetPopulacao(populacao);
  }
  public void SetNome(string nome) {
    if (nome != " ") this.nome = nome;
  }
  public void SetPopulacao(int populacao) {
    if (populacao > 0) this.populacao = populacao;
  }
  public string GetNome() {
    return this.nome;
  }
  public int GetPopulacao() {
    return this.populacao;
  }
  
  
  public override string ToString() {
    return $"O país {nome} tem uma população de {populacao} milhões de habitantes.";
  }
}