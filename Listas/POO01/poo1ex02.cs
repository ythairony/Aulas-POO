using System;

class MainClass {
  public static void Main() {
    Console.WriteLine("Cálculo da média do aluno");
    Console.WriteLine("Informe a nota do 1º bimestre:");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe a nota do 2º bimestre:");
    int n2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe a nota do 3º bimestre:");
    int n3 = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe a nota do 4º bimestre:");
    int n4 = int.Parse(Console.ReadLine());
    int media = Media(n1, n2, n3, n4);
    if (media < 60) {
      Console.WriteLine($"Média parcial = {media}");
      Console.WriteLine("Informe a nota da prova final");
      int nf = int.Parse(Console.ReadLine());
      int mf = MediaFinal(media, nf);
      Console.WriteLine($"Nota final = {mf}");
    } else Console.WriteLine($"Nota final = {media}");
    
  }

  public static int Media(int n1, int n2, int n3, int n4) {
    int mediaPonderada = (n1 * 2 + n2 * 2 + n3 * 3 + n4 * 3) / 10;
    return mediaPonderada;
  }
  public static int MediaFinal(int mediaParcial, int provaFinal) {
    int mediaFinal = (mediaParcial + provaFinal) / 2;
    return mediaFinal;
  }
}