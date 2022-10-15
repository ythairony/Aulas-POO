using System;

class Program {
  public static void Main() {
    string[] list = Console.ReadLine().Split();
    int a = int.Parse(list[0]);
    int b = int.Parse(list[1]);
    int c = int.Parse(list[2]);
    if (a > b) {
      int x = a;
      a = b;
      b = x;
    }
    if (a > c) {
      int x = a;
      a = c;
      c = x;
    }
    if (b > c) {
      int x = b;
      b = c;
      c = x;
    }
    Console.WriteLine($"{a}\n{b}\n{c}\n\n{list[0]}\n{list[1]}\n{list[2]}");
  }
}