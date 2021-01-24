using System;

class MainClass {
  public static void Main (string[] args) {
    string[] dia1 = Console.ReadLine().Split(' ');
    string[] inicio = Console.ReadLine().Split(':');
    string[] dia2 = Console.ReadLine().Split(' ');
    string[] final = Console.ReadLine().Split(':');
    int a = int.Parse(dia1[1]);
    int b = int.Parse(dia2[1]);
    int dias = ((b - a) * 24) * 3600;
    int ha = int.Parse(inicio[0]);
    int ma = int.Parse(inicio[1]);
    int sa = int.Parse(inicio[2]);
    int hb = int.Parse(final[0]);
    int mb = int.Parse(final[1]);
    int sb = int.Parse(final[2]);
    int x = (ha * 3600) + (ma * 60 ) + sa;
    int y = (hb * 3600) + (mb * 60) + sb;
    int soma = ((dias - x) + y);
    int ds = soma/(24 * 3600);
    int hs = (soma-(ds*24*3600))/3600;
    int ms = (soma-(( ds * 24 * 3600 + hs * 3600)))/60;
    int ss = soma - (ds* 24 * 3600 + hs * 3600 + ms * 60);
    Console.WriteLine($"{ds} dia(s)");
    Console.WriteLine($"{hs} hora(s)");
    Console.WriteLine($"{ms} minuto(s)");
    Console.WriteLine($"{ss} segundo(s)");
  }
}