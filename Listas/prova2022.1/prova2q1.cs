using System;

class Program {
  public static void Main() {
    Empresa empresa = new Empresa {Nome = "Salva-Vidas"};
    ContaPagar conta1 = new ContaPagar {Fornecedor = "Unimed", Vencimento = DateTime.Parse("2022-12-20"), Valor = 160.60};
    ContaPagar conta2 = new ContaPagar {Fornecedor = "Oi Fibra", Vencimento = DateTime.Parse("2024-01-26"), Valor = 89.00};
    ContaPagar conta3 = new ContaPagar {Fornecedor = "Uber", Vencimento = DateTime.Parse("2022-12-31"), Valor = 400};
    ContaPagar conta4 = new ContaPagar {Fornecedor = "Cosern", Vencimento = DateTime.Parse("2022-12-20"), Valor = 159.13};
    ContaPagar conta5 = new ContaPagar {Fornecedor = "Caern", Vencimento = DateTime.Parse("2023-01-24"), Valor = 120.00};
    empresa.Inserir(conta1);
    empresa.Inserir(conta2);
    empresa.Inserir(conta3);
    empresa.Inserir(conta4);
    empresa.Inserir(conta5);
    foreach (ContaPagar conta in empresa.Listar()) {
      Console.WriteLine(conta);
    }
    Console.WriteLine();
    foreach (ContaPagar conta in empresa.Pesquisar(1, 2024)) {
      Console.WriteLine(conta);
    }
    Console.WriteLine();
    Console.WriteLine($"Total R$ {empresa.Total(1, 2024):f2}");
  }
}


class Empresa {
  private ContaPagar[] contas = new ContaPagar[1];
  public string Nome {get; set;}
  public int Qtd {get => i; }
  private int i = 0;

  public void Inserir(ContaPagar conta) {
    if (i == contas.Length) {
      Array.Resize(ref contas, 2 * contas.Length);
    }
    contas[i++] = conta;
  }
  public ContaPagar[] Listar() {
    ContaPagar[] vetor = new ContaPagar[i]; 
    Array.Copy(contas, vetor, i);
    Array.Sort(vetor);
    return vetor;
  }
  public ContaPagar[] Pesquisar(int mes, int ano){
    ContaPagar[] lista = Listar();
    ContaPagar[] filter = new ContaPagar[Qtd];
    int j = 0;
    for (int k = 0; k < Qtd ; k++) {
      if (lista[k].Vencimento.Year == ano && lista[k].Vencimento.Month == mes) {
        filter[j++] = lista[k];
      }
    }
    Array.Resize(ref filter, j);
    return filter;
  } 
  public double Total(int mes, int ano){
    ContaPagar[] pag = Pesquisar(mes, ano);
    double soma = 0;
    foreach (ContaPagar conta in pag) {
      soma += conta.Valor;
    }
    return soma;
  }
}

class ContaPagar : IComparable {
  public string Fornecedor {get ; set ;}
  public DateTime Vencimento {get ; set ;}
  public double Valor {get ; set ;}  

  public int CompareTo(object obj) {
    ContaPagar cp1 = this;
    ContaPagar cp2 = (ContaPagar) obj;
    int ord = cp1.Vencimento.CompareTo(cp2.Vencimento);
    
    if (ord == 0) {
      return cp1.Fornecedor.CompareTo(cp2.Fornecedor);
    }
    
    return ord; 
  }

  public override string ToString() {
    return $"{Fornecedor} - {Vencimento:dd/MM/yyyy} - R$ {Valor:f2}";
  }
}