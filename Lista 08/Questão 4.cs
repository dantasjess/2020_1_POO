using System;
class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite 3 valores separados por vírgulas:");
    string calc = Console.ReadLine();
    string[] s = calc.Split(',');
    int a = int.Parse(s[0]); 
    int b = int.Parse(s[1]); 
    int c = int.Parse(s[2]);
    Console.WriteLine($"O produto entre esses valores é {a*b*c}");
  }
} 