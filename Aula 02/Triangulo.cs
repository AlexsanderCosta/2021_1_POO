using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite a base e altura do retêngulo:");
    double b = double.Parse(Console.ReadLine());
    double a = double.Parse(Console.ReadLine());
    double area = b * a;
    double perímetro = b * 2 + a * 2;
    double diagonal = Math.Sqrt((b * b + a * a)); 
    Console.WriteLine($"Área = {area:0.00}  Perímetro = {perímetro:0.00} Diagonal = {diagonal:0.00}");
  }
}
