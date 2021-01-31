using System;
class MainClass {
  public static int MMC(int x, int y) {
    int mmc = 0, aux = 0, i;
    for (i = 2; i <= y; i++) {
      aux = x * i;
      if ((aux % y) == 0) {
        mmc = aux;
        break;
      }
    }
    return mmc;
  }
  public static void Main(string[] args) {
    int x = int.Parse(Console.ReadLine());
    int y = int.Parse(Console.ReadLine());
    int mmc = MMC(x,y);
    Console.WriteLine(mmc); 
  }
}