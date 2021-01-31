using System;
class MainClass {
  public static void Main(string[] args){
    Console.WriteLine("Por favor, digite uma data no formato dd/mm/aaaa:");
    string linha = Console.ReadLine();
    string[] data = linha.Split('/');
    int dia = int.Parse(data[0]);
    int mes = int.Parse(data[1]);
    int ano = int.Parse(data[2]);
    int max = 31;
    switch(mes) {
      case 2:
        if (ano % 4 == 0 && ano % 100 != 0 || ano % 400 == 0) max = 29;
        else max = 28; break;
      case 4: max = 30; break;
      case 6: max = 30; break;
      case 9: max = 30; break;
      case 11: max = 30; break;
    }
    if (dia >= 1 && dia <= max && mes >= 1 && mes <= 12 && ano >= 1900 && ano <= 2100) Console.WriteLine("Data válida");
    else Console.WriteLine("Data inválida");
    Console.ReadKey();

  }
}