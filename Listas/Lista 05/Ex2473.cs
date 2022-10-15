using System;

class Program {
  public static void Main() {
    string[] aposta = Console.ReadLine().Split();
    string[] numerosSorteados = Console.ReadLine().Split();
    int i, j, premio;
    premio = 0;
    for (i = 0; i <= 5; i++) {
      j = 0;
      for (j = 0; j <=5; j++) {
        if (aposta[i] == numerosSorteados[j]) {
          premio++;
        }
      }
    }
    switch (premio) {
      case 3: Console.WriteLine("terno"); break;
      case 4: Console.WriteLine("quadra"); break;
      case 5: Console.WriteLine("quina"); break;
      case 6: Console.WriteLine("sena"); break;
      default : Console.WriteLine("azar"); break;
    }
  }
}