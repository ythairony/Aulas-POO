using System;

class Program {
  public static void Main() {
    int time = int.Parse(Console.ReadLine());
    int speed = int.Parse(Console.ReadLine());
    double dist = time * speed;
    double kml = 12.000;
    double media = dist / kml;
    Console.WriteLine($"{media:f3}");
  }
}