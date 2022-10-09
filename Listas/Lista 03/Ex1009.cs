using System;

class Program {
    public static void Main (){
      string nome = Console.ReadLine();
      double sal = double.Parse(Console.ReadLine());
      double sell = double.Parse(Console.ReadLine());
      double bonus = sell * 0.15 + sal;
      Console.WriteLine($"TOTAL = R$ {bonus:f2}");
    }
}