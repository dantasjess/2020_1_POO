using System;
class MainClass {
  public static void Main (string[] args) {
    string nome = Console.ReadLine();
    double salario = double.Parse(Console.ReadLine());
    double vendas = double.Parse(Console.ReadLine());
    double bonus = vendas*0.15;
    double TOTAL = salario + bonus;
    Console.WriteLine($"TOTAL = R$ {TOTAL:0.00}");
  }
}