using System;

class MainClass {
  public static void Main (string[] args) {
    string [] valores = Console.ReadLine().Split(' ');
    double a = double.Parse(valores[0]);
    double b = double.Parse(valores[1]);
    double c = double.Parse(valores[2]);
    double atri = a * c / 2;
    double circ = c * c * 3.14159;
    double atra = (a + b) * c / 2;
    double aqua = b * b;
    double aret = a * b;
    Console.WriteLine($"TRIANGULO: {atri:0.000}");
    Console.WriteLine($"CIRCULO: {circ:0.000}"); 
    Console.WriteLine($"TRAPEZIO: {atra:0.000}"); 
    Console.WriteLine($"QUADRADO: {aqua:0.000}"); 
    Console.WriteLine($"RETANGULO: {aret:0.000}"); 
  }
}