using System;

class Program {
  public static void Main() {
    string[] list = Console.ReadLine().Split();
    Array.Sort(list);
    int i;
    for (i = 0; i < 3; i++) {
      Console.WriteLine($"{list[i]}");
    }
    Console.WriteLine("");
    Array.Reverse(list);
    for (i = 0; i < 3; i++) {
      Console.WriteLine($"{originList[i]}");
    }
  }
}