using System;
class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite uma frase com três palavras:");
    string[] frase = Console.ReadLine().Split();
    
    string nome1 = frase[0];
    char letra1 = nome1[0];

    string nome2 = frase[1];
    char letra2 = nome2[0];
    
    string nome3 = frase[2];
    char letra3 = nome3[0];
    Console.WriteLine($"A sigla é {letra1}{letra2}{letra3}");
  }
}