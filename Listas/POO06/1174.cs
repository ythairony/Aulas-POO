using System;

class Program {
  public static void Main() {
    double[] a = new double[100];
    for (int i = 0; i < 100; i++) {
      a[i] = double.Parse(Console.ReadLine());
    }

    for (int j = 0; j < 100; j++) {
      if (a[j] <= 10) Console.WriteLine($"A[{j}] = {a[j]:0.0}");
    }
    
  }
}