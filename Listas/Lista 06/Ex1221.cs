using System;

class Program {
  public static void Main() {
    int teste = int.Parse(Console.ReadLine());
    int i, j, div;
    i = 1;
    while (i <= teste) {
    int x = int.Parse(Console.ReadLine());
    div = 0;
    j = 1;
      while (j <= x) {
        if (x % j == 0) {
          div++;
          
        }
        j++;
        
      }
    
    
    i++;
    }
    if (div == 1 && j > (x / 2) || x == 2) Console.WriteLine("Prime");
    else (div > 1 && j < (x/2)) Console.WriteLine("Not Prime");
  }
}