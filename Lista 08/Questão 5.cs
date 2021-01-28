using System;
class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite uma frase com três palavras:");
    string[] frase = Console.ReadLine().Split();
    string prim_palavra = (frase[0]);
    string seg_palavra = (frase[1]);
    string ter_palavra = (frase[2]);
    Console.WriteLine($"A senha é {prim_palavra.Length}{seg_palavra.Length}{ter_palavra.Length}");
  }
}