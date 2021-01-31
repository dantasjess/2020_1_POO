using System;
class MainClass {
  public static void Main (string[] args) {
  double distancia = double.Parse(Console.ReadLine());
  double combustivel = double.Parse(Console.ReadLine());
  double consumo = distancia/combustivel;
  Console.WriteLine($"{consumo:0.000} km/l");
  }
}
