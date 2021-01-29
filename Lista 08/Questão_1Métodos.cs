using System;
class MainClass {
  public static double AreaCirculo(double raio) {
    double area;
    area = 3.14*raio*raio;
    return area;
  }
  public static void Main() {
    double raio, area;
    raio = double.Parse(Console.ReadLine());
    area = AreaCirculo(raio);
    Console.WriteLine(area);
  }
}
