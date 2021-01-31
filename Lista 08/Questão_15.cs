using System;

class MainClass {
  public static void Main (string[] args) {
  Console.WriteLine("Digite 4 nomes");
  string[] nomes = Console.ReadLine().Split();
  StringComparer ordenar = StringComparer.InvariantCultureIgnoreCase;
  Array.Sort(nomes, ordenar);
  Console.WriteLine("Em ordem alfabética:");
  for (int i = 0; i < nomes.Length; i++) 
  Console.WriteLine(nomes[i]);
  }
}