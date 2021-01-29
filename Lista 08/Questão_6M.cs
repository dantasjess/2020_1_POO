using System;
class MainClass {
  public static int MenorInteiro(double x) {
    int xi = (int) x;
    return xi + 1;
  }
  public static void Main(string [] args) {
    string xs = Console.ReadLine();
    double xd = double.Parse(xs);
    Console.WriteLine(MenorInteiro(xd));
  }
}