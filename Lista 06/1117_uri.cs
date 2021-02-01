using System;

class MainClass {
  public static void Main() { 
    int i = 0;
    double med = 0;
    while (i < 2) {
    double nota = double.Parse(Console.ReadLine()); 
    if (nota >= 0 && nota <= 10) {
        i = i + 1;
        med = med + nota;
    }
    if (nota < 0 || nota > 10) Console.WriteLine("nota invalida");
    }
    med = med / 2;
    Console.WriteLine($"media = {med:0.00}");
  }
}