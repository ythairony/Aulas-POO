using System;

class Program {
  public static void Main() {
    Console.WriteLine();
    Pais brasil = new Pais("Brasil", 220);
    Console.WriteLine(brasil);
    Console.WriteLine();
    Pais eua = new Pais("Estados Unidos", 332);
    Console.WriteLine(eua);
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