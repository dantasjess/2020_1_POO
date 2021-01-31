using System;
class MainClass {
  public static void Main (string[] args) {
    string linha1 = Console.ReadLine();
    string[] valores1 = linha1.Split();
    double x1 = double.Parse(valores1[0]);
    double y1 = double.Parse(valores1[1]);
    string linha2 = Console.ReadLine();
    string[] valores2 = linha2.Split();
    double x2 = double.Parse(valores2[0]);
    double y2 = double.Parse(valores2[1]);
    double distancia = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
    Console.WriteLine($"{distancia:0.0000}");
  }
}