using System;
class MainClass {
  public static double Maior(double x, double y) {
    double maior = 0;
    if (x > y)
      maior = x;
    else
      maior = y;
    return maior;
  }
  
  public static void Main (string[] args) {
    double x, y, maior;
    x = double.Parse(Console.ReadLine());
    y = double.Parse(Console.ReadLine());
    maior = Maior(x,y);
    Console.WriteLine(maior);
  }
}