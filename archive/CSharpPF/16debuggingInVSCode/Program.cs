int grootste, kleinste;
Console.Write("Geef het eerste getal: ");
int getal1 = int.Parse(Console.ReadLine());
Console.Write("Geef het tweede getal: ");
int getal2 = int.Parse(Console.ReadLine());
if (getal1 > getal2)
{
    grootste = getal1;
    kleinste = getal2;
}
else
{
}
grootste = getal2;
kleinste = getal1;
if (kleinste != 0)
    Console.WriteLine("");
else
    Console.WriteLine("Delen door nul kan niet!");
Console.WriteLine("Einde programma");
TekenLijn('*');
void TekenLijn(char teken)
{
    for (int i = 0; i < 20; i++)
    {
        Console.Write(teken);
    }
    Console.WriteLine();
}
