using System;

class Program {
  public static void Main() {
    Console.WriteLine("Digite um valor:");
    int x = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite outro valor:");
    int y = int.Parse(Console.ReadLine());
    int mmc = MMC(x, y);
    Console.WriteLine($"O MMC entre {x} e {y} é {mmc}.");
  }

  public static int MMC(int x, int y) {
    int mmc1, mmc2, i, j, mmc;
    i = 2;
    j = 2;
    mmc = 0;
    while (mmc == 0) {
      mmc1 = x * i;
      mmc2 = y * j;
      if (mmc1 == mmc2) {
        mmc = mmc1;
      }
      if (mmc1 < mmc2) {
        i++;
      }
      if (mmc2 < mmc1) {
        j++;
      }
      
    }
    
    return mmc;
  }
}