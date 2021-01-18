using System;
class MainClass {
  public static void Main (string[] args) {
    double tempo = int.Parse(Console.ReadLine());
    double velocidade = int.Parse(Console.ReadLine());
    double combustivel = 12;
    double litros = (tempo*velocidade)/12;
    Console.WriteLine($"{litros:0.000}");
  }
}
