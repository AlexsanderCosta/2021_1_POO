using System;

class MainClass {
  public static void Main (string[] args) {
    double valor = double.Parse(Console.ReadLine());
    if (valor >= 0 && valor <= 25){
      Console.WriteLine("Intervalo [0,25]");
    }
    if (valor > 25 && valor <= 50){
      Console.WriteLine("Intervalo (25,50]");
    }
    if (valor > 50 && valor <= 75){
      Console.WriteLine("Intervalo (50,75]");
    }
    if (valor > 75 && valor <= 100){
      Console.WriteLine("Intervalo (75,100]");
    }
    if (valor < 0 || valor > 100){
      Console.WriteLine("Fora de intervalo");
    }
  }
}