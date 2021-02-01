using System;

class MainClass {
  public static void Main() {
    string s = Console.ReadLine(); //recebe s
    int n = int.Parse(s); //n vai ser s convertido pra inteiro
    for(int i = 1; i <= n; i++) {
      s = Console.ReadLine();
      int x = int.Parse(s);
      bool p = true;
      for (int d = 2; p && d <= Math.Sqrt(x); d++)
        if (x % d == 0) p = false;
      if (p) Console.WriteLine("Prime");
      else Console.WriteLine("Not Prime");
    }
  }
}