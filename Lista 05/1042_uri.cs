using System;
class MainClass {
  public static void Main (string[] args) {
  string linha = Console.ReadLine();
  string[] valores = linha.Split();
  int a = int.Parse(valores[0]);
  int b = int.Parse(valores[1]);
  int c = int.Parse(valores[2]);
  if (a < b && a < c && b < c) {
      Console.WriteLine(a);
      Console.WriteLine(b);
      Console.WriteLine(c);
  }
  else if (a < b && a < c && b > c) {
      Console.WriteLine(a);
      Console.WriteLine(c);
      Console.WriteLine(b);
  }
  else if ( a > b && b < c && a < c) {
      Console.WriteLine(b);
      Console.WriteLine(a);
      Console.WriteLine(c);
  }
  else if (a > b && b < c && a > c) {
      Console.WriteLine(b);
      Console.WriteLine(c);
      Console.WriteLine(a);
  }
  else if (a < b && b > c && a > c) {
      Console.WriteLine(c);
      Console.WriteLine(a);
      Console.WriteLine(b);
  }
  else if (a > b && b > c && a > c) {
      Console.WriteLine(c);
      Console.WriteLine(b);
      Console.WriteLine(a);
  }
  else { }
  Console.WriteLine("");
  Console.WriteLine(a);
  Console.WriteLine(b);
  Console.WriteLine(c);
  }
}