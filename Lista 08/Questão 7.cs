using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite a dimensão do ambiente em metros no formato largura X comprimento:");
    char x = 'x';
    string[] dim_amb = Console.ReadLine().Split(x);

    Console.WriteLine("Digite a dimensão do revestimento em centímetros no formato largura X comprimento:");
    string[] dim_rev = Console.ReadLine().Split(x);

    float a = float.Parse(dim_amb[0]);
    float b = float.Parse(dim_amb[1]);
    int c = int.Parse(dim_rev[0]);
    int d = int.Parse(dim_rev[1]);
    float f = a*b;
    int g = c*d;

    Console.WriteLine("Digite o número de peças por caixa:");
    int caixa = int.Parse(Console.ReadLine());

    Console.WriteLine($"São necessárias {(f/g)/caixa*10000}caixas do revestimento.");

  }
}