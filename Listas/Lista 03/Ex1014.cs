using System;

class Program {
  public static void Main () {
    int run = int.Parse(Console.ReadLine());
    double fuel = double.Parse(Console.ReadLine());
    double kml = run / fuel;
    Console.WriteLine($"{kml:f3} km/l");
  }  
}