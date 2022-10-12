using System;

class Program {
  public static void Main() {
    int x = int.Parse(Console.ReadLine());
    int f1 = 0;
    int f2 = 1;
    int f3, i;
    Console.Write($"{f1}");
    Console.Write($" {f2}");
    for (i = 2; i < x; i++) {
      f3 = f1 + f2;
      Console.Write($" {f3}");
      f1 = f2;
      f2 = f3;
    }
    Console.WriteLine("");
  }
}