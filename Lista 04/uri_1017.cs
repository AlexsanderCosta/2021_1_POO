using System;

class MainClass {
  public static void Main (string[] args) {
    double h = double.Parse(Console.ReadLine());
    double km = double.Parse(Console.ReadLine());
    double x = h * km/12;
    Console.WriteLine($"{x:0.000}");
  }
}