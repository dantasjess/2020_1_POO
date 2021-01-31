using System;
class MainClass {
  public static string FormatarTexto(string texto) {
    string aux = "";
    char ant = 'x';
    foreach (char letra in texto) {
      if (letra != ' ' || ant != ' ')
        aux = aux + letra;
      ant = letra;
    }
    return aux;
  }
  public static void Main (string[] args) {
    string texto = Console.ReadLine();
    Console.WriteLine(FormatarTexto(texto));
  }
}