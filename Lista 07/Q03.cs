using System;
class MainClass {
  public static void Intervalo(double x, out int inicio, out int fim) {
    inicio = (int)x;
    fim = inicio + 1;
  }
  public static void Main(string[] args) {
    double x = double.Parse(Console.ReadLine());
    int i,f;
    Intervalo(x, out i, out f);
    Console.WriteLine($"{i} e {f}");
  }
}