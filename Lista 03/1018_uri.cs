using System;
class MainClass {
  public static void Main (string[] args){
    n = int.Parse(Console.ReadLine());
    Console.WriteLine(n);
    
    int n100 = n; 
    n = n - n100*100;

    int n50 = n; 
    n = n - n50*50;

    int n20 = n;
    n = n - n20*20;

    int n10 = n;
    n = n - n10*10;

    int n5 = n;
    n = n - n5*5;

    int n2 = n;
    n = n - n2*2;

    int n1 = n;
    n = n - n1*1;
    Console.WriteLine($"{n100} nota(s) de R$ de R$ 100,00");
    Console.WriteLine($"{n50} nota(s) de R$ de R$ 50,00");
    Console.WriteLine($"{n20} nota(s) de R$ de R$ 20,00");
    Console.WriteLine($"{n10} nota(s) de R$ de R$ 10,00");
    Console.WriteLine($"{n5} nota(s) de R$ de R$ 5,00");
    Console.WriteLine($"{n2} nota(s) de R$ de R$ 2,00");
    Console.WriteLine($"{n1} nota(s) de R$ de R$ 1,00");
      }
    }