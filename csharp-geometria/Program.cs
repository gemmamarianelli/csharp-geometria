

using csharp_geometria;

string baseRettangolo = Console.ReadLine();
string altezzaRettangolo = Console.ReadLine();
Rettangolo rettangolo1 = new Rettangolo();



Console.WriteLine("------" + "Rettangolo" + "------");

Console.WriteLine("base: " + baseRettangolo +"cm");
Console.WriteLine("altezza: " + altezzaRettangolo + "cm");
Console.WriteLine("perimetro: " + rettangolo1.calcolaPerimetro);
Console.WriteLine("area: " + rettangolo1.calcoloArea);
Console.WriteLine("----------------------------");