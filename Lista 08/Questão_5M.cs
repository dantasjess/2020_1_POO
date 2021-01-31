using System;
class MainClass {
  public static double Frete(double massa, double distancia) {
  return 0.01 * massa * distancia;
  }
  static void Main(string[] args) {
    Console.WriteLine("Informe o peso do produto em kg");
    double p = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe a distância até o destino em km");
    double d = double.Parse(Console.ReadLine());
    double f = Frete(p, d);
    Console.WriteLine($"O valor do frete é R${f:0.00}");
  }
}