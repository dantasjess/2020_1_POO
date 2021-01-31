using System;
class MainClass {
  public static void Ordenar(ref int x, ref int y, ref int z) {
    int maior = 0;
    int menor = 0;
    int meio = 0;
    if (x < y && x < z && y < z) {
      menor = x;
      meio = y;
      maior = z; 
    } else if (x < y && x < z && z < y) {
      menor = x;
      meio = z;
      maior = y;
    } else if (y < z && y < x && x < z) {
      menor = y;
      meio = x;
      maior = z;
    } else if (y < x && y < z && z < x) {
      menor = y;
      meio = z;
      maior = x;
    } else if(z < y && z < x && x < y) {
      menor = z; 
      meio = x;
      maior = y;
    } else if (z < x && z < y && y < x) {
      menor = z;
      meio = y;
      maior = x;
    }
    x = menor; //menor significa a letra que ele encontrar como menor nos testes acima
    y = meio; //meio significa a letra que ele encontrar como meio nos testes acima
    z = maior; //maior significa a letra que ele encontrar como maior nos testes acima
  }
  public static void Main (string[] args){
    int x = int.Parse(Console.ReadLine());
    int y = int.Parse(Console.ReadLine());
    int z = int.Parse(Console.ReadLine());
    Ordenar(ref x, ref y, ref z);
    Console.WriteLine($"{x},{y},{z}");
  }
} 