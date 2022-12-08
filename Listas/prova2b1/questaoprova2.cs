using System;
using System.Collections;

class Program {
  public static void Main() {
    Equipe escalacao = new Equipe {Pais = "Brasil"};
    Jogador j1 = new Jogador {Nome = "Alisson", Camisa = 1, NumGols = 0};
    Jogador j2 = new Jogador {Nome = "Neymar Jr", Camisa = 10, NumGols = 1};
    Jogador j3 = new Jogador {Nome = "Vini Jr", Camisa = 20, NumGols = 2};
    Jogador j4 = new Jogador {Nome = "Richarlison", Camisa = 9, NumGols = 3};
    Jogador j5 = new Jogador {Nome = "Paqueta", Camisa = 7, NumGols = 1};
    Jogador j6 = new Jogador {Nome = "Raphinha", Camisa = 11, NumGols = 0};
    Jogador j7 = new Jogador {Nome = "Casemiro", Camisa = 5, NumGols = 1};
    Jogador j8 = new Jogador {Nome = "T. Silva", Camisa = 3, NumGols = 0};
    Jogador j9 = new Jogador {Nome = "Alex Sandro", Camisa = 6, NumGols = 0};
    Jogador j10 = new Jogador {Nome = "Fabinho", Camisa = 15, NumGols = 0};
    Jogador j11 = new Jogador {Nome = "Gilbert Silva", Camisa = 8, NumGols = 6};
    
    escalacao.Inserir(j1);
    escalacao.Inserir(j2);
    escalacao.Inserir(j3);
    escalacao.Inserir(j4);
    escalacao.Inserir(j5);
    escalacao.Inserir(j6);
    escalacao.Inserir(j7);
    escalacao.Inserir(j8);
    escalacao.Inserir(j9);
    escalacao.Inserir(j10);
    escalacao.Inserir(j11);

    Console.WriteLine();
    Console.WriteLine($"Escalação por nome do {escalacao.Pais}");
    Console.WriteLine();
    
    foreach (Jogador player in escalacao.Listar()) {
      Console.WriteLine(player);
    }

    Console.WriteLine();
    Console.WriteLine($"Os 3 artilheiros do {escalacao.Pais}:");
    Console.WriteLine();

    
    ComparadorArtilheiro objeto1 = new ComparadorArtilheiro();
    Jogador[] ranking = escalacao.Listar();
    Array.Sort(ranking, objeto1);
    Array.Reverse(ranking);
    for (int i = 0; i < 3; i++) {
      Console.WriteLine(ranking[i]);
    }

    Console.WriteLine();
    Console.WriteLine($"Escalação por número da camisa {escalacao.Pais}:");
    Console.WriteLine();
    
    ComparadorCamisa objeto2 = new ComparadorCamisa();
    Jogador[] numeracao = escalacao.Listar();
    Array.Sort(numeracao, objeto2);
    
    foreach (Jogador elem in numeracao)
      Console.WriteLine(elem);
  }
}



class Equipe {
  private string pais = "Seleção não informada";
  private Jogador[] jogs = new Jogador[1];
  public string Pais {get; set;}
  //public Jogador[] jogs {get;}
  private int i = 0;

  public void Inserir(Jogador jogador) {
    if (i == jogs.Length) {
      Array.Resize(ref jogs, 2 * jogs.Length);
    }
    jogs[i++] = jogador;
  }

  public Jogador[] Listar() {
    Jogador[] vetor = new Jogador[i]; 
    Array.Copy(jogs, vetor, i);
    Array.Sort(vetor);
    return vetor;
  }

  public override string ToString() {
    return pais;
  }
}





class Jogador : IComparable {
  private string nome = "Sem nome";
  private int camisa = 0;
  private int numgols = 0;
  
  public string Nome {
    get {return nome;}
    set {if (value != "") nome = value;}
  }

  public int Camisa {
    get {return camisa;}
    set {if (value > 0) camisa = value;}
  }

  public int NumGols {
    get {return numgols;}
    set {if (value >= 0) numgols = value;}
  }

  public int CompareTo(object obj) {
    Jogador player1 = this;
    Jogador player2 = (Jogador) obj;
    //int ord = player1.nome.CompareTo(player2.nome);  
    return player1.Nome.CompareTo(player2.Nome); 
  }

  public override string ToString() {
    return $"Jogador = {nome} | Número da camisa {camisa} | Gols Marcados {numgols}";
  }
}

class ComparadorArtilheiro : IComparer {
  public int Compare(object obj1, object obj2) {
    Jogador j1 = (Jogador) obj1;
    Jogador j2 = (Jogador) obj2;
    return j1.NumGols.CompareTo(j2.NumGols);
  }
}

class ComparadorCamisa : IComparer {
  public int Compare(object obj1, object obj2) {
    Jogador j1 = (Jogador) obj1;
    Jogador j2 = (Jogador) obj2;
    return j1.Camisa.CompareTo(j2.Camisa);
  }
}