using System;

class Program {
  public static void Main() {
    string[] cartas = Console.ReadLine().Split();
    int carta1 = int.Parse(cartas[0]);
    int carta2 = int.Parse(cartas[1]);
    int carta3 = int.Parse(cartas[2]);
    int carta4 = int.Parse(cartas[3]);
    int carta5 = int.Parse(cartas[4]);
    int test1, test2;
    test1 = 0;
    test2 = 0;
    // ordem crescente
    if (carta1 < carta2 && carta1 < carta3 && carta1 < carta4 && carta1 < carta5) {
      if (carta2 < carta3 && carta2 < carta4 && carta2 < carta5) {
        if (carta3 < carta4 && carta3 < carta5) {
          if (carta4 < carta5) {
            Console.WriteLine("C");
            test1 = 1;
          }
          else test1 = 0;
        }
      }      
    }
    
    // ordem decrescente
    if (carta1 > carta2 && carta1 > carta3 && carta1 > carta4 && carta1 > carta5) {
      if (carta2 > carta3 && carta2 > carta4 && carta2 > carta5) {
        if (carta3 > carta4 && carta3 > carta5) {
          if (carta4 > carta5) {
            Console.WriteLine("D");
            test2 = 1;
          }
          else test2 = 0;
        }
      }      
    }
    
    // não ordenado

    if (test1 == test2) Console.WriteLine("N");
  }
}