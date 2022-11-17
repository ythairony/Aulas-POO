using System;

class Program {
  public static void Main() {
    Pais x = null;
    double densidade = 0;
    for (int i = 0; i < 10; i++) {
      Console.WriteLine();
      Console.WriteLine($"Informe os dados do {i+1}º país");
      Console.WriteLine($"Nome: ");
      string nome = Console.ReadLine();
      Console.WriteLine("População: ");
      int populacao = int.Parse(Console.ReadLine());
      Console.WriteLine("Área geográfica (em km²):");
      double area = double.Parse(Console.ReadLine());
      
      if (x == null) {
        x = new Pais(nome, populacao, area);
        densidade = Pais.Densidade(x);
      }
      else if (densidade < (populacao / area)) {
        x = new Pais(nome, populacao, area);
        densidade = Pais.Densidade(x);
      }
    }
    Console.WriteLine(x);
  }
}

class Pais {
  private string nome;
  private int populacao;
  private double area;
  public Pais(string nome, int populacao, double area) {
    this.SetNome(nome);
    this.SetPopulacao(populacao);
    this.SetArea(area);
  }
  public void SetNome(string nome) {
    if (nome != " ") this.nome = nome;
  }
  public void SetPopulacao(int populacao) {
    if (populacao > 0) this.populacao = populacao;
  }
  public void SetArea(double area) {
    if (area > 0) this.area = area;
  }
  public string GetNome() {
    return this.nome;
  }
  public int GetPopulacao() {
    return this.populacao;
  }
  public double GetArea() {
    return this.area;
  }
  public static double Densidade(Pais p1) {
    double d = p1.GetPopulacao() / p1.GetArea();
    return d;
  }
  
  public override string ToString() {
    return $"O {nome} tem a maior densidade populacional com uma população de {populacao} habitantes e uma área territorial de {area} km².";
  }
}