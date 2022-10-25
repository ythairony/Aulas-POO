using System;

class Program {
  public static void Main() {
    // Referência
    Aluno x;
    // Instância
    x = new Aluno();
    x.nome = "Radmila";
    Aluno y = new Aluno();
    y.nome = "Felipe";
    Aluno z = x;
    Console.WriteLine(x.nome);
    Console.WriteLine(y.nome);
    Console.WriteLine(z.nome);
  }
}

class Aluno {
  public string nome;
}