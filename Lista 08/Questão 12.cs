using System; 
class MainClass {
public static void Main (string [] args) {
Console.WriteLine("Digite a placa do carro:");
string placa = Console.ReadLine();
char x = placa[6];
switch(x) {
  case '1': Console.WriteLine("O IPVA deverá ser pago em Fevereiro"); break;
  case '2': Console.WriteLine("O IPVA deverá ser pago em Fevereiro"); break;
  case '3': Console.WriteLine("O IPVA deverá ser pago em Março"); break;
  case '4': Console.WriteLine("O IPVA deverá ser pago em Março"); break;
  case '5': Console.WriteLine("O IPVA deverá ser pago em Abril"); break;
  case '6': Console.WriteLine("O IPVA deverá ser pago em Abril"); break;
  case '7': Console.WriteLine("O IPVA deverá ser pago em Maio"); break;
  case '8': Console.WriteLine("O IPVA deverá ser pago em Maio"); break;
  case '9': Console.WriteLine("O IPVA deverá ser pago em Junho"); break;
  case '0': Console.WriteLine("O IPVA deverá ser pago em Junho"); break;
  default: Console.WriteLine("Placa inválida."); break;
}
  }
}