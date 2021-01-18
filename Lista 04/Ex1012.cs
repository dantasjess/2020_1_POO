using System;
class MainClass {
  public static void Main (string[] args) {
    string valores = Console.ReadLine();
    string[] x = valores.Split(' ');
    double a = float.Parse(x[0]);
    double b = float.Parse(x[1]);
    double c = float.Parse(x[2]);
    double pi = 3.14159;
    double triangulo = a*c/2;
    double circulo = pi*(c*c);
    double trapezio = (c*(a+b))/2;
    double quadrado = b*b;
    double retangulo = a*b;
    Console.WriteLine($"TRIANGULO: {triangulo:0.000}");
    Console.WriteLine($"CIRCULO: {circulo:0.000}");
    Console.WriteLine($"TRAPEZIO: {trapezio:0.000}");
    Console.WriteLine($"QUADRADO: {quadrado:0.000}");
    Console.WriteLine($"RETANGULO: {retangulo:0.000}");
  }
}

//CIRCULO = Pi*(float(C)**2)
//TRAPEZIO = ((float(A)+float(B))*float(C))/2
//QUADRADO = float(B)**2
//RETANGULO = float(A)*float(B)