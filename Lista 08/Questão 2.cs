using System;
class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite o valor gasto com o combustível em reais:");
    double x = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor do litro do combustível em reais:");
    double y = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a distância percorrida em quilômetros:");
    double z = double.Parse(Console.ReadLine());

    double consumo = z/(x/y);
    double consumo2 = y/(z/(x/y));
    Console.WriteLine($"O consumo médio é de {consumo:0.00} Km por Litro \n O gasto por Km percorrido é R$ {consumo2:0.00}.");
  }
}