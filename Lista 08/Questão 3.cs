using System;
class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite a operação no formato op1+op2:");
    string calc = Console.ReadLine();
    string[] s = calc.Split('+');
    int a = int.Parse(s[0]); 
    int b = int.Parse(s[1]); 
    Console.WriteLine($"Soma = {a + b}"); 
  }
}