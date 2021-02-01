using System;
class MainClass {
  public static void Main() {
    string s = Console.ReadLine();
    while (s != "*") { //enquanto s não for um *
      s = s.ToLower(); //converte tudo para minúsculo
      char c = s[0]; //caracter c = primeira posição da frase
      bool ok = true; //ok recebe valor verdadeiro
      for (int i = 1; i < s.Length; i++) //enquanto i (que é igual a 1) for menor que a quantidade de letras de s, ele vai fazer o comando if
      if (s[i] == ' ' && s[i+1] != c) ok = false; //se a posição i de s for igual a um espaço e essa posição +1 for diferente de c, ok recebe false.
      if (ok) Console.WriteLine("Y");
      else Console.WriteLine("N");
      s = Console.ReadLine();
    }
  }
}