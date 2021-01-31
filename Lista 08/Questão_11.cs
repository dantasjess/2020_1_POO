using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite as notas");
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double c = double.Parse(Console.ReadLine());
    double d = double.Parse(Console.ReadLine());  

    double Mp = (((2*a)+(2*b)+(3*c)+(3*d))/10);
    if (Mp > 6.0) 
    Console.WriteLine("Você foi aprovado sem a MF");
      else {
        Console.WriteLine ("Você não foi aprovado ainda, preciso da sua PF, digite-a");
        double PF = double.Parse(Console.ReadLine());
        double MF = ((Mp+PF)/2);
          if (MF > 6.0)
          Console.WriteLine("Você foi aprovado pela MF");
            else 
            Console.WriteLine("Você está reprovado");
      }
  }
}