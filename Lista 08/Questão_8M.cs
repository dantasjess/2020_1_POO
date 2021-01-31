using System;
class MainClass {
  public static void Main(string[] args) {
    Console.WriteLine("Digite um texto:");
    string texto = Console.ReadLine();
    string iniciais = Iniciais(texto);
    Console.WriteLine("As iniciais das palavras sao:");
    foreach (char inicial in iniciais)
      Console.WriteLine(inicial);
  }
  public static string Iniciais(string s) {
    string[] palavras = s.Split();
    string iniciais = "";
    foreach (string palavra in palavras) {
      iniciais += palavra[0];
    };
    return iniciais;
  }
}