using System;

class Program {
  public static void Main() {
    int n = int.Parse(Console.ReadLine());
    int[] x = new int[n];
    string[] s = Console.ReadLine().Split();
    for (int i = 0; i < n; i++) {
      x[i] = int.Parse(s[i]);  
    }
    int menor = x[0];
    int index = 0;
    for (int j = 1; j < n; j++) {
      if (x[j] < menor) {
        menor = x[j];
        index = j;
      }
    }
    Console.WriteLine($"Menor valor: {menor}");
    Console.WriteLine($"Posicao: {index}");
  }
}