using System;
class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite a largura do ambiente em metros:");
    double larg_amb = double.Parse(Console.ReadLine());
    
    Console.WriteLine ("Digite o comprimento do ambiente em metros:");
    double comp_amb = double.Parse(Console.ReadLine());

    Console.WriteLine ("Digite a largura do revestimento em centímetros:");
    double larg_rev = double.Parse(Console.ReadLine());
    larg_rev = larg_rev/100;

    Console.WriteLine ("Digite o comprimento do revestimento em centímetros:");
    double comp_rev = double.Parse(Console.ReadLine());
    larg_rev = larg_rev/100;

    Console.WriteLine ("Digite o número de peças por caixa:");
    int caixas = int.Parse(Console.ReadLine());

    double area_amb = (larg_amb*comp_amb);
    double area_rev = (larg_rev*comp_rev);

    Console.WriteLine($"São necessárias {(area_amb/area_rev)/caixas:0.0} caixas do revestimento.");
  }
}
  