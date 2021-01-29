using System;
class MainClass {
  public static double VolumeEsfera(double r){
    double volume;
    volume = (4*(r*r*r)*3.14)/3;
    return volume;
  }
  public static void Main (string [] args){
    double volume, r;
    r = double.Parse(Console.ReadLine());
    volume = VolumeEsfera(r);
    Console.WriteLine(volume);
  }
}