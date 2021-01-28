using System;
class MainClass {
  public static void Main (string[] args) {
  Console.WriteLine("Digite três valores reais separados por pontos e vírgulas:");
  string[] valores = Console.ReadLine().Split(';');
  double v1 = double.Parse(valores[0]);
  double v2 = double.Parse(valores[1]);
  double v3 = double.Parse(valores[2]);
  Console.WriteLine($"A soma entre esses valores é {(v1+v2+v3):0.00}");
  }
}