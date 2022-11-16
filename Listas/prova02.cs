using System;

class Program {
  public static void Main() {
    Console.WriteLine();
    Pais brasil = new Pais("Brasil", 220);
    Console.WriteLine(brasil);
    Console.WriteLine();
    Pais eua = new Pais("Estados Unidos", 332);
    Console.WriteLine(eua);
    Console.WriteLine();
    Console.WriteLine(brasil.GetPopulacao);
  }
}

class Pais {
  private string nome;
  private int populacao;
  public Pais(string nome, int populacao) {
    if (nome != " ") this.nome = nome;
    if (populacao > 0) this.populacao = populacao;
  }

  public void GetPopulacao {
    return populacao;
  }
  
  public override string ToString() {
    return $"O país {nome} tem uma população de {populacao} milhões de habitantes.";
  }
}