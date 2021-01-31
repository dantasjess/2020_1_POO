using System;
class MainClass {
  public static void Main (string[] args) {
    string valores = Console.ReadLine();
    string [] valores1 = valores.Split();
    int A = int.Parse(valores1[0]);
    int B = int.Parse(valores1[1]);
    int C = int.Parse(valores1[2]);
    int maior = (A + B + Math.Abs(A - B))/2;
    int resultado = (maior + C + Math.Abs(maior - C))/2;
    Console.WriteLine($"{resultado} eh o maior");
  }
}