using System;

class Program {
  public static void Main () {
    string[] n = Console.ReadLine().Split();
    if (int.Parse(n[1]) > int.Parse(n[2]) && int.Parse(n[3]) > int.Parse(n[0]) && (int.Parse(n[2]) + int.Parse(n[3])) > (int.Parse(n[0]) + int.Parse(n[1])) && int.Parse(n[2]) > 0 && int.Parse(n[3]) > 0 && int.Parse(n[0]) % 2 == 0) {
      Console.WriteLine("Valores aceitos");
    }
    else {
      Console.WriteLine("Valores nao aceitos");
    }
  }                                                              
}