using System;

class MainClass {
  public static void Main (string[] args) {
    string[] v = Console.ReadLine().Split(' ');
    int a = int.Parse(v[0]);
    int b = int.Parse(v[1]);
    int c = int.Parse(v[2]);
    int me = Math.Min(a, b);
    int me1 = Math.Min(me, c);
    int ma = Math.Max(a, b);
    int ma1 = Math.Max(ma, c);
    Console.WriteLine(me1);
    if (a > b && a < c || a > c && a < b){
      Console.WriteLine(a);
    }
    if (b > a && b < c || b > c && b < a){
      Console.WriteLine(b);
    }
    if (c > a && c < b || c > b && c < a){
      Console.WriteLine(c);
    }
    Console.WriteLine(ma1);
    Console.WriteLine("");
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
  }
}