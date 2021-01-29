using System;
class MainClass{
public static double Diagonal(double b, double h){
  double diagonal;
  diagonal = Math.Sqrt((b*b)+(h*h));
  return diagonal;
}
public static void Main (string [] args) {
  Console.WriteLine("Informe base e altura:");
  double b,h, diagonal;
  b = double.Parse(Console.ReadLine());
  h = double.Parse(Console.ReadLine());
  diagonal = Diagonal(b,h);
  Console.WriteLine(diagonal);
}
}