using System;
class MainClass {
  public static double VolumeLitros(double h, double l, double p){
    double volume;
    volume = h*l*p;
    return volume;
  }
  public static void Main(string [] args) {
    double h,l,p,volume;
    h = double.Parse(Console.ReadLine());
    l = double.Parse(Console.ReadLine());
    p = double.Parse(Console.ReadLine());
    volume = VolumeLitros(h,l,p);
    Console.Write(volume);
  }
}