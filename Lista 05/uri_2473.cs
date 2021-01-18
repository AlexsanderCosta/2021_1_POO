using System;

class MainClass {
  public static void Main (string[] args) {
    int x = 0;
    string[] numeros = Console.ReadLine().Split(' ');
    string[] flavio = Console.ReadLine().Split(' ');
    int a = int.Parse(numeros[0]);
    int b = int.Parse(numeros[1]);
    int c = int.Parse(numeros[2]);
    int d = int.Parse(numeros[3]);
    int e = int.Parse(numeros[4]);
    int f = int.Parse(numeros[5]);
    int g = int.Parse(flavio[0]);
    int h = int.Parse(flavio[1]);
    int i = int.Parse(flavio[2]);
    int j = int.Parse(flavio[3]);
    int k = int.Parse(flavio[4]);
    int l = int.Parse(flavio[5]);
    if (a == g || a == h || a == i || a == j || a == k || a == l)
    x = x + 1;
    if (b == g || b == h || b == i || b == j || b == k || b == l)
    x = x + 1;
    if (c == g || c == h || c == i || c == j || c == k || c == l)
    x = x + 1;
    if (d == g || d == h || d == i || d == j || d == k || d == l)
    x = x + 1;
    if (e == g || e == h || e == i || e == j || e == k || e == l)
    x = x + 1;
    if (f == g || f == h || f == i || f == j || f == k || f == l)
    x = x + 1;
    if (x == 3)
    Console.WriteLine("terno");
    if (x == 4)
    Console.WriteLine("quadra");
    if (x == 5)
    Console.WriteLine("quina");
    if (x == 6)
    Console.WriteLine("sena");
    if (x < 3)
    Console.WriteLine("azar");
  }
}