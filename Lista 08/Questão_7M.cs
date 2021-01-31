using System;
class MainClass {
  public static int Soma(int inicio, int fim) {
    int soma = 0;
    for (int i = inicio; i <= fim; i++) 
      soma += i;
    return soma;
  }
  public static void Main(string[] args) {
    Console.WriteLine("Digite inicio:");
    int inicio = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite fim:");
    int fim = int.Parse(Console.ReadLine());
    Console.WriteLine(Soma(inicio,fim));
  }
}