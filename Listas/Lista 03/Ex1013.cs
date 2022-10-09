using System;

class Program {
  public static void Main () {
    string[] num = Console.ReadLine().Split();
    int a = int.Parse(num[0]);
    int b = int.Parse(num[1]);
    int c = int.Parse(num[2]);
    int comp1 = (a + b + Math.Abs(a-b)) / 2;
    int comp2 = (comp1 + c + Math.Abs(comp1-c)) / 2;
    Console.WriteLine($"{comp2} eh o maior");
  }
}