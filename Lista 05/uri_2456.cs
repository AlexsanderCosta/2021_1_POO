using System;

class MainClass {
  public static void Main (string[] args) {
    string[] valores = Console.ReadLine().Split(' ');
    int a = int.Parse(valores[0]);
    int b = int.Parse(valores[1]);
    int c = int.Parse(valores[2]);
    int d = int.Parse(valores[3]);
    int e = int.Parse(valores[4]);
    if (a < b && b < c && c < d && d < e){
      Console.WriteLine("C");         
    }
    else{
      if (a > b && b >c && c > d && d > e){
        Console.WriteLine("D");
      }
      else{
        Console.WriteLine("N");
      }
    }
  }
}